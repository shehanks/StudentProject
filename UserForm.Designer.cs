namespace StudentProject
{
    partial class UserForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserForm));
            UserForm_UserRegistration_LinkLabel = new LinkLabel();
            UserForm_UserRegistration_GroupBox = new GroupBox();
            UserForm_UserRegistration_Label = new Label();
            UserForm_StudentRegistration_GroupBox = new GroupBox();
            UserForm_StudentRegistration_Label = new Label();
            UserForm_StudentRegistration_LinkLabel = new LinkLabel();
            UserForm_Exit_LinkLabel = new LinkLabel();
            UserForm_Logout_LinkLabel = new LinkLabel();
            UserForm_Heading_Label = new Label();
            UserForm_UserRegistration_GroupBox.SuspendLayout();
            UserForm_StudentRegistration_GroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // UserForm_UserRegistration_LinkLabel
            // 
            UserForm_UserRegistration_LinkLabel.AutoSize = true;
            UserForm_UserRegistration_LinkLabel.LinkBehavior = LinkBehavior.HoverUnderline;
            UserForm_UserRegistration_LinkLabel.Location = new Point(377, 55);
            UserForm_UserRegistration_LinkLabel.Name = "UserForm_UserRegistration_LinkLabel";
            UserForm_UserRegistration_LinkLabel.Size = new Size(122, 20);
            UserForm_UserRegistration_LinkLabel.TabIndex = 0;
            UserForm_UserRegistration_LinkLabel.TabStop = true;
            UserForm_UserRegistration_LinkLabel.Text = "User Registration";
            UserForm_UserRegistration_LinkLabel.LinkClicked += UserForm_UserRegistration_LinkLabel_LinkClicked;
            // 
            // UserForm_UserRegistration_GroupBox
            // 
            UserForm_UserRegistration_GroupBox.Controls.Add(UserForm_UserRegistration_Label);
            UserForm_UserRegistration_GroupBox.Controls.Add(UserForm_UserRegistration_LinkLabel);
            UserForm_UserRegistration_GroupBox.Location = new Point(12, 66);
            UserForm_UserRegistration_GroupBox.Name = "UserForm_UserRegistration_GroupBox";
            UserForm_UserRegistration_GroupBox.Size = new Size(505, 88);
            UserForm_UserRegistration_GroupBox.TabIndex = 1;
            UserForm_UserRegistration_GroupBox.TabStop = false;
            UserForm_UserRegistration_GroupBox.Text = "User";
            // 
            // UserForm_UserRegistration_Label
            // 
            UserForm_UserRegistration_Label.AutoSize = true;
            UserForm_UserRegistration_Label.Location = new Point(6, 23);
            UserForm_UserRegistration_Label.Name = "UserForm_UserRegistration_Label";
            UserForm_UserRegistration_Label.Size = new Size(406, 20);
            UserForm_UserRegistration_Label.TabIndex = 1;
            UserForm_UserRegistration_Label.Text = "Please proceed here to add a new admin user to the system.";
            // 
            // UserForm_StudentRegistration_GroupBox
            // 
            UserForm_StudentRegistration_GroupBox.Controls.Add(UserForm_StudentRegistration_Label);
            UserForm_StudentRegistration_GroupBox.Controls.Add(UserForm_StudentRegistration_LinkLabel);
            UserForm_StudentRegistration_GroupBox.Location = new Point(12, 160);
            UserForm_StudentRegistration_GroupBox.Name = "UserForm_StudentRegistration_GroupBox";
            UserForm_StudentRegistration_GroupBox.Size = new Size(505, 88);
            UserForm_StudentRegistration_GroupBox.TabIndex = 2;
            UserForm_StudentRegistration_GroupBox.TabStop = false;
            UserForm_StudentRegistration_GroupBox.Text = "Student";
            // 
            // UserForm_StudentRegistration_Label
            // 
            UserForm_StudentRegistration_Label.AutoSize = true;
            UserForm_StudentRegistration_Label.Location = new Point(6, 23);
            UserForm_StudentRegistration_Label.Name = "UserForm_StudentRegistration_Label";
            UserForm_StudentRegistration_Label.Size = new Size(382, 20);
            UserForm_StudentRegistration_Label.TabIndex = 1;
            UserForm_StudentRegistration_Label.Text = "Please proceed here to add a new student to the system.";
            // 
            // UserForm_StudentRegistration_LinkLabel
            // 
            UserForm_StudentRegistration_LinkLabel.AutoSize = true;
            UserForm_StudentRegistration_LinkLabel.LinkBehavior = LinkBehavior.HoverUnderline;
            UserForm_StudentRegistration_LinkLabel.Location = new Point(355, 54);
            UserForm_StudentRegistration_LinkLabel.Name = "UserForm_StudentRegistration_LinkLabel";
            UserForm_StudentRegistration_LinkLabel.Size = new Size(144, 20);
            UserForm_StudentRegistration_LinkLabel.TabIndex = 0;
            UserForm_StudentRegistration_LinkLabel.TabStop = true;
            UserForm_StudentRegistration_LinkLabel.Text = "Student Registration";
            UserForm_StudentRegistration_LinkLabel.LinkClicked += UserForm_StudentRegistration_LinkLabel_LinkClicked;
            // 
            // UserForm_Exit_LinkLabel
            // 
            UserForm_Exit_LinkLabel.AutoSize = true;
            UserForm_Exit_LinkLabel.LinkBehavior = LinkBehavior.HoverUnderline;
            UserForm_Exit_LinkLabel.Location = new Point(484, 251);
            UserForm_Exit_LinkLabel.Name = "UserForm_Exit_LinkLabel";
            UserForm_Exit_LinkLabel.Size = new Size(33, 20);
            UserForm_Exit_LinkLabel.TabIndex = 3;
            UserForm_Exit_LinkLabel.TabStop = true;
            UserForm_Exit_LinkLabel.Text = "Exit";
            UserForm_Exit_LinkLabel.LinkClicked += UserForm_Exit_LinkLabel_LinkClicked;
            // 
            // UserForm_Logout_LinkLabel
            // 
            UserForm_Logout_LinkLabel.AutoSize = true;
            UserForm_Logout_LinkLabel.LinkBehavior = LinkBehavior.HoverUnderline;
            UserForm_Logout_LinkLabel.Location = new Point(12, 9);
            UserForm_Logout_LinkLabel.Name = "UserForm_Logout_LinkLabel";
            UserForm_Logout_LinkLabel.Size = new Size(56, 20);
            UserForm_Logout_LinkLabel.TabIndex = 4;
            UserForm_Logout_LinkLabel.TabStop = true;
            UserForm_Logout_LinkLabel.Text = "Logout";
            UserForm_Logout_LinkLabel.LinkClicked += UserForm_Logout_LinkLabel_LinkClicked;
            // 
            // UserForm_Heading_Label
            // 
            UserForm_Heading_Label.AutoSize = true;
            UserForm_Heading_Label.FlatStyle = FlatStyle.System;
            UserForm_Heading_Label.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            UserForm_Heading_Label.Location = new Point(84, 9);
            UserForm_Heading_Label.Name = "UserForm_Heading_Label";
            UserForm_Heading_Label.Size = new Size(374, 54);
            UserForm_Heading_Label.TabIndex = 5;
            UserForm_Heading_Label.Text = "Skills International";
            // 
            // UserForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(529, 279);
            Controls.Add(UserForm_Heading_Label);
            Controls.Add(UserForm_Logout_LinkLabel);
            Controls.Add(UserForm_Exit_LinkLabel);
            Controls.Add(UserForm_StudentRegistration_GroupBox);
            Controls.Add(UserForm_UserRegistration_GroupBox);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "UserForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "User - Skills International";
            UserForm_UserRegistration_GroupBox.ResumeLayout(false);
            UserForm_UserRegistration_GroupBox.PerformLayout();
            UserForm_StudentRegistration_GroupBox.ResumeLayout(false);
            UserForm_StudentRegistration_GroupBox.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private LinkLabel UserForm_UserRegistration_LinkLabel;
        private GroupBox UserForm_UserRegistration_GroupBox;
        private Label UserForm_UserRegistration_Label;
        private GroupBox UserForm_StudentRegistration_GroupBox;
        private Label UserForm_StudentRegistration_Label;
        private LinkLabel UserForm_StudentRegistration_LinkLabel;
        private LinkLabel UserForm_Exit_LinkLabel;
        private LinkLabel UserForm_Logout_LinkLabel;
        private Label UserForm_Heading_Label;
    }
}