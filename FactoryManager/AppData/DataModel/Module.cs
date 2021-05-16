using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryManager.AppData.DataModel
{
    public class Module
    {
        public int ModuleId { get; set; }
        public int ModuleTypeId { get; set; }
        public string ModuleTypeName { get; set; }
        public string ModuleNumber { get; set; }
        public string ApartmentNumber { get; set; }
        public string ProjectNumber { get; set; }
    }
}
