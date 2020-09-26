using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace InsightAvionics.Models
{
    public class Product
    {

        //ID of the product
        [Key]
        public int ProdID { get; set; }

        //The name that the user will see
        [Required]
        [Display(Name = "Product Name")]
        public string ProdName { get; set; }

        //Shorter name used in various places around the site
        [Required]
        [Display(Name = "Shorthand Name")]
       // TODO: FIX REGEX
        //[RegularExpression(@"[-0-9a-zA-Z _]",ErrorMessage="Please only use alphanumeric characters, dash, and underscore.")]
        public string ProdShort { get; set; }

        //Main Product Image
        [Display(Name ="Product Image")]
        public byte[] ProdImage { get; set; }

        //The main text of the article for the project, displayed as raw HTML
        //[UIHint("tinymce_jquery_full")]
        [AllowHtml]
        [Display(Name = "Body")]
        public string ProdBody { get; set; }

        //Specs of the product, displayed delineated by dot
        [Required]
        [Display(Name = "Product Description")]
        [MaxLength(500, ErrorMessage = "Maximum length of 500 Characters")]
        public string ProdDesc { get; set; }
        
        //testing
        [DisplayName("Splash Image")]
        public byte[] ProdSplash { get; set; }

        [DisplayName("Promo Image")]
        public byte[] ProdPromo { get; set; }



        [NotMapped]
        public string[] ProdBlurb { get
            {
                try
                {
                    return ProdDesc.Split('•');

                }
                catch
                {
                    return null;
                }
               
            } 
        }

    }

}