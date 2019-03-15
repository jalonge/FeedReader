using FeedReader.Feeds._2._0;
using FeedReader.Feeds.Base;
using System.Xml.Linq;

namespace FeedReader.Parser
{
    internal class Rss20Parser : AbstractXmlFeedParser
    {
        public override BaseFeed Parse(string feedXml, XDocument feedDoc)
        {
            var rss = feedDoc.Root;
            var channel = rss.GetElement("channel");
            Rss20Feed feed = new Rss20Feed(feedXml, channel);
            return feed;
        }
    }

}