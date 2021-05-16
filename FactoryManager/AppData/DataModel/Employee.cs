using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryManager.AppData.DataModel
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        public string Abbreviation { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string Title { get; set; }
        public bool IsEmployed { get; set; }

    }
}
