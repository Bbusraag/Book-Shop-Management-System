using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShopManagement1.modelBook
{
   public abstract class Person
    {
        string isim;
        string soyisim;
        string email;
        string password;

        public string Isim { get => isim; set => isim = value; }
        public string Soyisim { get => soyisim; set => soyisim = value; }
        public string Email { get => email; set => email = value; }
        public string Password { get => password; set => password = value; }
        public virtual void LogIn(string email,string password)
        {

        }

    }
    
    
}
