using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LAB3_B.Models
{
    public class Patient
    {
        public Patient() 
        {
            doctors = new List<Doctor>();
        }
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "The patient's name is required")]
        public string Name { get; set; }
        [RegularExpression(@"^[0-9]{5}$", ErrorMessage =
            "The code must be 5 digits")]
        [DisplayName("Код на пациентот")]
        public int PatientCode { get; set; }

        public string Address { get; set;}

        public string Phone { get; set;}

        public string Gender { get; set;}

        public virtual List<Doctor> doctors { get; set;}
    }
}