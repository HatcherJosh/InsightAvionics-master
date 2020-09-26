using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace InsightAvionics.Models
{
    public class SideProduct

    {

        //ID of the product
        [Key]
        public int SideID { get; set; }

        //The name that the user will see
        [Required]
        [Display(Name = "Product Name")]
        public string SideName { get; set; }

        //Shorter name used in various places around the site
        [Required]
        [Display(Name = "Shorthand Name")]
        // TODO: FIX REGEX
        //[RegularExpression(@"[-0-9a-zA-Z _]",ErrorMessage="Please only use alphanumeric characters, dash, and underscore.")]
        public string SideShort { get; set; }

        //Main Product Image
        [Display(Name = "Product Image")]
        public byte[] SideImage { get; set; }

        //The main text of the article for the project, displayed as raw HTML
        //[UIHint("tinymce_jquery_full")]
        [AllowHtml]
        [Display(Name = "Body")]
        public string SideBody { get; set; }

    }
}