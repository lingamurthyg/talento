using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Trianz.Enterprise.Operations.Models;

namespace TZOperations.Controllers
{
    public class AssociateAcceptanceController : Controller
    {
        TrianzOperationsEntities db = new TrianzOperationsEntities();
       
        // GET: AssociateAcceptance
        public ActionResult AssociateAcceptance(int? hrrfID)
        {
            ValidationModel model = new ValidationModel();
            //if (hrrfID == null)
            //{
            //    return new HttpStatusCodeResult(System.Net.HttpStatusCode.BadRequest);
            //}
           // HRRF hrrf = db.HRRF.Find(hrrfID);
            //if (hrrf == null)
            //{
            //    return HttpNotFound();
            //}
            //return view
            return View();
            
        }


        // GET: AssociateAcceptance
        public ActionResult Accept(HRRF HRRF, ValidationModel model, string Submit)
        {
           
            return View();

        }
    }
}