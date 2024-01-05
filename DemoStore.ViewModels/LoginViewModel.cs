using DemoStore.Repository.Repos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoStore.ViewModels
{
    public class LoginViewModel
    {
        private readonly LoginRepo _repo;
        public LoginViewModel()
        {
            _repo = new LoginRepo();
        }
        public bool Verify(string userName, string password)
        {
            bool result=false;
            if (userName == null || password == null) {  return result; }
            else
            {

                userName = userName.ToLower();
                var adminUser = _repo.GetAdminUserAndPassword(userName);
                if (adminUser == null)
                {
                    return result;
                }
                result = _repo.VerifyPassword(password,adminUser.EncryptedPassword);

            }
            return result;
        }
        public long GetAdminUserId(string userName)
        {
            return _repo.GetAdminUserId(userName);
        }
    }
}
