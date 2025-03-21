using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoctorsAppointmentApp.Core.Models
{
    public class AppointmentReportDetails
    {
        public int PatientId { get; set; }
        public string PatientName { get; set; }
        public string ContactNumber { get; set; }
        public DateTime LastAppointmentDate { get; set; }
        public string LastAppointmentDoctor { get; set; }
    }
}
