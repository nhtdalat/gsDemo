
using System;

namespace AVT.Media.RTSP
{
    public class RtspMessageEventArgs : EventArgs
    {
        public RtspMessageEventArgs(RtspMessage message)
        {
            Message = message;
        }

        public RtspMessage Message { get; private set; }
    }
}
