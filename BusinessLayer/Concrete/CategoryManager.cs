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
    public class CategoryManager:ICategoryService
    {
        Repository<Category> repocategory = new Repository<Category>(); /*DataAccessLayer katmanında CRUD işlemleri için oluşturulan Repository sınıfına Category tablosunu vererek bir değişken oluşturduk.*/
        ICategoryDal _categoryDal;

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public void DeleteCategoryBL(int id)
        {
            Category category = _categoryDal.Find(x => x.CategoryID == id);

            category.CategoryStatus = false;

            _categoryDal.Update(category);


        }

        public void ActiveCategoryBL(int id)
        {
            Category category = _categoryDal.Find(x => x.CategoryID == id);

            category.CategoryStatus = true;

            _categoryDal.Update(category);


        }

        public List<Category> GetList()
        {
            return _categoryDal.List();
        }
        public Category GetById(int id)
        {
            return _categoryDal.GetById(id);
        }


        public void TAdd(Category t)
        {
            _categoryDal.Insert(t);
        }

        public void TDelete(Category t)
        {
            _categoryDal.Delete(t);
        }

        public void TUpdate(Category t)
        {
            _categoryDal.Update(t);
        }
    }
}
