using FeedReader.Feeds._0._92;
using FeedReader.Feeds.Base;
using System.Xml.Linq;

namespace FeedReader.Parser
{
    internal class Rss092Parser : AbstractXmlFeedParser
    {
        public override BaseFeed Parse(string feedXml, XDocument feedDoc)
        {
            var rss = feedDoc.Root;
            var channel = rss.GetElement("channel");
            Rss092Feed feed = new Rss092Feed(feedXml, channel);
            return feed;
        }
    }
}