
using System;

namespace AVT.Media.Metadata
{
    [Serializable]
    public class PlayerInitializationException : Exception
    {
        public PlayerInitializationException() : base()
        {

        }

        public PlayerInitializationException(string msg) : base(msg)
        {

        }
    }
}
