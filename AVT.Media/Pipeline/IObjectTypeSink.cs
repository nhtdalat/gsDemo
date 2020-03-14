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
    /// A sink the consumes a object instead of a buffer.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IObjectTypeSink<T>: ISink
    {
        bool HandleObject(T obj);
    }
}
