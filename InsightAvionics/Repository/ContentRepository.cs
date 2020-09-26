using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using InsightAvionics.Models;

namespace UploadAndDisplayImageInMvc.Repositories
{
    public class ContentRepository
    {
        private readonly InsightAvionicsContext db = new InsightAvionicsContext();
        public int UploadImageInDataBase(HttpPostedFileBase file, Product product)
        {
            product.ProdImage = ConvertToBytes(file);
            db.Products.Add(product);
            int i = db.SaveChanges();
            if (i == 1)
            {
                return 1;
            }
            else
            {
                return 0;
            }

        }
        public Update UploadImageInDataBase(HttpPostedFileBase file, Update update)
        {
            update.UpdateImage = ConvertToBytes(file);
            db.Updates.Add(update);
            return update;

        }

        public SideProduct UploadImageInDataBase(HttpPostedFileBase file, SideProduct sp)
        {
            sp.SideImage = ConvertToBytes(file);
            db.SideProducts.Add(sp);
            return sp;

        }

        public Product UploadImageInDataBase(HttpPostedFileBase file, Product product,string type)
        {
            if (type == "ProdSplash")
            {
                product.ProdSplash = ConvertToBytes(file);
            }
            else if (type == "ProdPromo")
            {
                product.ProdPromo = ConvertToBytes(file);
            }
            else
            {
                product.ProdImage = ConvertToBytes(file);
            }

            //db.Products.Add(product);
            //db.SaveChanges();
            return product;

        }

        public byte[] ConvertToBytes(HttpPostedFileBase image)
        {
            byte[] imageBytes = null;
            BinaryReader reader = new BinaryReader(image.InputStream);
            imageBytes = reader.ReadBytes((int)image.ContentLength);
            return imageBytes;
        }
    }
}