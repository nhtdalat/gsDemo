
using System;

namespace AVT.Media.RTSP
{
    [Serializable]
    class RtspMessageParseException : Exception
    {
        public RtspMessageParseException(string msg) : base(msg)
        {

        }

        public RtspMessageParseException(string msg, Exception cause) : base(msg, cause)
        {

        }
    }
}
