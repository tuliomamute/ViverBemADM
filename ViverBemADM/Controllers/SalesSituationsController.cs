using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ViverBemADM.Models;

namespace ViverBemADM.Controllers
{
    public class SalesSituationController : Controller
    {
        private ViverBemADMContext viverbembd { get; set; }

        public SalesSituationController()
        {
            viverbembd = new ViverBemADMContext();
        }

        #region Get Methods

        // GET: SalesSituation
        public ActionResult Index()
        {
            var model = viverbembd.SalesSituation.ToList();
            return View(model);
        }

        // GET: SalesSituation/Details/5
        public ActionResult Details(int id)
        {
            var model = viverbembd.SalesSituation.Find(id);
            return View(model);
        }

        // GET: SalesSituation/Create
        public ActionResult Create()
        {
            return View();
        }

        // GET: SalesSituation/Edit/5
        public ActionResult Edit(int id)
        {
            var model = viverbembd.SalesSituation.Find(id);

            return View("Edit", model);
        }

        // GET: SalesSituation/Delete/5
        public ActionResult Delete(int id)
        {
            var model = viverbembd.SalesSituation.Find(id);
            return View("Delete", model);

        }
        #endregion

        #region Post Methods
        // POST: SalesSituation/Create
        [HttpPost]
        public ActionResult Create(SalesSituation situation)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    // TODO: Add insert logic here
                    viverbembd.SalesSituation.Add(situation);
                    viverbembd.SaveChanges();

                    return RedirectToAction("Index");
                }
                return View();

            }
            catch (Exception ex)
            {
                return View();
            }
        }

        // POST: SalesSituation/Edit/5
        [HttpPost]
        public ActionResult Edit(SalesSituation model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    viverbembd.Entry(model).State = System.Data.Entity.EntityState.Modified;
                    viverbembd.SaveChanges();

                    return RedirectToAction("Index");
                }
                return View();
            }
            catch (Exception ex)
            {
                return View();
            }
        }

        // POST: SalesSituation/Delete/5
        [HttpPost]
        public ActionResult Delete(SalesSituation model)
        {
            try
            {
                // TODO: Add delete logic here
                viverbembd.Entry(model).State = System.Data.Entity.EntityState.Deleted;
                viverbembd.SaveChanges();

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
