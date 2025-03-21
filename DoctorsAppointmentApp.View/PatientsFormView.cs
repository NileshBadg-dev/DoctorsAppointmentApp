using DoctorsAppointmentApp.Business;
using DoctorsAppointmentApp.Core.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoctorsAppointmentApp.View
{
    public partial class PatientsFormView: Form
    {
        private PatientService patientService;
        public PatientDetails SelectedPatient { get; private set; }


        public PatientsFormView()
        {
            InitializeComponent();
            patientService = new PatientService();
        }

        private void button_SearchPatientForm_Click(object sender, EventArgs e)
        {
            var patientId = textBox_PatientId.Text;
            var firstName = textBox_PaientFirstName.Text;
            var lastName = textBox_PaientLastName.Text;
            var contactNumber = textBox_PatientContactNumber.Text;

            dgrid_PatientDetails.DataSource = patientService.SearchPatients(patientId,firstName,lastName,contactNumber);
        }

        private void dgrid_PatientDetails_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataRow row = ((DataTable)dgrid_PatientDetails.DataSource).Rows[e.RowIndex];
                SelectedPatient = new PatientDetails
                {
                    PatientId = Convert.ToInt32(row["PatientId"]),
                    FullName = row["FullName"].ToString(),
                    ContactNumber = row["ContactNumber"].ToString()
                };
                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private void button_AddNewPatient_Click(object sender, EventArgs e)
        {
            button_SearchPatientForm.Hide();
            button_SavePatient.Show();
            textBox_PatientId.Enabled = false;
            ClearFields();
        }

        private void PatientsFormView_Load(object sender, EventArgs e)
        {
            button_SavePatient.Hide();
        }

        private void ClearFields()
        {
            textBox_PatientId.Text = "";
            textBox_PaientFirstName.Text = "";
            textBox_PaientLastName.Text = "";
            textBox_PatientContactNumber.Text = "";
            comboBox_Gender.SelectedIndex = -1;
            datePicker_DoctorsDOB.Value = DateTime.Today;
            textBox_DoctorAddress.Text = "";
            dgrid_PatientDetails.DataSource = null;
        }

        private void button_SavePatient_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrWhiteSpace(textBox_PaientFirstName.Text) && !string.IsNullOrWhiteSpace(textBox_PaientLastName.Text) 
                && !string.IsNullOrWhiteSpace(textBox_PatientContactNumber.Text))
            {
                PatientDetails newPatient = new PatientDetails
                {
                    FirstName = textBox_PaientFirstName.Text,
                    LastName = textBox_PaientLastName.Text,
                    ContactNumber = textBox_PatientContactNumber.Text,
                    Gender = comboBox_Gender.Text,
                    DateOfBirth = datePicker_DoctorsDOB.Value,
                    Address = textBox_DoctorAddress.Text
                };

                try
                {
                    bool success = patientService.AddNewPatient(newPatient);

                    if (success)
                    {
                        MessageBox.Show("Patient added successfully!");
                        ClearFields();
                    }
                    else
                    {
                        MessageBox.Show("Error adding patient.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error add in new patient: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Fileds should not be blank");
            }
        }

        private void dgrid_PatientDetails_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataRow row = ((DataTable)dgrid_PatientDetails.DataSource).Rows[e.RowIndex];
                SelectedPatient = new PatientDetails
                {
                    PatientId = Convert.ToInt32(row["PatientId"]),
                    FullName = row["FullName"].ToString(),
                    ContactNumber = row["ContactNumber"].ToString()
                };
                DialogResult = DialogResult.OK;
                Close();
            }
        }
    }
}
