using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class AuthRepository : IAuthRepository
    {
        ShopingMiniContext myDb = new ShopingMiniContext();
        public Member checkLogin(string username, string password)
            => myDb.Members.FirstOrDefault(x => x.Email.Equals(username) && x.Password.Equals(password));
    }
}
