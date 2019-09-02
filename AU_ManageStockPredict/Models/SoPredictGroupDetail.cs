using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AU_ManageStockPredict.Models
{
    public class SoPredictGroupDetail : MasterProductGroup
    {
        public string PDT_ItemCode { set; get; }
        public string Product_code { set; get; }
        public string PDT_Name { set; get; }
        public string PDT_Barcode { set; get; }
        public int QtyGroupAll { set; get; }
        public int QtyGroupPer { set; get; }
        public int QtyProdAll { set; get; }
        public int QtyProdPer { set; get; }
        public int QtyCount { set; get; }
        public int Per { set; get; }
    }
}