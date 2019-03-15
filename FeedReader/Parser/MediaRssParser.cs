using FeedReader.Feeds.Base;
using FeedReader.Feeds.MediaRSS;
using System.Xml.Linq;

namespace FeedReader.Parser
{
    internal class MediaRssParser : AbstractXmlFeedParser
    {
        public override BaseFeed Parse(string feedXml, XDocument feedDoc)
        {
            var rss = feedDoc.Root;
            var channel = rss.GetElement("channel");
            MediaRssFeed feed = new MediaRssFeed(feedXml, channel);
            return feed;
        }
    }
}