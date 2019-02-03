using BusinessLayer;
using DataModel;
using System.Web.Mvc;

namespace Hms.Controllers
{
    public class ControlController : Controller
    {
        private ControlBL controlBL = new ControlBL();
        public ActionResult Index()
        {
            if (controlBL.CheckExists())
            {
                return RedirectToAction("Edit");
            }
            return RedirectToAction("Create");
        }

        //[ChildActionOnly]
        public ActionResult Create()
        {
            ViewBag.Title = "Control";
            ViewBag.ControllerName = "RoomStatus";
            ViewBag.MethodName = "Create";
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Control control)
        {
            ViewBag.Title = "Control";
            ViewBag.ControllerName = "RoomStatus";
            ViewBag.MethodName = "Create";
            if (ModelState.IsValid)
            {
                if (!controlBL.CheckExists())
                {
                    controlBL.InsertControl(control);
                    return RedirectToAction("Index", "RoomStatus");
                }
            }
            return View(control);
        }

        public ActionResult Edit()
        {
            ViewBag.Title = "Control";
            ViewBag.ControllerName = "RoomStatus";
            ViewBag.MethodName = "Edit";
            Control control = controlBL.GetControl();
            return View(control);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Control control)
        {
            ViewBag.Title = "Control";
            ViewBag.ControllerName = "RoomStatus";
            ViewBag.MethodName = "Edit";
            if (ModelState.IsValid)
            {
                if (controlBL.CheckExists())
                {
                    controlBL.UpdateControl(control);
                    return RedirectToAction("Index", "RoomStatus");
                }
            }
            return View(control);
        }
    }
}