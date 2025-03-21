namespace DoctorsAppointmentApp.View
{
    partial class MainView
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel_Header = new System.Windows.Forms.Panel();
            this.linkLabel_AppointmentReport = new System.Windows.Forms.LinkLabel();
            this.linkLabel_AddDoctor = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button_SearchDoctor = new System.Windows.Forms.Button();
            this.textBox_LastName = new System.Windows.Forms.TextBox();
            this.textBox_FirstName = new System.Windows.Forms.TextBox();
            this.comboBox_Speciality = new System.Windows.Forms.ComboBox();
            this.specializationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.doctorsAppointmentAppDataSet = new DoctorsAppointmentApp.View.DoctorsAppointmentAppDataSet();
            this.dateTimePicker_ApntDate = new System.Windows.Forms.DateTimePicker();
            this.label_LastName = new System.Windows.Forms.Label();
            this.label_FirstName = new System.Windows.Forms.Label();
            this.label_Speciality = new System.Windows.Forms.Label();
            this.label_Date = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ToTimePicker = new System.Windows.Forms.DateTimePicker();
            this.FromTimePicker = new System.Windows.Forms.DateTimePicker();
            this.button_SearchPatient = new System.Windows.Forms.Button();
            this.textBox_ContactNumber = new System.Windows.Forms.TextBox();
            this.textBox_PatientName = new System.Windows.Forms.TextBox();
            this.label_ContactNumber = new System.Windows.Forms.Label();
            this.label_PatientName = new System.Windows.Forms.Label();
            this.label_ToTime = new System.Windows.Forms.Label();
            this.label_FromTime = new System.Windows.Forms.Label();
            this.button_BookAppointment = new System.Windows.Forms.Button();
            this.label_DoctorList = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dataGrid_DoctorDetails = new System.Windows.Forms.DataGridView();
            this.DoctorsName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Speciality = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ContactNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.specializationTableAdapter = new DoctorsAppointmentApp.View.DoctorsAppointmentAppDataSetTableAdapters.SpecializationTableAdapter();
            this.panel_Header.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.specializationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorsAppointmentAppDataSet)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_DoctorDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_Header
            // 
            this.panel_Header.Controls.Add(this.linkLabel_AppointmentReport);
            this.panel_Header.Controls.Add(this.linkLabel_AddDoctor);
            this.panel_Header.Controls.Add(this.label1);
            this.panel_Header.Location = new System.Drawing.Point(2, 0);
            this.panel_Header.Name = "panel_Header";
            this.panel_Header.Size = new System.Drawing.Size(882, 62);
            this.panel_Header.TabIndex = 0;
            // 
            // linkLabel_AppointmentReport
            // 
            this.linkLabel_AppointmentReport.AutoSize = true;
            this.linkLabel_AppointmentReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel_AppointmentReport.ForeColor = System.Drawing.Color.RoyalBlue;
            this.linkLabel_AppointmentReport.Location = new System.Drawing.Point(733, 41);
            this.linkLabel_AppointmentReport.Name = "linkLabel_AppointmentReport";
            this.linkLabel_AppointmentReport.Size = new System.Drawing.Size(147, 17);
            this.linkLabel_AppointmentReport.TabIndex = 1;
            this.linkLabel_AppointmentReport.TabStop = true;
            this.linkLabel_AppointmentReport.Text = "AppointmentReport";
            this.linkLabel_AppointmentReport.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_AppointmentReport_LinkClicked);
            // 
            // linkLabel_AddDoctor
            // 
            this.linkLabel_AddDoctor.AutoSize = true;
            this.linkLabel_AddDoctor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel_AddDoctor.ForeColor = System.Drawing.Color.RoyalBlue;
            this.linkLabel_AddDoctor.Location = new System.Drawing.Point(603, 41);
            this.linkLabel_AddDoctor.Name = "linkLabel_AddDoctor";
            this.linkLabel_AddDoctor.Size = new System.Drawing.Size(124, 17);
            this.linkLabel_AddDoctor.TabIndex = 1;
            this.linkLabel_AddDoctor.TabStop = true;
            this.linkLabel_AddDoctor.Text = "Add New Doctor";
            this.linkLabel_AddDoctor.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_AddDoctor_LinkClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label1.Location = new System.Drawing.Point(306, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(296, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Doctor\'s Appointment System";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button_SearchDoctor);
            this.panel1.Controls.Add(this.textBox_LastName);
            this.panel1.Controls.Add(this.textBox_FirstName);
            this.panel1.Controls.Add(this.comboBox_Speciality);
            this.panel1.Controls.Add(this.dateTimePicker_ApntDate);
            this.panel1.Controls.Add(this.label_LastName);
            this.panel1.Controls.Add(this.label_FirstName);
            this.panel1.Controls.Add(this.label_Speciality);
            this.panel1.Controls.Add(this.label_Date);
            this.panel1.Location = new System.Drawing.Point(2, 65);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(882, 117);
            this.panel1.TabIndex = 1;
            // 
            // button_SearchDoctor
            // 
            this.button_SearchDoctor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_SearchDoctor.ForeColor = System.Drawing.Color.RoyalBlue;
            this.button_SearchDoctor.Location = new System.Drawing.Point(644, 56);
            this.button_SearchDoctor.Name = "button_SearchDoctor";
            this.button_SearchDoctor.Size = new System.Drawing.Size(117, 35);
            this.button_SearchDoctor.TabIndex = 4;
            this.button_SearchDoctor.Text = "Search Doctor";
            this.button_SearchDoctor.UseVisualStyleBackColor = true;
            this.button_SearchDoctor.Click += new System.EventHandler(this.button_SearchDoctor_Click);
            // 
            // textBox_LastName
            // 
            this.textBox_LastName.Location = new System.Drawing.Point(425, 63);
            this.textBox_LastName.Name = "textBox_LastName";
            this.textBox_LastName.Size = new System.Drawing.Size(162, 20);
            this.textBox_LastName.TabIndex = 3;
            // 
            // textBox_FirstName
            // 
            this.textBox_FirstName.Location = new System.Drawing.Point(98, 67);
            this.textBox_FirstName.Name = "textBox_FirstName";
            this.textBox_FirstName.Size = new System.Drawing.Size(162, 20);
            this.textBox_FirstName.TabIndex = 3;
            // 
            // comboBox_Speciality
            // 
            this.comboBox_Speciality.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.specializationBindingSource, "SpecializationName", true));
            this.comboBox_Speciality.FormattingEnabled = true;
            this.comboBox_Speciality.Location = new System.Drawing.Point(425, 19);
            this.comboBox_Speciality.Name = "comboBox_Speciality";
            this.comboBox_Speciality.Size = new System.Drawing.Size(163, 21);
            this.comboBox_Speciality.TabIndex = 2;
            // 
            // specializationBindingSource
            // 
            this.specializationBindingSource.DataMember = "Specialization";
            this.specializationBindingSource.DataSource = this.doctorsAppointmentAppDataSet;
            // 
            // doctorsAppointmentAppDataSet
            // 
            this.doctorsAppointmentAppDataSet.DataSetName = "DoctorsAppointmentAppDataSet";
            this.doctorsAppointmentAppDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dateTimePicker_ApntDate
            // 
            this.dateTimePicker_ApntDate.Location = new System.Drawing.Point(98, 17);
            this.dateTimePicker_ApntDate.Name = "dateTimePicker_ApntDate";
            this.dateTimePicker_ApntDate.Size = new System.Drawing.Size(197, 20);
            this.dateTimePicker_ApntDate.TabIndex = 1;
            // 
            // label_LastName
            // 
            this.label_LastName.AutoSize = true;
            this.label_LastName.Location = new System.Drawing.Point(356, 70);
            this.label_LastName.Name = "label_LastName";
            this.label_LastName.Size = new System.Drawing.Size(58, 13);
            this.label_LastName.TabIndex = 0;
            this.label_LastName.Text = "Last Name";
            // 
            // label_FirstName
            // 
            this.label_FirstName.AutoSize = true;
            this.label_FirstName.Location = new System.Drawing.Point(11, 70);
            this.label_FirstName.Name = "label_FirstName";
            this.label_FirstName.Size = new System.Drawing.Size(57, 13);
            this.label_FirstName.TabIndex = 0;
            this.label_FirstName.Text = "First Name";
            // 
            // label_Speciality
            // 
            this.label_Speciality.AutoSize = true;
            this.label_Speciality.Location = new System.Drawing.Point(356, 19);
            this.label_Speciality.Name = "label_Speciality";
            this.label_Speciality.Size = new System.Drawing.Size(52, 13);
            this.label_Speciality.TabIndex = 0;
            this.label_Speciality.Text = "Speciality";
            // 
            // label_Date
            // 
            this.label_Date.AutoSize = true;
            this.label_Date.Location = new System.Drawing.Point(11, 19);
            this.label_Date.Name = "label_Date";
            this.label_Date.Size = new System.Drawing.Size(63, 13);
            this.label_Date.TabIndex = 0;
            this.label_Date.Text = "Select Date";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.ToTimePicker);
            this.panel2.Controls.Add(this.FromTimePicker);
            this.panel2.Controls.Add(this.button_SearchPatient);
            this.panel2.Controls.Add(this.textBox_ContactNumber);
            this.panel2.Controls.Add(this.textBox_PatientName);
            this.panel2.Controls.Add(this.label_ContactNumber);
            this.panel2.Controls.Add(this.label_PatientName);
            this.panel2.Controls.Add(this.label_ToTime);
            this.panel2.Controls.Add(this.label_FromTime);
            this.panel2.Location = new System.Drawing.Point(2, 184);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(882, 117);
            this.panel2.TabIndex = 1;
            // 
            // ToTimePicker
            // 
            this.ToTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.ToTimePicker.Location = new System.Drawing.Point(425, 19);
            this.ToTimePicker.Name = "ToTimePicker";
            this.ToTimePicker.ShowUpDown = true;
            this.ToTimePicker.Size = new System.Drawing.Size(200, 20);
            this.ToTimePicker.TabIndex = 5;
            // 
            // FromTimePicker
            // 
            this.FromTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.FromTimePicker.Location = new System.Drawing.Point(98, 19);
            this.FromTimePicker.Name = "FromTimePicker";
            this.FromTimePicker.ShowUpDown = true;
            this.FromTimePicker.Size = new System.Drawing.Size(200, 20);
            this.FromTimePicker.TabIndex = 5;
            this.FromTimePicker.ValueChanged += new System.EventHandler(this.FromTimePicker_ValueChanged);
            // 
            // button_SearchPatient
            // 
            this.button_SearchPatient.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_SearchPatient.ForeColor = System.Drawing.Color.RoyalBlue;
            this.button_SearchPatient.Location = new System.Drawing.Point(644, 56);
            this.button_SearchPatient.Name = "button_SearchPatient";
            this.button_SearchPatient.Size = new System.Drawing.Size(117, 35);
            this.button_SearchPatient.TabIndex = 4;
            this.button_SearchPatient.Text = "Search Patient";
            this.button_SearchPatient.UseVisualStyleBackColor = true;
            this.button_SearchPatient.Click += new System.EventHandler(this.button_SearchPatient_Click);
            // 
            // textBox_ContactNumber
            // 
            this.textBox_ContactNumber.Location = new System.Drawing.Point(447, 65);
            this.textBox_ContactNumber.Name = "textBox_ContactNumber";
            this.textBox_ContactNumber.ReadOnly = true;
            this.textBox_ContactNumber.Size = new System.Drawing.Size(162, 20);
            this.textBox_ContactNumber.TabIndex = 3;
            // 
            // textBox_PatientName
            // 
            this.textBox_PatientName.Location = new System.Drawing.Point(98, 67);
            this.textBox_PatientName.Name = "textBox_PatientName";
            this.textBox_PatientName.ReadOnly = true;
            this.textBox_PatientName.Size = new System.Drawing.Size(200, 20);
            this.textBox_PatientName.TabIndex = 3;
            // 
            // label_ContactNumber
            // 
            this.label_ContactNumber.AutoSize = true;
            this.label_ContactNumber.Location = new System.Drawing.Point(356, 70);
            this.label_ContactNumber.Name = "label_ContactNumber";
            this.label_ContactNumber.Size = new System.Drawing.Size(84, 13);
            this.label_ContactNumber.TabIndex = 0;
            this.label_ContactNumber.Text = "Contact Number";
            // 
            // label_PatientName
            // 
            this.label_PatientName.AutoSize = true;
            this.label_PatientName.Location = new System.Drawing.Point(11, 70);
            this.label_PatientName.Name = "label_PatientName";
            this.label_PatientName.Size = new System.Drawing.Size(71, 13);
            this.label_PatientName.TabIndex = 0;
            this.label_PatientName.Text = "Patient Name";
            // 
            // label_ToTime
            // 
            this.label_ToTime.AutoSize = true;
            this.label_ToTime.Location = new System.Drawing.Point(356, 19);
            this.label_ToTime.Name = "label_ToTime";
            this.label_ToTime.Size = new System.Drawing.Size(46, 13);
            this.label_ToTime.TabIndex = 0;
            this.label_ToTime.Text = "To Time";
            // 
            // label_FromTime
            // 
            this.label_FromTime.AutoSize = true;
            this.label_FromTime.Location = new System.Drawing.Point(11, 19);
            this.label_FromTime.Name = "label_FromTime";
            this.label_FromTime.Size = new System.Drawing.Size(56, 13);
            this.label_FromTime.TabIndex = 0;
            this.label_FromTime.Text = "From Time";
            // 
            // button_BookAppointment
            // 
            this.button_BookAppointment.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_BookAppointment.ForeColor = System.Drawing.Color.RoyalBlue;
            this.button_BookAppointment.Location = new System.Drawing.Point(346, 320);
            this.button_BookAppointment.Name = "button_BookAppointment";
            this.button_BookAppointment.Size = new System.Drawing.Size(180, 35);
            this.button_BookAppointment.TabIndex = 4;
            this.button_BookAppointment.Text = "Book Appointment";
            this.button_BookAppointment.UseVisualStyleBackColor = true;
            this.button_BookAppointment.Click += new System.EventHandler(this.button_BookAppointment_Click);
            // 
            // label_DoctorList
            // 
            this.label_DoctorList.AutoSize = true;
            this.label_DoctorList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_DoctorList.Location = new System.Drawing.Point(16, 374);
            this.label_DoctorList.Name = "label_DoctorList";
            this.label_DoctorList.Size = new System.Drawing.Size(93, 16);
            this.label_DoctorList.TabIndex = 5;
            this.label_DoctorList.Text = "Doctor\'s List";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dataGrid_DoctorDetails);
            this.panel3.Location = new System.Drawing.Point(13, 416);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(857, 228);
            this.panel3.TabIndex = 6;
            // 
            // dataGrid_DoctorDetails
            // 
            this.dataGrid_DoctorDetails.AllowUserToAddRows = false;
            this.dataGrid_DoctorDetails.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGrid_DoctorDetails.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGrid_DoctorDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid_DoctorDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DoctorsName,
            this.Speciality,
            this.ContactNumber});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGrid_DoctorDetails.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGrid_DoctorDetails.Location = new System.Drawing.Point(168, 3);
            this.dataGrid_DoctorDetails.Name = "dataGrid_DoctorDetails";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGrid_DoctorDetails.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGrid_DoctorDetails.Size = new System.Drawing.Size(495, 150);
            this.dataGrid_DoctorDetails.TabIndex = 0;
            this.dataGrid_DoctorDetails.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGrid_DoctorDetails_CellDoubleClick);
            // 
            // DoctorsName
            // 
            this.DoctorsName.DataPropertyName = "DoctorsName";
            this.DoctorsName.HeaderText = "Doctors Name";
            this.DoctorsName.Name = "DoctorsName";
            this.DoctorsName.Width = 150;
            // 
            // Speciality
            // 
            this.Speciality.DataPropertyName = "SpecializationName";
            this.Speciality.HeaderText = "Speciality";
            this.Speciality.Name = "Speciality";
            this.Speciality.Width = 150;
            // 
            // ContactNumber
            // 
            this.ContactNumber.DataPropertyName = "ContactNumber";
            this.ContactNumber.HeaderText = "ContactNumber";
            this.ContactNumber.Name = "ContactNumber";
            this.ContactNumber.Width = 150;
            // 
            // specializationTableAdapter
            // 
            this.specializationTableAdapter.ClearBeforeFill = true;
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(884, 679);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label_DoctorList);
            this.Controls.Add(this.button_BookAppointment);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel_Header);
            this.MaximumSize = new System.Drawing.Size(900, 800);
            this.MinimumSize = new System.Drawing.Size(900, 718);
            this.Name = "MainView";
            this.Text = "Doctor\'s Appointment System";
            this.Load += new System.EventHandler(this.MainView_Load);
            this.panel_Header.ResumeLayout(false);
            this.panel_Header.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.specializationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorsAppointmentAppDataSet)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_DoctorDetails)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel_Header;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel linkLabel_AddDoctor;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox comboBox_Speciality;
        private System.Windows.Forms.DateTimePicker dateTimePicker_ApntDate;
        private System.Windows.Forms.Label label_Speciality;
        private System.Windows.Forms.Label label_Date;
        private System.Windows.Forms.TextBox textBox_LastName;
        private System.Windows.Forms.TextBox textBox_FirstName;
        private System.Windows.Forms.Label label_LastName;
        private System.Windows.Forms.Label label_FirstName;
        private System.Windows.Forms.Button button_SearchDoctor;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button_SearchPatient;
        private System.Windows.Forms.TextBox textBox_ContactNumber;
        private System.Windows.Forms.TextBox textBox_PatientName;
        private System.Windows.Forms.Label label_ContactNumber;
        private System.Windows.Forms.Label label_PatientName;
        private System.Windows.Forms.Label label_ToTime;
        private System.Windows.Forms.Label label_FromTime;
        private System.Windows.Forms.Button button_BookAppointment;
        private System.Windows.Forms.Label label_DoctorList;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dataGrid_DoctorDetails;
        private DoctorsAppointmentAppDataSet doctorsAppointmentAppDataSet;
        private System.Windows.Forms.BindingSource specializationBindingSource;
        private DoctorsAppointmentAppDataSetTableAdapters.SpecializationTableAdapter specializationTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn DoctorsName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Speciality;
        private System.Windows.Forms.DataGridViewTextBoxColumn ContactNumber;
        private System.Windows.Forms.DateTimePicker ToTimePicker;
        private System.Windows.Forms.DateTimePicker FromTimePicker;
        private System.Windows.Forms.LinkLabel linkLabel_AppointmentReport;
    }
}

