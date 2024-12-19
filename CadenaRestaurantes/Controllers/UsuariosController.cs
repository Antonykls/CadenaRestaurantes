using CadenaRestaurantes.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CadenaRestaurantes.Controllers
{
    public class UsuariosController : Controller
    {
        // GET: Usuarios
        public ActionResult Index()
        {
            using (DbModels context = new DbModels())
            {
                return View(context.Usuarios.ToList());
            }
        }

        // GET: Usuarios/Details/5
        public ActionResult Details(int id)
        {
            using (DbModels context = new DbModels())
            {
                return View(context.Usuarios.Where(x => x.MeseroID == id).FirstOrDefault());
            }
        }

        // GET: Usuarios/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Usuarios/Create
        [HttpPost]
        public ActionResult Create(Usuarios usuarios)
        {
            try
            {
                using (DbModels context = new DbModels())
                {
                    context.Usuarios.Add(usuarios);
                    context.SaveChanges();
                }
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Usuarios/Edit/5
        public ActionResult Edit(int id)
        {
            using (DbModels context = new DbModels())
            {
                return View(context.Usuarios.Where(x => x.MeseroID == id).FirstOrDefault());
            }
        }

        // POST: Usuarios/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Usuarios usuarios)
        {
            try
            {
                using (DbModels context = new DbModels())
                {
                    context.Entry(usuarios).State = EntityState.Modified;
                    context.SaveChanges();
                }

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Usuarios/Delete/5
        public ActionResult Delete(int id)
        {
            using (DbModels context = new DbModels())
            {
                return View(context.Usuarios.Where(x => x.MeseroID == id).FirstOrDefault());
            }
        }

        // POST: Usuarios/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                using (DbModels context = new DbModels())
                {
                    Usuarios usuarios = context.Usuarios.Where(x => x.MeseroID == id).FirstOrDefault();
                    context.Usuarios.Remove(usuarios);
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
