using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AU_ManageStockPredict.Models
{
    public class SoPredictGroup : MasterProductGroup
    {
        public string PriceAll { set; get; }
        public int QtyGroupAll { set; get; }
        public int QtyGroupPer { set; get; }
        public int QtyProdCount { set; get; }
        public int Per { set; get; }


    }
}