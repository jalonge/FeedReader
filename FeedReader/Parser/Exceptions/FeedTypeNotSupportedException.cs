using System;

namespace FeedReader.Parser.Exceptions
{
    public class FeedTypeNotSupportedException : Exception
    {
        /// <summary>
        /// Initializes a new FeedTypeNotSupportedException
        /// </summary>
        public FeedTypeNotSupportedException()
        {
        }

        /// <summary>
        /// Initializes a new FeedTypeNotSupportedException with a message
        /// </summary>
        /// <param name="message">custom error message</param>
        public FeedTypeNotSupportedException(string message) : base(message)
        {
        }

        /// <summary>
        /// Initializes a new FeedTypeNotSupportedException with a message and an innerException
        /// </summary>
        /// <param name="message">custom error message</param>
        /// <param name="innerException">the inner exception</param>
        public FeedTypeNotSupportedException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
