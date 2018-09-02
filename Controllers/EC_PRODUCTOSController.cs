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
    public class EC_PRODUCTOSController : Controller
    {
        private DB_PROYECTO_WEBEntities db = new DB_PROYECTO_WEBEntities();

        // GET: EC_PRODUCTOS
        public ActionResult Index()
        {
            return View(db.EC_PRODUCTOS.ToList());
        }

        // GET: EC_PRODUCTOS/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EC_PRODUCTOS eC_PRODUCTOS = db.EC_PRODUCTOS.Find(id);
            if (eC_PRODUCTOS == null)
            {
                return HttpNotFound();
            }
            return View(eC_PRODUCTOS);
        }

        // GET: EC_PRODUCTOS/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: EC_PRODUCTOS/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "EC_PRODUCTO_ID,EC_PRODUCTO_NOMBRE,EC_PRODUCTO_MARCA,EC_PRODUCTO_URL_IMAGEN,EC_PRODUCTO_DESCRIPCION,EC_PRODUCTO_PRECIO")] EC_PRODUCTOS eC_PRODUCTOS)
        {
            if (ModelState.IsValid)
            {
                db.EC_PRODUCTOS.Add(eC_PRODUCTOS);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(eC_PRODUCTOS);
        }

        // GET: EC_PRODUCTOS/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EC_PRODUCTOS eC_PRODUCTOS = db.EC_PRODUCTOS.Find(id);
            if (eC_PRODUCTOS == null)
            {
                return HttpNotFound();
            }
            return View(eC_PRODUCTOS);
        }

        // POST: EC_PRODUCTOS/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "EC_PRODUCTO_ID,EC_PRODUCTO_NOMBRE,EC_PRODUCTO_MARCA,EC_PRODUCTO_URL_IMAGEN,EC_PRODUCTO_DESCRIPCION,EC_PRODUCTO_PRECIO")] EC_PRODUCTOS eC_PRODUCTOS)
        {
            if (ModelState.IsValid)
            {
                db.Entry(eC_PRODUCTOS).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(eC_PRODUCTOS);
        }

        // GET: EC_PRODUCTOS/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EC_PRODUCTOS eC_PRODUCTOS = db.EC_PRODUCTOS.Find(id);
            if (eC_PRODUCTOS == null)
            {
                return HttpNotFound();
            }
            return View(eC_PRODUCTOS);
        }

        // POST: EC_PRODUCTOS/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            EC_PRODUCTOS eC_PRODUCTOS = db.EC_PRODUCTOS.Find(id);
            db.EC_PRODUCTOS.Remove(eC_PRODUCTOS);
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
