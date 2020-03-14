
namespace AVT.Media.Pipeline
{
    /// <summary>
    /// Base class representing an pipeline upstream event.
    /// </summary>
    public class MediaEvent
    {
        /// <summary>
        /// The event's topic.
        /// </summary>
        public string Topic { get; set; }
    }
}
