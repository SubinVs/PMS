using PMS.Core.Interfaces.HMS;
using PMS.ViewModel.HMS;
using System.Web.Mvc;

namespace Hms.Controllers
{
    public class FloorController : Controller
    {
        private IFloorManager _floorManager;

        public FloorController(IFloorManager floorManager)
        {
            this._floorManager = floorManager;
        }

        public ActionResult Index()
        {
            if (_floorManager.GetCount() > 0)
            {
                ViewBag.Count = _floorManager.GetCount();
                return View(_floorManager.GetAll());
            }
            return View("_EmptyRecord");
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(FloorViewModel floor)
        {
            if (ModelState.IsValid)
            {
                if (_floorManager.CheckDuplicate(floor))
                {
                    ViewBag.DuplicateError = "Floor Already Exists!!";
                    return View(floor);
                }
                else
                {
                    _floorManager.Add(floor);
                    return RedirectToAction("Index");
                }
            }
            return View(floor);
        }

        public ActionResult Edit(int id = 0)
        {
            return View(_floorManager.Get(id));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(FloorViewModel floor)
        {
            if (ModelState.IsValid)
            {
                if (_floorManager.CheckDuplicate(floor))
                {
                    ViewBag.DuplicateError = "Floor Already Exists!!";
                    return View(floor);
                }
                else
                {
                    _floorManager.Edit(floor);
                    return RedirectToAction("Index");
                }
            }
            return View(floor);
        }

        public ActionResult Delete(int id)
        {
            if (ModelState.IsValid)
            {
                _floorManager.Delete(id);
            }
            return RedirectToAction("Index");
        }
    }
}