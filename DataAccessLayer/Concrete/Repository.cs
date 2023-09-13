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

        public void Delete(T p)
        {
            var deletedEntity=c.Entry(p);
            deletedEntity.State = EntityState.Deleted;
            c.SaveChanges();
        }

        public T Find(Expression<Func<T, bool>> where)
        {
            return _object.FirstOrDefault(where); // Gönderdiğim "where" parametresine göre bulma işlemini döndürmek
        }

        public T GetById(int id)
        {
            return _object.Find(id);
        }

        public void Insert(T p)
        {
            var addedEntity = c.Entry(p);
            addedEntity.State = EntityState.Added;  
            c.SaveChanges();
        }

        public List<T> List()
        {
            return _object.ToList();
        }

        public List<T> List(Expression<Func<T, bool>> where)
        {
            return _object.Where(where).ToList(); /*Yukarıda tanımlananan where parametre ifadesine göre ToList yapmak*/
        }

        public void Update(T p)
        {
            var updatedEntity=c.Entry(p);
            updatedEntity.State=EntityState.Modified;
            c.SaveChanges();
        }
    }
}
