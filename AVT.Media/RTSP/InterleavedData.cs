﻿//
// Copyright (c) 2018 AVT. All rights reserved.
//
// This file contains trade secrets of AVT.  No part may be reproduced or
// transmitted in any form by any means or for any purpose without the express
// written permission of AVT.
//
using System;

namespace AVT.Media.RTSP
{
    /// <summary>
    /// Represents an interleaved RTP/RTCP packet.  Users can retrieve the packet's data as well
    /// as the packets associated channel.
    /// </summary>
    public class InterleavedData : RtspChunk, ICloneable
    {
        public InterleavedData(ushort channel)
        {
            Channel = channel;
        }

        /// <summary>
        /// The Interleaved data's channel.  Usually channel 0 indicates and RTP payload,
        /// while 1 indicates and RTCP payload.
        /// </summary>
        public ushort Channel { get; private set; }

        /// <summary>
        /// Holds the Interleaved packets RTP/RTCP data.
        /// </summary>
        public byte[] Payload
        {
            get
            {
                return Data;
            }

            internal set
            {
                Data = value;
            }
        }

        /// <summary>
        /// <see cref="RtspDataChunk.Clone"/>
        /// </summary>
        /// <returns></returns>
        public object Clone()
        {
            InterleavedData data = new InterleavedData(Channel);
            Data.CopyTo(data.Data, 0);

            return data;
        }
    }
}
