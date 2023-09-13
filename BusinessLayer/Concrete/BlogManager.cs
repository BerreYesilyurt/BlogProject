using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class BlogManager:IBlogService
    {
        IBlogDal _blogDal;
        Repository<Blog> repoblog = new Repository<Blog>();

        public BlogManager(IBlogDal blogDal)
        {
            _blogDal = blogDal;
        }


        public List<Blog> GetBlogByAuthor(int id)
        {
            return _blogDal.List(x => x.AuthorID == id);
        }

        public List<Blog> GetBlogById(int id)
        {
            return _blogDal.List(x => x.BlogID == id); /*Burada BlogManager sınıfında kullandığımız List metodu ile listeleme yaptık.
                                                        EF metodu kullanmadık. Örneğin ToList yapzarak yapsaydık SOLID'e aykırı hareket edilmiş olurdu.*/
        }

        public List<Blog> GetBlogByCategory(int id)
        {

            return _blogDal.List(x => x.CategoryID == id);
        }

        public List<Blog> GetList()
        {
            return _blogDal.List(); 
        }
        public Blog GetById(int id)
        {
            return _blogDal.GetById(id);   
        }

        public void TAdd(Blog t)
        {
            _blogDal.Insert(t);
        }

        public void TDelete(Blog t)
        {
            _blogDal.Delete(t);

        }

        public void TUpdate(Blog t)
        {
            _blogDal.Update(t);
        }
    }
}
