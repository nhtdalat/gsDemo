//
// Copyright (c) 2018 AVT. All rights reserved.
//
// This file contains trade secrets of AVT.  No part may be reproduced or
// transmitted in any form by any means or for any purpose without the express
// written permission of AVT.
//
namespace AVT.Media.RTSP
{
    /// <summary>
    /// Represents a chuck of RTSP data.  In the case of a interleaved frame
    /// the chunk will hold the interleaved payload.  In the case of an Rtsp
    /// response or request it will contain the body payload.
    /// </summary>
    public class RtspChunk
    {
        /// <summary>
        /// Holds the data associated with the rtsp chunk.
        /// </summary>
        protected byte[] Data { get; set; }
    }
}
