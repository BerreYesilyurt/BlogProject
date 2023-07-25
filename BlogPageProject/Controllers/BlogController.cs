using BusinessLayer.Concrete;
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
        BlogManager bm=new BlogManager();
        // GET: Blog
        public ActionResult Index()
        {
            return View();
        }

        public PartialViewResult BlogList(int page=1)
        {
            var bloglist = bm.GelAll().ToPagedList(page,6);

            return PartialView(bloglist);
        }

        public PartialViewResult FeaturedPosts()
        {
            // 1. Post
            var posttitle1 = bm.GelAll().OrderByDescending(z=>z.BlogID).Where(x => x.CategoryID == 1).Select(y => y.BlogTitle).FirstOrDefault(); 
            // BlogManager aracılığıyla, GetAll metodu ile listele ama, ID'si 1 olan ppost title'lar içerisinde ilk değeri getirir.
            // Azalan Id'ye göre sıraladık çünkü biz burada en son postu istiyoruz.

            var postimage1= bm.GelAll().OrderByDescending(z => z.BlogID).Where(x => x.CategoryID == 1).Select(y => y.BlogImage).FirstOrDefault();
            // Blog'un image değerini çektik.

            var blogdate1= bm.GelAll().OrderByDescending(z => z.BlogID).Where(x => x.CategoryID == 1).Select(y => y.BlogDate).FirstOrDefault();
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
            var posttitletop = bm.GelAll().OrderBy(z=>z.BlogID).Select(y => y.BlogTitle).FirstOrDefault();
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

        public PartialViewResult BlogCover(int id) {
            var blogDetailsGround = bm.GetBlogById(id);

            return PartialView(blogDetailsGround);
        
        }

        public PartialViewResult BlogReadAll(int id) {
            var blogDetailsList = bm.GetBlogById(id); 

            return PartialView(blogDetailsList);
        
        }

        public ActionResult BlogByCategory()
        {
            return View();  
        }



    
    }
}