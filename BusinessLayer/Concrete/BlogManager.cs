using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class BlogManager
    {
        Repository<Blog> repoblog = new Repository<Blog>();

        public List<Blog> GelAll()
        {

            return repoblog.List();
        }

        public List<Blog> GetBlogByAuthor(int id)
        {
            return repoblog.List(x => x.AuthorID == id);
        }

        public List<Blog> GetBlogById(int id)
        {
            return repoblog.List(x => x.BlogID == id); /*Burada BlogManager sınıfında kullandığımız List metodu ile listeleme yaptık.
                                                        EF metodu kullanmadık. Örneğin ToList yapzarak yapsaydık SOLID'e aykırı hareket edilmiş olurdu.*/
        }

        public List<Blog> GetBlogByCategory(int id)
        {

            return repoblog.List(x => x.CategoryID == id);
        }

        public int BlogAddBL(Blog p)
        {
            if (p.BlogTitle == " " || p.BlogImage == " " || p.BlogTitle.Length < 5 || p.BlogContent.Length <= 200)
            {
                return -1;
            }

            return repoblog.Insert(p);

        }

        public int DeleteBlog(int p)
        {
            Blog blog = repoblog.Find(x => x.BlogID == p); // Silinen blogun değerlerini tutan, Blog sınıfından türemiş bir blog parametresi

            return repoblog.Delete(blog);

        }

        public Blog FindBlog(int id) {


            return repoblog.Find(x => x.BlogID == id);
        
        
        }

        public int UpdateBlog(Blog p)
        {
            Blog blog = repoblog.Find(x => x.BlogID == p.BlogID);

            blog.BlogTitle = p.BlogTitle;
            blog.BlogContent = p.BlogContent;
            blog.BlogDate = p.BlogDate;
            blog.BlogImage = p.BlogImage;
            blog.CategoryID= p.CategoryID;      
            blog.AuthorID= p.AuthorID;  


            return repoblog.Update(blog);

        }

      



    }
}
