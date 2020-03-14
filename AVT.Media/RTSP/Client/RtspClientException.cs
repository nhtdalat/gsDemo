
using System;

namespace AVT.Media.RTSP.Client
{
    public class RtspClientException : RtspException
    {
        public RtspClientException(string msg) : base(msg)
        {

        }

        public RtspClientException(string msg, Exception cause) : base(msg, cause)
        {

        }
    }
}
