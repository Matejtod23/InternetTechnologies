using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Doctor_Patient.Models
{
    public class Patient
    {
        public Patient()
        {
            Doctors = new List<Doctor>();
        }
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "The name of the patient is required")]
        public string Name { get; set; }
        public string Gender { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        [Required(ErrorMessage = "The code is required")]
        [RegularExpression("\\d{5}", ErrorMessage = "The code need's to be 5 digits")]
        public int PatientCode { get; set; }
        public virtual List<Doctor> Doctors { get; set; }
    }
}