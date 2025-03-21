using DoctorsAppointmentApp.Core.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoctorsAppointmentApp.Data
{
    public class AppointmentReportRepository
    {
        private SqlConnection sqlConnection;
        private readonly string connectionString = @"Data Source=NILESHBADG-W11\MSSQLSERVER2019;Initial Catalog=DoctorsAppointmentApp;User ID=sa;Password=cybage@123456;Integrated Security=True;";

        public List<AppointmentReportDetails> GetAppointmentsReport(int doctorId, DateTime fromDate, DateTime toDate)
        {
            List<AppointmentReportDetails> reportList = new List<AppointmentReportDetails>();

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("GetAppointmentsReport", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@DoctorId", doctorId);
                    cmd.Parameters.AddWithValue("@FromDate", fromDate);
                    cmd.Parameters.AddWithValue("@ToDate", toDate);

                    con.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            reportList.Add(new AppointmentReportDetails
                            {
                                PatientId = Convert.ToInt32(reader["PatientId"]),
                                PatientName = reader["PatientName"].ToString(),
                                ContactNumber = reader["ContactNumber"].ToString(),
                                LastAppointmentDate = Convert.ToDateTime(reader["LastAppointmentDate"]),
                                LastAppointmentDoctor = reader["LastAppointmentDoctor"].ToString()
                            });
                        }
                    }
                }
            }
            return reportList;
        }
    }
}
