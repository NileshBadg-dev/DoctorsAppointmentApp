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
    public partial class DoctorsFormView: Form
    {
        private int doctorId;
        private DateTime selectedDate;
        private bool openAppointmentsTab;
        private DoctorService doctorService;
        private AppointmentService appointmentService;
        private bool isNewDoctor = false;
        public DoctorDetails SelectedDoctor { get; private set; }

        public DoctorsFormView(int dctID = -1, DateTime? appointmentDate = null, bool appointmentTab = false)
        {
            InitializeComponent();
            doctorService = new DoctorService();
            appointmentService = new AppointmentService();
            doctorId = dctID;
            selectedDate = appointmentDate ?? DateTime.Today;
            openAppointmentsTab = appointmentTab;

            if (openAppointmentsTab)
            {
                tabControl_DoctorAppointment.SelectedTab = tabPage_AppointmentDetails;
                datePicker_Appointtab.Value = selectedDate;
                LoadAppointments();
            }

            LoadDoctorsList();
            LoadSpecializations();
            LoadDoctorDetails();
            EnableDisableFields(true);
        }

        #region Load Data

        private void LoadDoctorsList()
        {
            try
            {
                DataTable dtDoctors = doctorService.SearchDoctors(string.Empty, string.Empty, 0);

                DataRow dr = dtDoctors.NewRow();
                dr["DoctorID"] = -1;
                dr["DoctorsName"] = "Select Doctor";
                dtDoctors.Rows.InsertAt(dr, 0);

                comboBox_DoctorsList.DataSource = dtDoctors;
                comboBox_DoctorsList.DisplayMember = "DoctorsName";
                comboBox_DoctorsList.ValueMember = "DoctorID";
                comboBox_DoctorsList.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading doctors: " + ex.Message);
            }
        }

        private void LoadDoctorDetails()
        {
            if (doctorId == -1 || isNewDoctor)
            {
                ClearFields();
            }
            else
            {
                DoctorDetails doctorData = doctorService.GetDoctorById(doctorId);
                SelectedDoctor = doctorData;

                if (doctorData != null)
                {
                    textBox_DoctorFirstName.Text = doctorData.FirstName;
                    textBox_DoctorLastName.Text = doctorData.LastName;
                    comboBox_Gender.Text = doctorData.Gender;
                    datePicker_DoctorsDOB.Value = doctorData.DateOfBirth;
                    textBox_Qualification.Text = doctorData.Qualification;
                    cB_DoctorsSpecialization.SelectedValue = doctorData.SpecializationID;
                    textBox_DoctorAddress.Text = doctorData.Address;
                    textBox_ContactNumber.Text = doctorData.ContactNumber.ToString();
                    comboBox_DoctorsList.SelectedValue = doctorId;
                }
            }
        }

        private void LoadSpecializations()
        {
            try
            {
                List<Specialization> specializations = doctorService.GetSpecializations();
                cB_DoctorsSpecialization.DataSource = specializations;
                cB_DoctorsSpecialization.DisplayMember = "SpecializationName";
                cB_DoctorsSpecialization.ValueMember = "SpecializationID";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading in specializations: " + ex.Message);
            }
        }

        private void ClearFields()
        {
            textBox_DoctorFirstName.Text = "";
            textBox_DoctorLastName.Text = "";
            comboBox_Gender.SelectedIndex = -1;
            datePicker_DoctorsDOB.Value = DateTime.Today;
            textBox_Qualification.Text = "";
            cB_DoctorsSpecialization.SelectedIndex = -1;
            textBox_DoctorAddress.Text = "";
            textBox_ContactNumber.Text = "";
        }

        private void EnableDisableFields(bool enable)
        {
            textBox_DoctorFirstName.Enabled = enable;
            textBox_DoctorLastName.Enabled = enable;
            comboBox_Gender.Enabled = enable;
            datePicker_DoctorsDOB.Enabled = enable;
            textBox_Qualification.Enabled = enable;
            cB_DoctorsSpecialization.Enabled = enable;
            textBox_DoctorAddress.Enabled = enable;
            textBox_ContactNumber.Enabled = enable;
        }

        #endregion

        #region Control Events

        private void linkLabel_DF_AddNewDoctor_Click(object sender, EventArgs e)
        {
            doctorId = -1;
            isNewDoctor = true;
            ClearFields();
            EnableDisableFields(true);
        }

        private void comboBox_DoctorsList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_DoctorsList.SelectedIndex > 0)
            {
                doctorId = Convert.ToInt32(comboBox_DoctorsList.SelectedValue);
                isNewDoctor = false;
                LoadDoctorDetails();
                EnableDisableFields(true);
            }
            else
            {
                ClearFields();
                EnableDisableFields(false);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (doctorId == -1)
            {
                DoctorDetails newDoctor = new DoctorDetails
                {
                    FirstName = textBox_DoctorFirstName.Text,
                    LastName = textBox_DoctorLastName.Text,
                    Gender = comboBox_Gender.Text,
                    DateOfBirth = datePicker_DoctorsDOB.Value,
                    Qualification = textBox_Qualification.Text,
                    SpecializationID = Convert.ToInt32(cB_DoctorsSpecialization.SelectedValue),
                    Address = textBox_DoctorAddress.Text,
                    ContactNumber = textBox_ContactNumber.Text
                };

                try
                {
                    bool success = doctorService.AddNewDoctor(newDoctor);

                    if (success)
                    {
                        MessageBox.Show("Doctor added successfully!");
                        ClearFields();
                    }
                    else
                    {
                        MessageBox.Show("Error adding doctor.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error add in new doctor: " + ex.Message);
                }
            }
            else
            {
                DoctorDetails updateDoctor = new DoctorDetails
                {
                    DoctorId = doctorId,
                    FirstName = textBox_DoctorFirstName.Text,
                    LastName = textBox_DoctorLastName.Text,
                    Gender = comboBox_Gender.Text,
                    DateOfBirth = datePicker_DoctorsDOB.Value,
                    Qualification = textBox_Qualification.Text,
                    SpecializationID = Convert.ToInt32(cB_DoctorsSpecialization.SelectedValue),
                    Address = textBox_DoctorAddress.Text,
                    ContactNumber = textBox_ContactNumber.Text
                };

                try
                {
                    bool updated = doctorService.UpdateDoctorDetails(updateDoctor);

                    if (updated)
                    {
                        MessageBox.Show("Doctor details updated successfully!");
                    }
                    else
                    {
                        MessageBox.Show("Error in updating doctor details.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error update in new doctor: " + ex.Message);
                }
            }
        }


        #endregion

        private void textBox_ContactNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            if (textBox_ContactNumber.Text.Length >= 10 && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tabControl_DoctorAppointment_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl_DoctorAppointment.SelectedTab == tabPage_AppointmentDetails && doctorId > 0)
            {
                LoadAppointments();
            }
        }

        private void LoadAppointments()
        {
            try
            {
                DataTable appointments = appointmentService.GetAppointmentsByDoctor(doctorId, selectedDate);
                dataGrid_AppointmentDetails.DataSource = appointments;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading appointments: " + ex.Message);
            }
        }

        private void datePicker_Appointtab_ValueChanged(object sender, EventArgs e)
        {
            selectedDate = datePicker_Appointtab.Value;
            LoadAppointments();
        }
    }
}
