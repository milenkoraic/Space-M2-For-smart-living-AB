using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryManager.AppData.DataModel
{
    public class User
    {
        public int UserId {get; set;}
        public int RoleId {get; set;}
        public string FirsName { get; set; }
        public string LastName { get; set; }
        public string Password { get; set; }
        public string ImageLocation { get; set; }

    }
}
