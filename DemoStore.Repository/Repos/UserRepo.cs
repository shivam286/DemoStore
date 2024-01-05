using DemoStore.DataAccess.Data;
using DemoStore.DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoStore.Repository.Repos
{
    public class UserRepo
    {
        private readonly DemoStoreContext _context;
        public UserRepo()
        {
            _context = new DemoStoreContext();

        }

        public User GetUser(string name,string phone)
        {
            name = name.ToLower();
            return _context.Users.FirstOrDefault(x => x.FullPhoneNumber == phone && x.Name.ToLower() == name && x.Activated == true);
        }

        public long AddUser(string name, string phone)
        {
            User user = new User { FullPhoneNumber = phone, Name = name, Activated = true };
            _context.Users.Add(user);
            _context.SaveChanges();
            return user.Id;
        }
    }
}
