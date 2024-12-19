using CadenaRestaurantes.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CadenaRestaurantes.Controllers
{
    public class ClientesController : Controller
    {
        // GET: Clientes
        public ActionResult Index()
        {
            using (DbModels context = new DbModels())
            {
                return View(context.Clientes.ToList());
            }
        }

        // GET: Clientes/Details/5
        public ActionResult Details(int id)
        {
            using (DbModels context = new DbModels())
            {
                return View(context.Clientes.Where(x => x.ClienteID == id).FirstOrDefault());
            }
        }

        // GET: Clientes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Clientes/Create
        [HttpPost]
        public ActionResult Create(Clientes clientes)
        {
            try
            {
                using (DbModels context = new DbModels())
                {
                    context.Clientes.Add(clientes);
                    context.SaveChanges();
                }
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Clientes/Edit/5
        public ActionResult Edit(int id)
        {
            using (DbModels context = new DbModels())
            {
                return View(context.Clientes.Where(x => x.ClienteID == id).FirstOrDefault());
            }
        }

        // POST: Clientes/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Clientes clientes)
        {
            try
            {
                using (DbModels context = new DbModels())
                {
                    context.Entry(clientes).State = EntityState.Modified;
                    context.SaveChanges();
                }

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Clientes/Delete/5
        public ActionResult Delete(int id)
        {
            using (DbModels context = new DbModels())
            {
                return View(context.Clientes.Where(x => x.ClienteID == id).FirstOrDefault());
            }
        }

        // POST: Clientes/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                using (DbModels context = new DbModels())
                {
                    Clientes clientes = context.Clientes.Where(x => x.ClienteID == id).FirstOrDefault();
                    context.Clientes.Remove(clientes);
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
