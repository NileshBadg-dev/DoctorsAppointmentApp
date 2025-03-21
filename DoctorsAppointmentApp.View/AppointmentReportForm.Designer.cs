namespace DoctorsAppointmentApp.View
{
    partial class AppointmentReportForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label_DoctorName = new System.Windows.Forms.Label();
            this.comboBox_DoctorName = new System.Windows.Forms.ComboBox();
            this.label_Or = new System.Windows.Forms.Label();
            this.textBox_Search = new System.Windows.Forms.TextBox();
            this.button_Search = new System.Windows.Forms.Button();
            this.label_AppointmentDate = new System.Windows.Forms.Label();
            this.datePicker_From = new System.Windows.Forms.DateTimePicker();
            this.label_To = new System.Windows.Forms.Label();
            this.datePicker_To = new System.Windows.Forms.DateTimePicker();
            this.button_Report = new System.Windows.Forms.Button();
            this.appointmentReportViewer = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // label_DoctorName
            // 
            this.label_DoctorName.AutoSize = true;
            this.label_DoctorName.Location = new System.Drawing.Point(13, 13);
            this.label_DoctorName.Name = "label_DoctorName";
            this.label_DoctorName.Size = new System.Drawing.Size(70, 13);
            this.label_DoctorName.TabIndex = 0;
            this.label_DoctorName.Text = "Doctor Name";
            // 
            // comboBox_DoctorName
            // 
            this.comboBox_DoctorName.FormattingEnabled = true;
            this.comboBox_DoctorName.Location = new System.Drawing.Point(104, 12);
            this.comboBox_DoctorName.Name = "comboBox_DoctorName";
            this.comboBox_DoctorName.Size = new System.Drawing.Size(177, 21);
            this.comboBox_DoctorName.TabIndex = 1;
            // 
            // label_Or
            // 
            this.label_Or.AutoSize = true;
            this.label_Or.Location = new System.Drawing.Point(301, 16);
            this.label_Or.Name = "label_Or";
            this.label_Or.Size = new System.Drawing.Size(23, 13);
            this.label_Or.TabIndex = 2;
            this.label_Or.Text = "OR";
            // 
            // textBox_Search
            // 
            this.textBox_Search.Location = new System.Drawing.Point(344, 12);
            this.textBox_Search.Name = "textBox_Search";
            this.textBox_Search.Size = new System.Drawing.Size(158, 20);
            this.textBox_Search.TabIndex = 3;
            // 
            // button_Search
            // 
            this.button_Search.Location = new System.Drawing.Point(522, 10);
            this.button_Search.Name = "button_Search";
            this.button_Search.Size = new System.Drawing.Size(75, 23);
            this.button_Search.TabIndex = 4;
            this.button_Search.Text = "Search";
            this.button_Search.UseVisualStyleBackColor = true;
            this.button_Search.Click += new System.EventHandler(this.button_Search_Click);
            // 
            // label_AppointmentDate
            // 
            this.label_AppointmentDate.AutoSize = true;
            this.label_AppointmentDate.Location = new System.Drawing.Point(13, 63);
            this.label_AppointmentDate.Name = "label_AppointmentDate";
            this.label_AppointmentDate.Size = new System.Drawing.Size(92, 13);
            this.label_AppointmentDate.TabIndex = 0;
            this.label_AppointmentDate.Text = "Appointment Date";
            // 
            // datePicker_From
            // 
            this.datePicker_From.Location = new System.Drawing.Point(112, 59);
            this.datePicker_From.Name = "datePicker_From";
            this.datePicker_From.Size = new System.Drawing.Size(200, 20);
            this.datePicker_From.TabIndex = 5;
            // 
            // label_To
            // 
            this.label_To.AutoSize = true;
            this.label_To.Location = new System.Drawing.Point(329, 63);
            this.label_To.Name = "label_To";
            this.label_To.Size = new System.Drawing.Size(22, 13);
            this.label_To.TabIndex = 2;
            this.label_To.Text = "TO";
            // 
            // datePicker_To
            // 
            this.datePicker_To.Location = new System.Drawing.Point(357, 59);
            this.datePicker_To.Name = "datePicker_To";
            this.datePicker_To.Size = new System.Drawing.Size(200, 20);
            this.datePicker_To.TabIndex = 5;
            // 
            // button_Report
            // 
            this.button_Report.Location = new System.Drawing.Point(581, 58);
            this.button_Report.Name = "button_Report";
            this.button_Report.Size = new System.Drawing.Size(75, 23);
            this.button_Report.TabIndex = 4;
            this.button_Report.Text = "Report";
            this.button_Report.UseVisualStyleBackColor = true;
            this.button_Report.Click += new System.EventHandler(this.button_Report_Click);
            // 
            // appointmentReportViewer
            // 
            this.appointmentReportViewer.Location = new System.Drawing.Point(16, 108);
            this.appointmentReportViewer.Name = "appointmentReportViewer";
            this.appointmentReportViewer.ServerReport.BearerToken = null;
            this.appointmentReportViewer.Size = new System.Drawing.Size(640, 327);
            this.appointmentReportViewer.TabIndex = 6;
            // 
            // AppointmentReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 461);
            this.Controls.Add(this.appointmentReportViewer);
            this.Controls.Add(this.datePicker_To);
            this.Controls.Add(this.datePicker_From);
            this.Controls.Add(this.button_Report);
            this.Controls.Add(this.button_Search);
            this.Controls.Add(this.textBox_Search);
            this.Controls.Add(this.label_To);
            this.Controls.Add(this.label_Or);
            this.Controls.Add(this.comboBox_DoctorName);
            this.Controls.Add(this.label_AppointmentDate);
            this.Controls.Add(this.label_DoctorName);
            this.MaximumSize = new System.Drawing.Size(700, 500);
            this.MinimumSize = new System.Drawing.Size(700, 500);
            this.Name = "AppointmentReportForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AppointmentReportForm";
            this.Load += new System.EventHandler(this.AppointmentReportForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_DoctorName;
        private System.Windows.Forms.ComboBox comboBox_DoctorName;
        private System.Windows.Forms.Label label_Or;
        private System.Windows.Forms.TextBox textBox_Search;
        private System.Windows.Forms.Button button_Search;
        private System.Windows.Forms.Label label_AppointmentDate;
        private System.Windows.Forms.DateTimePicker datePicker_From;
        private System.Windows.Forms.Label label_To;
        private System.Windows.Forms.DateTimePicker datePicker_To;
        private System.Windows.Forms.Button button_Report;
        private Microsoft.Reporting.WinForms.ReportViewer appointmentReportViewer;
    }
}