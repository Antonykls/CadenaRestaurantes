using CadenaRestaurantes.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CadenaRestaurantes.Controllers
{
    public class DetalleOrdenesController : Controller
    {
        // GET: DetalleOrdenes
        public ActionResult Index()
        {
            using (DbModels context = new DbModels())
            {
                return View(context.DetalleOrdenes.ToList());
            }
        }

        // GET: DetalleOrdenes/Details/5
        public ActionResult Details(int id)
        {
            using (DbModels context = new DbModels())
            {
                return View(context.DetalleOrdenes.Where(x => x.DetalleID == id).FirstOrDefault());
            }
        }

        // GET: DetalleOrdenes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: DetalleOrdenes/Create
        [HttpPost]
        public ActionResult Create(DetalleOrdenes detalleordenes)
        {
            try
            {
                using (DbModels context = new DbModels())
                {
                    context.DetalleOrdenes.Add(detalleordenes);
                    context.SaveChanges();
                }
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: DetalleOrdenes/Edit/5
        public ActionResult Edit(int id)
        {
            using (DbModels context = new DbModels())
            {
                return View(context.DetalleOrdenes.Where(x => x.DetalleID == id).FirstOrDefault());
            }
        }

        // POST: DetalleOrdenes/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, DetalleOrdenes detalleordenes)
        {
            try
            {
                using (DbModels context = new DbModels())
                {
                    context.Entry(detalleordenes).State = EntityState.Modified;
                    context.SaveChanges();
                }

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: DetalleOrdenes/Delete/5
        public ActionResult Delete(int id)
        {
            using (DbModels context = new DbModels())
            {
                return View(context.DetalleOrdenes.Where(x => x.DetalleID == id).FirstOrDefault());
            }
        }

        // POST: DetalleOrdenes/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                using (DbModels context = new DbModels())
                {
                    DetalleOrdenes detalleordenes = context.DetalleOrdenes.Where(x => x.DetalleID == id).FirstOrDefault();
                    context.DetalleOrdenes.Remove(detalleordenes);
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
