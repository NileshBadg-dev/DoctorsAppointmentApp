using DoctorsAppointmentApp.Core.Models;
using DoctorsAppointmentApp.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoctorsAppointmentApp.Business
{
    public class AppointmentReportService
    {
        private AppointmentReportRepository appointmentReport;

        public AppointmentReportService()
        {
            appointmentReport = new AppointmentReportRepository();
        }

        public List<AppointmentReportDetails> GetAppointmentsReport(int doctorId, DateTime fromDate, DateTime toDate)
        {
            return appointmentReport.GetAppointmentsReport(doctorId, fromDate,toDate);
        }
    }
}
