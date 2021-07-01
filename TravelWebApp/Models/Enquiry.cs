using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TravelWebApp.Models
{
    public class Enquiry
    {
        [Key]
        public int EnquiryID { get; set; }

        [Required]
        [Display(Name = "User ID")]
        public string UserID { get; set; }

        [Display(Name = "Enquiry Date")]
        public DateTime EnquiryDate { get; set; }

        [StringLength(200)]
        [Display(Name = "About")]
        public string About { get; set; }

        [Required]
        [StringLength(20)]
        [Display(Name = "Phone No")]
        public string Phone { get; set; }

        [Required]
        [StringLength(200)]
        [Display(Name = "Person Name")]
        public string Name { get; set; }
    }
}
