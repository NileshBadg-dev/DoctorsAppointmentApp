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
    public class AppointmentRepository
    {
        private SqlConnection sqlConnection;
        private readonly string connectionString = @"Data Source=NILESHBADG-W11\MSSQLSERVER2019;Initial Catalog=DoctorsAppointmentApp;User ID=sa;Password=cybage@123456;Integrated Security=True;";

        public int BookAppointment(AppointmentDetails appointmentDetails)
        {
            try
            {
                using (SqlConnection sqlConnection = new SqlConnection(connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand("BookAppointment", sqlConnection))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@DoctorId", appointmentDetails.DoctorId);
                        cmd.Parameters.AddWithValue("@PatientId", appointmentDetails.PatientId);
                        cmd.Parameters.AddWithValue("@AppointmentDate", appointmentDetails.AppointmentDate);
                        cmd.Parameters.AddWithValue("@FromTime", appointmentDetails.FromTime.ToShortTimeString());
                        cmd.Parameters.AddWithValue("@ToTime", appointmentDetails.ToTime.ToShortTimeString());

                        SqlParameter outputParam = new SqlParameter("@AppointmentId", SqlDbType.Int)
                        {
                            Direction = ParameterDirection.Output
                        };
                        cmd.Parameters.Add(outputParam);

                        sqlConnection.Open();
                        int rowsAffected = cmd.ExecuteNonQuery();

                        int appointmentId = (outputParam.Value != DBNull.Value) ? Convert.ToInt32(outputParam.Value) : -1;

                        if (rowsAffected > 0 && appointmentId > 0)
                        {
                            return appointmentId;
                        }
                        else
                        {
                            return -1;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error in booking appointment: " + ex.Message);
            }
        }

        public DataTable GetAppointmentsByDoctor(int doctorId, DateTime? selectedDate)
        {
            DataTable dtAppointments = new DataTable();
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand("GetAppointmentsByDoctor", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@DoctorId", doctorId);
                        cmd.Parameters.AddWithValue("@AppointmentDate", selectedDate);

                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        da.Fill(dtAppointments);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error retrieving appointments: " + ex.Message);
            }
            return dtAppointments;
        }
    }
}
