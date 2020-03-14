﻿
using NLog;
using System;
using System.Collections.Concurrent;
using System.Threading;
using System.Threading.Tasks;

namespace AVT.Media.Pipeline.Sinks
{
    /// <summary>
    /// A TeeSink is a sink that takes in a single source buffer and replicates
    /// it out to all output sources.
    /// </summary>
    public class TeeSink : SinkBase, IDisposable
    {
        private const int DEFAULT_QUEUE_SIZE = 100;

        private bool _disposed;
        private int _queueSize;
        private ConcurrentBag<ISink> _clients;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="queueSize">Size of the input source queue</param>
        public TeeSink(int queueSize = DEFAULT_QUEUE_SIZE)
        {
            _disposed = false;
            _queueSize = queueSize;
            _clients = new ConcurrentBag<ISink>();
        }

        ~TeeSink()
        {
            Dispose(false);
        }

        /// <summary>
        /// <see cref="ISink.Stop"/>
        /// </summary>
        public override void Stop()
        {
            foreach (var client in _clients)
            {
                client.Stop();
            }

            // Clear the clients
            ISink sink;
            while (!_clients.IsEmpty)
            {
                _clients.TryTake(out sink);
            }
        }

        /// <summary>
        /// Creates an new output source instance.
        /// </summary>
        /// <returns></returns>
        public ISource CreateSource()
        {
            var source = new TeeOutflowSource(_queueSize);
            _clients.Add(source);

            return source;
        }

        /// <summary>
        /// <see cref="ISink.WriteBuffer(ByteBuffer)"/>
        /// </summary>
        /// <param name="buffer"></param>
        /// <returns></returns>
        public override bool WriteBuffer(ByteBuffer buffer)
        {
            foreach (var client in _clients)
            {
                client.WriteBuffer(buffer);
            }

            return true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!_disposed)
            {
                if (disposing)
                {
                    foreach (var client in _clients)
                    {
                        (client as TeeOutflowSource).Dispose();
                    }
                }

                _disposed = true;
            }
        }

        private class TeeOutflowSource : TransformBase, IDisposable
        {
            private static readonly Logger LOG = LogManager.GetCurrentClassLogger();

            private bool _disposed;
            private ManualResetEvent _stop;
            private BlockingCollection<ByteBuffer> _queue;

            public TeeOutflowSource(int queueSize)
            {
                Flushing = true;
                _disposed = false;
                _stop = new ManualResetEvent(false);
                _queue = new BlockingCollection<ByteBuffer>(queueSize);
            }

            ~TeeOutflowSource()
            {
                Dispose(false);
            }

            public override void Start()
            {
                _stop.Reset();

                Task.Run(() => ProcessBuffers()); // Start processing thread

                // We need to set the flushing flag to false so that the buffers
                // will be processed.
                Flushing = false;
            }

            public override void Stop()
            {
                Dispose();
            }

            public override bool WriteBuffer(ByteBuffer buffer)
            {
                try
                {
                    if (!_stop.WaitOne(0))
                    {
                        if (!_queue.TryAdd(buffer))
                        {
                            LOG.Warn("Dropping buffer queue is full and cannot process the buffer");
                        }
                    }

                    return true;
                }
                catch (ObjectDisposedException)
                {
                    // The sink was stopped and disposed.
                    return false;
                }
            }

            public void Dispose()
            {
                Dispose(true);
                GC.SuppressFinalize(this);
            }

            protected virtual void Dispose(bool disposing)
            {
                if (!_disposed)
                {
                    if (disposing)
                    {
                        _stop.Set();
                        _stop?.Dispose();
                    }

                    _disposed = true;
                }
            }

            private void ProcessBuffers()
            {
                try
                {
                    while (!_stop.WaitOne(0))
                    {
                        var buffer = _queue.Take();
                        PushBuffer(buffer);
                    }

                    _queue.Dispose();
                }
                catch (ObjectDisposedException)
                {
                    LOG.Info("Shutdown requested for TeeSink source");
                }
                catch (Exception e)
                {
                    LOG.Error($"Received exception while processing buffer, reason={e.Message}");
                }
            }
        }
    }
}
