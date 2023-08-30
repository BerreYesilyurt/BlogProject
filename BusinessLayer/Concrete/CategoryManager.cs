using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class CategoryManager
    {
        Repository<Category> repocategory = new Repository<Category>(); /*DataAccessLayer katmanında CRUD işlemleri için oluşturulan Repository sınıfına Category tablosunu vererek bir değişşken oluşturduk.*/

        public List<Category> GetAll()
        {
            return repocategory.List(); /*değişken yardımıyla metota erişim sağladık.*/
        }

        public int CategoryAddBL(Category p)
        {
            if (p.CategoryName == " " || p.CategoryDescription == " " || p.CategoryName.Length < 5 || p.CategoryName.Length >= 20)
            {
                return -1;
            }

            return repocategory.Insert(p);

        }

        public Category FindCategory(int id)
        {


            return repocategory.Find(x=>x.CategoryID==id);


        }

        public int EditCategory(Category p)
        {
            Category category = repocategory.Find(x => x.CategoryID == p.CategoryID);

            if(p.CategoryName.Length<=4 || p.CategoryName=="" || p.CategoryDescription=="" || p.CategoryDescription.Length >= 30)
            {
                return -1;

            }
            category.CategoryDescription = p.CategoryDescription;
            category.CategoryName = p.CategoryName;

            return repocategory.Update(category);


        }

        public int DeleteCategoryBL(int id)
        {
            Category category = repocategory.Find(x => x.CategoryID == id);

            category.CategoryStatus = false;

            return repocategory.Update(category);


        }

        public int ActiveCategoryBL(int id)
        {
            Category category = repocategory.Find(x => x.CategoryID == id);

            category.CategoryStatus = true;

            return repocategory.Update(category);


        }
    }
}
