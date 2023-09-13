using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IRepository<T> /*Bir entity parametresi yolluyoruz.*/
    {
        List<T> List();

        void Insert(T p);

        void Delete(T p);

        void Update(T p);

        T GetById(int id); /*ID değerini içeren T sınıfını getirmek*/

        List<T> List(Expression<Func<T,bool>> where); /*Şartlı listeleme*/

        T Find(Expression<Func<T, bool>> where);


    }
}
