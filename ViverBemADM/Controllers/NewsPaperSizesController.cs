using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ViverBemADM.Models;

namespace ViverBemADM.Controllers
{
    public class NewsPaperSizesController : Controller
    {
        private ViverBemADMContext viverbembd { get; set; }

        public NewsPaperSizesController()
        {
            viverbembd = new ViverBemADMContext();
        }

        #region Get Methods

        // GET: NewsPaperSizes
        public ActionResult Index()
        {
            var model = viverbembd.NewsPaperSizes.ToList();
            return View(model);
        }

        // GET: NewsPaperSizes/Details/5
        public ActionResult Details(int id)
        {
            var model = viverbembd.NewsPaperSizes.Find(id);
            return View(model);
        }

        // GET: NewsPaperSizes/Create
        public ActionResult Create()
        {
            return View();
        }

        // GET: NewsPaperSizes/Edit/5
        public ActionResult Edit(int id)
        {
            var model = viverbembd.NewsPaperSizes.Find(id);

            return View("Edit", model);
        }

        // GET: NewsPaperSizes/Delete/5
        public ActionResult Delete(int id)
        {
            var model = viverbembd.NewsPaperSizes.Find(id);
            return View("Delete", model);

        }
        #endregion

        #region Post Methods
        // POST: NewsPaperSizes/Create
        [HttpPost]
        public ActionResult Create(NewsPaperSizes newspapersizes)
        {
            try
            {
                // TODO: Add insert logic here
                viverbembd.NewsPaperSizes.Add(newspapersizes);
                viverbembd.SaveChanges();

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // POST: NewsPaperSizes/Edit/5
        [HttpPost]
        public ActionResult Edit(NewsPaperSizes model)
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

        // POST: NewsPaperSizes/Delete/5
        [HttpPost]
        public ActionResult Delete(NewsPaperSizes model)
        {
            try
            {
                // TODO: Add delete logic here

                viverbembd.NewsPaperSizes.Remove(model);
                viverbembd.SaveChanges();

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        #endregion
    }
}
