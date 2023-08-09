using DataAccessLayer.Abstract;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete
{
    public class Repository<T> : IRepository<T> where T : class
    {
        Context c = new Context();/* Tablolarımıza ulaşabilmek için sınıf üzerinden bir c nesnesi */
        DbSet<T> _object; /* Dışarıdan gönderilen değerleri tutan bir tablo. Yani ben hangi entity sınıfıyla çalışacaksam o tabloyu tutuyor.*/


        public Repository() /* Constructor */
        {
            _object = c.Set<T>(); /*Context üzerinden gönderilen sınıfı _object değişkeninde tutuyor. */

        }

        public int Delete(T p)
        {
            _object.Remove(p);
            return c.SaveChanges();
        }

        public T Find(Expression<Func<T, bool>> where)
        {
            return _object.FirstOrDefault(where); // Gönderdiğim "where" parametresine göre bulma işlemini döndürmek
        }

        public T GetById(int id)
        {
            return _object.Find(id);
        }

        public int Insert(T p)
        {
            _object.Add(p);
            return c.SaveChanges();
        }

        public List<T> List()
        {
            return _object.ToList();
        }

        public List<T> List(Expression<Func<T, bool>> where)
        {
            return _object.Where(where).ToList(); /*Yukarıda tanımlananan where parametre ifadesine göre ToList yapmak*/
        }

        public int Update(T p)
        {
            return c.SaveChanges();
        }
    }
}
