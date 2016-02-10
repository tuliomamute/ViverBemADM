using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ViverBemADM.Models;

namespace ViverBemADM.Controllers
{
    public class PaymentFormsController : Controller
    {
        private ViverBemADMContext db = new ViverBemADMContext();

        #region Métodos Get
        // GET: PaymentForms
        public ActionResult Index()
        {
            var model = db.PaymentForm.ToList();
            return View(model);
        }

        // GET: PaymentForms/Edit/5
        public ActionResult Edit(int? id)
        {
            PaymentForm model = db.PaymentForm.Find(id);
            return View(model);
        }

        // GET: PaymentForms/Details/5
        public ActionResult Details(int? id)
        {
            PaymentForm model = db.PaymentForm.Find(id);
            return View(model);
        }

        // GET: PaymentForms/Create
        public ActionResult Create()
        {
            return View();
        }

        // GET: PaymentForms/Delete/5
        public ActionResult Delete(int? id)
        {
            PaymentForm model = db.PaymentForm.Find(id);
            return View(model);
        }

        #endregion

        #region Métodos Post
        // POST: PaymentForms/Create/
        [HttpPost]
        public ActionResult Create(PaymentForm model)
        {
            if (ModelState.IsValid)
            {
                db.PaymentForm.Add(model);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(model);
        }

        // POST: PaymentForms/Edit/5
        [HttpPost]
        public ActionResult Edit(PaymentForm model)
        {
            if (ModelState.IsValid)
            {
                db.Entry(model).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(model);
        }

        // POST: PaymentForms/Delete/5
        [HttpPost]
        public ActionResult Delete(PaymentForm model)
        {
            db.Entry(model).State = System.Data.Entity.EntityState.Deleted;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        #endregion

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
