namespace StudentProject
{
    partial class StudentRegistrationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentRegistrationForm));
            RegistrationForm_Heading_Label = new Label();
            RegistrationForm_Logout_LinkLabel = new LinkLabel();
            RegistrationForm_StudentRegistration_GroupBox = new GroupBox();
            RegistrationForm_Clear_Button = new Button();
            RegistrationForm_Delete_Button = new Button();
            RegistrationForm_Update_Button = new Button();
            RegistrationForm_Register_Button = new Button();
            RegistrationForm_ParentDetails_GroupBox = new GroupBox();
            RegistrationForm_ContactNumber_TextBox = new TextBox();
            RegistrationForm_ContactNumber_Label = new Label();
            RegistrationForm_NIC_TextBox = new TextBox();
            RegistrationForm_NIC_Label = new Label();
            RegistrationForm_ParentName_TextBox = new TextBox();
            RegistrationForm_ParentName_Label = new Label();
            RegistrationForm_ContactDetails_GroupBox = new GroupBox();
            RegistrationForm_HomePhone_TextBox = new TextBox();
            RegistrationForm_HomePhone_Label = new Label();
            RegistrationForm_MobilePhone_TextBox = new TextBox();
            RegistrationForm_MobilePhone_Label = new Label();
            RegistrationForm_Address_TextBox = new TextBox();
            RegistrationForm_Email_TextBox = new TextBox();
            RegistrationForm_Email_Label = new Label();
            RegistrationForm_Address_Label = new Label();
            RegistrationForm_BasicDetails_GroupBox = new GroupBox();
            RegistrationForm_GenderFemale_RadioButton = new RadioButton();
            RegistrationForm_GenderMale_RadioButton = new RadioButton();
            RegistrationForm_Gender_Label = new Label();
            RegistrationForm_DateOfBirth_DateTimePicker = new DateTimePicker();
            RegistrationForm_DateOfBirth_Label = new Label();
            RegistrationForm_LastName_TextBox = new TextBox();
            RegistrationForm_LastName_Label = new Label();
            RegistrationForm_FirstName_TextBox = new TextBox();
            RegistrationForm_FirstName_Label = new Label();
            RegistrationForm_RegNo_ComboBox = new ComboBox();
            RegistrationForm_RegNo_Label = new Label();
            RegistrationForm_Exit_LinkLabel = new LinkLabel();
            RegistrationForm_StudentRegistration_GroupBox.SuspendLayout();
            RegistrationForm_ParentDetails_GroupBox.SuspendLayout();
            RegistrationForm_ContactDetails_GroupBox.SuspendLayout();
            RegistrationForm_BasicDetails_GroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // RegistrationForm_Heading_Label
            // 
            RegistrationForm_Heading_Label.AutoSize = true;
            RegistrationForm_Heading_Label.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            RegistrationForm_Heading_Label.Location = new Point(138, 9);
            RegistrationForm_Heading_Label.Name = "RegistrationForm_Heading_Label";
            RegistrationForm_Heading_Label.Size = new Size(374, 54);
            RegistrationForm_Heading_Label.TabIndex = 0;
            RegistrationForm_Heading_Label.Text = "Skills International";
            // 
            // RegistrationForm_Logout_LinkLabel
            // 
            RegistrationForm_Logout_LinkLabel.AutoSize = true;
            RegistrationForm_Logout_LinkLabel.LinkBehavior = LinkBehavior.HoverUnderline;
            RegistrationForm_Logout_LinkLabel.Location = new Point(12, 9);
            RegistrationForm_Logout_LinkLabel.Name = "RegistrationForm_Logout_LinkLabel";
            RegistrationForm_Logout_LinkLabel.Size = new Size(56, 20);
            RegistrationForm_Logout_LinkLabel.TabIndex = 1;
            RegistrationForm_Logout_LinkLabel.TabStop = true;
            RegistrationForm_Logout_LinkLabel.Text = "Logout";
            RegistrationForm_Logout_LinkLabel.LinkClicked += RegistrationForm_Logout_LinkLabel_LinkClicked;
            // 
            // RegistrationForm_StudentRegistration_GroupBox
            // 
            RegistrationForm_StudentRegistration_GroupBox.Controls.Add(RegistrationForm_Clear_Button);
            RegistrationForm_StudentRegistration_GroupBox.Controls.Add(RegistrationForm_Delete_Button);
            RegistrationForm_StudentRegistration_GroupBox.Controls.Add(RegistrationForm_Update_Button);
            RegistrationForm_StudentRegistration_GroupBox.Controls.Add(RegistrationForm_Register_Button);
            RegistrationForm_StudentRegistration_GroupBox.Controls.Add(RegistrationForm_ParentDetails_GroupBox);
            RegistrationForm_StudentRegistration_GroupBox.Controls.Add(RegistrationForm_ContactDetails_GroupBox);
            RegistrationForm_StudentRegistration_GroupBox.Controls.Add(RegistrationForm_BasicDetails_GroupBox);
            RegistrationForm_StudentRegistration_GroupBox.Controls.Add(RegistrationForm_RegNo_ComboBox);
            RegistrationForm_StudentRegistration_GroupBox.Controls.Add(RegistrationForm_RegNo_Label);
            RegistrationForm_StudentRegistration_GroupBox.Location = new Point(12, 65);
            RegistrationForm_StudentRegistration_GroupBox.Name = "RegistrationForm_StudentRegistration_GroupBox";
            RegistrationForm_StudentRegistration_GroupBox.Size = new Size(642, 741);
            RegistrationForm_StudentRegistration_GroupBox.TabIndex = 2;
            RegistrationForm_StudentRegistration_GroupBox.TabStop = false;
            RegistrationForm_StudentRegistration_GroupBox.Text = "Student Registration";
            // 
            // RegistrationForm_Clear_Button
            // 
            RegistrationForm_Clear_Button.Location = new Point(428, 683);
            RegistrationForm_Clear_Button.Name = "RegistrationForm_Clear_Button";
            RegistrationForm_Clear_Button.Size = new Size(94, 39);
            RegistrationForm_Clear_Button.TabIndex = 14;
            RegistrationForm_Clear_Button.Text = "Clear";
            RegistrationForm_Clear_Button.UseVisualStyleBackColor = true;
            RegistrationForm_Clear_Button.Click += RegistrationForm_Clear_Button_Click;
            // 
            // RegistrationForm_Delete_Button
            // 
            RegistrationForm_Delete_Button.Location = new Point(528, 683);
            RegistrationForm_Delete_Button.Name = "RegistrationForm_Delete_Button";
            RegistrationForm_Delete_Button.Size = new Size(94, 39);
            RegistrationForm_Delete_Button.TabIndex = 13;
            RegistrationForm_Delete_Button.Text = "Delete";
            RegistrationForm_Delete_Button.UseVisualStyleBackColor = true;
            RegistrationForm_Delete_Button.Click += RegistrationForm_Delete_Button_Click;
            // 
            // RegistrationForm_Update_Button
            // 
            RegistrationForm_Update_Button.Location = new Point(122, 683);
            RegistrationForm_Update_Button.Name = "RegistrationForm_Update_Button";
            RegistrationForm_Update_Button.Size = new Size(94, 39);
            RegistrationForm_Update_Button.TabIndex = 12;
            RegistrationForm_Update_Button.Text = "Update";
            RegistrationForm_Update_Button.UseVisualStyleBackColor = true;
            RegistrationForm_Update_Button.Click += RegistrationForm_Update_Button_Click;
            // 
            // RegistrationForm_Register_Button
            // 
            RegistrationForm_Register_Button.Location = new Point(22, 683);
            RegistrationForm_Register_Button.Name = "RegistrationForm_Register_Button";
            RegistrationForm_Register_Button.Size = new Size(94, 39);
            RegistrationForm_Register_Button.TabIndex = 11;
            RegistrationForm_Register_Button.Text = "Register";
            RegistrationForm_Register_Button.UseVisualStyleBackColor = true;
            RegistrationForm_Register_Button.Click += RegistrationForm_Register_Button_Click;
            // 
            // RegistrationForm_ParentDetails_GroupBox
            // 
            RegistrationForm_ParentDetails_GroupBox.Controls.Add(RegistrationForm_ContactNumber_TextBox);
            RegistrationForm_ParentDetails_GroupBox.Controls.Add(RegistrationForm_ContactNumber_Label);
            RegistrationForm_ParentDetails_GroupBox.Controls.Add(RegistrationForm_NIC_TextBox);
            RegistrationForm_ParentDetails_GroupBox.Controls.Add(RegistrationForm_NIC_Label);
            RegistrationForm_ParentDetails_GroupBox.Controls.Add(RegistrationForm_ParentName_TextBox);
            RegistrationForm_ParentDetails_GroupBox.Controls.Add(RegistrationForm_ParentName_Label);
            RegistrationForm_ParentDetails_GroupBox.Location = new Point(22, 504);
            RegistrationForm_ParentDetails_GroupBox.Name = "RegistrationForm_ParentDetails_GroupBox";
            RegistrationForm_ParentDetails_GroupBox.Size = new Size(600, 161);
            RegistrationForm_ParentDetails_GroupBox.TabIndex = 10;
            RegistrationForm_ParentDetails_GroupBox.TabStop = false;
            RegistrationForm_ParentDetails_GroupBox.Text = "Parent Details";
            // 
            // RegistrationForm_ContactNumber_TextBox
            // 
            RegistrationForm_ContactNumber_TextBox.Location = new Point(121, 113);
            RegistrationForm_ContactNumber_TextBox.Name = "RegistrationForm_ContactNumber_TextBox";
            RegistrationForm_ContactNumber_TextBox.Size = new Size(208, 27);
            RegistrationForm_ContactNumber_TextBox.TabIndex = 8;
            // 
            // RegistrationForm_ContactNumber_Label
            // 
            RegistrationForm_ContactNumber_Label.AutoSize = true;
            RegistrationForm_ContactNumber_Label.Location = new Point(6, 116);
            RegistrationForm_ContactNumber_Label.Name = "RegistrationForm_ContactNumber_Label";
            RegistrationForm_ContactNumber_Label.Size = new Size(84, 20);
            RegistrationForm_ContactNumber_Label.TabIndex = 7;
            RegistrationForm_ContactNumber_Label.Text = "Contact No";
            // 
            // RegistrationForm_NIC_TextBox
            // 
            RegistrationForm_NIC_TextBox.Location = new Point(120, 69);
            RegistrationForm_NIC_TextBox.Name = "RegistrationForm_NIC_TextBox";
            RegistrationForm_NIC_TextBox.Size = new Size(208, 27);
            RegistrationForm_NIC_TextBox.TabIndex = 6;
            // 
            // RegistrationForm_NIC_Label
            // 
            RegistrationForm_NIC_Label.AutoSize = true;
            RegistrationForm_NIC_Label.Location = new Point(6, 72);
            RegistrationForm_NIC_Label.Name = "RegistrationForm_NIC_Label";
            RegistrationForm_NIC_Label.Size = new Size(33, 20);
            RegistrationForm_NIC_Label.TabIndex = 5;
            RegistrationForm_NIC_Label.Text = "NIC";
            // 
            // RegistrationForm_ParentName_TextBox
            // 
            RegistrationForm_ParentName_TextBox.Location = new Point(120, 26);
            RegistrationForm_ParentName_TextBox.Name = "RegistrationForm_ParentName_TextBox";
            RegistrationForm_ParentName_TextBox.Size = new Size(459, 27);
            RegistrationForm_ParentName_TextBox.TabIndex = 3;
            // 
            // RegistrationForm_ParentName_Label
            // 
            RegistrationForm_ParentName_Label.AutoSize = true;
            RegistrationForm_ParentName_Label.Location = new Point(6, 29);
            RegistrationForm_ParentName_Label.Name = "RegistrationForm_ParentName_Label";
            RegistrationForm_ParentName_Label.Size = new Size(94, 20);
            RegistrationForm_ParentName_Label.TabIndex = 2;
            RegistrationForm_ParentName_Label.Text = "Parent Name";
            // 
            // RegistrationForm_ContactDetails_GroupBox
            // 
            RegistrationForm_ContactDetails_GroupBox.Controls.Add(RegistrationForm_HomePhone_TextBox);
            RegistrationForm_ContactDetails_GroupBox.Controls.Add(RegistrationForm_HomePhone_Label);
            RegistrationForm_ContactDetails_GroupBox.Controls.Add(RegistrationForm_MobilePhone_TextBox);
            RegistrationForm_ContactDetails_GroupBox.Controls.Add(RegistrationForm_MobilePhone_Label);
            RegistrationForm_ContactDetails_GroupBox.Controls.Add(RegistrationForm_Address_TextBox);
            RegistrationForm_ContactDetails_GroupBox.Controls.Add(RegistrationForm_Email_TextBox);
            RegistrationForm_ContactDetails_GroupBox.Controls.Add(RegistrationForm_Email_Label);
            RegistrationForm_ContactDetails_GroupBox.Controls.Add(RegistrationForm_Address_Label);
            RegistrationForm_ContactDetails_GroupBox.Location = new Point(22, 278);
            RegistrationForm_ContactDetails_GroupBox.Name = "RegistrationForm_ContactDetails_GroupBox";
            RegistrationForm_ContactDetails_GroupBox.Size = new Size(600, 220);
            RegistrationForm_ContactDetails_GroupBox.TabIndex = 9;
            RegistrationForm_ContactDetails_GroupBox.TabStop = false;
            RegistrationForm_ContactDetails_GroupBox.Text = "Contact Details";
            // 
            // RegistrationForm_HomePhone_TextBox
            // 
            RegistrationForm_HomePhone_TextBox.Location = new Point(442, 173);
            RegistrationForm_HomePhone_TextBox.Name = "RegistrationForm_HomePhone_TextBox";
            RegistrationForm_HomePhone_TextBox.Size = new Size(137, 27);
            RegistrationForm_HomePhone_TextBox.TabIndex = 8;
            // 
            // RegistrationForm_HomePhone_Label
            // 
            RegistrationForm_HomePhone_Label.AutoSize = true;
            RegistrationForm_HomePhone_Label.Location = new Point(328, 176);
            RegistrationForm_HomePhone_Label.Name = "RegistrationForm_HomePhone_Label";
            RegistrationForm_HomePhone_Label.Size = new Size(95, 20);
            RegistrationForm_HomePhone_Label.TabIndex = 7;
            RegistrationForm_HomePhone_Label.Text = "Home Phone";
            // 
            // RegistrationForm_MobilePhone_TextBox
            // 
            RegistrationForm_MobilePhone_TextBox.Location = new Point(120, 170);
            RegistrationForm_MobilePhone_TextBox.Name = "RegistrationForm_MobilePhone_TextBox";
            RegistrationForm_MobilePhone_TextBox.Size = new Size(137, 27);
            RegistrationForm_MobilePhone_TextBox.TabIndex = 6;
            // 
            // RegistrationForm_MobilePhone_Label
            // 
            RegistrationForm_MobilePhone_Label.AutoSize = true;
            RegistrationForm_MobilePhone_Label.Location = new Point(6, 173);
            RegistrationForm_MobilePhone_Label.Name = "RegistrationForm_MobilePhone_Label";
            RegistrationForm_MobilePhone_Label.Size = new Size(101, 20);
            RegistrationForm_MobilePhone_Label.TabIndex = 5;
            RegistrationForm_MobilePhone_Label.Text = "Mobile Phone";
            // 
            // RegistrationForm_Address_TextBox
            // 
            RegistrationForm_Address_TextBox.Location = new Point(120, 26);
            RegistrationForm_Address_TextBox.Multiline = true;
            RegistrationForm_Address_TextBox.Name = "RegistrationForm_Address_TextBox";
            RegistrationForm_Address_TextBox.Size = new Size(459, 82);
            RegistrationForm_Address_TextBox.TabIndex = 4;
            // 
            // RegistrationForm_Email_TextBox
            // 
            RegistrationForm_Email_TextBox.Location = new Point(120, 124);
            RegistrationForm_Email_TextBox.Name = "RegistrationForm_Email_TextBox";
            RegistrationForm_Email_TextBox.Size = new Size(459, 27);
            RegistrationForm_Email_TextBox.TabIndex = 3;
            // 
            // RegistrationForm_Email_Label
            // 
            RegistrationForm_Email_Label.AutoSize = true;
            RegistrationForm_Email_Label.Location = new Point(6, 131);
            RegistrationForm_Email_Label.Name = "RegistrationForm_Email_Label";
            RegistrationForm_Email_Label.Size = new Size(46, 20);
            RegistrationForm_Email_Label.TabIndex = 2;
            RegistrationForm_Email_Label.Text = "Email";
            // 
            // RegistrationForm_Address_Label
            // 
            RegistrationForm_Address_Label.AutoSize = true;
            RegistrationForm_Address_Label.Location = new Point(6, 29);
            RegistrationForm_Address_Label.Name = "RegistrationForm_Address_Label";
            RegistrationForm_Address_Label.Size = new Size(62, 20);
            RegistrationForm_Address_Label.TabIndex = 0;
            RegistrationForm_Address_Label.Text = "Address";
            // 
            // RegistrationForm_BasicDetails_GroupBox
            // 
            RegistrationForm_BasicDetails_GroupBox.Controls.Add(RegistrationForm_GenderFemale_RadioButton);
            RegistrationForm_BasicDetails_GroupBox.Controls.Add(RegistrationForm_GenderMale_RadioButton);
            RegistrationForm_BasicDetails_GroupBox.Controls.Add(RegistrationForm_Gender_Label);
            RegistrationForm_BasicDetails_GroupBox.Controls.Add(RegistrationForm_DateOfBirth_DateTimePicker);
            RegistrationForm_BasicDetails_GroupBox.Controls.Add(RegistrationForm_DateOfBirth_Label);
            RegistrationForm_BasicDetails_GroupBox.Controls.Add(RegistrationForm_LastName_TextBox);
            RegistrationForm_BasicDetails_GroupBox.Controls.Add(RegistrationForm_LastName_Label);
            RegistrationForm_BasicDetails_GroupBox.Controls.Add(RegistrationForm_FirstName_TextBox);
            RegistrationForm_BasicDetails_GroupBox.Controls.Add(RegistrationForm_FirstName_Label);
            RegistrationForm_BasicDetails_GroupBox.Location = new Point(22, 76);
            RegistrationForm_BasicDetails_GroupBox.Name = "RegistrationForm_BasicDetails_GroupBox";
            RegistrationForm_BasicDetails_GroupBox.Size = new Size(600, 196);
            RegistrationForm_BasicDetails_GroupBox.TabIndex = 2;
            RegistrationForm_BasicDetails_GroupBox.TabStop = false;
            RegistrationForm_BasicDetails_GroupBox.Text = "Basic Details";
            // 
            // RegistrationForm_GenderFemale_RadioButton
            // 
            RegistrationForm_GenderFemale_RadioButton.AutoSize = true;
            RegistrationForm_GenderFemale_RadioButton.Location = new Point(250, 157);
            RegistrationForm_GenderFemale_RadioButton.Name = "RegistrationForm_GenderFemale_RadioButton";
            RegistrationForm_GenderFemale_RadioButton.Size = new Size(78, 24);
            RegistrationForm_GenderFemale_RadioButton.TabIndex = 8;
            RegistrationForm_GenderFemale_RadioButton.Text = "Female";
            RegistrationForm_GenderFemale_RadioButton.UseVisualStyleBackColor = true;
            // 
            // RegistrationForm_GenderMale_RadioButton
            // 
            RegistrationForm_GenderMale_RadioButton.AutoSize = true;
            RegistrationForm_GenderMale_RadioButton.Checked = true;
            RegistrationForm_GenderMale_RadioButton.Location = new Point(120, 157);
            RegistrationForm_GenderMale_RadioButton.Name = "RegistrationForm_GenderMale_RadioButton";
            RegistrationForm_GenderMale_RadioButton.Size = new Size(63, 24);
            RegistrationForm_GenderMale_RadioButton.TabIndex = 7;
            RegistrationForm_GenderMale_RadioButton.TabStop = true;
            RegistrationForm_GenderMale_RadioButton.Text = "Male";
            RegistrationForm_GenderMale_RadioButton.UseVisualStyleBackColor = true;
            // 
            // RegistrationForm_Gender_Label
            // 
            RegistrationForm_Gender_Label.AutoSize = true;
            RegistrationForm_Gender_Label.Location = new Point(6, 159);
            RegistrationForm_Gender_Label.Name = "RegistrationForm_Gender_Label";
            RegistrationForm_Gender_Label.Size = new Size(57, 20);
            RegistrationForm_Gender_Label.TabIndex = 6;
            RegistrationForm_Gender_Label.Text = "Gender";
            // 
            // RegistrationForm_DateOfBirth_DateTimePicker
            // 
            RegistrationForm_DateOfBirth_DateTimePicker.Format = DateTimePickerFormat.Short;
            RegistrationForm_DateOfBirth_DateTimePicker.Location = new Point(120, 113);
            RegistrationForm_DateOfBirth_DateTimePicker.Name = "RegistrationForm_DateOfBirth_DateTimePicker";
            RegistrationForm_DateOfBirth_DateTimePicker.Size = new Size(208, 27);
            RegistrationForm_DateOfBirth_DateTimePicker.TabIndex = 5;
            // 
            // RegistrationForm_DateOfBirth_Label
            // 
            RegistrationForm_DateOfBirth_Label.AutoSize = true;
            RegistrationForm_DateOfBirth_Label.Location = new Point(6, 118);
            RegistrationForm_DateOfBirth_Label.Name = "RegistrationForm_DateOfBirth_Label";
            RegistrationForm_DateOfBirth_Label.Size = new Size(94, 20);
            RegistrationForm_DateOfBirth_Label.TabIndex = 4;
            RegistrationForm_DateOfBirth_Label.Text = "Date of Birth";
            // 
            // RegistrationForm_LastName_TextBox
            // 
            RegistrationForm_LastName_TextBox.Location = new Point(120, 68);
            RegistrationForm_LastName_TextBox.Name = "RegistrationForm_LastName_TextBox";
            RegistrationForm_LastName_TextBox.Size = new Size(459, 27);
            RegistrationForm_LastName_TextBox.TabIndex = 3;
            // 
            // RegistrationForm_LastName_Label
            // 
            RegistrationForm_LastName_Label.AutoSize = true;
            RegistrationForm_LastName_Label.Location = new Point(6, 71);
            RegistrationForm_LastName_Label.Name = "RegistrationForm_LastName_Label";
            RegistrationForm_LastName_Label.Size = new Size(79, 20);
            RegistrationForm_LastName_Label.TabIndex = 2;
            RegistrationForm_LastName_Label.Text = "Last Name";
            // 
            // RegistrationForm_FirstName_TextBox
            // 
            RegistrationForm_FirstName_TextBox.Location = new Point(120, 26);
            RegistrationForm_FirstName_TextBox.Name = "RegistrationForm_FirstName_TextBox";
            RegistrationForm_FirstName_TextBox.Size = new Size(459, 27);
            RegistrationForm_FirstName_TextBox.TabIndex = 1;
            // 
            // RegistrationForm_FirstName_Label
            // 
            RegistrationForm_FirstName_Label.AutoSize = true;
            RegistrationForm_FirstName_Label.Location = new Point(6, 29);
            RegistrationForm_FirstName_Label.Name = "RegistrationForm_FirstName_Label";
            RegistrationForm_FirstName_Label.Size = new Size(80, 20);
            RegistrationForm_FirstName_Label.TabIndex = 0;
            RegistrationForm_FirstName_Label.Text = "First Name";
            // 
            // RegistrationForm_RegNo_ComboBox
            // 
            RegistrationForm_RegNo_ComboBox.FormattingEnabled = true;
            RegistrationForm_RegNo_ComboBox.Location = new Point(142, 36);
            RegistrationForm_RegNo_ComboBox.Name = "RegistrationForm_RegNo_ComboBox";
            RegistrationForm_RegNo_ComboBox.Size = new Size(208, 28);
            RegistrationForm_RegNo_ComboBox.TabIndex = 1;
            RegistrationForm_RegNo_ComboBox.SelectedIndexChanged += RegistrationForm_RegNo_ComboBox_SelectedIndexChanged;
            // 
            // RegistrationForm_RegNo_Label
            // 
            RegistrationForm_RegNo_Label.AutoSize = true;
            RegistrationForm_RegNo_Label.Location = new Point(28, 36);
            RegistrationForm_RegNo_Label.Name = "RegistrationForm_RegNo_Label";
            RegistrationForm_RegNo_Label.Size = new Size(59, 20);
            RegistrationForm_RegNo_Label.TabIndex = 0;
            RegistrationForm_RegNo_Label.Text = "Reg No";
            // 
            // RegistrationForm_Exit_LinkLabel
            // 
            RegistrationForm_Exit_LinkLabel.AutoSize = true;
            RegistrationForm_Exit_LinkLabel.LinkBehavior = LinkBehavior.HoverUnderline;
            RegistrationForm_Exit_LinkLabel.Location = new Point(598, 813);
            RegistrationForm_Exit_LinkLabel.Name = "RegistrationForm_Exit_LinkLabel";
            RegistrationForm_Exit_LinkLabel.Size = new Size(33, 20);
            RegistrationForm_Exit_LinkLabel.TabIndex = 3;
            RegistrationForm_Exit_LinkLabel.TabStop = true;
            RegistrationForm_Exit_LinkLabel.Text = "Exit";
            RegistrationForm_Exit_LinkLabel.LinkClicked += RegistrationForm_Exit_LinkLabel_LinkClicked;
            // 
            // RegistrationForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(666, 842);
            Controls.Add(RegistrationForm_Exit_LinkLabel);
            Controls.Add(RegistrationForm_StudentRegistration_GroupBox);
            Controls.Add(RegistrationForm_Logout_LinkLabel);
            Controls.Add(RegistrationForm_Heading_Label);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "RegistrationForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Student Registration - Skills International";
            RegistrationForm_StudentRegistration_GroupBox.ResumeLayout(false);
            RegistrationForm_StudentRegistration_GroupBox.PerformLayout();
            RegistrationForm_ParentDetails_GroupBox.ResumeLayout(false);
            RegistrationForm_ParentDetails_GroupBox.PerformLayout();
            RegistrationForm_ContactDetails_GroupBox.ResumeLayout(false);
            RegistrationForm_ContactDetails_GroupBox.PerformLayout();
            RegistrationForm_BasicDetails_GroupBox.ResumeLayout(false);
            RegistrationForm_BasicDetails_GroupBox.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label RegistrationForm_Heading_Label;
        private LinkLabel RegistrationForm_Logout_LinkLabel;
        private GroupBox RegistrationForm_StudentRegistration_GroupBox;
        private Label RegistrationForm_RegNo_Label;
        private GroupBox RegistrationForm_BasicDetails_GroupBox;
        private ComboBox RegistrationForm_RegNo_ComboBox;
        private Label RegistrationForm_FirstName_Label;
        private TextBox RegistrationForm_FirstName_TextBox;
        private TextBox RegistrationForm_LastName_TextBox;
        private Label RegistrationForm_LastName_Label;
        private Label RegistrationForm_DateOfBirth_Label;
        private DateTimePicker RegistrationForm_DateOfBirth_DateTimePicker;
        private RadioButton RegistrationForm_GenderFemale_RadioButton;
        private RadioButton RegistrationForm_GenderMale_RadioButton;
        private Label RegistrationForm_Gender_Label;
        private GroupBox RegistrationForm_ContactDetails_GroupBox;
        private TextBox RegistrationForm_Email_TextBox;
        private Label RegistrationForm_Email_Label;
        private Label RegistrationForm_Address_Label;
        private TextBox RegistrationForm_Address_TextBox;
        private Label RegistrationForm_MobilePhone_Label;
        private TextBox RegistrationForm_HomePhone_TextBox;
        private Label RegistrationForm_HomePhone_Label;
        private TextBox RegistrationForm_MobilePhone_TextBox;
        private GroupBox RegistrationForm_ParentDetails_GroupBox;
        private TextBox RegistrationForm_ContactNumber_TextBox;
        private Label RegistrationForm_ContactNumber_Label;
        private TextBox RegistrationForm_NIC_TextBox;
        private Label RegistrationForm_NIC_Label;
        private TextBox RegistrationForm_ParentName_TextBox;
        private Label RegistrationForm_ParentName_Label;
        private Button RegistrationForm_Clear_Button;
        private Button RegistrationForm_Delete_Button;
        private Button RegistrationForm_Update_Button;
        private Button RegistrationForm_Register_Button;
        private LinkLabel RegistrationForm_Exit_LinkLabel;
    }
}