using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Dapper;
using PagedList;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;
using AU_ManageStockPredict.Models;
using AU_ManageStockPredict.Models.Common;

namespace AU_ManageStockPredict.DataAccess
{
    public class StatisticDal
    {

        public static List<SoPredict> GetSummaryPredict(string dateStart , string dateEnd)
        {
            using (SqlConnection conn = new SqlConnection(Constants.AurNewConn))
            {

                var p = new DynamicParameters();
                {
                    p.Add("@STARTDATE", dateStart);
                    p.Add("@ENDDATE", dateEnd);
                }

                var data = conn.Query<SoPredict>("[spSoPredict]", p, commandType: CommandType.StoredProcedure).ToList();

                return data;
            }
        }



        public static List<SoPredictGroup> GetSummaryPredictGroup(string dateStart, string dateEnd,int per)
        {
            using (SqlConnection conn = new SqlConnection(Constants.AurNewConn))
            {
                if (per == 0) per = 50;
                var p = new DynamicParameters();
                {
                    p.Add("@STARTDATE", dateStart);
                    p.Add("@ENDDATE", dateEnd);
                    p.Add("@iPer", per);
                }

                var data = conn.Query<SoPredictGroup>("[spSoPredictGroup]", p, commandType: CommandType.StoredProcedure).ToList();

                return data;
            }
        }


        public static List<SoPredictGroup> GetSummaryPredictGroupDatatil(string dateStart, string dateEnd, int per)
        {
            List<SoPredictGroupDetail> dataRes  = new List<SoPredictGroupDetail>();
            if (per == 0) per = 50;
            var dataGroup = GetSummaryPredictGroup(dateStart, dateEnd, per);

            using (SqlConnection conn = new SqlConnection(Constants.AurNewConn))
            {

                foreach (var g in dataGroup)
                {
                    var p = new DynamicParameters();
                    {
                        p.Add("@STARTDATE", dateStart);
                        p.Add("@ENDDATE", dateEnd);
                        p.Add("@iPer", per);
                        p.Add("@PDG_Code", g.PDG_Code);
                    }

                    var data = conn.Query<SoPredictGroupDetail>("[spSoPredictGroupDetail]", p, commandType: CommandType.StoredProcedure).ToList();
                    g.QtyProdCount = data.Count();

                    foreach (var a in data)
                    {
                        dataRes.Add(new SoPredictGroupDetail {PDT_Code = a.PDT_Code, PDG_Code = a.PDG_Code, PDG_Name = a.PDG_Name,PDG_Ds = a.PDG_Ds,Product_code = a.Product_code,PDT_Name = a.PDT_Name,PDT_Barcode = a.PDT_Barcode,QtyProdAll = a.QtyProdAll });
                    }
                }
            }
            return dataGroup;
        }



        public static SoPredictGroupDetailAll GetSummaryPredictGroupDatatilAll(string dateStart, string dateEnd, int per)
        {
            List<SoPredictGroupDetail> dataRes = new List<SoPredictGroupDetail>();

            if (per == 0) per = 50;
            var dataG = GetSummaryPredictGroup(dateStart, dateEnd, per);

            using (SqlConnection conn = new SqlConnection(Constants.AurNewConn))
            {

                foreach (var g in dataG)
                {
                    var p = new DynamicParameters();
                    {
                        p.Add("@STARTDATE", dateStart);
                        p.Add("@ENDDATE", dateEnd);
                        p.Add("@iPer", per);
                        p.Add("@PDG_Code", g.PDG_Code);
                    }

                    var data = conn.Query<SoPredictGroupDetail>("[spSoPredictGroupDetail]", p, commandType: CommandType.StoredProcedure).ToList();
                    g.QtyProdCount = data.Count();

                    foreach (var a in data)
                    {
                        dataRes.Add(new SoPredictGroupDetail { PDT_Code = a.PDT_Code, PDG_Code = a.PDG_Code, PDG_Name = a.PDG_Name, PDG_Ds = a.PDG_Ds, Product_code = a.Product_code, PDT_Name = a.PDT_Name, PDT_Barcode = a.PDT_Barcode, QtyProdAll = a.QtyProdAll, PDT_ItemCode = a.PDT_ItemCode });
                    }
                }
            }

                return new SoPredictGroupDetailAll
                {
                    dataGroup = dataG,
                    dataDatail = dataRes
                };

        }




        public static List<SoPredictLA> GetSummaryPredictLA(string dateStart, string dateEnd)
        {
            using (SqlConnection conn = new SqlConnection(Constants.AurNewConn))
            {
                var p = new DynamicParameters();
                {
                    p.Add("@STARTDATE", dateStart);
                    p.Add("@ENDDATE", dateEnd);
                }

                var data = conn.Query<SoPredictLA>("[spSoPredictLA]", p, commandType: CommandType.StoredProcedure).ToList();
                return data;
            }
        }


        public static SoPredictH_LA GetSummaryPredictH_LA(string dateStart, string dateEnd)
        {
            var dataH = GetSummaryPredict(dateStart, dateEnd);
            var dataLA = GetSummaryPredictLA(dateStart, dateEnd);

            return new SoPredictH_LA
            {
                dataH = dataH,
                dataLA = dataLA
            };
        }



        
    }
}