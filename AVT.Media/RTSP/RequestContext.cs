//
// Copyright (c) 2018 AVT. All rights reserved.
//
// This file contains trade secrets of AVT.  No part may be reproduced or
// transmitted in any form by any means or for any purpose without the express
// written permission of AVT.
//
using AVT.Media.Pipeline;
using System;
using System.Net;

namespace AVT.Media.RTSP
{
    /// <summary>
    /// Holds contextual information related to an RTSP request.
    /// </summary>
    public class RequestContext
    {
        private RtspListener _listener;

        internal RequestContext(RtspListener listener)
        {
            _listener = listener ?? throw new ArgumentNullException("Listener cannot be null");
        }

        /// <summary>
        /// Gets the requesting IP endpoint.
        /// </summary>
        public IPEndPoint Endpoint
        {
            get
            {
                return _listener.Endpoint;
            }
        }

        /// <summary>
        /// Write data to the underlying RTSP connectionn.
        /// </summary>
        /// <param name="data">The data to write to RTCP connection</param>
        /// <returns>true if successful, false otherwise</returns>
        public bool Write(byte[] data)
        {
            return _listener.Write(data, 0, data.Length);
        }

        /// <summary>
        /// Write buffer to the underlying RTSP connectionn.
        /// </summary>
        /// <param name="data">The buffer to write to RTCP connection</param>
        /// <returns>true if successful, false otherwise</returns>
        public bool Write(ByteBuffer buffer)
        {
            return _listener.Write(buffer.Raw, buffer.StartIndex, buffer.Length);
        }
    }
}
 