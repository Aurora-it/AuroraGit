using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AU_ManageStockPredict.Models
{
    public class SoPredictLA
    {
        public string LA { set; get; }
        public int Id { set; get; }
        public string Branch_Code { set; get; }
        public string Branch_Name { set; get; }
        public int PriceAll { set; get; }
    }
}