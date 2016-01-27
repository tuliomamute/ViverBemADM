using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ViverBemADM.Models;

namespace ViverBemADM.Controllers
{
    public class ClientController : Controller
    {
        private ViverBemADMContext viverbembd { get; set; }

        public ClientController()
        {
            viverbembd = new ViverBemADMContext();
        }

        #region Métodos Get

        // GET: Client
        public ActionResult Index()
        {
            var model = viverbembd.Client.ToList();
            return View(model);
        }

        // GET: Client/Details/5
        public ActionResult Details(int id)
        {
            var model = viverbembd.Client.Find(id);
            return View(model);
        }

        // GET: Client/Create
        public ActionResult Create()
        {
            return View();
        }

        // GET: Client/Delete/5
        public ActionResult Delete(int id)
        {
            var model = viverbembd.Client.Find(id);
            return View(model);
        }

        // GET: Client/Edit/5
        public ActionResult Edit(int id)
        {
            var model = viverbembd.Client.Find(id);
            return View(model);
        }

        #endregion

        #region Métodos Post

        // POST: Client/Create
        [HttpPost]
        public ActionResult Create(Client model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    viverbembd.Client.Add(model);
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


        // POST: Client/Edit/5
        [HttpPost]
        public ActionResult Edit(Client model)
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

        // POST: Client/Delete/5
        [HttpPost]
        public ActionResult Delete(Client model)
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
