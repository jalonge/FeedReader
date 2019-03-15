using FeedReader.Feeds._0._91;
using System.Xml.Linq;

namespace FeedReader.Feeds._2._0
{
    public class Rss20FeedImage : Rss091FeedImage
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Rss20FeedImage"/> class.
        /// default constructor (for serialization)
        /// </summary>
        public Rss20FeedImage()
            : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Rss20FeedImage"/> class.
        /// Reads a rss 2.0 feed image based on the xml given in element
        /// </summary>
        /// <param name="element">feed image as xml</param>
        public Rss20FeedImage(XElement element)
            : base(element)
        {
        }
    }
}