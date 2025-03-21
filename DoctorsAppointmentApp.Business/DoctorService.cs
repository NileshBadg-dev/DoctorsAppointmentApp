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
    public class DoctorService
    {
        private DoctorRepository doctorRepository;

        public DoctorService()
        {
            doctorRepository = new DoctorRepository();
        }

        public List<Specialization> GetSpecializations()
        {
            return doctorRepository.GetSpecializations();
        }

        public DataTable SearchDoctors(string firstName, string lastName, int specialtyId)
        {
            return doctorRepository.SearchDoctors(firstName, lastName, specialtyId);
        }

        public DoctorDetails GetDoctorById(int doctorId)
        {
            return doctorRepository.GetDoctorById(doctorId);
        }

        public bool AddNewDoctor(DoctorDetails doctorDetails)
        {
            return doctorRepository.AddNewDoctor(doctorDetails);
        }

        public bool UpdateDoctorDetails(DoctorDetails doctorDetails)
        {
            return doctorRepository.UpdateDoctorDetails(doctorDetails);
        }
    }
}
