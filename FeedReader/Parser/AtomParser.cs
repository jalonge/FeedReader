using FeedReader.Feeds.Atom;
using FeedReader.Feeds.Base;
using System.Xml.Linq;

namespace FeedReader.Parser
{
    internal class AtomParser : AbstractXmlFeedParser
    {
        public override BaseFeed Parse(string feedXml, XDocument feedDoc)
        {
            AtomFeed feed = new AtomFeed(feedXml, feedDoc.Root);
            return feed;
        }
    }
}
