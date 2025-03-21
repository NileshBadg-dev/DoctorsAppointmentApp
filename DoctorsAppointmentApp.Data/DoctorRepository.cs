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
    public class DoctorRepository
    {
        private SqlConnection sqlConnection;
        private readonly string connectionString = @"Data Source=NILESHBADG-W11\MSSQLSERVER2019;Initial Catalog=DoctorsAppointmentApp;User ID=sa;Password=cybage@123456;Integrated Security=True;";

        public DoctorRepository()
        {

        }

        public List<Specialization> GetSpecializations()
        {
            List<Specialization> specializations = new List<Specialization>();

            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                SqlDataAdapter sqlData = new SqlDataAdapter("select * from Specialization", sqlConnection);
                DataSet dataSet = new DataSet();
                sqlData.Fill(dataSet, "Specialization");

                specializations.Add(new Specialization { SpecializationID = 0, SpecializationName = "Select Specialization" });

                foreach (DataRow row in dataSet.Tables["Specialization"].Rows)
                {
                    specializations.Add(new Specialization
                    {
                        SpecializationID = Convert.ToInt32(row["SpecializationID"]),
                        SpecializationName = row["SpecializationName"].ToString()
                    });
                }

                return specializations;
            }
        }

        public DataTable SearchDoctors(string firstName, string lastName, int specialtyId)
        {
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("SearchDoctors", sqlConnection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@FirstName", string.IsNullOrEmpty(firstName) ? null : firstName);
                    cmd.Parameters.AddWithValue("@LastName", string.IsNullOrEmpty(lastName) ? null : lastName);
                    cmd.Parameters.AddWithValue("@SpecialtyID", specialtyId == 0 ? (object)DBNull.Value : specialtyId);

                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        return dt;
                    }
                }
            }
        }

        public DoctorDetails GetDoctorById(int doctorId)
        {
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("GetDoctorById", sqlConnection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@DoctorID", doctorId);

                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        DataSet dataSet = new DataSet();
                        da.Fill(dataSet, "DoctorDetails");

                        if (dataSet.Tables["DoctorDetails"].Rows.Count > 0)
                        {
                            DataRow row = dataSet.Tables["DoctorDetails"].Rows[0];
                            return new DoctorDetails
                            {
                                DoctorId = Convert.ToInt32(row["DoctorID"]),
                                FirstName = row["FirstName"].ToString(),
                                LastName = row["LastName"].ToString(),
                                Gender = row["Gender"].ToString(),
                                DateOfBirth = Convert.ToDateTime(row["DateOfBirth"]),
                                Qualification = row["Qualification"].ToString(),
                                SpecializationID = Convert.ToInt32(row["SpecializationID"]),
                                Address = row["Address"].ToString(),
                                ContactNumber = row["ContactNumber"].ToString()
                            };
                        }
                        return null;
                    }
                }
            }
        }

        public bool AddNewDoctor(DoctorDetails doctorDetails)
        {
            try
            {
                using (SqlConnection sqlConnection = new SqlConnection(connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand("AddNewDoctor", sqlConnection))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@FirstName", doctorDetails.FirstName);
                        cmd.Parameters.AddWithValue("@LastName", doctorDetails.LastName);
                        cmd.Parameters.AddWithValue("@Gender", doctorDetails.Gender);
                        cmd.Parameters.AddWithValue("@DateOfBirth", doctorDetails.DateOfBirth);
                        cmd.Parameters.AddWithValue("@Qualification", doctorDetails.Qualification);
                        cmd.Parameters.AddWithValue("@SpecializationID", doctorDetails.SpecializationID);
                        cmd.Parameters.AddWithValue("@Address", doctorDetails.Address);
                        cmd.Parameters.AddWithValue("@ContactNumber", doctorDetails.ContactNumber);

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
                throw new Exception("Error adding doctor: " + ex.Message);
            }
        }

        public bool UpdateDoctorDetails(DoctorDetails doctorDetails)
        {
            try
            {
                using (SqlConnection sqlConnection = new SqlConnection(connectionString))
                {
                    using (SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM DoctorDetails WHERE DoctorID = @DoctorID", sqlConnection))
                    {
                        da.SelectCommand.Parameters.AddWithValue("@DoctorID", doctorDetails.DoctorId);

                        SqlCommandBuilder builder = new SqlCommandBuilder(da);

                        DataSet ds = new DataSet();
                        da.Fill(ds, "DoctorDetails");

                        if (ds.Tables["DoctorDetails"].Rows.Count > 0)
                        {
                            DataRow row = ds.Tables["DoctorDetails"].Rows[0];
                            row["FirstName"] = doctorDetails.FirstName;
                            row["LastName"] = doctorDetails.LastName;
                            row["Gender"] = doctorDetails.Gender;
                            row["DateOfBirth"] = doctorDetails.DateOfBirth;
                            row["Qualification"] = doctorDetails.Qualification;
                            row["SpecializationID"] = doctorDetails.SpecializationID;
                            row["Address"] = doctorDetails.Address;
                            row["ContactNumber"] = doctorDetails.ContactNumber;

                            da.Update(ds, "DoctorDetails");
                            return true;
                        }
                        return false;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error updating doctor: " + ex.Message);
            }
        }
    }
}
