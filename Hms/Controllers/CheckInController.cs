using BusinessLayer;
using DataModel;
using System.Collections.Generic;
using System.Web.Mvc;
using ViewModel;

namespace Hms.Controllers
{
    public class CheckInController : Controller
    {
        private PurposeBL purposeBL = new PurposeBL();
        private PlanBL planBL = new PlanBL();
        private CompanyBL companyBL= new CompanyBL();
        private AgentBL agentBL = new AgentBL();
        private PrefixBL prefixBL = new PrefixBL();
        private CountryBL countryBL = new CountryBL();
        private StateBL stateBL = new StateBL();
        private CityBL cityBL = new CityBL();
        private GuestBL guestBL = new GuestBL();
        private CheckInBL checkInBL = new CheckInBL();
        private CheckInModel checkInDetails = new CheckInModel();

        public ActionResult Create(int id)
        {
            checkInDetails.roomId = id;
            var details = new CheckInModel
            {
                PurposeList = purposeBL.ListPurpose(),
                PlanList = planBL.ListPlan(),
                CompanyList = companyBL.ListCompany(),
                AgentList = agentBL.ListAgent(),
                PrefixList = prefixBL.ListPrefix(),
                CountryList = countryBL.ListCountry()
            };
            
            ViewBag.Title = "Check-In";
            ViewBag.ControllerName = "CheckIn";
            ViewBag.RoomNo = checkInDetails.GetRoomNo();
            ViewBag.GrcNo = checkInDetails.GetGrcNo();
            return View(details);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(CheckInModel checkInModel)
        {
            if (ModelState.IsValid)
            {
                var guest = new Guest();
                guest = checkInModel.Guest;
                guestBL.InsertGuest(guest);
                //var checkIn = new CheckIn {
                //    PlanId = checkInModel.PlanId
                //};
                //checkIn = (CheckIn)checkInModel;
                //checkInBL.CreateCheckIn(checkIn);
                return RedirectToAction("Create");
            }
            return View(checkInModel);
        }

        public JsonResult GetStateList(int id)
        {
            return Json(stateBL.GetState(id), JsonRequestBehavior.AllowGet);
        }

        public JsonResult GetCityList(int id)
        {
            return Json(cityBL.GetCity(id), JsonRequestBehavior.AllowGet);
        }
    }
}