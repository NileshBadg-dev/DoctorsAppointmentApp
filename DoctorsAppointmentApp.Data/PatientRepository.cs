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
    public class PatientRepository
    {
        private SqlConnection sqlConnection;
        private readonly string connectionString = @"Data Source=NILESHBADG-W11\MSSQLSERVER2019;Initial Catalog=DoctorsAppointmentApp;User ID=sa;Password=cybage@123456;Integrated Security=True;";

        public DataTable SearchPatients(string patientId, string firstName, string lastName, string contactNumber)
        {
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("SearchPatients", sqlConnection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@PatientId", string.IsNullOrEmpty(patientId) ? (object)DBNull.Value : Convert.ToInt32(patientId));
                    cmd.Parameters.AddWithValue("@FirstName", string.IsNullOrEmpty(firstName) ? (object)DBNull.Value : firstName);
                    cmd.Parameters.AddWithValue("@LastName", string.IsNullOrEmpty(lastName) ? (object)DBNull.Value : lastName);
                    cmd.Parameters.AddWithValue("@ContactNumber", string.IsNullOrEmpty(contactNumber) ? (object)DBNull.Value : contactNumber);

                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        DataSet ds = new DataSet();
                        da.Fill(ds, "PatientDetails");
                        return ds.Tables["PatientDetails"];
                    }
                }
            }
        }

        /// <summary>
        /// For add new patient
        /// </summary>
        /// <param name="patientDetails"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public bool AddNewPatient(PatientDetails patientDetails)
        {
            try
            {
                using (SqlConnection sqlConnection = new SqlConnection(connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand("AddNewPatient", sqlConnection))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@FirstName", patientDetails.FirstName);
                        cmd.Parameters.AddWithValue("@LastName", patientDetails.LastName);
                        cmd.Parameters.AddWithValue("@ContactNumber", patientDetails.ContactNumber);
                        cmd.Parameters.AddWithValue("@Gender", patientDetails.Gender);
                        cmd.Parameters.AddWithValue("@DateOfBirth", patientDetails.DateOfBirth);
                        cmd.Parameters.AddWithValue("@Address", patientDetails.Address);
                        

                        SqlDataAdapter da = new SqlDataAdapter();
                        da.InsertCommand = cmd;

                        DataSet ds = new DataSet();
                        sqlConnection.Open();
                        int rowsAffected = da.InsertCommand.ExecuteNonQuery();

                        return rowsAffected > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error adding patient: " + ex.Message);
            }
        }
    }
}
