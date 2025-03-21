using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoctorsAppointmentApp.Core.Models
{
    public class PatientDetails : CommonEntities
    {
        public int PatientId { get; set; }
        public string FullName { get; set; }
    }
}
