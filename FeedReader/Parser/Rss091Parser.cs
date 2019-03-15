using FeedReader.Feeds._0._91;
using FeedReader.Feeds.Base;
using System.Xml.Linq;

namespace FeedReader.Parser
{
    internal class Rss091Parser : AbstractXmlFeedParser
    {
        public override BaseFeed Parse(string feedXml, XDocument feedDoc)
        {
            var rss = feedDoc.Root;
            var channel = rss.GetElement("channel");
            Rss091Feed feed = new Rss091Feed(feedXml, channel);
            return feed;
        }
    }
}