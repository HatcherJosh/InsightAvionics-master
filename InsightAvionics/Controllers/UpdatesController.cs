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
    public class UpdatesController : Controller
    {
        private InsightAvionicsContext db = new InsightAvionicsContext();

        // GET: Updates
        public ActionResult Index()
        {
            return View(db.Updates.ToList());
        }

        // GET: Updates/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Update update = db.Updates.Find(id);
            if (update == null)
            {
                return HttpNotFound();
            }
            return View(update);
        }

        // GET: Updates/Create-
        [Authorize]
        public ActionResult Create()
        {
            return View();
        }

        // POST: Updates/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [Authorize]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "UpdateID,UpdateName,UpdateBody,UpdateHeading")] Update update)
        {
            update.posted = DateTime.Now;
            try
            {
                HttpPostedFileBase file = Request.Files["ImageData"];
                ContentRepository service = new ContentRepository();
                update = service.UploadImageInDataBase(file, update);
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
                List<Update> p = new List<Update> { update };
                var x = new ProductUpdateVM() { Updates = p };
                x.Updates.Add(update);

                db.ProductUpdateVMs.Add(x);
                db.SaveChanges();
                return RedirectToAction("Dash", "ProductUpdateVMs");
            }

            return View(update);
        }

        // GET: Updates/Edit/5
        [Authorize]
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Update update = db.Updates.Find(id);
            if (update == null)
            {
                return HttpNotFound();
            }
            return View(update);
        }

        // POST: Updates/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [Authorize]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "UpdateID,UpdateName,UpdateBody,UpdateHeading")] Update update)
        {
            update.posted = DateTime.Now;
            try
            {
                HttpPostedFileBase file = Request.Files["ImageData"];
                ContentRepository service = new ContentRepository();
                update = service.UploadImageInDataBase(file, update);
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
                db.Entry(update).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Dash", "ProductUpdateVMs");
            }
            return View(update);
        }

        // GET: Updates/Delete/5
        [Authorize]
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Update update = db.Updates.Find(id);
            if (update == null)
            {
                return HttpNotFound();
            }
            return View(update);
        }

        // POST: Updates/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        [Authorize]
        public ActionResult DeleteConfirmed(int id)
        {
            Update update = db.Updates.Find(id);
            db.Updates.Remove(update);
            db.SaveChanges();
            return RedirectToAction("Dash", "ProductUpdateVMs");
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

            q = from temp in db.Updates where temp.UpdateID == Id select temp.UpdateImage;

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
