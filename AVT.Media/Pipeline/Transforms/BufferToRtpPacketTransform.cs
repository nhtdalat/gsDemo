
using NLog;
using AVT.Media.Pipeline;
using AVT.Media.RTP;
using System;

namespace AVT.PDK.Media.Pipeline.Transforms
{
    /// <summary>
    /// Transform that converts an incoming buffer into an <see cref="RtpPacket"/> and pushes
    /// the packet object down stream.
    /// </summary>
    public class BufferToRtpPacketTransform : BufferToObjectTypeTransformBase<RtpPacket>
    {
        private static readonly Logger LOG = LogManager.GetCurrentClassLogger();

        /// <summary>
        /// <see cref="BufferToObjectTypeTransformBase{T}.WriteBuffer(ByteBuffer)"/>
        /// </summary>
        /// <param name="buffer"></param>
        /// <returns></returns>
        public override bool WriteBuffer(ByteBuffer buffer)
        {
            try
            {
                var packet = RtpPacket.Decode(buffer);
                return PushObject(packet);
            }
            catch (Exception e)
            {
                LOG.Error($"Unable to decode buffer into RTP packet, reason: {e.Message}");
            }

            return true;
        }
    }
}
