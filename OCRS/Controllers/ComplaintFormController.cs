using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OCRS.Controllers
{
    public class ComplaintFormController : Controller
    {
        // GET: ComplaintForm
        public ActionResult Complaint_Form()
        {
            return View();
        }
        //test1
        [HttpPost]

        [ValidateAntiForgeryToken]
        public ActionResult Complaint_Form(Complaint_TB U)
        {
            if (ModelState.IsValid)
            {
                using (Complaint_DBEntities dc = new Complaint_DBEntities())
                {
                    dc.Complaint_TB.Add(U);
                    dc.SaveChanges();
                    ModelState.Clear();
                    U = null;
                    ViewBag.Message = "Complaint Successfully Lodged";
                    return RedirectToAction("viewdata");
                }
            }
            return View();
        } 
        public ActionResult viewdata()
        {
            return View();
        }
    }
}
