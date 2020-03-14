//
// Copyright (c) 2018 AVT. All rights reserved.
//
// This file contains trade secrets of AVT.  No part may be reproduced or
// transmitted in any form by any means or for any purpose without the express
// written permission of AVT.
//
using System;

namespace AVT.Media.RTSP
{
    [Serializable]
    public class RtspException : Exception
    {
        public RtspException() : base()
        {

        }

        public RtspException(string msg) : base(msg)
        {

        }

        public RtspException(string msg, Exception cause) : base(msg, cause)
        {

        }
    }
}
