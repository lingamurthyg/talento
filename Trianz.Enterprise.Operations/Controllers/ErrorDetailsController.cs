using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Trianz.Enterprise.Operations.Models;

namespace Trianz.Enterprise.Operations.Controllers
{
    public class ErrorDetailsController : Controller
    {
      
        public ActionResult ErrorDetailsView()
        {
            TrianzOperationsEntities Db = new TrianzOperationsEntities();
            Error_Info ei = new Error_Info();
            var errorlist = (from e in Db.Error_Info select e);
            return View(errorlist);
        }
    }
}