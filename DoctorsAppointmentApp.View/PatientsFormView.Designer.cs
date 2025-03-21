namespace DoctorsAppointmentApp.View
{
    partial class PatientsFormView
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
            this.label_PatientId = new System.Windows.Forms.Label();
            this.textBox_PatientId = new System.Windows.Forms.TextBox();
            this.label_PatientFirstName = new System.Windows.Forms.Label();
            this.textBox_PaientFirstName = new System.Windows.Forms.TextBox();
            this.label_PaientLastName = new System.Windows.Forms.Label();
            this.textBox_PaientLastName = new System.Windows.Forms.TextBox();
            this.label_PaientContactNumber = new System.Windows.Forms.Label();
            this.textBox_PatientContactNumber = new System.Windows.Forms.TextBox();
            this.button_SearchPatientForm = new System.Windows.Forms.Button();
            this.dgrid_PatientDetails = new System.Windows.Forms.DataGridView();
            this.comboBox_Gender = new System.Windows.Forms.ComboBox();
            this.datePicker_DoctorsDOB = new System.Windows.Forms.DateTimePicker();
            this.textBox_DoctorAddress = new System.Windows.Forms.TextBox();
            this.label_Address = new System.Windows.Forms.Label();
            this.label_DateOfBirth = new System.Windows.Forms.Label();
            this.label_Gender = new System.Windows.Forms.Label();
            this.button_AddNewPatient = new System.Windows.Forms.Button();
            this.button_SavePatient = new System.Windows.Forms.Button();
            this.PatientId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PatientName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PatientContact = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SelectButton = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_PatientDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // label_PatientId
            // 
            this.label_PatientId.AutoSize = true;
            this.label_PatientId.Location = new System.Drawing.Point(13, 75);
            this.label_PatientId.Name = "label_PatientId";
            this.label_PatientId.Size = new System.Drawing.Size(52, 13);
            this.label_PatientId.TabIndex = 0;
            this.label_PatientId.Text = "Patient Id";
            // 
            // textBox_PatientId
            // 
            this.textBox_PatientId.Location = new System.Drawing.Point(100, 75);
            this.textBox_PatientId.Name = "textBox_PatientId";
            this.textBox_PatientId.Size = new System.Drawing.Size(113, 20);
            this.textBox_PatientId.TabIndex = 1;
            // 
            // label_PatientFirstName
            // 
            this.label_PatientFirstName.AutoSize = true;
            this.label_PatientFirstName.Location = new System.Drawing.Point(245, 75);
            this.label_PatientFirstName.Name = "label_PatientFirstName";
            this.label_PatientFirstName.Size = new System.Drawing.Size(57, 13);
            this.label_PatientFirstName.TabIndex = 0;
            this.label_PatientFirstName.Text = "First Name";
            // 
            // textBox_PaientFirstName
            // 
            this.textBox_PaientFirstName.Location = new System.Drawing.Point(332, 75);
            this.textBox_PaientFirstName.Name = "textBox_PaientFirstName";
            this.textBox_PaientFirstName.Size = new System.Drawing.Size(113, 20);
            this.textBox_PaientFirstName.TabIndex = 1;
            // 
            // label_PaientLastName
            // 
            this.label_PaientLastName.AutoSize = true;
            this.label_PaientLastName.Location = new System.Drawing.Point(13, 120);
            this.label_PaientLastName.Name = "label_PaientLastName";
            this.label_PaientLastName.Size = new System.Drawing.Size(58, 13);
            this.label_PaientLastName.TabIndex = 0;
            this.label_PaientLastName.Text = "Last Name";
            // 
            // textBox_PaientLastName
            // 
            this.textBox_PaientLastName.Location = new System.Drawing.Point(100, 117);
            this.textBox_PaientLastName.Name = "textBox_PaientLastName";
            this.textBox_PaientLastName.Size = new System.Drawing.Size(113, 20);
            this.textBox_PaientLastName.TabIndex = 1;
            // 
            // label_PaientContactNumber
            // 
            this.label_PaientContactNumber.AutoSize = true;
            this.label_PaientContactNumber.Location = new System.Drawing.Point(245, 120);
            this.label_PaientContactNumber.Name = "label_PaientContactNumber";
            this.label_PaientContactNumber.Size = new System.Drawing.Size(84, 13);
            this.label_PaientContactNumber.TabIndex = 0;
            this.label_PaientContactNumber.Text = "Contact Number";
            // 
            // textBox_PatientContactNumber
            // 
            this.textBox_PatientContactNumber.Location = new System.Drawing.Point(332, 117);
            this.textBox_PatientContactNumber.Name = "textBox_PatientContactNumber";
            this.textBox_PatientContactNumber.Size = new System.Drawing.Size(113, 20);
            this.textBox_PatientContactNumber.TabIndex = 1;
            // 
            // button_SearchPatientForm
            // 
            this.button_SearchPatientForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_SearchPatientForm.ForeColor = System.Drawing.Color.RoyalBlue;
            this.button_SearchPatientForm.Location = new System.Drawing.Point(484, 112);
            this.button_SearchPatientForm.Name = "button_SearchPatientForm";
            this.button_SearchPatientForm.Size = new System.Drawing.Size(103, 28);
            this.button_SearchPatientForm.TabIndex = 5;
            this.button_SearchPatientForm.Text = "Search Patient";
            this.button_SearchPatientForm.UseVisualStyleBackColor = true;
            this.button_SearchPatientForm.Click += new System.EventHandler(this.button_SearchPatientForm_Click);
            // 
            // dgrid_PatientDetails
            // 
            this.dgrid_PatientDetails.AllowUserToAddRows = false;
            this.dgrid_PatientDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrid_PatientDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PatientId,
            this.PatientName,
            this.PatientContact,
            this.SelectButton});
            this.dgrid_PatientDetails.Location = new System.Drawing.Point(69, 285);
            this.dgrid_PatientDetails.Name = "dgrid_PatientDetails";
            this.dgrid_PatientDetails.Size = new System.Drawing.Size(485, 150);
            this.dgrid_PatientDetails.TabIndex = 6;
            this.dgrid_PatientDetails.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgrid_PatientDetails_CellClick);
            this.dgrid_PatientDetails.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgrid_PatientDetails_CellDoubleClick);
            // 
            // comboBox_Gender
            // 
            this.comboBox_Gender.FormattingEnabled = true;
            this.comboBox_Gender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.comboBox_Gender.Location = new System.Drawing.Point(100, 167);
            this.comboBox_Gender.Name = "comboBox_Gender";
            this.comboBox_Gender.Size = new System.Drawing.Size(113, 21);
            this.comboBox_Gender.TabIndex = 13;
            // 
            // datePicker_DoctorsDOB
            // 
            this.datePicker_DoctorsDOB.Location = new System.Drawing.Point(332, 168);
            this.datePicker_DoctorsDOB.MinDate = new System.DateTime(1947, 8, 15, 0, 0, 0, 0);
            this.datePicker_DoctorsDOB.Name = "datePicker_DoctorsDOB";
            this.datePicker_DoctorsDOB.Size = new System.Drawing.Size(200, 20);
            this.datePicker_DoctorsDOB.TabIndex = 12;
            // 
            // textBox_DoctorAddress
            // 
            this.textBox_DoctorAddress.Location = new System.Drawing.Point(100, 213);
            this.textBox_DoctorAddress.Name = "textBox_DoctorAddress";
            this.textBox_DoctorAddress.Size = new System.Drawing.Size(169, 20);
            this.textBox_DoctorAddress.TabIndex = 11;
            // 
            // label_Address
            // 
            this.label_Address.AutoSize = true;
            this.label_Address.Location = new System.Drawing.Point(13, 213);
            this.label_Address.Name = "label_Address";
            this.label_Address.Size = new System.Drawing.Size(45, 13);
            this.label_Address.TabIndex = 8;
            this.label_Address.Text = "Address";
            // 
            // label_DateOfBirth
            // 
            this.label_DateOfBirth.AutoSize = true;
            this.label_DateOfBirth.Location = new System.Drawing.Point(245, 170);
            this.label_DateOfBirth.Name = "label_DateOfBirth";
            this.label_DateOfBirth.Size = new System.Drawing.Size(62, 13);
            this.label_DateOfBirth.TabIndex = 9;
            this.label_DateOfBirth.Text = "DateOfBirth";
            // 
            // label_Gender
            // 
            this.label_Gender.AutoSize = true;
            this.label_Gender.Location = new System.Drawing.Point(13, 170);
            this.label_Gender.Name = "label_Gender";
            this.label_Gender.Size = new System.Drawing.Size(42, 13);
            this.label_Gender.TabIndex = 10;
            this.label_Gender.Text = "Gender";
            // 
            // button_AddNewPatient
            // 
            this.button_AddNewPatient.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_AddNewPatient.ForeColor = System.Drawing.Color.RoyalBlue;
            this.button_AddNewPatient.Location = new System.Drawing.Point(571, 8);
            this.button_AddNewPatient.Name = "button_AddNewPatient";
            this.button_AddNewPatient.Size = new System.Drawing.Size(111, 28);
            this.button_AddNewPatient.TabIndex = 5;
            this.button_AddNewPatient.Text = "Add New Patient";
            this.button_AddNewPatient.UseVisualStyleBackColor = true;
            this.button_AddNewPatient.Click += new System.EventHandler(this.button_AddNewPatient_Click);
            // 
            // button_SavePatient
            // 
            this.button_SavePatient.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_SavePatient.ForeColor = System.Drawing.Color.RoyalBlue;
            this.button_SavePatient.Location = new System.Drawing.Point(484, 236);
            this.button_SavePatient.Name = "button_SavePatient";
            this.button_SavePatient.Size = new System.Drawing.Size(103, 28);
            this.button_SavePatient.TabIndex = 5;
            this.button_SavePatient.Text = "Save";
            this.button_SavePatient.UseVisualStyleBackColor = true;
            this.button_SavePatient.Click += new System.EventHandler(this.button_SavePatient_Click);
            // 
            // PatientId
            // 
            this.PatientId.DataPropertyName = "PatientId";
            this.PatientId.HeaderText = "Patient Id";
            this.PatientId.Name = "PatientId";
            this.PatientId.Width = 120;
            // 
            // PatientName
            // 
            this.PatientName.DataPropertyName = "FullName";
            this.PatientName.HeaderText = "Patient Name";
            this.PatientName.Name = "PatientName";
            this.PatientName.Width = 160;
            // 
            // PatientContact
            // 
            this.PatientContact.DataPropertyName = "ContactNumber";
            this.PatientContact.HeaderText = "Contact Number";
            this.PatientContact.Name = "PatientContact";
            this.PatientContact.Width = 160;
            // 
            // SelectButton
            // 
            this.SelectButton.HeaderText = "";
            this.SelectButton.Name = "SelectButton";
            this.SelectButton.Text = "Select";
            this.SelectButton.UseColumnTextForButtonValue = true;
            // 
            // PatientsFormView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 461);
            this.Controls.Add(this.comboBox_Gender);
            this.Controls.Add(this.datePicker_DoctorsDOB);
            this.Controls.Add(this.textBox_DoctorAddress);
            this.Controls.Add(this.label_Address);
            this.Controls.Add(this.label_DateOfBirth);
            this.Controls.Add(this.label_Gender);
            this.Controls.Add(this.dgrid_PatientDetails);
            this.Controls.Add(this.button_AddNewPatient);
            this.Controls.Add(this.button_SavePatient);
            this.Controls.Add(this.button_SearchPatientForm);
            this.Controls.Add(this.textBox_PatientContactNumber);
            this.Controls.Add(this.label_PaientContactNumber);
            this.Controls.Add(this.textBox_PaientLastName);
            this.Controls.Add(this.label_PaientLastName);
            this.Controls.Add(this.textBox_PaientFirstName);
            this.Controls.Add(this.label_PatientFirstName);
            this.Controls.Add(this.textBox_PatientId);
            this.Controls.Add(this.label_PatientId);
            this.MaximumSize = new System.Drawing.Size(700, 500);
            this.MinimumSize = new System.Drawing.Size(700, 500);
            this.Name = "PatientsFormView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Patients Details";
            this.Load += new System.EventHandler(this.PatientsFormView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_PatientDetails)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_PatientId;
        private System.Windows.Forms.TextBox textBox_PatientId;
        private System.Windows.Forms.Label label_PatientFirstName;
        private System.Windows.Forms.TextBox textBox_PaientFirstName;
        private System.Windows.Forms.Label label_PaientLastName;
        private System.Windows.Forms.TextBox textBox_PaientLastName;
        private System.Windows.Forms.Label label_PaientContactNumber;
        private System.Windows.Forms.TextBox textBox_PatientContactNumber;
        private System.Windows.Forms.Button button_SearchPatientForm;
        private System.Windows.Forms.DataGridView dgrid_PatientDetails;
        private System.Windows.Forms.ComboBox comboBox_Gender;
        private System.Windows.Forms.DateTimePicker datePicker_DoctorsDOB;
        private System.Windows.Forms.TextBox textBox_DoctorAddress;
        private System.Windows.Forms.Label label_Address;
        private System.Windows.Forms.Label label_DateOfBirth;
        private System.Windows.Forms.Label label_Gender;
        private System.Windows.Forms.Button button_AddNewPatient;
        private System.Windows.Forms.Button button_SavePatient;
        private System.Windows.Forms.DataGridViewTextBoxColumn PatientId;
        private System.Windows.Forms.DataGridViewTextBoxColumn PatientName;
        private System.Windows.Forms.DataGridViewTextBoxColumn PatientContact;
        private System.Windows.Forms.DataGridViewButtonColumn SelectButton;
    }
}