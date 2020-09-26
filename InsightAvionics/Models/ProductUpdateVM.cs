using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace InsightAvionics.Models
{
    public class ProductUpdateVM

    {
        [Key]
        public int ID { get; set; }

        public IList<Update> Updates { get; set; }
        public IList<Product> Products { get; set; }

    }
}