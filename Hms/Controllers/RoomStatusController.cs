using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BusinessLayer;
using ViewModel;

namespace Hms.Controllers
{
    public class RoomStatusController : Controller
    {
        private FloorBL floorBL = new FloorBL();
        private RoomTypeBL roomTypeBL = new RoomTypeBL();
        private RoomBL roomBL = new RoomBL();
        // GET: RoomStatus
        public ActionResult Index()
        {
            var details = new RoomStatusModel
            {
                FloorList = floorBL.ListFloor(),
                RoomTypeList = roomTypeBL.ListRoomType(),
                RoomList = roomBL.ListRoom()
            };
            return View(details);
        }
    }
}