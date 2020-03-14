
using System;

namespace AVT.Media.RTSP.SDP
{
    [Serializable]
    public class SdpParseException : Exception
    {
        public SdpParseException(string msg) : base(msg)
        {
        }

        public SdpParseException(string msg, Exception cause) : base(msg, cause)
        {
        }
    }
}
