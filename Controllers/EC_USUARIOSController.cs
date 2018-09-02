using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using EC_Ventas_Respuestos.Models;

namespace EC_Ventas_Respuestos.Controllers
{
    public class EC_USUARIOSController : Controller
    {
        private DB_PROYECTO_WEBEntities db = new DB_PROYECTO_WEBEntities();

        // GET: EC_USUARIOS
        public ActionResult Index()
        {
            return View(db.EC_USUARIOS.ToList());
        }

        // GET: EC_USUARIOS/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EC_USUARIOS eC_USUARIOS = db.EC_USUARIOS.Find(id);
            if (eC_USUARIOS == null)
            {
                return HttpNotFound();
            }
            return View(eC_USUARIOS);
        }

        // GET: EC_USUARIOS/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: EC_USUARIOS/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "EC_USUARIOS_ID,EC_USUARIOS_CEDULA,EC_USUARIOS_NOMBRE,EC_USUARIOS_APE1,EC_USUARIOS_APE2,EC_USUARIOS_TELEFONO,EC_USUARIOS_EMAIL,EC_USUARIOS_ESTADO,EC_USUARIOS_CONTRASENNA")] EC_USUARIOS eC_USUARIOS)
        {
            if (ModelState.IsValid)
            {
                db.EC_USUARIOS.Add(eC_USUARIOS);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(eC_USUARIOS);
        }

        // GET: EC_USUARIOS/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EC_USUARIOS eC_USUARIOS = db.EC_USUARIOS.Find(id);
            if (eC_USUARIOS == null)
            {
                return HttpNotFound();
            }
            return View(eC_USUARIOS);
        }

        // POST: EC_USUARIOS/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "EC_USUARIOS_ID,EC_USUARIOS_CEDULA,EC_USUARIOS_NOMBRE,EC_USUARIOS_APE1,EC_USUARIOS_APE2,EC_USUARIOS_TELEFONO,EC_USUARIOS_EMAIL,EC_USUARIOS_ESTADO,EC_USUARIOS_CONTRASENNA")] EC_USUARIOS eC_USUARIOS)
        {
            if (ModelState.IsValid)
            {
                db.Entry(eC_USUARIOS).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(eC_USUARIOS);
        }

        // GET: EC_USUARIOS/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EC_USUARIOS eC_USUARIOS = db.EC_USUARIOS.Find(id);
            if (eC_USUARIOS == null)
            {
                return HttpNotFound();
            }
            return View(eC_USUARIOS);
        }

        // POST: EC_USUARIOS/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            EC_USUARIOS eC_USUARIOS = db.EC_USUARIOS.Find(id);
            db.EC_USUARIOS.Remove(eC_USUARIOS);
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
