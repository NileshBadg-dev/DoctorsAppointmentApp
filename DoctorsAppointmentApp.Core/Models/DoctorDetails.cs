using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoctorsAppointmentApp.Core.Models
{
    public class DoctorDetails : CommonEntities
    {
        public int DoctorId { get; set; }
        public string Qualification { get; set; }
        public int SpecializationID { get; set; }
    }
}
