namespace StudentProject
{
    partial class UserRegistrationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserRegistrationForm));
            UserRegistration_Logout_LinkLabel = new LinkLabel();
            UserRegistration_Heading_Label = new Label();
            UserRegistration_User_GroupBox = new GroupBox();
            UserRegistration_Register_Button = new Button();
            UserRegistration_Password_TextBox = new TextBox();
            UserRegistration_Password_Label = new Label();
            UserRegistration_Username_TextBox = new TextBox();
            UserRegistration_Username_Label = new Label();
            UserRegistration_Exit_LinkLabel = new LinkLabel();
            UserRegistration_User_GroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // UserRegistration_Logout_LinkLabel
            // 
            UserRegistration_Logout_LinkLabel.AutoSize = true;
            UserRegistration_Logout_LinkLabel.LinkBehavior = LinkBehavior.HoverUnderline;
            UserRegistration_Logout_LinkLabel.Location = new Point(15, 9);
            UserRegistration_Logout_LinkLabel.Name = "UserRegistration_Logout_LinkLabel";
            UserRegistration_Logout_LinkLabel.Size = new Size(56, 20);
            UserRegistration_Logout_LinkLabel.TabIndex = 0;
            UserRegistration_Logout_LinkLabel.TabStop = true;
            UserRegistration_Logout_LinkLabel.Text = "Logout";
            UserRegistration_Logout_LinkLabel.LinkClicked += UserRegistration_Logout_LinkLabel_LinkClicked;
            // 
            // UserRegistration_Heading_Label
            // 
            UserRegistration_Heading_Label.AutoSize = true;
            UserRegistration_Heading_Label.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            UserRegistration_Heading_Label.Location = new Point(97, 9);
            UserRegistration_Heading_Label.Name = "UserRegistration_Heading_Label";
            UserRegistration_Heading_Label.Size = new Size(374, 54);
            UserRegistration_Heading_Label.TabIndex = 1;
            UserRegistration_Heading_Label.Text = "Skills International";
            // 
            // UserRegistration_User_GroupBox
            // 
            UserRegistration_User_GroupBox.Controls.Add(UserRegistration_Register_Button);
            UserRegistration_User_GroupBox.Controls.Add(UserRegistration_Password_TextBox);
            UserRegistration_User_GroupBox.Controls.Add(UserRegistration_Password_Label);
            UserRegistration_User_GroupBox.Controls.Add(UserRegistration_Username_TextBox);
            UserRegistration_User_GroupBox.Controls.Add(UserRegistration_Username_Label);
            UserRegistration_User_GroupBox.Location = new Point(15, 66);
            UserRegistration_User_GroupBox.Name = "UserRegistration_User_GroupBox";
            UserRegistration_User_GroupBox.Size = new Size(550, 173);
            UserRegistration_User_GroupBox.TabIndex = 2;
            UserRegistration_User_GroupBox.TabStop = false;
            UserRegistration_User_GroupBox.Text = "User Registration";
            // 
            // UserRegistration_Register_Button
            // 
            UserRegistration_Register_Button.Location = new Point(443, 120);
            UserRegistration_Register_Button.Name = "UserRegistration_Register_Button";
            UserRegistration_Register_Button.Size = new Size(94, 39);
            UserRegistration_Register_Button.TabIndex = 4;
            UserRegistration_Register_Button.Text = "Register";
            UserRegistration_Register_Button.UseVisualStyleBackColor = true;
            UserRegistration_Register_Button.Click += UserRegistration_Register_Button_Click;
            // 
            // UserRegistration_Password_TextBox
            // 
            UserRegistration_Password_TextBox.Location = new Point(118, 78);
            UserRegistration_Password_TextBox.MaxLength = 12;
            UserRegistration_Password_TextBox.Name = "UserRegistration_Password_TextBox";
            UserRegistration_Password_TextBox.Size = new Size(419, 27);
            UserRegistration_Password_TextBox.TabIndex = 3;
            // 
            // UserRegistration_Password_Label
            // 
            UserRegistration_Password_Label.AutoSize = true;
            UserRegistration_Password_Label.Location = new Point(6, 81);
            UserRegistration_Password_Label.Name = "UserRegistration_Password_Label";
            UserRegistration_Password_Label.Size = new Size(70, 20);
            UserRegistration_Password_Label.TabIndex = 2;
            UserRegistration_Password_Label.Text = "Password";
            // 
            // UserRegistration_Username_TextBox
            // 
            UserRegistration_Username_TextBox.Location = new Point(118, 30);
            UserRegistration_Username_TextBox.MaxLength = 10;
            UserRegistration_Username_TextBox.Name = "UserRegistration_Username_TextBox";
            UserRegistration_Username_TextBox.Size = new Size(419, 27);
            UserRegistration_Username_TextBox.TabIndex = 1;
            // 
            // UserRegistration_Username_Label
            // 
            UserRegistration_Username_Label.AutoSize = true;
            UserRegistration_Username_Label.Location = new Point(6, 33);
            UserRegistration_Username_Label.Name = "UserRegistration_Username_Label";
            UserRegistration_Username_Label.Size = new Size(75, 20);
            UserRegistration_Username_Label.TabIndex = 0;
            UserRegistration_Username_Label.Text = "Username";
            // 
            // UserRegistration_Exit_LinkLabel
            // 
            UserRegistration_Exit_LinkLabel.AutoSize = true;
            UserRegistration_Exit_LinkLabel.LinkBehavior = LinkBehavior.HoverUnderline;
            UserRegistration_Exit_LinkLabel.Location = new Point(532, 242);
            UserRegistration_Exit_LinkLabel.Name = "UserRegistration_Exit_LinkLabel";
            UserRegistration_Exit_LinkLabel.Size = new Size(33, 20);
            UserRegistration_Exit_LinkLabel.TabIndex = 3;
            UserRegistration_Exit_LinkLabel.TabStop = true;
            UserRegistration_Exit_LinkLabel.Text = "Exit";
            UserRegistration_Exit_LinkLabel.LinkClicked += UserRegistration_Exit_LinkLabel_LinkClicked;
            // 
            // UserRegistrationForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(579, 271);
            Controls.Add(UserRegistration_Exit_LinkLabel);
            Controls.Add(UserRegistration_User_GroupBox);
            Controls.Add(UserRegistration_Heading_Label);
            Controls.Add(UserRegistration_Logout_LinkLabel);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "UserRegistrationForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "User Registration - Skills International";
            UserRegistration_User_GroupBox.ResumeLayout(false);
            UserRegistration_User_GroupBox.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private LinkLabel UserRegistration_Logout_LinkLabel;
        private Label UserRegistration_Heading_Label;
        private GroupBox UserRegistration_User_GroupBox;
        private TextBox UserRegistration_Username_TextBox;
        private Label UserRegistration_Username_Label;
        private TextBox UserRegistration_Password_TextBox;
        private Label UserRegistration_Password_Label;
        private Button UserRegistration_Register_Button;
        private LinkLabel UserRegistration_Exit_LinkLabel;
    }
}