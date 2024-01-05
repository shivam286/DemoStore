using DemoStore.DataAccess.Data;
using DemoStore.DataAccess.Models;
using System.Collections.Generic;
using System.Linq;

namespace DemoStore.Repository.Repos
{
    public class CategoryRepo
    {
        private readonly DemoStoreContext _context;
        public CategoryRepo()
        {
            _context = new DemoStoreContext();
        }
        public List<Category> GetCategories()
        {
            return _context.Categories.ToList();
        }
        public Category? GetCategoryById(int id)
        {
            return _context.Categories.FirstOrDefault(x => x.Id == id);
        }

        public long GetCategoryIdByName(string name)
        {
            return _context.Categories.Where(x => x.Name.Equals(name)).Select(x => x.Id).FirstOrDefault();
        }
    }
}
