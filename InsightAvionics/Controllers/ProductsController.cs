using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Web;
using System.Web.Hosting;
using System.Web.Mvc;
using InsightAvionics.Models;
using InsightAvionics.Repository;
using UploadAndDisplayImageInMvc.Repositories;

namespace InsightAvionics.Controllers
{
    public class ProductsController : Controller
    {
        private InsightAvionicsContext db = new InsightAvionicsContext();

        // GET: Products
        public ActionResult Index()
        {
            return View(db.Products.ToList());
        }

        public ActionResult Short(string shortname)
        {
            Product product = db.Products.Where(p => p.ProdShort == shortname).FirstOrDefault();
            if(product != null)
            {
                ViewBag.body = product.ProdBody;
                return View("Details",product);
            }
            else
            {
                return RedirectToAction("Dash","ProductUpdateVMs");
            }
        }

        // GET: Products/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Product product = db.Products.Find(id);
            if (product == null)
            {
                return HttpNotFound();
            }
            return View(product);
        }

        [Authorize]
        // GET: Products/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Products/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [Authorize]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ProdID,ProdBody,ProdName,ProdDesc,ProdShort")] Product product)
        {
            try
            {
                HttpPostedFileBase file = Request.Files["ImageData"];
                ContentRepository service = new ContentRepository();
                product = service.UploadImageInDataBase(file, product, "");
            }
            catch(System.Data.Entity.Validation.DbEntityValidationException dbEx)
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
            try
            {
                HttpPostedFileBase file = Request.Files["ImageDataSplash"];
                ContentRepository service = new ContentRepository();
                product = service.UploadImageInDataBase(file, product, "ProdSplash");
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
            try
            {
                HttpPostedFileBase file = Request.Files["ImageDataPromo"];
                ContentRepository service = new ContentRepository();
                product = service.UploadImageInDataBase(file, product, "ProdPromo");

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

            UploadImage(product.ProdBody);


            List<Product> p = new List<Product> {product}; 
            var x = new ProductUpdateVM() { Products =  p};
            x.Products.Add(product);

            db.ProductUpdateVMs.Add(x);
            try
            {
                db.SaveChanges();
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
                return RedirectToAction("Index","ProductUpdateVMs");
            //return View(product);
        }

        [Authorize]
        // GET: Products/Edit/5
        public ActionResult Edit(int? id)
        {

            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Product product = db.Products.Find(id);
            if (product == null)
            {
                return HttpNotFound();
            }
            return View(product);
        }

        // POST: Products/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [Authorize]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ProdID,ProdName,ProdBody,ProdShort,ProdImage,ProdDesc")] Product product)
        {

            ContentRepository service = new ContentRepository();


            HttpPostedFileBase file1 = Request.Files["ImageData"];
            if (file1.ContentLength != 0)
            {
                try
                {

                    product = service.UploadImageInDataBase(file1, product, "");
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
            }
            
            HttpPostedFileBase file2 = Request.Files["ImageDataSplash"];
            if (file2.ContentLength != 0)
            {
                try
                {
                    product = service.UploadImageInDataBase(file2, product, "ProdSplash");
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
            }

            HttpPostedFileBase file3 = Request.Files["ImageDataPromo"];
            
            if (file3.ContentLength != 0)
            {
                try
                {
                    product = service.UploadImageInDataBase(file3, product, "ProdPromo");

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
            }

            if (ModelState.IsValid)
            {
                db.Entry(product).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index", "ProductUpdateVMs");
            }
            return View(product);
        }

        [Authorize]
        // GET: Products/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Product product = db.Products.Find(id);
            if (product == null)
            {
                return HttpNotFound();
            }
            return View(product);
        }

        // POST: Products/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Product product = db.Products.Find(id);
            db.Products.Remove(product);
            db.SaveChanges();
            return RedirectToAction("Dash", "ProductUpdateVMs");
        }


        /// <summary>
        /// Retrive Image from database 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        //public ActionResult RetrieveImage(int id)
        //{
        //    byte[] cover = GetImageFromDataBase(id);
        //    if (cover != null)
        //    {
        //        return File(cover, "image/jpg");
        //    }
        //    else
        //    {
        //        return null;
        //    }
        //}
        public ActionResult RetrieveImage(int id, string type)
        {
            byte[] cover = GetImageFromDataBase(id,type);
            if (cover != null)
            {
                return File(cover, "image/jpg");
            }
            else
            {
                return null;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        //public byte[] GetImageFromDataBase(int Id)
        //{
        //    var q = from temp in db.Products where temp.ProdID == Id select temp.ProdImage;
        //    byte[] cover = q.First();
        //    return cover;
        //}
        public byte[] GetImageFromDataBase(int Id, string type)
        {
            IQueryable<byte[]> q;

            if (type == "ProdSplash")
            {
                q = from temp in db.Products where temp.ProdID == Id select temp.ProdSplash;
            }
            else if (type == "ProdPromo")
            {
                q = from temp in db.Products where temp.ProdID == Id select temp.ProdPromo;
            }
            else
            {
                q = from temp in db.Products where temp.ProdID == Id select temp.ProdImage;
            }


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


        /// <summary>
        /// NOT IMPLEMENTED
        /// </summary>
        /// <param name="file"></param>
        /// <returns></returns>

        [HttpPost]
        public JsonResult UploadImage(HttpPostedFileBase file)
        {
            var uploadsPath = HostingEnvironment.MapPath($"/uploads");
            var uploadsDir = new DirectoryInfo(uploadsPath);
            if (!uploadsDir.Exists)
                uploadsDir.Create();

            var imageRelativePath = $"/uploads/{DateTime.Now:yyyy-MM-dd_HH-mm-ss}.jpg";
            var imageAbsPath = HostingEnvironment.MapPath(imageRelativePath);
            var imageBytes = file.InputStream.ReadToEnd();
            System.IO.File.WriteAllBytes(imageAbsPath, imageBytes);
            return Json(new { location = imageRelativePath });
        }
        public JsonResult UploadImage(string file)
        {
            var uploadsPath = HostingEnvironment.MapPath($"/uploads");
            var uploadsDir = new DirectoryInfo(uploadsPath);
            if (!uploadsDir.Exists)
                uploadsDir.Create();

            var imageRelativePath = $"/uploads/{DateTime.Now:yyyy-MM-dd_HH-mm-ss}.jpg";
            var imageAbsPath = HostingEnvironment.MapPath(imageRelativePath);
            //var imageBytes = file/*.InputStream.ReadToEnd();*/;
            byte[] imageBytes = Encoding.ASCII.GetBytes(file);
            System.IO.File.WriteAllBytes(imageAbsPath, imageBytes);
            return Json(new { location = imageRelativePath });
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
