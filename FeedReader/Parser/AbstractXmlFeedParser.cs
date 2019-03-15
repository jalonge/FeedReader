using FeedReader.Feeds.Base;
using System.Xml.Linq;

namespace FeedReader.Parser
{
    internal abstract class AbstractXmlFeedParser : IFeedParser
    {
        public BaseFeed Parse(string feedXml)
        {
            XDocument feedDoc = XDocument.Parse(feedXml);

            return this.Parse(feedXml, feedDoc);
        }

        public abstract BaseFeed Parse(string feedXml, XDocument feedDoc);
    }
}