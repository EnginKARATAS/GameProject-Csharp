using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject_v1
{
    partial class Program
    {
        static void Main(string[] args)
        {
            SiteUserManager siteUserManager = new SiteUserManager();
            //ref alır
            SiteUser user = new Gamer() { Name="engin",BirthDay="1.1.1",Surname="Karataş",TcNo="1232131"};
            siteUserManager.AddUser(user); //gamer
            
        }
    }
}
 
