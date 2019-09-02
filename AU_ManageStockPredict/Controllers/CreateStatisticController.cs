using AU_ManageStockPredict.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using System.Web.Script.Serialization;

namespace AU_ManageStockPredict.Controllers
{
    public class CreateStatisticController : Controller
    {
        // GET: CreateStatistic
        public ActionResult Create()
        {
            return View();
        }
        public JsonResult GetSummaryPredict(string dateStart,string dateEnd)
        {
            var data = StatisticDal.GetSummaryPredict(dateStart, dateEnd);
            return Json(data, JsonRequestBehavior.AllowGet);
        }

        public JsonResult GetSummaryPredictGroup(string dateStart, string dateEnd,int per)
        {
            var data = StatisticDal.GetSummaryPredictGroupDatatil(dateStart, dateEnd, per);
            return Json(data, JsonRequestBehavior.AllowGet);
        }

        public JsonResult GetSummaryPredictGroupDetail(string dateStart, string dateEnd, int per)
        {
            var data = StatisticDal.GetSummaryPredictGroupDatatil(dateStart, dateEnd, per);
            return Json(data, JsonRequestBehavior.AllowGet);
        }

        public JsonResult GetSummaryPredictGroupDatailAll(string dateStart, string dateEnd, int per)
        {
            var data = StatisticDal.GetSummaryPredictGroupDatatilAll(dateStart, dateEnd, per);
            return Json(data, JsonRequestBehavior.AllowGet);
        }

        public JsonResult GetSummaryPredictLA(string dateStart, string dateEnd)
        {
            var data = StatisticDal.GetSummaryPredictLA(dateStart, dateEnd);
            return Json(data, JsonRequestBehavior.AllowGet);
        }


        public JsonResult GetSummaryPredictH_LA(string dateStart, string dateEnd)
        {
            var data = StatisticDal.GetSummaryPredictH_LA(dateStart, dateEnd);
            return Json(data, JsonRequestBehavior.AllowGet);
        }
        
    }
}