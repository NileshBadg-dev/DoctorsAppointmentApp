using DoctorsAppointmentApp.Business;
using DoctorsAppointmentApp.Core.Models;
using Microsoft.Reporting.WinForms;
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
    public partial class AppointmentReportForm: Form
    {
        private DoctorService doctorService;

        public AppointmentReportForm()
        {
            InitializeComponent();
            doctorService = new DoctorService();
        }
        private void LoadDoctorsList(string doctorName)
        {
            try
            {
                DataTable dtDoctors = doctorService.SearchDoctors(string.Empty, string.Empty, 0);

                DataRow dr = dtDoctors.NewRow();
                dr["DoctorID"] = -1;
                dr["DoctorsName"] = "Select Doctor";
                dtDoctors.Rows.InsertAt(dr, 0);

                comboBox_DoctorName.DataSource = dtDoctors;
                comboBox_DoctorName.DisplayMember = "DoctorsName";
                comboBox_DoctorName.ValueMember = "DoctorID";
                comboBox_DoctorName.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading doctors: " + ex.Message);
            }
        }

        private void AppointmentReportForm_Load(object sender, EventArgs e)
        {
            LoadDoctorsList(string.Empty);
            this.appointmentReportViewer.RefreshReport();
        }

        private void button_Search_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dtDoctors = doctorService.SearchDoctors(textBox_Search.Text, string.Empty, 0);

                DataRow dr = dtDoctors.NewRow();
                dr["DoctorID"] = -1;
                dr["DoctorsName"] = "Select Doctor";
                dtDoctors.Rows.InsertAt(dr, 0);

                comboBox_DoctorName.DataSource = dtDoctors;
                comboBox_DoctorName.DisplayMember = "DoctorsName";
                comboBox_DoctorName.ValueMember = "DoctorID";
                comboBox_DoctorName.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading doctors: " + ex.Message);
            }
        }

        private void button_Report_Click(object sender, EventArgs e)
        {
            int doctorId = comboBox_DoctorName.SelectedIndex >= 0 ? Convert.ToInt32(comboBox_DoctorName.SelectedValue) : -1;
            DateTime fromDate = datePicker_From.Value;
            DateTime toDate = datePicker_To.Value;

            LoadReport(doctorId, fromDate, toDate);
        }

        private void LoadReport(int doctorId, DateTime fromDate, DateTime toDate)
        {
            AppointmentReportService appointmentReportService = new AppointmentReportService();
            List<AppointmentReportDetails> appointmentReports = appointmentReportService.GetAppointmentsReport(doctorId, fromDate, toDate);
            appointmentReportViewer.Visible = true;
            appointmentReportViewer.LocalReport.DataSources.Clear();
            ReportDataSource reportDataSource = new ReportDataSource("AppointmentDataSet", appointmentReports);
            appointmentReportViewer.LocalReport.DataSources.Add(reportDataSource);
            appointmentReportViewer.LocalReport.ReportEmbeddedResource = "DoctorsAppointmentApp.View.AppointmentReport.rdlc";
            appointmentReportViewer.RefreshReport();
        }
    }
}

    
