using ClinicManagement.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClinicManagement.Application.Interfaces.Repository
{
    public interface IDoctorRepository
    {

        public string GetByMedicalIdAsync(string medicallId);

        public bool ExistsByMedicalIdAsync(string medicalIdl);

        public void AddAsync(Doctor doctor);


    }
}
