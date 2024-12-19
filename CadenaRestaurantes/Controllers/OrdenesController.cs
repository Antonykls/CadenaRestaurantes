using CadenaRestaurantes.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CadenaRestaurantes.Controllers
{
    public class OrdenesController : Controller
    {
        // GET: Ordenes
        public ActionResult Index()
        {
            using (DbModels context = new DbModels())
            {
                return View(context.Ordenes.ToList());
            }
        }

        // GET: Ordenes/Details/5
        public ActionResult Details(int id)
        {
            using (DbModels context = new DbModels())
            {
                return View(context.Ordenes.Where(x => x.OrdenID == id).FirstOrDefault());
            }
        }

        // GET: Ordenes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Ordenes/Create
        [HttpPost]
        public ActionResult Create(Ordenes ordenes)
        {
            try
            {
                using (DbModels context = new DbModels())
                {
                    context.Ordenes.Add(ordenes);
                    context.SaveChanges();
                }
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Ordenes/Edit/5
        public ActionResult Edit(int id)
        {
            using (DbModels context = new DbModels())
            {
                return View(context.Ordenes.Where(x => x.OrdenID == id).FirstOrDefault());
            }
        }

        // POST: Ordenes/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Ordenes ordenes)
        {
            try
            {
                using (DbModels context = new DbModels())
                {
                    context.Entry(ordenes).State = EntityState.Modified;
                    context.SaveChanges();
                }

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Ordenes/Delete/5
        public ActionResult Delete(int id)
        {
            using (DbModels context = new DbModels())
            {
                return View(context.Ordenes.Where(x => x.OrdenID == id).FirstOrDefault());
            }
        }

        // POST: Ordenes/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                using (DbModels context = new DbModels())
                {
                    Ordenes ordenes = context.Ordenes.Where(x => x.OrdenID == id).FirstOrDefault();
                    context.Ordenes.Remove(ordenes);
                    context.SaveChanges();
                }

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
