using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryManager.AppData.DataModel
{
    public class Component
    {
        public int ComponentId { get; set; }
        public string ComponentName { get; set; }
        public int TypeId { get; set; }
        public string TypeName { get; set; }
    }
}
