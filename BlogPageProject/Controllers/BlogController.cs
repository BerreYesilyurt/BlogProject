
using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using PagedList;
using PagedList.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BlogPageProject.Controllers
{
    public class BlogController : Controller
    {
        BlogManager bm = new BlogManager();
        // GET: Blog
        public ActionResult Index()
        {
            return View();
        }

        public PartialViewResult BlogList(int page = 1)
        {
            var bloglist = bm.GelAll().ToPagedList(page, 6);

            return PartialView(bloglist);
        }

        public PartialViewResult FeaturedPosts()
        {
            // 1. Post
            var posttitle1 = bm.GelAll().OrderByDescending(z => z.BlogID).Where(x => x.CategoryID == 1).Select(y => y.BlogTitle).FirstOrDefault();
            // BlogManager aracılığıyla, GetAll metodu ile listele ama, ID'si 1 olan ppost title'lar içerisinde ilk değeri getirir.
            // Azalan Id'ye göre sıraladık çünkü biz burada en son postu istiyoruz.

            var postimage1 = bm.GelAll().OrderByDescending(z => z.BlogID).Where(x => x.CategoryID == 1).Select(y => y.BlogImage).FirstOrDefault();
            // Blog'un image değerini çektik.

            var blogdate1 = bm.GelAll().OrderByDescending(z => z.BlogID).Where(x => x.CategoryID == 1).Select(y => y.BlogDate).FirstOrDefault();
            // Blog'un tarih(date) değerini çektik.

            ViewBag.posttitle1 = posttitle1;
            ViewBag.postimage1 = postimage1;
            ViewBag.blogdate1 = blogdate1;


            // 2. Post
            var posttitle2 = bm.GelAll().OrderByDescending(z => z.BlogID).Where(x => x.CategoryID == 2).Select(y => y.BlogTitle).FirstOrDefault();
            // BlogManager aracılığıyla, GetAll metodu ile listele ama, ID'si 1 olan ppost title'lar içerisinde ilk değeri getirir.
            // Azalan Id'ye göre sıraladık çünkü biz burada en son postu istiyoruz.

            var postimage2 = bm.GelAll().OrderByDescending(z => z.BlogID).Where(x => x.CategoryID == 2).Select(y => y.BlogImage).FirstOrDefault();
            // Blog'un image değerini çektik.

            var blogdate2 = bm.GelAll().OrderByDescending(z => z.BlogID).Where(x => x.CategoryID == 2).Select(y => y.BlogDate).FirstOrDefault();
            // Blog'un tarih(date) değerini çektik.

            ViewBag.posttitle2 = posttitle2;
            ViewBag.postimage2 = postimage2;
            ViewBag.blogdate2 = blogdate2;


            // 3. Post
            var posttitle3 = bm.GelAll().OrderByDescending(z => z.BlogID).Where(x => x.CategoryID == 3).Select(y => y.BlogTitle).FirstOrDefault();
            // BlogManager aracılığıyla, GetAll metodu ile listele ama, ID'si 1 olan ppost title'lar içerisinde ilk değeri getirir.
            // Azalan Id'ye göre sıraladık çünkü biz burada en son postu istiyoruz.

            var postimage3 = bm.GelAll().OrderByDescending(z => z.BlogID).Where(x => x.CategoryID == 3).Select(y => y.BlogImage).FirstOrDefault();
            // Blog'un image değerini çektik.

            var blogdate3 = bm.GelAll().OrderByDescending(z => z.BlogID).Where(x => x.CategoryID == 3).Select(y => y.BlogDate).FirstOrDefault();
            // Blog'un tarih(date) değerini çektik.

            ViewBag.posttitle3 = posttitle3;
            ViewBag.postimage3 = postimage3;
            ViewBag.blogdate3 = blogdate3;

            // 4. Post
            var posttitle4 = bm.GelAll().OrderByDescending(z => z.BlogID).Where(x => x.CategoryID == 4).Select(y => y.BlogTitle).FirstOrDefault();
            // BlogManager aracılığıyla, GetAll metodu ile listele ama, ID'si 1 olan ppost title'lar içerisinde ilk değeri getirir.
            // Azalan Id'ye göre sıraladık çünkü biz burada en son postu istiyoruz.

            var postimage4 = bm.GelAll().OrderByDescending(z => z.BlogID).Where(x => x.CategoryID == 4).Select(y => y.BlogImage).FirstOrDefault();
            // Blog'un image değerini çektik.

            var blogdate4 = bm.GelAll().OrderByDescending(z => z.BlogID).Where(x => x.CategoryID == 4).Select(y => y.BlogDate).FirstOrDefault();
            // Blog'un tarih(date) değerini çektik.

            ViewBag.posttitle4 = posttitle4;
            ViewBag.postimage4 = postimage4;
            ViewBag.blogdate4 = blogdate4;


            // İlk atılan Post
            var posttitletop = bm.GelAll().OrderBy(z => z.BlogID).Select(y => y.BlogTitle).FirstOrDefault();
            // BlogManager aracılığıyla, GetAll metodu ile listele ama, ID'si 1 olan ppost title'lar içerisinde ilk değeri getirir.
            // Azalan Id'ye göre sıraladık çünkü biz burada en son postu istiyoruz.

            var postimagetop = bm.GelAll().OrderBy(z => z.BlogID).Select(y => y.BlogImage).FirstOrDefault();
            // Blog'un image değerini çektik.

            var blogdatetop = bm.GelAll().OrderBy(z => z.BlogID).Select(y => y.BlogDate).FirstOrDefault();
            // Blog'un tarih(date) değerini çektik.

            ViewBag.posttitletop = posttitletop;
            ViewBag.postimagetop = postimagetop;
            ViewBag.blogdatetop = blogdatetop;

            return PartialView();
        }

        public PartialViewResult OtherFeaturedPosts()
        {
            return PartialView();
        }


        public ActionResult BlogDetails()
        {

            return View();
        }

        public PartialViewResult BlogCover(int id)
        {
            var blogDetailsGround = bm.GetBlogById(id);

            return PartialView(blogDetailsGround);

        }

        public PartialViewResult BlogReadAll(int id)
        {
            var blogDetailsList = bm.GetBlogById(id);

            return PartialView(blogDetailsList);

        }

        public ActionResult BlogByCategory(int id)
        {
            var blogListByCategory = bm.GetBlogByCategory(id);
            var CategoryName = bm.GetBlogByCategory(id).Select(y => y.Category.CategoryName).FirstOrDefault();
            ViewBag.CategoryName = CategoryName; // Değişkenimizi başka bir sayfaya taşımak istediğimiz için ViewBag kullandık. Yukardaki değişkeni viewbag deişkenmine aktardık.

            var CategoryDescription = bm.GetBlogByCategory(id).Select(y => y.Category.CategoryDescription).FirstOrDefault();
            ViewBag.CategoryDescription = CategoryDescription;

            return View(blogListByCategory);
        }

        public ActionResult AdminBlogList()
        {
            var bloglist = bm.GelAll();


            return View(bloglist);
        }

        [HttpGet]
        public ActionResult AddNewBlog()
        {
            Context c = new Context();

            List<SelectListItem> values = (from x in c.Categories.ToList()
                                           select new SelectListItem
                                           {
                                               Text = x.CategoryName,
                                               Value = x.CategoryID.ToString()
                                           }).ToList(); /*Kategori tablosundaki verilerin listelenmesi*/

            ViewBag.values = values;

            List<SelectListItem> values2 = (from x in c.Authors.ToList()
                                            select new SelectListItem
                                            {
                                                Text = x.AuthorName,
                                                Value = x.AuthorID.ToString()
                                            }).ToList();
            ViewBag.values2 = values2;  


            return View();
        }

        [HttpPost]
        public ActionResult AddNewBlog(Blog b)
        {
            bm.BlogAddBL(b);

            return RedirectToAction("AdminBlogList");
        }

        public ActionResult DeleteBlog(int id)
        {
            bm.DeleteBlog(id);
            return RedirectToAction("AdminBlogList");

        }

        [HttpGet]
        public ActionResult UpdateBlog(int id)
        {
            Blog blog = bm.FindBlog(id);
            Context c = new Context();

            List<SelectListItem> values = (from x in c.Categories.ToList()
                                           select new SelectListItem
                                           {
                                               Text = x.CategoryName,
                                               Value = x.CategoryID.ToString()
                                           }).ToList(); /*Kategori tablosundaki verilerin listelenmesi*/

            ViewBag.values = values;

            List<SelectListItem> values2 = (from x in c.Authors.ToList()
                                            select new SelectListItem
                                            {
                                                Text = x.AuthorName,
                                                Value = x.AuthorID.ToString()
                                            }).ToList();
            ViewBag.values2 = values2;

            return View(blog);
        }

        [HttpPost]
        public ActionResult UpdateBlog(Blog p)
        {
            bm.UpdateBlog(p);

            return RedirectToAction("AdminBlogList");
        }

        public ActionResult GetCommentByBlog(int id)
        {
            CommentManager cm = new CommentManager();
            var comments = cm.CommentBybLog(id);

            return View(comments);
        }



    }
}