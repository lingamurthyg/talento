using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Trianz.Enterprise.Operations.Controllers
{
    public class RoleMastersController : Controller
    {
        // GET: RoleMasters
        public ActionResult Index()
        {
            return View();
        }

        // GET: RoleMasters/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: RoleMasters/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: RoleMasters/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
               

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: RoleMasters/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: RoleMasters/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: RoleMasters/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: RoleMasters/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
