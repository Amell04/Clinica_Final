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
    public class recetaDetallesController : Controller
    {
         private Modelo db = new Modelo();

        // GET: recetaDetalles
        public ActionResult Index()
        {
            var recetaDetalle = db.recetaDetalle.Include(r => r.consulta).Include(r => r.Medicamento);
            return View(recetaDetalle.ToList());
        }

        // GET: recetaDetalles/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            recetaDetalle recetaDetalle = db.recetaDetalle.Find(id);
            if (recetaDetalle == null)
            {
                return HttpNotFound();
            }
            return View(recetaDetalle);
        }

        // GET: recetaDetalles/Create
        public ActionResult Create()
        {
            ViewBag.idConsulta = new SelectList(db.consulta, "codconsulta", "diagnostico");
            ViewBag.idMed = new SelectList(db.Medicamento, "idMed", "Medicamento1");
            return View();
        }

        // POST: recetaDetalles/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "idreceta,idMed,idConsulta,dosis,cantidad")] recetaDetalle recetaDetalle)
        {
            if (ModelState.IsValid)
            {
                db.recetaDetalle.Add(recetaDetalle);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.idConsulta = new SelectList(db.consulta, "codconsulta", "diagnostico", recetaDetalle.idConsulta);
            ViewBag.idMed = new SelectList(db.Medicamento, "idMed", "Medicamento1", recetaDetalle.idMed);
            return View(recetaDetalle);
        }

        // GET: recetaDetalles/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            recetaDetalle recetaDetalle = db.recetaDetalle.Find(id);
            if (recetaDetalle == null)
            {
                return HttpNotFound();
            }
            ViewBag.idConsulta = new SelectList(db.consulta, "codconsulta", "diagnostico", recetaDetalle.idConsulta);
            ViewBag.idMed = new SelectList(db.Medicamento, "idMed", "Medicamento1", recetaDetalle.idMed);
            return View(recetaDetalle);
        }

        // POST: recetaDetalles/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "idreceta,idMed,idConsulta,dosis,cantidad")] recetaDetalle recetaDetalle)
        {
            if (ModelState.IsValid)
            {
                db.Entry(recetaDetalle).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.idConsulta = new SelectList(db.consulta, "codconsulta", "diagnostico", recetaDetalle.idConsulta);
            ViewBag.idMed = new SelectList(db.Medicamento, "idMed", "Medicamento1", recetaDetalle.idMed);
            return View(recetaDetalle);
        }

        // GET: recetaDetalles/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            recetaDetalle recetaDetalle = db.recetaDetalle.Find(id);
            if (recetaDetalle == null)
            {
                return HttpNotFound();
            }
            return View(recetaDetalle);
        }

        // POST: recetaDetalles/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            recetaDetalle recetaDetalle = db.recetaDetalle.Find(id);
            db.recetaDetalle.Remove(recetaDetalle);
            db.SaveChanges();
            return RedirectToAction("Index");
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
