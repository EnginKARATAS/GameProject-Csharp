using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject_v1
{
    public class SiteUserManager:IDataService
    {
        public void AddUser(SiteUser siteuser)
        {
            Console.WriteLine("site kullanıcısı sisteme eklendi");
        }

        public void AddUser()
        {
            throw new NotImplementedException();
        }
    }
}
