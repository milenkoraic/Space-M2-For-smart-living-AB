using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryManager.AppData.DataModel
{
    public class Building
    {
        public int BuildingId { get; set; }
        public string BuildingNumber { get; set; }
        public string BuildingName { get; set; }
        public int NumberOfFloors { get;set; }
        public int PlanId { get; set; }
    }
}
