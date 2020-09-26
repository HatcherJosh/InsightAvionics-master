using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using InsightAvionics.Models;

namespace InsightAvionics.Controllers
{
    public class ProductUpdateVMsController : Controller
    {
        private InsightAvionicsContext db = new InsightAvionicsContext();

        // GET: ProductUpdateVMs
        public ActionResult Index()
        {
            return View(db.ProductUpdateVMs.Include(p=>p.Products).Include(u=>u.Updates).ToList());
        }

        // GET: ProductUpdateVMs/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ProductUpdateVM productUpdateVM = db.ProductUpdateVMs.Find(id);
            if (productUpdateVM == null)
            {
                return HttpNotFound();
            }
            return View(productUpdateVM);
        }

        // GET: ProductUpdateVMs/Dash
        [Authorize]
        public ActionResult Dash()
        {

            ViewBag.Side = db.SideProducts.ToList();
            return View(db.ProductUpdateVMs.Include(p => p.Products).Include(u => u.Updates).ToList());

        }

        // GET: ProductUpdateVMs/Create
        [Authorize]
        public ActionResult Create()
        {
            return View();
        }

        // POST: ProductUpdateVMs/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [Authorize]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID")] ProductUpdateVM productUpdateVM)
        {
            if (ModelState.IsValid)
            {
                db.ProductUpdateVMs.Add(productUpdateVM);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(productUpdateVM);
        }

        // GET: ProductUpdateVMs/Edit/5
        [Authorize]
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ProductUpdateVM productUpdateVM = db.ProductUpdateVMs.Find(id);
            if (productUpdateVM == null)
            {
                return HttpNotFound();
            }
            return View(productUpdateVM);
        }

        // POST: ProductUpdateVMs/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize]
        public ActionResult Edit([Bind(Include = "ID")] ProductUpdateVM productUpdateVM)
        {
            if (ModelState.IsValid)
            {
                db.Entry(productUpdateVM).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(productUpdateVM);
        }

        // GET: ProductUpdateVMs/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ProductUpdateVM productUpdateVM = db.ProductUpdateVMs.Find(id);
            if (productUpdateVM == null)
            {
                return HttpNotFound();
            }
            return View(productUpdateVM);
        }

        // POST: ProductUpdateVMs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        [Authorize]
        public ActionResult DeleteConfirmed(int id)
        {
            ProductUpdateVM productUpdateVM = db.ProductUpdateVMs.Find(id);
            db.ProductUpdateVMs.Remove(productUpdateVM);
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
