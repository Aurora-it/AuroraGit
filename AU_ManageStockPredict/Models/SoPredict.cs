using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AU_ManageStockPredict.Models
{
    public class SoPredict: MasterProductGroup
    {
        public decimal PriceAll { set; get; }
        public int QtyAll { set; get; }
        public int Qty100 { set; get; }
        public int Qty90 { set; get; }
        public int Qty80 { set; get; }
        public int Qty70 { set; get; }
        public int Qty60 { set; get; }
        public int Qty50 { set; get; }
        public int Qty40 { set; get; }
        public int Qty30 { set; get; }
        public int Qty20 { set; get; }
        public int Qty10 { set; get; }


    }
}