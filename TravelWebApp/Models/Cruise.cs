using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TravelWebApp.Models
{
    public class Cruise
    {
        [Key]
        public int CruiseID { get; set; }

        [Required]
        [StringLength(200)]
        [Display(Name = "Cruise Line")]
        public string CruiseLine { get; set; }

        [Required]
        [StringLength(200)]
        [Display(Name = "Destination Name")]
        public string DestinationName { get; set; }

        [Required]
        [StringLength(200)]
        [Display(Name = "Destination Description")]
        public string Description { get; set; }

        [Required]
        [Display(Name = "Price")]
        public int Price { get; set; }

    }
}
