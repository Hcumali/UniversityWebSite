using System.Collections.Generic;
using UniversityWebSite.DataAccess.Abstract.Repositories;
using UniversityWebSite.Business.Abstract;
using UniversityWebSite.Entities.Concrete;
using UniversityWebSite.Entities.Enums;

namespace UniversityWebSite.Business.Concrete
{
    public class CategoryManager : ICategoryService
    {
        ICategoryRepository _categoryRepository;

        public CategoryManager(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

        public void CreateCategory(Category category)
        {
            _categoryRepository.Create(category);
        }

        public void DeleteCategory(int id)
        {
            _categoryRepository.Delete(id);
        }

        public IEnumerable<Category> GetAllCategory()
        {
            return _categoryRepository.GetAll();
        }

        public IEnumerable<Category> GetCategoryByHeader(NavBarHeader navBarHeader)
        {
            return _categoryRepository.GetAll(x => x.NavBarHeader == navBarHeader);
        }

        public Category GetCategoryById(int id)
        {
            return _categoryRepository.Get(x => x.Id == id);
        }

        public Category GetCategoryByName(string name)
        {
            return _categoryRepository.Get(x => x.Name == name);
        }

        public void UpdateCategory(Category category)
        {
            _categoryRepository.Update(category);
        }
    }
}
