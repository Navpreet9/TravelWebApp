using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TravelWebApp.Models
{
    public class Flight
    {
        [Key]
        public int FlightID { get; set; }


        [Required]
        [StringLength(200)]
        [Display(Name = "Airline Name")]
        public string Airline { get; set; }

        [Required]
        [StringLength(200)]
        [Display(Name = "Seat Type")]
        public string Type { get; set; }

        [Required]
        [Display(Name = "Price")]
        public int Price { get; set; }

        [Required]
        [Display(Name = "Source")]
        public int SourceID { get; set; }

        [Required]
        [Display(Name = "Destination")]
        public int DestinationID { get; set; }

        [ForeignKey("SourceID")]
        [InverseProperty("SourceFlights")]
        public virtual Destination Source { get; set; }

        [ForeignKey("DestinationID")]
        [InverseProperty("DestinationFlights")]
        public virtual Destination Destination { get; set; }


    }
}
