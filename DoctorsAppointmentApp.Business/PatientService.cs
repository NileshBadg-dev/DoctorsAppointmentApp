using DoctorsAppointmentApp.Core.Models;
using DoctorsAppointmentApp.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoctorsAppointmentApp.Business
{
    public class PatientService
    {
        private PatientRepository patientRepository;

        public PatientService()
        {
            patientRepository = new PatientRepository();
        }

        public DataTable SearchPatients(string patientId, string firstName, string lastName, string contactNumber)
        {
            return patientRepository.SearchPatients(patientId, firstName, lastName, contactNumber);
        }

        public bool AddNewPatient(PatientDetails patientDetails)
        {
            return patientRepository.AddNewPatient(patientDetails);
        }
    }
}
