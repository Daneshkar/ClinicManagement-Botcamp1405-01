using System;
using System.Collections.Generic;
using System.Text;

namespace ClinicManagement.Application.DTOs.Doctors
{
 public  record DoctorSignupRequestDtocs
    {
        public required string MedicalID { get; set; }
        public required string Name { get; set; }
        public string Password { get; set; }
        public decimal Fee { get; set; }


    }
}
