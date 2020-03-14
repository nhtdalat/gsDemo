﻿
using AVT.Media.RTP;

namespace AVT.Media.Pipeline.Transforms
{
    public class AlwaysFalseDemarcator : IRtpDemarcator
    {
        public bool Check(RtpPacket packet)
        {
            return false;
        }
    }
}
