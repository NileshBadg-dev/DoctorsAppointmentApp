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
    public class AppointmentService
    {
        private AppointmentRepository appointmentRepository;

        public AppointmentService()
        {
            appointmentRepository = new AppointmentRepository();
        }

        public int BookAppointment(AppointmentDetails appointmentDetails)
        {
            return appointmentRepository.BookAppointment(appointmentDetails);
        }

        public DataTable GetAppointmentsByDoctor(int doctorId, DateTime? selectedDate)
        {
            return appointmentRepository.GetAppointmentsByDoctor(doctorId, selectedDate);
        }
    }
}
