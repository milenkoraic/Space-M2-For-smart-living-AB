using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryManager.AppData.DataModel
{
    public class Construction
    {
        public int ConstructionId { get; set; }
        public int ConstructionNumber { get; set; }
        public string WallType { get; set; }
        public int SortingOrder { get; set; }
        public string MaterialName { get; set; }
        public decimal PartThickness { get; set; }
        public bool ForProcessing { get; set; }
        public decimal FinalThickness { get; set; }
    }
}
