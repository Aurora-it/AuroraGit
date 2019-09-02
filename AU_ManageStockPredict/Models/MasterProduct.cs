using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AU_ManageStockPredict.Models
{
    public class MasterProduct
    {
        public string PDG_Code { get; set; }
        public string PDT_Code { get; set; }
        public string PDG_Name { get; set; }
        public string PDG_Ds { get; set; }
        public string PDG_Wg { get; set; }
        public string Active_Status { get; set; }
    }
}