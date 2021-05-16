using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryManager.AppData.DataModel
{
    public class Apartment
    {
        public int ApartmentId { get; set; }
        public string ApartmentNumber { get; set; }
        public int ApartmentNameId { get; set; }
        public string ApartmentName { get; set; }
        public decimal ApartmentArea { get; set; }
        public string ProjectNumber { get; set; }
    }
}
