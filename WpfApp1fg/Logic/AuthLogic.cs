using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1fg.Logic
{
    public class AuthLogic
    {
        private ShopDBDGREntities db = new ShopDBDGREntities();

        public bool Auth(string Login, string Password)=>
            db.Users.Any(user => user.Login == Login &&  user.Password == Password);
    }
}
