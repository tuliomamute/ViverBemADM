using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ViverBemADM.Models;

namespace ViverBemADM.Controllers
{
    public class SalesController : Controller
    {
        private ViverBemADMContext viverbembd { get; set; }

        public SalesController()
        {
            viverbembd = new ViverBemADMContext();
        }

        #region Métodos Get

        // GET: Sales
        public ActionResult Index()
        {
            var model = viverbembd.Sales.ToList();
            return View(model);
        }

        // GET: Sales/Details/5
        public ActionResult Details(int id)
        {
            var model = viverbembd.Sales.Find(id);
            return View(model);
        }

        // GET: Sales/Create
        public ActionResult Create()
        {
            return View();
        }

        // GET: Sales/Delete/5
        public ActionResult Delete(int id)
        {
            var model = viverbembd.Sales.Find(id);
            return View(model);
        }

        // GET: Sales/Edit/5
        public ActionResult Edit(int id)
        {
            var model = viverbembd.Sales.Find(id);
            return View(model);
        }

        #endregion

        #region Métodos Post

        // POST: Sales/Create
        [HttpPost]
        public ActionResult Create(Sales model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    viverbembd.Sales.Add(model);
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


        // POST: Sales/Edit/5
        [HttpPost]
        public ActionResult Edit(Sales model)
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

        // POST: Sales/Delete/5
        [HttpPost]
        public ActionResult Delete(Sales model)
        {
            try
            {
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
