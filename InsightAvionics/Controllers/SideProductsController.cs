using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using InsightAvionics.Models;
using UploadAndDisplayImageInMvc.Repositories;

namespace InsightAvionics.Controllers
{
    public class SideProductsController : Controller
    {
        private InsightAvionicsContext db = new InsightAvionicsContext();

        // GET: SideProducts
        public ActionResult Index()
        {
            return View(db.SideProducts.ToList());
        }

        public ActionResult Short(string shortname)
        {
            SideProduct sp = db.SideProducts.Where(p => p.SideShort == shortname).FirstOrDefault();
            if (sp != null)
            {
                return View("Details", sp);
            }
            else
            {
                return RedirectToAction("Dash", "ProductUpdateVMs");
            }
        }

        // GET: SideProducts/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SideProduct sideProduct = db.SideProducts.Find(id);
            if (sideProduct == null)
            {
                return HttpNotFound();
            }
            return View(sideProduct);
        }

        // GET: SideProducts/Create
        [Authorize]
        public ActionResult Create()
        {
            return View();
        }

        // POST: SideProducts/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [Authorize]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "SideID,SideName,SideShort,SideBody")] SideProduct sideProduct)
        {
            try
            {
                HttpPostedFileBase file = Request.Files["ImageData"];
                ContentRepository service = new ContentRepository();
                sideProduct = service.UploadImageInDataBase(file, sideProduct);
            }
            catch (System.Data.Entity.Validation.DbEntityValidationException dbEx)
            {
                Exception raise = dbEx;
                foreach (var validationErrors in dbEx.EntityValidationErrors)
                {
                    foreach (var validationError in validationErrors.ValidationErrors)
                    {
                        string message = string.Format("{0}:{1}",
                            validationErrors.Entry.Entity.ToString(),
                            validationError.ErrorMessage);
                        // raise a new exception nesting  
                        // the current instance as InnerException  
                        raise = new InvalidOperationException(message, raise);
                    }
                }
                throw raise;
            }
            if (ModelState.IsValid)
            {
                db.SideProducts.Add(sideProduct);
                db.SaveChanges();
                return RedirectToAction("Dash", "ProductUpdateVMs");
            }

            return View(sideProduct);

        }

        // GET: SideProducts/Edit/5
        [Authorize]
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SideProduct sideProduct = db.SideProducts.Find(id);
            if (sideProduct == null)
            {
                return HttpNotFound();
            }
            return View(sideProduct);
        }

        // POST: SideProducts/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [Authorize]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "SideID,SideName,SideShort,SideBody")] SideProduct sideProduct)
        {
            try
            {
                HttpPostedFileBase file = Request.Files["ImageData"];
                ContentRepository service = new ContentRepository();
                sideProduct = service.UploadImageInDataBase(file, sideProduct);
            }
            catch (System.Data.Entity.Validation.DbEntityValidationException dbEx)
            {
                Exception raise = dbEx;
                foreach (var validationErrors in dbEx.EntityValidationErrors)
                {
                    foreach (var validationError in validationErrors.ValidationErrors)
                    {
                        string message = string.Format("{0}:{1}",
                            validationErrors.Entry.Entity.ToString(),
                            validationError.ErrorMessage);
                        // raise a new exception nesting  
                        // the current instance as InnerException  
                        raise = new InvalidOperationException(message, raise);
                    }
                }
                throw raise;
            }

            if (ModelState.IsValid)
            {
                db.Entry(sideProduct).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(sideProduct);
        }

        // GET: SideProducts/Delete/5
        [Authorize]
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SideProduct sideProduct = db.SideProducts.Find(id);
            if (sideProduct == null)
            {
                return HttpNotFound();
            }
            return View(sideProduct);
        }

        // POST: SideProducts/Delete/5
        [Authorize]
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            SideProduct sideProduct = db.SideProducts.Find(id);
            db.SideProducts.Remove(sideProduct);
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
        public ActionResult RetrieveImage(int id)
        {
            byte[] cover = GetImageFromDataBase(id);
            if (cover != null)
            {
                return File(cover, "image/jpg");
            }
            else
            {
                return null;
            }
        }
        public byte[] GetImageFromDataBase(int Id)
        {
            IQueryable<byte[]> q;

            q = from temp in db.SideProducts where temp.SideID == Id select temp.SideImage;

            byte[] cover = q.First();
            return cover;
        }

        [AcceptVerbs(HttpVerbs.Post)]
        public JsonResult UploadFile(HttpPostedFileBase aUploadedFile)
        {
            var vReturnImagePath = string.Empty;
            if (aUploadedFile.ContentLength > 0)
            {
                var vFileName = Path.GetFileNameWithoutExtension(aUploadedFile.FileName);
                var vExtension = Path.GetExtension(aUploadedFile.FileName);

                string sImageName = vFileName + DateTime.Now.ToString("YYYYMMDDHHMMSS");

                var vImageSavePath = Server.MapPath("/UpImages/") + sImageName + vExtension;
                //sImageName = sImageName + vExtension;  
                vReturnImagePath = "/UpImages/" + sImageName + vExtension;
                ViewBag.Msg = vImageSavePath;
                var path = vImageSavePath;

                // Saving Image in Original Mode  
                aUploadedFile.SaveAs(path);
                var vImageLength = new FileInfo(path).Length;
                //here to add Image Path to You Database ,  
                TempData["message"] = string.Format("Image was Added Successfully");
            }
            return Json(Convert.ToString(vReturnImagePath), JsonRequestBehavior.AllowGet);
        }
    }
}
