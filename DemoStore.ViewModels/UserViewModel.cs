using DemoStore.DataAccess.Models;
using DemoStore.Repository.Repos;

namespace DemoStore.ViewModels
{
    public class UserViewModel
    {
        private readonly UserRepo _context;
        public UserViewModel()
        {
            _context = new UserRepo();
        }

        public User GetUser(string name, string phone)
        {
            return _context.GetUser(name, phone);
        }

        public long AddUser(string name, string phone)
        {
            return _context.AddUser(name, phone);
        }
    }
}
