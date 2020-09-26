using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace InsightAvionics.Models
{
    public class Update
    {
        [Key]
        public int UpdateID { get; set; }

        [Required]
        [Display(Name = "Title")]
        public string UpdateName { get; set; }

        [Required]
        [Display(Name = "Subheading")]
        public string UpdateHeading { get; set; }

        [Display(Name = "Image URL")]
        public byte[] UpdateImage { get; set; }

        [Required]
        [Display(Name = "Body")]
        [MinLength(500,ErrorMessage ="Minimum length of 500 Characters")]
        [AllowHtml]
        public string UpdateBody { get; set; }

        [Display(Name ="Date")]
        public DateTime posted { get; set; }

        [NotMapped]
        public string UpdateBlurb
        {
            get
            {
                return UpdateBody.Substring(0, 446) + "...";
            }
        }
    }
}