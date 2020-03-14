
using System;

namespace AVT.Media.Pipeline.Transforms
{
    /// <summary>
    /// Transform that filters out any RTP packets that do not contain
    /// the provided SSRC.
    /// </summary>
    public class SsrcFilter : TransformBase
    {
        private uint _ssrc;

        public SsrcFilter(string ssrc)
        {
            _ssrc = Convert.ToUInt32(ssrc, 16);
        }

        public override bool WriteBuffer(ByteBuffer buffer)
        {
            // TODO(frank.lamar): Actually implement the filtering.
            return PushBuffer(buffer);
        }
    }
}
