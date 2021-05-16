using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryManager.AppData.DataModel
{
    public class Activity
    {
        public int ActivityId { get; set; }
        public string ActivityNumber { get; set; }
        public string Description { get; set; }
        public string Selfcontrol { get; set; }
        public string Instruction { get; set; }
    }
}
