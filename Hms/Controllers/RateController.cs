using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BusinessLayer;
using DataModel;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Hms.Controllers
{
    public class RateController : Controller
    {
        private RateBL rateBL = new RateBL();
        private AgentBL agentBL = new AgentBL();
        private PlanBL planBL = new PlanBL();
        private RoomTypeBL roomTypeBL = new RoomTypeBL();
        public ActionResult Index()
        {
            if (!rateBL.CheckExists())
            {
                rateBL.InsertDefaults();
            }
            ViewBag.Title = "Rate";
            ViewBag.ControllerName = "Rate";
            return View(rateBL.GetRateList());
        }

        [HttpPost]
        public JsonResult UpdateRateValue(string data)
        {
            int id, amount, exppercharge;
            var obj = (JObject)JsonConvert.DeserializeObject(data);
            id = Convert.ToInt32(obj["id"]);
            amount = Convert.ToInt32(obj["amount"]);
            exppercharge = Convert.ToInt32(obj["expcharge"]);
            rateBL.UpdateValue(id, amount, exppercharge);
            return Json(1);
        }

        public JsonResult GetRateList()
        {
            return new JsonResult { Data = rateBL.GetRateList(), JsonRequestBehavior = JsonRequestBehavior.AllowGet };
        }

        public JsonResult GetAgentList()
        {
            return new JsonResult { Data = agentBL.ListAgent(), JsonRequestBehavior = JsonRequestBehavior.AllowGet };
        }

        public JsonResult GetPlanList()
        {
            return new JsonResult { Data = planBL.ListPlan(), JsonRequestBehavior = JsonRequestBehavior.AllowGet };
        }

        public JsonResult GetRoomTypeList()
        {
            return new JsonResult { Data = roomTypeBL.ListRoomType(), JsonRequestBehavior = JsonRequestBehavior.AllowGet };
        }
    }
}