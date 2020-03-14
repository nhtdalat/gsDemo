
namespace AVT.Media.Pipeline
{

    /// <summary>
    /// Transform for converting an object type into a <see cref="ByteBuffer"/>
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public abstract class ObjectTypeToBufferTransformBase<T> : TransformBase, IObjectTypeSink<T>
    {
        /// <summary>
        /// <see cref="IObjectTypeSink{T}.HandleObject(T)"/>
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public abstract bool HandleObject(T obj);
    }
}
