using DemoStore.DataAccess.Models;
using DemoStore.Repository.Repos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoStore.ViewModels
{
    public class CategoryViewModel
    {
        private readonly CategoryRepo _category;
        public CategoryViewModel()
        {
            _category = new CategoryRepo();
        }
        public List<Category> GetCategories()
        {
            return _category.GetCategories();
        }

        public Category? GetCategoryById(int id)
        {
            return _category.GetCategoryById(id);
        }
        public long GetCategoryIdByName(string name)
        {
            return _category.GetCategoryIdByName(name);
        }
    }
}
