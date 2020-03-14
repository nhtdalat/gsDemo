
using System;

namespace AVT.Media.Pipeline
{
    /// <summary>
    /// Object sink base class.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public abstract class ObjectTypeSinkBase<T> : IObjectTypeSink<T>
    {
        private ISource _upstreamLink;

        /// <summary>
        /// <see cref="ISink.UpstreamLink"/>
        /// </summary>
        public ISource UpstreamLink
        {
            get
            {
                return _upstreamLink;
            }

            set
            {
                _upstreamLink = value;
            }
        }

        /// <summary>
        /// <see cref="IObjectTypeSink{T}.HandleObject(T)"/>
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public abstract bool HandleObject(T obj);

        /// <summary>
        /// <see cref="ISink.Stop"/>
        /// </summary>
        public virtual void Stop()
        {
        }

        /// <summary>
        /// <see cref="ISink.PushEvent(MediaEvent)"/>
        /// </summary>
        /// <param name="e"></param>
        public virtual void PushEvent(MediaEvent e)
        {
            UpstreamLink?.OnMediaEvent(e);
        }

        public bool WriteBuffer(ByteBuffer buffer)
        {
            throw new InvalidOperationException();
        }
    }
}
