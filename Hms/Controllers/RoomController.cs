using PMS.Core.Interfaces.HMS;
using System.Web.Mvc;
using PMS.ViewModel.HMS;
using System.Linq;
using System.Threading.Tasks;

namespace Hms.Controllers
{
    public class RoomController : Controller
    {
        private IRoomManager _roomManager;
        private IFloorManager _floorManager;
        private IRoomTypeManager _roomTypeManager;

        public RoomController(IRoomManager roomManager, IFloorManager floorManager, IRoomTypeManager roomTypeManager)
        {
            this._roomManager = roomManager;
            _floorManager = floorManager;
            _roomTypeManager = roomTypeManager;
        }

        public ActionResult Index()
        {
            if (_roomManager.GetCount() > 0)
            {
                ViewBag.Count = _roomManager.GetCount();
                return View(_roomManager.GetAll());
            }
            return View("_EmptyRecord");
        }

        public ActionResult Create()
        {
            var details = new RoomViewModel
            {
                RoomTypeList = _roomTypeManager.GetAll().Where(n => n.Active),
                FloorList = _floorManager.GetAll().Where(n => n.Active)
            };
            return View(details);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(RoomViewModel model)
        {
            model.RoomTypeList = _roomTypeManager.GetAll().Where(n => n.Active);
            model.FloorList = _floorManager.GetAll().Where(n => n.Active);

            if (ModelState.IsValid)
            {
                if (_roomManager.CheckDuplicate(model))
                {
                    ViewBag.DuplicateError = "Room Already Exists!!";
                    return View(model);
                }
                else
                {
                    _roomManager.Add(model);
                    return RedirectToAction("Index");
                }
            }
            return View(model);
        }

        public ActionResult Edit(int id = 0)
        {
            var model = _roomManager.Get(id);
            model.RoomTypeList = _roomTypeManager.GetAll().Where(n => n.Active);
            model.FloorList = _floorManager.GetAll().Where(n => n.Active);
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(RoomViewModel model)
        {
            model.RoomTypeList = _roomTypeManager.GetAll().Where(n => n.Active);
            model.FloorList = _floorManager.GetAll().Where(n => n.Active);
            if (ModelState.IsValid)
            {
                if (_roomManager.CheckDuplicate(model))
                {
                    ViewBag.DuplicateError = "Room Already Exists!!";
                    return View(model);
                }
                else
                {
                    _roomManager.Edit(model);
                    return RedirectToAction("Index");
                }
            }
            return View(model);
        }

        public ActionResult Delete(int id)
        {
            if (ModelState.IsValid)
            {
                _roomManager.Delete(id);
            }
            return RedirectToAction("Index");
        }
    }
}