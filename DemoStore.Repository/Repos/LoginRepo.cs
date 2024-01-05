using DemoStore.DataAccess.Data;
using DemoStore.DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoStore.Repository.Repos
{
   
    public class LoginRepo
    {
        private readonly DemoStoreContext _context;
        public LoginRepo()
        {
            _context = new DemoStoreContext();
        }
        public AdminUser GetAdminUserAndPassword(string email)
        {
            var user = _context.AdminUsers.FirstOrDefault(x => x.Email == email);
            if(user != null)
            {
                user.Email= user.Email.ToLower();
            }
            return user;
        }

        public long GetAdminUserId(string email)
        {
            email = email.ToLower();
            return _context.AdminUsers.Where(x => x.Email == email).Select(i => i.Id).FirstOrDefault();
        }
        public string Encrypt(string paassword)
        {
            if (paassword == null) throw new ArgumentNullException("Please Insert Password!");

            string salt = BCrypt.Net.BCrypt.GenerateSalt(12); // Generate a salt (you can adjust the work factor by changing the 12)

            string hashedPassword = BCrypt.Net.BCrypt.HashPassword(paassword, salt);

            return hashedPassword;
        }
        public bool VerifyPassword(string cipher,string storedPassword)
        {
            if (cipher == null) throw new ArgumentNullException("Password in null!");

            bool isPasswordCorrect = BCrypt.Net.BCrypt.Verify(cipher, storedPassword);
            return isPasswordCorrect;
        }
    }
}
