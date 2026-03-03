using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Trianz.Enterprise.Operations.Models;

namespace Trianz.Enterprise.Operations.Controllers
{
    public class EmployeeDashBoardController : Controller
    {
        // GET: EmployeeDashBoard
        private TrianzOperationsEntities db = new TrianzOperationsEntities();
        public ActionResult Index()
        {
            return View();
        }

        //public ActionResult EmployeeDashBoard()
        //{
        //    return View();
        //}

        public ActionResult EmployeeDashBoard()

        {
            if (Convert.ToInt32(Session["EmployeeId"]) > 0)
            {
                var emp = new ValidationModel();
                emp.EmployeeLocationlst = GenerateEmployeeLocation();
                emp.EmployeeDesignationlst = GetEmployeeDesignation();
                emp.EmployeeCountrieslst = GetEmployeeByCountry();
                return View(emp);
            }
            else
            {
                //ermsg = "Session expired";
                return Json("Sessionexpired", JsonRequestBehavior.AllowGet);
                //return RedirectToAction("SessionExpire", "Signout");
            }
        }
        private List<EmployeeLocation> GenerateEmployeeLocation()
        {
            int empId = Convert.ToInt32(Session["EmployeeId"]);

            List<EmployeeLocation> lstEmpLocationsummary = new List<EmployeeLocation>();

            //lstEmpLocationsummary = db.Database.SqlQuery<EmployeeLocation>
            //  ("exec GetEmployeeLocation").ToList<EmployeeLocation>();
            lstEmpLocationsummary = db.Database.SqlQuery<EmployeeLocation>("exec GetEmployeeLocation").ToList();

            //var studentGrades = db.GetEmployeeLocation();

            return lstEmpLocationsummary;
        }
       private List<EmployeeDesignation> GetEmployeeDesignation()
        {
            int empId = Convert.ToInt32(Session["EmployeeId"]);

            List<EmployeeDesignation> lstEmployeeDesignation = new List<EmployeeDesignation>();

            lstEmployeeDesignation = db.Database.SqlQuery<EmployeeDesignation>("exec GetEmployeeByDesignation").ToList();

            return lstEmployeeDesignation;
        }

        private List<EmployeeCountry> GetEmployeeByCountry()
        {
            int empId = Convert.ToInt32(Session["EmployeeId"]);

            List<EmployeeCountry> lstEmployeeCountry = new List<EmployeeCountry>();

            lstEmployeeCountry = db.Database.SqlQuery<EmployeeCountry>("exec GetEmployeeByCountry").ToList();

            return lstEmployeeCountry;
        }
    }
}