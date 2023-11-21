using Practics_entityFr.DataBase;
using Practics_entityFr.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practics_entityFr
{
    public class Servis
    {
        public void AddNewUser(int uid,string uname)
        {
            using (var db = new UserDB())
            {
                db.Users.Add(new User()
                {
                    Id = uid,
                    Name = uname,
                });
                db.SaveChanges();
            }
        }
    }
}
