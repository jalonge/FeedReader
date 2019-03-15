namespace FeedReader
{
    public class HtmlFeedLink
    {
        /// <summary>
        /// The title of the feed
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// The url to the feed
        /// </summary>
        public string Url { get; set; }

        /// <summary>
        /// The type of the feed - rss or atom
        /// </summary>
        public FeedType FeedType { get; set; }


        public HtmlFeedLink()
        {
        }


        public HtmlFeedLink(string title, string url, FeedType feedtype)
        {
            this.Title = title;
            this.Url = url;
            this.FeedType = feedtype;
        }
    }
}
