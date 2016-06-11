using Final.Models;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace Final.Controllers
{
    public class HomeController : Controller
    {
        ApplicationDbContext db = new ApplicationDbContext();
        [HttpGet]
        public ActionResult Index(string searchString, int? page)
        {
            List<Post> post = new List<Post>();

            if (searchString != null)
            {
                foreach (Post item in db.Post)
                {
                    if (item.Category.Contains(searchString) || item.Title.Contains(searchString)) {
                        post.Add(item);
                    }
                }
                ViewBag.Post = post;
            }
            else {
                foreach (Post item in db.Post)
                {
                    
                    post.Add(item);
                    
                };
                int number = 1;
                List<Post> sorted = post.OrderByDescending(o => o.Likes).ToList();

                foreach (Post item in sorted)
                {
                    item.Number = number;
                    number++;
                }
                ViewBag.Post = sorted;
            }
            var pager = new Pager(ViewBag.Post.Count, page);

            ViewBag.pageSize = pager.PageSize;

            IEnumerable<Post> sort = ViewBag.Post as IEnumerable<Post>;

            var viewModel = new Pagination
            {
                Items = sort.Skip((pager.CurrentPage - 1) * pager.PageSize).Take(pager.PageSize),
                Pager = pager
            };

            return View(viewModel);
        }

        //detail post
        public ActionResult Post(int PostID, int Number)
        {
            var userId = User.Identity.GetUserId();

            List<Post> list = new List<Post>();
            List<object> comment = new List<object>();

            foreach (Post item in db.Post)
            {
                System.Reflection.PropertyInfo id = item.GetType().GetProperty("ID");
                Int32 getid = (Int32)(id.GetValue(item, null));
                if (getid == PostID)
                {
                    list.Add(item);
                };
            };

            ViewBag.Post = list[0];

            foreach (object item in db.Comments)
            {
                System.Reflection.PropertyInfo id = item.GetType().GetProperty("PostID");
                Int32 getid = (Int32)(id.GetValue(item, null));
                if (getid == PostID)
                {
                    comment.Add(item);
                };
            };

            if (Request.IsAuthenticated)
            {
                ViewBag.IsGov = db.Users.Where(x => x.Id == userId).SingleOrDefault().IsGov;
                ViewBag.IsUser = db.Users.Where(x => x.Id == userId).SingleOrDefault().IsUser;
            }
            else
            {
                ViewBag.IsGov = false;
                ViewBag.IsUser = false;
            }
            ViewBag.Comments = comment;
            ViewBag.Number = Number;

            return View(new Comments());
        }

        public ActionResult Popular(List<Post> model)
        {
            List<Post> post = model.OrderByDescending(o => o.Likes).ToList();
            ViewBag.post = post;

            return View("Index");
        }

        public ActionResult New(List<Post> model)
        {
            List<Post> post = model.OrderByDescending(o => o.Time).ToList();
            ViewBag.post = post;

            return View("Index");
        }

        public ActionResult Fix(string searchString, int? page)
        {
            var postNames = from x in db.Post
                            select x;

            if (searchString != null)
            {
                postNames = postNames.Where(x => x.Title.Contains(searchString) && x.Category == "Fix"
                                       || x.Description.Contains(searchString) && x.Category == "Fix");
                ViewBag.Post = postNames.OrderByDescending(o => o.Likes).ToList();
            }
            else {
                var model = db.Post.Where(x => x.Category == "fix");
                List<Post> sorted = model.OrderByDescending(o => o.Likes).ToList();
                int number = 1;

                foreach (Post item in sorted)
                {
                    item.Number = number;
                    number++;
                }
                ViewBag.Post = sorted;
            }
            var pager = new Pager(ViewBag.Post.Count, page);

            ViewBag.pageSize = pager.PageSize;

            IEnumerable<Post> sort = ViewBag.Post as IEnumerable<Post>;

            var viewModel = new Pagination
            {
                Items = sort.Skip((pager.CurrentPage - 1) * pager.PageSize).Take(pager.PageSize),
                Pager = pager
            };
            return View("Index", viewModel);
        }

        public ActionResult Build(string searchString, int? page)
        {
            var postNames = from x in db.Post
                            select x;

            if (searchString != null)
            {
                postNames = postNames.Where(x => x.Title.Contains(searchString) && x.Category == "Build"
                                       || x.Description.Contains(searchString) && x.Category == "Build");
                ViewBag.Post = postNames.OrderByDescending(o => o.Likes).ToList();
            }
            else {
                var model = db.Post.Where(x => x.Category == "Build");
                List<Post> sorted = model.OrderByDescending(o => o.Likes).ToList();
                int number = 1;

                foreach (Post item in sorted)
                {
                    item.Number = number;
                    number++;
                }
                ViewBag.Post = sorted;
            }
            var pager = new Pager(ViewBag.Post.Count, page);

            ViewBag.pageSize = pager.PageSize;

            IEnumerable<Post> sort = ViewBag.Post as IEnumerable<Post>;

            var viewModel = new Pagination
            {
                Items = sort.Skip((pager.CurrentPage - 1) * pager.PageSize).Take(pager.PageSize),
                Pager = pager
            };
            return View("Index", viewModel);
        }

        public ActionResult Help(string searchString, int? page)
        {
            var postNames = from x in db.Post
                            select x;

            if (searchString != null)
            {
                postNames = postNames.Where(x => x.Title.Contains(searchString) && x.Category == "Help"
                                       || x.Description.Contains(searchString) && x.Category == "Help");
                ViewBag.Post = postNames.OrderByDescending(o => o.Likes).ToList();
            }
            else {
                var model = db.Post.Where(x => x.Category == "Help");
                List<Post> sorted = model.OrderByDescending(o => o.Likes).ToList();
                int number = 1;

                foreach (Post item in sorted)
                {
                    item.Number = number;
                    number++;
                }
                ViewBag.Post = sorted;
            }
            var pager = new Pager(ViewBag.Post.Count, page);

            ViewBag.pageSize = pager.PageSize;

            IEnumerable<Post> sort = ViewBag.Post as IEnumerable<Post>;

            var viewModel = new Pagination
            {
                Items = sort.Skip((pager.CurrentPage - 1) * pager.PageSize).Take(pager.PageSize),
                Pager = pager
            };
            return View("Index", viewModel);
        }

        public ActionResult NewPost()
        {
            Post model = new Post()
            {
                ListCategory = new List<SelectListItem>() { new SelectListItem() {
                    Text = "Fix", Value = "fix" }, new SelectListItem() {
                        Text = "Build", Value = "build" }, new SelectListItem() {
                            Text = "Help", Value = "help" },
                }
            };
            return View(model);
        }

        public ActionResult GovernmentComment(int PostID)
        {

            ViewBag.postId = PostID;
            return View();
        }

        public ActionResult AddPhoto(int PostID)
        {

            ViewBag.postId = PostID;
            return View();
        }

        public ActionResult MyProfile( string pageTitle)
        {
            var userId = User.Identity.GetUserId();

            if (Request.IsAuthenticated)
            {
                ViewBag.Img = db.Users.Where(x => x.Id == userId).SingleOrDefault().ImageData;
            }
                ViewBag.subTitle = pageTitle;
            return View("Profile");
        }
    }
}