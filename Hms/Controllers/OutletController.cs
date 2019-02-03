using BusinessLayer;
using System.Web.Mvc;
using DataModel;

namespace Hms.Controllers
{
    public class OutletController : Controller
    {
        private OutletBL outletBL = new OutletBL();

        public ActionResult Index()
        {
            ViewBag.Title = "Outlet";
            ViewBag.ControllerName = "Outlet";
            if(outletBL.GetCount() > 0)
            {
                ViewBag.Count = outletBL.GetCount();
                return View(outletBL.ListOutlet());
            }
            return View("_EmptyRecord");
        }

        public ActionResult Create()
        {
            ViewBag.Title = "Outlet";
            ViewBag.ControllerName = "Outlet";
            ViewBag.MethodName = "Create";
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Outlet outlet)
        {
            ViewBag.Title = "Outlet";
            ViewBag.ControllerName = "Outlet";
            ViewBag.MethodName = "Create";
            if (ModelState.IsValid)
            {
                if (outletBL.CheckDuplicate(outlet))
                {
                    ViewBag.DuplicateError = "Outlet Already Exists!!";
                    return View(outlet);
                }
                else
                {
                    outletBL.InsertOutlet(outlet);
                    return RedirectToAction("Index");
                }
            }
            return View(outlet);
        }

        public ActionResult Edit(int id = 0)
        {
            ViewBag.Title = "Outlet";
            ViewBag.ControllerName = "Outlet";
            ViewBag.MethodName = "Edit";
            Outlet outlet = outletBL.FindId(id);
            if (outlet == null)
            {
                return HttpNotFound();
            }
            return View(outlet);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Outlet outlet)
        {
            ViewBag.Title = "Outlet";
            ViewBag.ControllerName = "Outlet";
            ViewBag.MethodName = "Edit";
            if (ModelState.IsValid)
            {
                if (outletBL.CheckDuplicate(outlet))
                {
                    ViewBag.DuplicateError = "Floor Already Exists!!";
                    return View(outlet);
                }
                else
                {
                    outletBL.UpdateOutlet(outlet);
                    return RedirectToAction("Index");
                }
            }
            return View(outlet);
        }

        public ActionResult Delete(int id)
        {
            ViewBag.Title = "Delete";
            if (ModelState.IsValid)
            {
                outletBL.DeleteOutlet(id);
            }
            return RedirectToAction("Index");
        }
    }
}