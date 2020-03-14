//
// Copyright (c) 2018 AVT. All rights reserved.
//
// This file contains trade secrets of AVT.  No part may be reproduced or
// transmitted in any form by any means or for any purpose without the express
// written permission of AVT.
//
using System;

namespace AVT.Media.Pipeline
{
    /// <summary>
    /// Reports that th end of the <see cref="ByteBuffer"/> has been meet.
    /// </summary>
    [Serializable]
    class EndOfBufferException : Exception
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public EndOfBufferException() : base("End of Pipeline.Buffer reached")
        {

        }
    }
}