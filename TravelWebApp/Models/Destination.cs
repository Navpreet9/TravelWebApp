using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TravelWebApp.Models
{
    public class Destination
    {
        [Key]
        public int DestinationID { get; set; }

        [Required]
        [StringLength(200)]
        [Display(Name = "Destination Name")]
        public string DestinationName { get; set; }

        [Required]
        [StringLength(2000)]
        [Display(Name = "About")]
        public string About { get; set; }

        [Required]
        [StringLength(200)]
        [Display(Name = "Country")]
        public string Country { get; set; }

        [Required]
        [StringLength(20)]
        public string Extension { get; set; }

        [NotMapped]
        public PhotoData File { get; set; }


        public virtual ICollection<Flight> SourceFlights { get; set; }

        public virtual ICollection<Flight> DestinationFlights { get; set; }
    }
}
