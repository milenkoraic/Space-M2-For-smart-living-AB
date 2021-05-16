using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryManager.AppData.DataModel
{
    public class SupplierAddress
    {
        public int AddressId { get; set; }
        public string AddresNumber { get; set; }
        public string Address { get; set; }
        public string PostalCode { get; set; }
        public string City { get; set; }
    }
}
