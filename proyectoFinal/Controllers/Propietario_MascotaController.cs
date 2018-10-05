using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using proyectoFinal.Models;

namespace proyectoFinal.Controllers
{
    public class Propietario_MascotaController : Controller
    {
        private Modelo db = new Modelo();

        // GET: Propietario_Mascota
        public ActionResult Index()
        {
            return View(db.Propietario_Mascota.ToList());
        }

        // GET: Propietario_Mascota/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Propietario_Mascota propietario_Mascota = db.Propietario_Mascota.Find(id);
            if (propietario_Mascota == null)
            {
                return HttpNotFound();
            }
            return View(propietario_Mascota);
        }

        // GET: Propietario_Mascota/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Propietario_Mascota/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "codpropietario,nombre,apellido,dui,sexo,direccion,telefono")] Propietario_Mascota propietario_Mascota)
        {
            if (ModelState.IsValid)
            {
                db.Propietario_Mascota.Add(propietario_Mascota);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(propietario_Mascota);
        }

        // GET: Propietario_Mascota/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Propietario_Mascota propietario_Mascota = db.Propietario_Mascota.Find(id);
            if (propietario_Mascota == null)
            {
                return HttpNotFound();
            }
            return View(propietario_Mascota);
        }

        // POST: Propietario_Mascota/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "codpropietario,nombre,apellido,dui,sexo,direccion,telefono")] Propietario_Mascota propietario_Mascota)
        {
            if (ModelState.IsValid)
            {
                db.Entry(propietario_Mascota).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(propietario_Mascota);
        }

        // GET: Propietario_Mascota/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Propietario_Mascota propietario_Mascota = db.Propietario_Mascota.Find(id);
            if (propietario_Mascota == null)
            {
                return HttpNotFound();
            }
            return View(propietario_Mascota);
        }

        // POST: Propietario_Mascota/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Propietario_Mascota propietario_Mascota = db.Propietario_Mascota.Find(id);

            try
            {
                db.Propietario_Mascota.Remove(propietario_Mascota);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            catch (Exception)
            {
                //ViewBag.error = "No se Puede Eliminar";
                //return RedirectToAction("Delete", propietario_Mascota );
                return RedirectToAction("Delete", new { id = id, error = "Este Registro No se Puede Eliminar" });
            }
            
        }

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
