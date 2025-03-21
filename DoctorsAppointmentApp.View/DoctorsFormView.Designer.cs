namespace DoctorsAppointmentApp.View
{
    partial class DoctorsFormView
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
            this.tabControl_DoctorAppointment = new System.Windows.Forms.TabControl();
            this.tabPage_DoctorPersonalDetails = new System.Windows.Forms.TabPage();
            this.linkLabel_DF_AddNewDoctor = new System.Windows.Forms.LinkLabel();
            this.comboBox_Gender = new System.Windows.Forms.ComboBox();
            this.comboBox_DoctorsList = new System.Windows.Forms.ComboBox();
            this.label_SelectDoctor = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.cB_DoctorsSpecialization = new System.Windows.Forms.ComboBox();
            this.datePicker_DoctorsDOB = new System.Windows.Forms.DateTimePicker();
            this.textBox_ContactNumber = new System.Windows.Forms.TextBox();
            this.label_DoctorContactNumber = new System.Windows.Forms.Label();
            this.textBox_DoctorAddress = new System.Windows.Forms.TextBox();
            this.label_Address = new System.Windows.Forms.Label();
            this.label_Specialization = new System.Windows.Forms.Label();
            this.textBox_Qualification = new System.Windows.Forms.TextBox();
            this.label_Qualification = new System.Windows.Forms.Label();
            this.label_DateOfBirth = new System.Windows.Forms.Label();
            this.label_Gender = new System.Windows.Forms.Label();
            this.textBox_DoctorLastName = new System.Windows.Forms.TextBox();
            this.label_DoctorLastName = new System.Windows.Forms.Label();
            this.textBox_DoctorFirstName = new System.Windows.Forms.TextBox();
            this.label_DoctorFirstName = new System.Windows.Forms.Label();
            this.tabPage_AppointmentDetails = new System.Windows.Forms.TabPage();
            this.dataGrid_AppointmentDetails = new System.Windows.Forms.DataGridView();
            this.datePicker_Appointtab = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl_DoctorAppointment.SuspendLayout();
            this.tabPage_DoctorPersonalDetails.SuspendLayout();
            this.tabPage_AppointmentDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_AppointmentDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl_DoctorAppointment
            // 
            this.tabControl_DoctorAppointment.Controls.Add(this.tabPage_DoctorPersonalDetails);
            this.tabControl_DoctorAppointment.Controls.Add(this.tabPage_AppointmentDetails);
            this.tabControl_DoctorAppointment.Location = new System.Drawing.Point(12, 12);
            this.tabControl_DoctorAppointment.Name = "tabControl_DoctorAppointment";
            this.tabControl_DoctorAppointment.SelectedIndex = 0;
            this.tabControl_DoctorAppointment.Size = new System.Drawing.Size(659, 420);
            this.tabControl_DoctorAppointment.TabIndex = 0;
            this.tabControl_DoctorAppointment.SelectedIndexChanged += new System.EventHandler(this.tabControl_DoctorAppointment_SelectedIndexChanged);
            // 
            // tabPage_DoctorPersonalDetails
            // 
            this.tabPage_DoctorPersonalDetails.Controls.Add(this.linkLabel_DF_AddNewDoctor);
            this.tabPage_DoctorPersonalDetails.Controls.Add(this.comboBox_Gender);
            this.tabPage_DoctorPersonalDetails.Controls.Add(this.comboBox_DoctorsList);
            this.tabPage_DoctorPersonalDetails.Controls.Add(this.label_SelectDoctor);
            this.tabPage_DoctorPersonalDetails.Controls.Add(this.button1);
            this.tabPage_DoctorPersonalDetails.Controls.Add(this.cB_DoctorsSpecialization);
            this.tabPage_DoctorPersonalDetails.Controls.Add(this.datePicker_DoctorsDOB);
            this.tabPage_DoctorPersonalDetails.Controls.Add(this.textBox_ContactNumber);
            this.tabPage_DoctorPersonalDetails.Controls.Add(this.label_DoctorContactNumber);
            this.tabPage_DoctorPersonalDetails.Controls.Add(this.textBox_DoctorAddress);
            this.tabPage_DoctorPersonalDetails.Controls.Add(this.label_Address);
            this.tabPage_DoctorPersonalDetails.Controls.Add(this.label_Specialization);
            this.tabPage_DoctorPersonalDetails.Controls.Add(this.textBox_Qualification);
            this.tabPage_DoctorPersonalDetails.Controls.Add(this.label_Qualification);
            this.tabPage_DoctorPersonalDetails.Controls.Add(this.label_DateOfBirth);
            this.tabPage_DoctorPersonalDetails.Controls.Add(this.label_Gender);
            this.tabPage_DoctorPersonalDetails.Controls.Add(this.textBox_DoctorLastName);
            this.tabPage_DoctorPersonalDetails.Controls.Add(this.label_DoctorLastName);
            this.tabPage_DoctorPersonalDetails.Controls.Add(this.textBox_DoctorFirstName);
            this.tabPage_DoctorPersonalDetails.Controls.Add(this.label_DoctorFirstName);
            this.tabPage_DoctorPersonalDetails.Location = new System.Drawing.Point(4, 22);
            this.tabPage_DoctorPersonalDetails.Name = "tabPage_DoctorPersonalDetails";
            this.tabPage_DoctorPersonalDetails.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_DoctorPersonalDetails.Size = new System.Drawing.Size(651, 394);
            this.tabPage_DoctorPersonalDetails.TabIndex = 0;
            this.tabPage_DoctorPersonalDetails.Text = "Doctor Personal Details";
            this.tabPage_DoctorPersonalDetails.UseVisualStyleBackColor = true;
            // 
            // linkLabel_DF_AddNewDoctor
            // 
            this.linkLabel_DF_AddNewDoctor.AutoSize = true;
            this.linkLabel_DF_AddNewDoctor.Location = new System.Drawing.Point(535, 14);
            this.linkLabel_DF_AddNewDoctor.Name = "linkLabel_DF_AddNewDoctor";
            this.linkLabel_DF_AddNewDoctor.Size = new System.Drawing.Size(86, 13);
            this.linkLabel_DF_AddNewDoctor.TabIndex = 8;
            this.linkLabel_DF_AddNewDoctor.TabStop = true;
            this.linkLabel_DF_AddNewDoctor.Text = "Add New Doctor";
            this.linkLabel_DF_AddNewDoctor.Click += new System.EventHandler(this.linkLabel_DF_AddNewDoctor_Click);
            // 
            // comboBox_Gender
            // 
            this.comboBox_Gender.FormattingEnabled = true;
            this.comboBox_Gender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.comboBox_Gender.Location = new System.Drawing.Point(99, 129);
            this.comboBox_Gender.Name = "comboBox_Gender";
            this.comboBox_Gender.Size = new System.Drawing.Size(124, 21);
            this.comboBox_Gender.TabIndex = 7;
            // 
            // comboBox_DoctorsList
            // 
            this.comboBox_DoctorsList.FormattingEnabled = true;
            this.comboBox_DoctorsList.Location = new System.Drawing.Point(99, 28);
            this.comboBox_DoctorsList.Name = "comboBox_DoctorsList";
            this.comboBox_DoctorsList.Size = new System.Drawing.Size(231, 21);
            this.comboBox_DoctorsList.TabIndex = 7;
            this.comboBox_DoctorsList.SelectedIndexChanged += new System.EventHandler(this.comboBox_DoctorsList_SelectedIndexChanged);
            // 
            // label_SelectDoctor
            // 
            this.label_SelectDoctor.AutoSize = true;
            this.label_SelectDoctor.Location = new System.Drawing.Point(10, 28);
            this.label_SelectDoctor.Name = "label_SelectDoctor";
            this.label_SelectDoctor.Size = new System.Drawing.Size(72, 13);
            this.label_SelectDoctor.TabIndex = 6;
            this.label_SelectDoctor.Text = "Select Doctor";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(259, 275);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 27);
            this.button1.TabIndex = 5;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cB_DoctorsSpecialization
            // 
            this.cB_DoctorsSpecialization.FormattingEnabled = true;
            this.cB_DoctorsSpecialization.Location = new System.Drawing.Point(421, 176);
            this.cB_DoctorsSpecialization.Name = "cB_DoctorsSpecialization";
            this.cB_DoctorsSpecialization.Size = new System.Drawing.Size(142, 21);
            this.cB_DoctorsSpecialization.TabIndex = 4;
            // 
            // datePicker_DoctorsDOB
            // 
            this.datePicker_DoctorsDOB.Location = new System.Drawing.Point(421, 129);
            this.datePicker_DoctorsDOB.MinDate = new System.DateTime(1947, 8, 15, 0, 0, 0, 0);
            this.datePicker_DoctorsDOB.Name = "datePicker_DoctorsDOB";
            this.datePicker_DoctorsDOB.Size = new System.Drawing.Size(200, 20);
            this.datePicker_DoctorsDOB.TabIndex = 3;
            // 
            // textBox_ContactNumber
            // 
            this.textBox_ContactNumber.Location = new System.Drawing.Point(421, 222);
            this.textBox_ContactNumber.Name = "textBox_ContactNumber";
            this.textBox_ContactNumber.Size = new System.Drawing.Size(124, 20);
            this.textBox_ContactNumber.TabIndex = 1;
            this.textBox_ContactNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_ContactNumber_KeyPress);
            // 
            // label_DoctorContactNumber
            // 
            this.label_DoctorContactNumber.AutoSize = true;
            this.label_DoctorContactNumber.Location = new System.Drawing.Point(329, 225);
            this.label_DoctorContactNumber.Name = "label_DoctorContactNumber";
            this.label_DoctorContactNumber.Size = new System.Drawing.Size(84, 13);
            this.label_DoctorContactNumber.TabIndex = 0;
            this.label_DoctorContactNumber.Text = "Contact Number";
            // 
            // textBox_DoctorAddress
            // 
            this.textBox_DoctorAddress.Location = new System.Drawing.Point(99, 219);
            this.textBox_DoctorAddress.Name = "textBox_DoctorAddress";
            this.textBox_DoctorAddress.Size = new System.Drawing.Size(124, 20);
            this.textBox_DoctorAddress.TabIndex = 1;
            // 
            // label_Address
            // 
            this.label_Address.AutoSize = true;
            this.label_Address.Location = new System.Drawing.Point(7, 222);
            this.label_Address.Name = "label_Address";
            this.label_Address.Size = new System.Drawing.Size(45, 13);
            this.label_Address.TabIndex = 0;
            this.label_Address.Text = "Address";
            // 
            // label_Specialization
            // 
            this.label_Specialization.AutoSize = true;
            this.label_Specialization.Location = new System.Drawing.Point(329, 176);
            this.label_Specialization.Name = "label_Specialization";
            this.label_Specialization.Size = new System.Drawing.Size(72, 13);
            this.label_Specialization.TabIndex = 0;
            this.label_Specialization.Text = "Specialization";
            // 
            // textBox_Qualification
            // 
            this.textBox_Qualification.Location = new System.Drawing.Point(99, 170);
            this.textBox_Qualification.Name = "textBox_Qualification";
            this.textBox_Qualification.Size = new System.Drawing.Size(124, 20);
            this.textBox_Qualification.TabIndex = 1;
            // 
            // label_Qualification
            // 
            this.label_Qualification.AutoSize = true;
            this.label_Qualification.Location = new System.Drawing.Point(7, 173);
            this.label_Qualification.Name = "label_Qualification";
            this.label_Qualification.Size = new System.Drawing.Size(65, 13);
            this.label_Qualification.TabIndex = 0;
            this.label_Qualification.Text = "Qualification";
            // 
            // label_DateOfBirth
            // 
            this.label_DateOfBirth.AutoSize = true;
            this.label_DateOfBirth.Location = new System.Drawing.Point(329, 129);
            this.label_DateOfBirth.Name = "label_DateOfBirth";
            this.label_DateOfBirth.Size = new System.Drawing.Size(62, 13);
            this.label_DateOfBirth.TabIndex = 0;
            this.label_DateOfBirth.Text = "DateOfBirth";
            // 
            // label_Gender
            // 
            this.label_Gender.AutoSize = true;
            this.label_Gender.Location = new System.Drawing.Point(7, 129);
            this.label_Gender.Name = "label_Gender";
            this.label_Gender.Size = new System.Drawing.Size(42, 13);
            this.label_Gender.TabIndex = 0;
            this.label_Gender.Text = "Gender";
            // 
            // textBox_DoctorLastName
            // 
            this.textBox_DoctorLastName.Location = new System.Drawing.Point(421, 81);
            this.textBox_DoctorLastName.Name = "textBox_DoctorLastName";
            this.textBox_DoctorLastName.Size = new System.Drawing.Size(124, 20);
            this.textBox_DoctorLastName.TabIndex = 1;
            // 
            // label_DoctorLastName
            // 
            this.label_DoctorLastName.AutoSize = true;
            this.label_DoctorLastName.Location = new System.Drawing.Point(329, 84);
            this.label_DoctorLastName.Name = "label_DoctorLastName";
            this.label_DoctorLastName.Size = new System.Drawing.Size(58, 13);
            this.label_DoctorLastName.TabIndex = 0;
            this.label_DoctorLastName.Text = "Last Name";
            // 
            // textBox_DoctorFirstName
            // 
            this.textBox_DoctorFirstName.Location = new System.Drawing.Point(99, 81);
            this.textBox_DoctorFirstName.Name = "textBox_DoctorFirstName";
            this.textBox_DoctorFirstName.Size = new System.Drawing.Size(124, 20);
            this.textBox_DoctorFirstName.TabIndex = 1;
            // 
            // label_DoctorFirstName
            // 
            this.label_DoctorFirstName.AutoSize = true;
            this.label_DoctorFirstName.Location = new System.Drawing.Point(7, 84);
            this.label_DoctorFirstName.Name = "label_DoctorFirstName";
            this.label_DoctorFirstName.Size = new System.Drawing.Size(57, 13);
            this.label_DoctorFirstName.TabIndex = 0;
            this.label_DoctorFirstName.Text = "First Name";
            // 
            // tabPage_AppointmentDetails
            // 
            this.tabPage_AppointmentDetails.Controls.Add(this.dataGrid_AppointmentDetails);
            this.tabPage_AppointmentDetails.Controls.Add(this.datePicker_Appointtab);
            this.tabPage_AppointmentDetails.Controls.Add(this.label2);
            this.tabPage_AppointmentDetails.Controls.Add(this.label1);
            this.tabPage_AppointmentDetails.Location = new System.Drawing.Point(4, 22);
            this.tabPage_AppointmentDetails.Name = "tabPage_AppointmentDetails";
            this.tabPage_AppointmentDetails.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_AppointmentDetails.Size = new System.Drawing.Size(651, 394);
            this.tabPage_AppointmentDetails.TabIndex = 1;
            this.tabPage_AppointmentDetails.Text = "Appointment Details";
            this.tabPage_AppointmentDetails.UseVisualStyleBackColor = true;
            // 
            // dataGrid_AppointmentDetails
            // 
            this.dataGrid_AppointmentDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid_AppointmentDetails.Location = new System.Drawing.Point(29, 118);
            this.dataGrid_AppointmentDetails.Name = "dataGrid_AppointmentDetails";
            this.dataGrid_AppointmentDetails.Size = new System.Drawing.Size(561, 150);
            this.dataGrid_AppointmentDetails.TabIndex = 2;
            // 
            // datePicker_Appointtab
            // 
            this.datePicker_Appointtab.Location = new System.Drawing.Point(167, 19);
            this.datePicker_Appointtab.Name = "datePicker_Appointtab";
            this.datePicker_Appointtab.Size = new System.Drawing.Size(200, 20);
            this.datePicker_Appointtab.TabIndex = 1;
            this.datePicker_Appointtab.ValueChanged += new System.EventHandler(this.datePicker_Appointtab_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Appointment List";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select Appointment Date";
            // 
            // DoctorsFormView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 461);
            this.Controls.Add(this.tabControl_DoctorAppointment);
            this.MaximumSize = new System.Drawing.Size(700, 500);
            this.MinimumSize = new System.Drawing.Size(700, 500);
            this.Name = "DoctorsFormView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Doctors Details";
            this.tabControl_DoctorAppointment.ResumeLayout(false);
            this.tabPage_DoctorPersonalDetails.ResumeLayout(false);
            this.tabPage_DoctorPersonalDetails.PerformLayout();
            this.tabPage_AppointmentDetails.ResumeLayout(false);
            this.tabPage_AppointmentDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_AppointmentDetails)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl_DoctorAppointment;
        private System.Windows.Forms.TabPage tabPage_DoctorPersonalDetails;
        private System.Windows.Forms.TabPage tabPage_AppointmentDetails;
        private System.Windows.Forms.TextBox textBox_DoctorFirstName;
        private System.Windows.Forms.Label label_DoctorFirstName;
        private System.Windows.Forms.TextBox textBox_DoctorAddress;
        private System.Windows.Forms.Label label_Address;
        private System.Windows.Forms.Label label_Specialization;
        private System.Windows.Forms.TextBox textBox_Qualification;
        private System.Windows.Forms.Label label_Qualification;
        private System.Windows.Forms.Label label_DateOfBirth;
        private System.Windows.Forms.Label label_Gender;
        private System.Windows.Forms.TextBox textBox_DoctorLastName;
        private System.Windows.Forms.Label label_DoctorLastName;
        private System.Windows.Forms.DateTimePicker datePicker_DoctorsDOB;
        private System.Windows.Forms.ComboBox cB_DoctorsSpecialization;
        private System.Windows.Forms.TextBox textBox_ContactNumber;
        private System.Windows.Forms.Label label_DoctorContactNumber;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label_SelectDoctor;
        private System.Windows.Forms.ComboBox comboBox_DoctorsList;
        private System.Windows.Forms.LinkLabel linkLabel_DF_AddNewDoctor;
        private System.Windows.Forms.DataGridView dataGrid_AppointmentDetails;
        private System.Windows.Forms.DateTimePicker datePicker_Appointtab;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox_Gender;
    }
}