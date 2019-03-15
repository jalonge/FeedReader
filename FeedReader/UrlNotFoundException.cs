using System;

namespace FeedReader
{
    public sealed class UrlNotFoundException : Exception
    {

        public UrlNotFoundException()
        {
        }


        public UrlNotFoundException(string message) : base(message)
        {
        }


        public UrlNotFoundException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
