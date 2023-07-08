using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IRepository<T> /*Bir entity parametresi yolluyoruz.*/
    {
        List<T> List();

        int Insert(T p);

        int Delete(T p);

        int Update(T p);

        T GetById(int id); /*ID değerini içeren T sınıfını getirmek*/
    }
}
