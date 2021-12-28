using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using UniversityWebSite.Entities.Concrete;
using UniversityWebSite.Entities.Enums;

namespace UniversityWebSite.Business.Abstract
{
    public interface ICategoryService
    {
        void CreateCategory(Category category);
        Category GetCategoryById(int id);
        Category GetCategoryByName(string name);
        IEnumerable<Category> GetAllCategory();
        IEnumerable<Category> GetCategoryByHeader(NavBarHeader navBarHeader);
        void UpdateCategory(Category category);
        void DeleteCategory(int id);
    }
}
