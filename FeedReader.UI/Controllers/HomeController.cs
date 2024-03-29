﻿using FeedReader;
using FeedReader.UI.Helpers;
using FeedReader.UI.Models;
using FeedsReader.UI.Models;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace FeedsReader.UI.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        private ApplicationDbContext _db = new ApplicationDbContext();
        private readonly ApplicationUserManager userManager;
        private readonly ApplicationSignInManager signInManager;
        public HomeController() { }
        public HomeController(ApplicationUserManager userManager, ApplicationSignInManager signInManager)
        {
            this.userManager = userManager;
            this.signInManager = signInManager;
        }

        public ActionResult Index(string url, string search)
        {
            try
            {

                if (url == "all")
                {
                    FeedItem FI = new FeedItem();
                    var user = User.Identity.GetUserId();
                    var Feeds = _db.Subscribes.Where(x => x.UserID == user).Select(x => x.SubUrl).ToArray();
                    var RSSFeed = FeedsHelper.GetFeeds(Feeds);

                    ViewBag.RSSFeed = RSSFeed.OrderBy(x => x.PublishingDate);
                    ViewBag.count = RSSFeed.Count();
                }
                else
                {
                    Guid FeedGuid = Guid.Parse(url);
                    var Feed = _db.Subscribes.FirstOrDefault(x => x.SubscribeID == FeedGuid).SubUrl;
                    var RSSFeed = FeedsHelper.GetFeed(Feed);
                    ViewBag.count = RSSFeed.Count();
                    ViewBag.RSSFeed = RSSFeed;
                    ViewBag.count = RSSFeed.Count();
                    ViewBag.ShowUnsubcribe = FeedGuid;
                }
            }
            catch
            {

            }
            return View();
        }

        [HttpPost]
        public ActionResult Index(string url)
        {

            try
            {

                var user = User.Identity.GetUserId();
                var RSSFeed = FeedsHelper.GetFeed(url);
                ViewBag.RSSFeed = RSSFeed;
                ViewBag.count = RSSFeed.Count();

                Subscribe sb = new Subscribe
                {
                    UserID = user,
                    SubUrl = url,
                    SubName = RSSFeed.Select(x => x.FeedName).FirstOrDefault(),
                    SubImageURl = RSSFeed.Select(x => x.FeedImg).FirstOrDefault(),
                    DateCreated = DateTime.Now,
                    isDeleted = false,
                    FeedID = RSSFeed.Select(x => x.Id).FirstOrDefault()
                };

                var FeedExist = _db.Subscribes.FirstOrDefault(x => x.SubName == sb.SubName.Trim() && x.UserID == user);
                if (FeedExist == null)
                {
                    _db.Subscribes.Add(sb);
                    _db.SaveChanges();
                    ViewBag.ShowUnsubcribe = sb.SubscribeID;
                }
                else
                {
                    ViewBag.ShowUnsubcribe = FeedExist.SubscribeID;
                }


            }
            catch (Exception ex)
            {
                string me = ex.Message;
                ViewBag.Error = "No feeds were found for this URL";
            }

            ViewBag.URL = url;
            return View();
        }
        public ActionResult Unsubcribe(String id)
        {
            try
            {
                Guid FeedGuid = Guid.Parse(id);
                var XFeed = _db.Subscribes.FirstOrDefault(x => x.SubscribeID == FeedGuid);

                _db.Subscribes.Remove(XFeed);
                _db.SaveChanges();
            }
            catch { }
            return View("Index");
        }
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult _Navigation()
        {
            var user = User.Identity.GetUserId();
            List<MenuItems> List = new List<MenuItems>();
            var items = _db.Subscribes.Where(x => x.UserID == user);
            foreach (var i in items)
            {
                MenuItems mi = new MenuItems();
                mi.Link = i.SubUrl;
                mi.LinkName = i.SubName;
                mi.ID = i.SubscribeID;
                List.Add(mi);
            }
            return PartialView("_Navigation", List);
        }




        public ActionResult FeedSearch(string search)
        {
            var FeedSearch = (ICollection<FeedItem>)TempData["search"];
            var result = FeedSearch.Where(x => x.Title.ToLower().Contains(search.ToLower()));
            ViewBag.RSSFeed = result;
            ViewBag.count = result.Count();

            return View("index");
        }
    }
}