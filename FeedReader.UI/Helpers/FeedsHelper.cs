using FeedsReader.UI.Helpers;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace FeedReader.UI.Helpers
{
    public static class FeedsHelper
    {


        public static ICollection<FeedItem> GetFeed(string url)
        {

            ICollection<FeedItem> t = new Collection<FeedItem>();
            var urlsTask = FeedReader.GetFeedUrlsFromUrlAsync(url);
            urlsTask.ConfigureAwait(false);
            var urls = urlsTask.Result;

            string feedUrl;
            feedUrl = url;
            var readerTask = FeedReader.ReadAsync(feedUrl);
            readerTask.ConfigureAwait(false);

            foreach (var item in readerTask.Result.Items)
            {
                FeedItem feed = new FeedItem
                {
                    FeedImg = readerTask.Result.ImageUrl,
                    FeedName = readerTask.Result.Title,
                    Author = item.Author,
                    Categories = item.Categories,
                    Content = item.Content,
                    Description = item.Description,
                    Id = item.Id,
                    Link = item.Link,
                    PublishingDate = item.PublishingDate,
                    PublishingDateString = item.PublishingDateString,
                    SpecificItem = item.SpecificItem,
                    Title = item.Title,
                    TimeAgo = TimeHelper.GetPrettyDate(item.PublishingDate)
                };
                t.Add(feed);

            }
            return t;
            //  return readerTask.Result.Items;
        }
        public static ICollection<FeedItem> GetFeeds(string[] Stringurls)
        {
            ICollection<FeedItem> t = new Collection<FeedItem>();
            foreach (var url in Stringurls)

            {
                var urlsTask = FeedReader.GetFeedUrlsFromUrlAsync(url);
                urlsTask.ConfigureAwait(false);
                var urls = urlsTask.Result;

                string feedUrl;
                feedUrl = url;
                var readerTask = FeedReader.ReadAsync(feedUrl);
                readerTask.ConfigureAwait(false);

                foreach (var item in readerTask.Result.Items)
                {
                    FeedItem feed = new FeedItem
                    {
                        FeedImg = readerTask.Result.ImageUrl,
                        FeedName = readerTask.Result.Title,
                        Author = item.Author,
                        Categories = item.Categories,
                        Content = item.Content,
                        Description = item.Description,
                        Id = item.Id,
                        Link = item.Link,
                        PublishingDate = item.PublishingDate,
                        PublishingDateString = item.PublishingDateString,
                        SpecificItem = item.SpecificItem,
                        Title = item.Title,
                        TimeAgo = TimeHelper.GetPrettyDate(item.PublishingDate)
                    };
                    t.Add(feed);

                }
            }
            return t;
            //  return readerTask.Result.Items;
        }
    }
}