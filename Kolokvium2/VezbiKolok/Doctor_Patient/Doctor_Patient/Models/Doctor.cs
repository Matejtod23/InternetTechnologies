using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Doctor_Patient.Models
{
    public class Doctor
    {
        public Doctor()
        {
            Patients = new List<Patient>();
        }
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "The doctors name is required")]
        public string Name { get; set; }
        public string Profession { get; set; }
        public string Phone { get; set;}
        public string Gender { get; set; }

        public Hospital Hospital { get; set;}
        public int HospitalId { get; set; }
        public virtual List<Patient> Patients { get; set; }
    }
}