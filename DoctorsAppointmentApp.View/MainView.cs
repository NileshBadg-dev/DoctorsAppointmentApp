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
    public partial class MainView: Form
    {
        private DoctorService doctorService;
        private AppointmentService appointmentService;
        private DoctorDetails selectedDoctorDetails;
        private PatientDetails selectedPatientDetails;

        public MainView()
        {
            InitializeComponent();
            InitializeDateTimeControl();
            doctorService = new DoctorService();
            appointmentService = new AppointmentService();
            LoadSpecializations();
        }

        #region ControlEvents

        #region LinkLable Events

        private void linkLabel_AddDoctor_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DoctorsFormView doctorsForm = new DoctorsFormView();
            doctorsForm.ShowDialog();
        }

        #endregion

        #region Button Events

        private void button_SearchDoctor_Click(object sender, EventArgs e)
        {
            var firstName = textBox_FirstName.Text;
            var lastName = textBox_LastName.Text;
            int specialityID = comboBox_Speciality.SelectedIndex;

            if (string.IsNullOrEmpty(firstName) && string.IsNullOrEmpty(lastName) && specialityID <= 0)
            {
                dataGrid_DoctorDetails.DataSource = doctorService.SearchDoctors(firstName, lastName, specialityID);
            }
            else if (!string.IsNullOrEmpty(firstName) || !string.IsNullOrEmpty(lastName) || specialityID > 0)
            {
                dataGrid_DoctorDetails.DataSource = doctorService.SearchDoctors(firstName, lastName, specialityID);
            }
            else
            {
                MessageBox.Show("Please enter First Name, Last Name, or select a Specialization.");
            }

            if (dataGrid_DoctorDetails.Columns.Contains("DoctorID"))
            {
                dataGrid_DoctorDetails.Columns["DoctorID"].Visible = false;
            }
        }

        private void button_SearchPatient_Click(object sender, EventArgs e)
        {
            using (PatientsFormView patientForm = new PatientsFormView())
            {
                if (patientForm.ShowDialog() == DialogResult.OK)
                {
                    selectedPatientDetails = patientForm.SelectedPatient;
                    textBox_PatientName.Text = patientForm.SelectedPatient.FullName;
                    textBox_ContactNumber.Text = patientForm.SelectedPatient.ContactNumber;
                }
            }
        }

        #endregion

        private void dataGrid_DoctorDetails_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int doctorId = Convert.ToInt32(dataGrid_DoctorDetails.Rows[e.RowIndex].Cells["DoctorID"].Value);
                using (DoctorsFormView doctorsForm = new DoctorsFormView(doctorId, dateTimePicker_ApntDate.Value.Date ,true))
                {
                    selectedDoctorDetails = doctorsForm.SelectedDoctor;
                    textBox_FirstName.Text = selectedDoctorDetails.FirstName;
                    textBox_LastName.Text = selectedDoctorDetails.LastName;
                    comboBox_Speciality.SelectedValue = selectedDoctorDetails.SpecializationID;
                    doctorsForm.ShowDialog();
                }
            }
        }

        private void MainView_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'doctorsAppointmentAppDataSet.Specialization' table. You can move, or remove it, as needed.
            //this.specializationTableAdapter.Fill(this.doctorsAppointmentAppDataSet.Specialization);
        }

        #endregion

        #region Load Data

        private void LoadSpecializations()
        {
            try
            {
                List<Specialization> specializations = doctorService.GetSpecializations();
                comboBox_Speciality.DataSource = specializations;
                comboBox_Speciality.DisplayMember = "SpecializationName";
                comboBox_Speciality.ValueMember = "SpecializationID";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading in specializations: " + ex.Message);
            }
        }

        #endregion

        private void InitializeDateTimeControl()
        {
            //Appointment Date Picker Control
            dateTimePicker_ApntDate.Format = DateTimePickerFormat.Short;
            dateTimePicker_ApntDate.Value = DateTime.Now.Date;
            dateTimePicker_ApntDate.MinDate = DateTime.Now.Date;
            dateTimePicker_ApntDate.MaxDate = DateTime.Now.Date.AddDays(7);

            //Appintment Time Control
            FromTimePicker.Format = DateTimePickerFormat.Time;
            ToTimePicker.Format = DateTimePickerFormat.Time;
        }

        private void FromTimePicker_ValueChanged(object sender, EventArgs e)
        {
            ToTimePicker.Value = FromTimePicker.Value.AddMinutes(15);
        }

        private void button_BookAppointment_Click(object sender, EventArgs e)
        {
            AppointmentDetails appointmentDetails = new AppointmentDetails()
            {
                DoctorId = selectedDoctorDetails.DoctorId,
                PatientId = selectedPatientDetails.PatientId,
                AppointmentDate = dateTimePicker_ApntDate.Value.Date,
                FromTime = FromTimePicker.Value,
                ToTime = ToTimePicker.Value
            };
            
            try
            {
                int appointmentId = appointmentService.BookAppointment(appointmentDetails);

                if (appointmentId > 0)
                {
                    MessageBox.Show($"Appointment booked successfully. Appointment Number: {appointmentId}");
                }
                else
                {
                    MessageBox.Show("Error in booking appointment.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in booking appointment: " + ex.Message);
            }
        }

        private void linkLabel_AppointmentReport_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AppointmentReportForm appointmentReport = new AppointmentReportForm();
            appointmentReport.ShowDialog();
        }
    }
}
