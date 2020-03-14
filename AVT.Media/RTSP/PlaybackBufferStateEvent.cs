﻿//
// Copyright (c) 2018 AVT. All rights reserved.
//
// This file contains trade secrets of AVT.  No part may be reproduced or
// transmitted in any form by any means or for any purpose without the express
// written permission of AVT.
//
using AVT.Media.Pipeline;

namespace AVT.Media.RTSP
{
    /// <summary>
    /// Pipeline event used to indicate that the playback buffer is either high or low.
    /// VxS uess the tcp window to perform an implicit pause. If the
    /// buffer is full then this event will be used to tell the RtspListener
    /// to stop reading to allow the tcp window to fill.
    /// </summary>
    public class PlaybackBufferStateEvent : MediaEvent
    {
        public const string TOPIC = "playback/buffer/state";

        /// <summary>
        /// Inidicates the state of the playback buffer.
        /// </summary>
        public enum State
        {
            Low,
            High
        }

        public PlaybackBufferStateEvent()
        {
            Topic = TOPIC;
        }

        /// <summary>
        /// Gets and sets the flag indicating that the buffer is full.
        /// </summary>
        public State BufferState { get; set; }
    }
}
