﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryManager.AppData.DataModel
{
    public class Improvement
    {
        public int ImprovementId { get; set; }
        public string ProjectNumber { get; set; }
        public string StatusType { get; set; }
        public DateTime DateRegistered { get; set; }
        public string IssuedBy { get; set; }
        public string Problem { get; set; }
        public string ImprovementReason { get; set; }
        public string ActionInProject { get; set; }
        public string Responsible1 { get; set; }
        public DateTime RepairDate { get; set; }
        public string Solution { get; set; }
        public string Responsible2 { get; set; }
        public DateTime LongTermDateStart { get; set; }
        public int VeckaStart { get; set; }
        public int VeckaSlut{ get; set; }
    }
}
