using FeedReader.Feeds._0._91;
using System.Xml.Linq;

namespace FeedReader.Feeds.MediaRSS
{
    public class MediaRssFeedImage : Rss091FeedImage
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MediaRssFeedImage"/> class.
        /// default constructor (for serialization)
        /// </summary>
        public MediaRssFeedImage()
            : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MediaRssFeedImage"/> class.
        /// Reads a rss 2.0 feed image based on the xml given in element
        /// </summary>
        /// <param name="element">feed image as xml</param>
        public MediaRssFeedImage(XElement element)
            : base(element)
        {
        }
    }
}
