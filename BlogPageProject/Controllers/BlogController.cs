
using BusinessLayer.Concrete;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
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
        CommentManager cm = new CommentManager(new EfCommentDal());
        BlogManager bm = new BlogManager(new EfBlogDal());
        // GET: Blog
        [AllowAnonymous]
        public ActionResult Index()
        {
            return View();
        }

        [AllowAnonymous]
        public PartialViewResult BlogList(int page = 1)
        {
            var bloglist = bm.GetList().ToPagedList(page, 6);

            return PartialView(bloglist);
        }

        [AllowAnonymous]    
        public PartialViewResult FeaturedPosts()
        {
            // 1. Post
            var posttitle1 = bm.GetList().OrderByDescending(z => z.BlogID).Where(x => x.CategoryID == 1).Select(y => y.BlogTitle).FirstOrDefault();
            // BlogManager aracılığıyla, GetAll metodu ile listele ama, ID'si 1 olan ppost title'lar içerisinde ilk değeri getirir.
            // Azalan Id'ye göre sıraladık çünkü biz burada en son postu istiyoruz.

            var postimage1 = bm.GetList().OrderByDescending(z => z.BlogID).Where(x => x.CategoryID == 1).Select(y => y.BlogImage).FirstOrDefault();
            // Blog'un image değerini çektik.

            var blogdate1 = bm.GetList().OrderByDescending(z => z.BlogID).Where(x => x.CategoryID == 1).Select(y => y.BlogDate).FirstOrDefault();
            // Blog'un tarih(date) değerini çektik.

            var blogpostid1=bm.GetList().OrderByDescending(z=>z.BlogID).Where(x=>x.CategoryID==1).Select(y=>y.BlogID).FirstOrDefault();  

            ViewBag.posttitle1 = posttitle1;
            ViewBag.postimage1 = postimage1;
            ViewBag.blogdate1 = blogdate1;
            ViewBag.blogpostid1=blogpostid1;    


            // 2. Post
            var posttitle2 = bm.GetList().OrderByDescending(z => z.BlogID).Where(x => x.CategoryID == 2).Select(y => y.BlogTitle).FirstOrDefault();
            // BlogManager aracılığıyla, GetAll metodu ile listele ama, ID'si 1 olan ppost title'lar içerisinde ilk değeri getirir.
            // Azalan Id'ye göre sıraladık çünkü biz burada en son postu istiyoruz.

            var postimage2 = bm.GetList().OrderByDescending(z => z.BlogID).Where(x => x.CategoryID == 2).Select(y => y.BlogImage).FirstOrDefault();
            // Blog'un image değerini çektik.

            var blogdate2 = bm.GetList().OrderByDescending(z => z.BlogID).Where(x => x.CategoryID == 2).Select(y => y.BlogDate).FirstOrDefault();
            // Blog'un tarih(date) değerini çektik.
            var blogpostid2 = bm.GetList().OrderByDescending(z => z.BlogID).Where(x => x.CategoryID == 2).Select(y => y.BlogID).FirstOrDefault();

            ViewBag.posttitle2 = posttitle2;
            ViewBag.postimage2 = postimage2;
            ViewBag.blogdate2 = blogdate2;
            ViewBag.blogpostid2 = blogpostid2;




            // 3. Post
            var posttitle3 = bm.GetList().OrderByDescending(z => z.BlogID).Where(x => x.CategoryID == 3).Select(y => y.BlogTitle).FirstOrDefault();
            // BlogManager aracılığıyla, GetAll metodu ile listele ama, ID'si 1 olan ppost title'lar içerisinde ilk değeri getirir.
            // Azalan Id'ye göre sıraladık çünkü biz burada en son postu istiyoruz.

            var postimage3 = bm.GetList().OrderByDescending(z => z.BlogID).Where(x => x.CategoryID == 3).Select(y => y.BlogImage).FirstOrDefault();
            // Blog'un image değerini çektik.

            var blogdate3 = bm.GetList().OrderByDescending(z => z.BlogID).Where(x => x.CategoryID == 3).Select(y => y.BlogDate).FirstOrDefault();
            // Blog'un tarih(date) değerini çektik.
            var blogpostid3 = bm.GetList().OrderByDescending(z => z.BlogID).Where(x => x.CategoryID == 3).Select(y => y.BlogID).FirstOrDefault();

            ViewBag.posttitle3 = posttitle3;
            ViewBag.postimage3 = postimage3;
            ViewBag.blogdate3 = blogdate3;
            ViewBag.blogpostid3 = blogpostid3;

            // 4. Post
            var posttitle4 = bm.GetList().OrderByDescending(z => z.BlogID).Where(x => x.CategoryID == 4).Select(y => y.BlogTitle).FirstOrDefault();
            // BlogManager aracılığıyla, GetAll metodu ile listele ama, ID'si 1 olan ppost title'lar içerisinde ilk değeri getirir.
            // Azalan Id'ye göre sıraladık çünkü biz burada en son postu istiyoruz.

            var postimage4 = bm.GetList().OrderByDescending(z => z.BlogID).Where(x => x.CategoryID == 4).Select(y => y.BlogImage).FirstOrDefault();
            // Blog'un image değerini çektik.

            var blogdate4 = bm.GetList().OrderByDescending(z => z.BlogID).Where(x => x.CategoryID == 4).Select(y => y.BlogDate).FirstOrDefault();
            // Blog'un tarih(date) değerini çektik.
            // Blog'un tarih(date) değerini çektik.
            var blogpostid4 = bm.GetList().OrderByDescending(z => z.BlogID).Where(x => x.CategoryID == 4).Select(y => y.BlogID).FirstOrDefault();


            ViewBag.posttitle4 = posttitle4;
            ViewBag.postimage4 = postimage4;
            ViewBag.blogdate4 = blogdate4;
            ViewBag.blogpostid4 = blogpostid4;


            // İlk atılan Post
            var posttitletop = bm.GetList().OrderBy(z => z.BlogID).Select(y => y.BlogTitle).FirstOrDefault();
            // BlogManager aracılığıyla, GetAll metodu ile listele ama, ID'si 1 olan ppost title'lar içerisinde ilk değeri getirir.
            // Azalan Id'ye göre sıraladık çünkü biz burada en son postu istiyoruz.

            var postimagetop = bm.GetList().OrderBy(z => z.BlogID).Select(y => y.BlogImage).FirstOrDefault();
            // Blog'un image değerini çektik.

            var blogdatetop = bm.GetList().OrderBy(z => z.BlogID).Select(y => y.BlogDate).FirstOrDefault();
            // Blog'un tarih(date) değerini çektik.
            var blogpostidtop = bm.GetList().OrderBy(z => z.BlogID).Select(y => y.BlogID).FirstOrDefault();

            ViewBag.posttitletop = posttitletop;
            ViewBag.postimagetop = postimagetop;
            ViewBag.blogdatetop = blogdatetop;
            ViewBag.blogpostidtop = blogpostidtop;

            return PartialView();
        }

        [AllowAnonymous]
        public PartialViewResult OtherFeaturedPosts()
        {
            return PartialView();
        }

        [AllowAnonymous]
        public ActionResult BlogDetails()
        {

            return View();
        }

        [AllowAnonymous]    
        public PartialViewResult BlogCover(int id)
        {
            var blogDetailsGround = bm.GetBlogById(id);

            return PartialView(blogDetailsGround);

        }

        [AllowAnonymous]    
        public PartialViewResult BlogReadAll(int id)
        {
            var blogDetailsList = bm.GetBlogById(id);

            return PartialView(blogDetailsList);

        }

        [AllowAnonymous]    
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
            var bloglist = bm.GetList();


            return View(bloglist);
        }

        public ActionResult AdminBlogList2()
        {
            var bloglist = bm.GetList();


            return View(bloglist);
        }
        [Authorize(Roles="A")]
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
            bm.TAdd(b);

            return RedirectToAction("AdminBlogList");
        }

        public ActionResult DeleteBlog(int id)
        {

            Blog blog = bm.GetById(id);
            bm.TDelete(blog);
            return RedirectToAction("AdminBlogList");

        }

        [HttpGet]
        public ActionResult UpdateBlog(int id)
        {
            Blog blog = bm.GetById(id);
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
            bm.TUpdate(p);

            return RedirectToAction("AdminBlogList");
        }

        public ActionResult GetCommentByBlog(int id)
        {
            var comments = cm.CommentBybLog(id);

            return View(comments);
        }

        public ActionResult AuthorBlogList(int id)
        {

            var blogs = bm.GetBlogByAuthor(id);
            return View(blogs);
        }



    }
}