
using System;

namespace AVT.Media.Pipeline
{
    /// <summary>
    /// Transform for converting an oject type to another.
    /// </summary>
    /// <typeparam name="SRC">The input object type</typeparam>
    /// <typeparam name="TARGET">The output object type</typeparam>
    public abstract class ObjectTypeTransformBase<SRC, TARGET> : ObjectTypeSource<TARGET>, IObjectTypeSink<SRC>, ITransform
    {
        /// <summary>
        /// <see cref="IObjectTypeSink{T}.HandleObject(T)"/>
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public abstract bool HandleObject(SRC obj);

        /// <summary>
        /// <see cref="ISink.PushEvent(MediaEvent)"/>
        /// </summary>
        /// <param name="e"></param>
        public virtual void PushEvent(MediaEvent e)
        {
            OnMediaEvent(e);
        }

        public virtual bool WriteBuffer(ByteBuffer buffer)
        {
            throw new InvalidOperationException();
        }
    }
}
