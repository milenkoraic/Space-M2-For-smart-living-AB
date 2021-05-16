using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryManager.AppData.DataModel
{
    public class Supplier
    {
        public int SupplierId { get; set; }
        public string SupplierNumber { get; set; }
        public string SupplierName { get; set; }
        public string SuplierType { get; set; }
        public string OrganizationNumber { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string OrderEmail { get; set; }
        public string Address { get; set; }
        public string PostalCode { get; set; }
        public string City { get; set; }
        public string BankgiroNumber { get; set; }
        public string AccountNumber { get; set; }
        public int LeadTime { get; set; }
        public int CreditTime { get; set; }
        public string Reference { get; set; }
    }
}
