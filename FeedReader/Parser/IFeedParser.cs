using FeedReader.Feeds.Base;

namespace FeedReader.Parser
{
    internal interface IFeedParser
    {
        BaseFeed Parse(string feedXml);
    }
}