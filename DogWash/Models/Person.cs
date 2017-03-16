

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace DogWash.Models
{
    public class Person
    {
        [Required]
        [StringLength(50)]
        [Display(Name = "Name")]
        public string Name { get; set; }


        public int ID { get; set; }

        [Required]
        [StringLength(10)]
        [Display(Name = "Phone Number")]
        public string PhoneNumber { get; set; }

        [Required]
        [Display(Name = "Appointment Type")]
        public string AppointmentType { get; set; }

        [Required]
        [Display(Name = "Date")]
        public DateTime Date { get; set; }

       
        [StringLength(500)]
        [Display(Name = "Comments")]
        public string Comments { get; set; }

    }
}