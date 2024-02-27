using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Doctor_Patient.Models
{
    public class PatientDoctors
    {
        public PatientDoctors()
        {
            Patients = new List<Patient>();
        }
        public int DoctorId { get; set; }
        public Doctor Doctor { get; set; }

        public int PatientId { get; set; }
        public List<Patient> Patients { get; set; }
    }
}