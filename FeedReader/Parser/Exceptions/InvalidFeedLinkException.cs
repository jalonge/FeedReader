using System;

namespace FeedReader.Parser.Exceptions
{
    public sealed class InvalidFeedLinkException : Exception
    {
        /// <summary>
        /// Initializes a new InvalidFeedLinkException
        /// </summary>
        public InvalidFeedLinkException() { }

        /// <summary>
        /// Initializes a new InvalidFeedLinkException with a message
        /// </summary>
        /// <param name="message">custom error message</param>
        public InvalidFeedLinkException(string message) : base(message) { }

        /// <summary>
        /// Initializes a new InvalidFeedLinkException with a message and an innerException
        /// </summary>
        /// <param name="message">custom error message</param>
        /// <param name="innerException">the inner exception</param>
        public InvalidFeedLinkException(string message, Exception innerException) : base(message, innerException) { }
    }
}
