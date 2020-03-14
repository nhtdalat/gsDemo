//
// Copyright (c) 2018 AVT. All rights reserved.
//
// This file contains trade secrets of AVT.  No part may be reproduced or
// transmitted in any form by any means or for any purpose without the express
// written permission of AVT.
//
namespace AVT.Media.Pipeline
{
    /// <summary>
    /// Pipeline union interface for Source and Sink.
    /// </summary>
    public interface ITransform : ISource, ISink
    {
    }
}
