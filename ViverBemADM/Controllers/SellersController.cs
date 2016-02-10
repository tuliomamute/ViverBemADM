using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ViverBemADM.Models;

namespace ViverBemADM.Controllers
{
    public class SellersController : Controller
    {
        private ViverBemADMContext db { get; set; }

        public SellersController()
        {
            db = new ViverBemADMContext();
        }

        #region Get Methods

        // GET: Sellers
        public ActionResult Index()
        {
            var model = db.Sellers.ToList();
            return View(model);
        }

        // GET: Sellers/Details/5
        public ActionResult Details(int id)
        {
            var model = db.Sellers.Find(id);
            return View(model);
        }

        // GET: Sellers/Create
        public ActionResult Create()
        {
            return View();
        }

        // GET: Sellers/Edit/5
        public ActionResult Edit(int id)
        {
            var model = db.Sellers.Find(id);

            return View("Edit", model);
        }

        // GET: Sellers/Delete/5
        public ActionResult Delete(int id)
        {
            var model = db.Sellers.Find(id);
            return View("Delete", model);

        }
        #endregion

        #region Post Methods
        // POST: Sellers/Create
        [HttpPost]
        public ActionResult Create(Sellers model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    // TODO: Add insert logic here
                    db.Sellers.Add(model);
                    db.SaveChanges();

                    return RedirectToAction("Index");
                }
                return View();

            }
            catch (Exception ex)
            {
                return View();
            }
        }

        // POST: Sellers/Edit/5
        [HttpPost]
        public ActionResult Edit(Sellers model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    db.Entry(model).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();

                    return RedirectToAction("Index");
                }
                return View();
            }
            catch (Exception ex)
            {
                return View();
            }
        }

        // POST: Sellers/Delete/5
        [HttpPost]
        public ActionResult Delete(Sellers model)
        {
            try
            {
                // TODO: Add delete logic here
                db.Entry(model).State = System.Data.Entity.EntityState.Deleted;
                db.SaveChanges();

                return RedirectToAction("Index");

            }
            catch (Exception ex)
            {
                return View();
            }
        }

        #endregion
    }
}
