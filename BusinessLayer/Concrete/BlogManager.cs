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
        Repository<Blog> repoblog=new Repository<Blog>();   

        public List<Blog> GelAll()
        {

            return repoblog.List();
        }

        public List<Blog> GetBlogByAuthor(int id)
        {
            return repoblog.List(x=>x.AuthorID==id);
        }

        public List<Blog> GetBlogById(int id)
        {
            return repoblog.List(x => x.BlogID == id); /*Burada BlogManager sınıfında kullandığımız List metodu ile listeleme yaptık.
                                                        EF metodu kullanmadık. Örneğin ToList yapzarak yapsaydık SOLID'e aykırı hareket edilmiş olurdu.*/
        }



    }
}
