using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LAB3_B.Models
{
    public class Doctor
    {
        public Doctor() { 
            Patients = new List<Patient>();
        }
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "The doctor's name is required")]
        public string Name { get; set; }

        public string Phone { get; set; }

        public int HospitalId { get; set; }

        public Hospital hospital { get; set; }

        public virtual List<Patient> Patients { get; set; }
    }
}