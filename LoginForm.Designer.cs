namespace StudentProject
{
    partial class LoginForm : Form
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            LoginForm_Logi_PictureBox = new PictureBox();
            LoginForm_Heading_Label = new Label();
            LoginForm_Login_GroupBox = new GroupBox();
            LoginForm_Login_Button = new Button();
            LoginForm_Clear_Button = new Button();
            LoginForm_Password_Textbox = new TextBox();
            LoginForm_Username_Textbox = new TextBox();
            LoginForm_Password_Label = new Label();
            LoginForm_Username_Label = new Label();
            LoginForm_Exit_Button = new Button();
            ((System.ComponentModel.ISupportInitialize)LoginForm_Logi_PictureBox).BeginInit();
            LoginForm_Login_GroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // LoginForm_Logi_PictureBox
            // 
            LoginForm_Logi_PictureBox.Image = Properties.Resources.Skills;
            LoginForm_Logi_PictureBox.Location = new Point(178, 12);
            LoginForm_Logi_PictureBox.Name = "LoginForm_Logi_PictureBox";
            LoginForm_Logi_PictureBox.Size = new Size(186, 135);
            LoginForm_Logi_PictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            LoginForm_Logi_PictureBox.TabIndex = 0;
            LoginForm_Logi_PictureBox.TabStop = false;
            // 
            // LoginForm_Heading_Label
            // 
            LoginForm_Heading_Label.AutoSize = true;
            LoginForm_Heading_Label.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            LoginForm_Heading_Label.Location = new Point(80, 154);
            LoginForm_Heading_Label.Name = "LoginForm_Heading_Label";
            LoginForm_Heading_Label.Size = new Size(374, 54);
            LoginForm_Heading_Label.TabIndex = 1;
            LoginForm_Heading_Label.Text = "Skills International";
            // 
            // LoginForm_Login_GroupBox
            // 
            LoginForm_Login_GroupBox.Controls.Add(LoginForm_Login_Button);
            LoginForm_Login_GroupBox.Controls.Add(LoginForm_Clear_Button);
            LoginForm_Login_GroupBox.Controls.Add(LoginForm_Password_Textbox);
            LoginForm_Login_GroupBox.Controls.Add(LoginForm_Username_Textbox);
            LoginForm_Login_GroupBox.Controls.Add(LoginForm_Password_Label);
            LoginForm_Login_GroupBox.Controls.Add(LoginForm_Username_Label);
            LoginForm_Login_GroupBox.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            LoginForm_Login_GroupBox.Location = new Point(38, 235);
            LoginForm_Login_GroupBox.Name = "LoginForm_Login_GroupBox";
            LoginForm_Login_GroupBox.Size = new Size(479, 228);
            LoginForm_Login_GroupBox.TabIndex = 2;
            LoginForm_Login_GroupBox.TabStop = false;
            LoginForm_Login_GroupBox.Text = "Login";
            // 
            // LoginForm_Login_Button
            // 
            LoginForm_Login_Button.Location = new Point(343, 157);
            LoginForm_Login_Button.Name = "LoginForm_Login_Button";
            LoginForm_Login_Button.Size = new Size(98, 38);
            LoginForm_Login_Button.TabIndex = 5;
            LoginForm_Login_Button.Text = "Login";
            LoginForm_Login_Button.UseVisualStyleBackColor = true;
            LoginForm_Login_Button.Click += LoginForm_Login_Button_Click;
            // 
            // LoginForm_Clear_Button
            // 
            LoginForm_Clear_Button.Location = new Point(228, 157);
            LoginForm_Clear_Button.Name = "LoginForm_Clear_Button";
            LoginForm_Clear_Button.Size = new Size(98, 38);
            LoginForm_Clear_Button.TabIndex = 4;
            LoginForm_Clear_Button.Text = "Clear";
            LoginForm_Clear_Button.UseVisualStyleBackColor = true;
            LoginForm_Clear_Button.Click += LoginForm_Clear_Button_Click;
            // 
            // LoginForm_Password_Textbox
            // 
            LoginForm_Password_Textbox.Location = new Point(182, 99);
            LoginForm_Password_Textbox.MaxLength = 12;
            LoginForm_Password_Textbox.Name = "LoginForm_Password_Textbox";
            LoginForm_Password_Textbox.Size = new Size(259, 27);
            LoginForm_Password_Textbox.TabIndex = 3;
            // 
            // LoginForm_Username_Textbox
            // 
            LoginForm_Username_Textbox.Location = new Point(182, 50);
            LoginForm_Username_Textbox.MaxLength = 10;
            LoginForm_Username_Textbox.Name = "LoginForm_Username_Textbox";
            LoginForm_Username_Textbox.Size = new Size(259, 27);
            LoginForm_Username_Textbox.TabIndex = 2;
            // 
            // LoginForm_Password_Label
            // 
            LoginForm_Password_Label.AutoSize = true;
            LoginForm_Password_Label.Location = new Point(42, 102);
            LoginForm_Password_Label.Name = "LoginForm_Password_Label";
            LoginForm_Password_Label.Size = new Size(70, 20);
            LoginForm_Password_Label.TabIndex = 1;
            LoginForm_Password_Label.Text = "Password";
            // 
            // LoginForm_Username_Label
            // 
            LoginForm_Username_Label.AutoSize = true;
            LoginForm_Username_Label.Location = new Point(42, 53);
            LoginForm_Username_Label.Name = "LoginForm_Username_Label";
            LoginForm_Username_Label.Size = new Size(75, 20);
            LoginForm_Username_Label.TabIndex = 0;
            LoginForm_Username_Label.Text = "Username";
            // 
            // LoginForm_Exit_Button
            // 
            LoginForm_Exit_Button.Location = new Point(419, 488);
            LoginForm_Exit_Button.Name = "LoginForm_Exit_Button";
            LoginForm_Exit_Button.Size = new Size(98, 38);
            LoginForm_Exit_Button.TabIndex = 6;
            LoginForm_Exit_Button.Text = "Exit";
            LoginForm_Exit_Button.UseVisualStyleBackColor = true;
            LoginForm_Exit_Button.Click += LoginForm_Exit_Button_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(551, 548);
            Controls.Add(LoginForm_Exit_Button);
            Controls.Add(LoginForm_Login_GroupBox);
            Controls.Add(LoginForm_Heading_Label);
            Controls.Add(LoginForm_Logi_PictureBox);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Skills - International";
            ((System.ComponentModel.ISupportInitialize)LoginForm_Logi_PictureBox).EndInit();
            LoginForm_Login_GroupBox.ResumeLayout(false);
            LoginForm_Login_GroupBox.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox LoginForm_Logi_PictureBox;
        private Label LoginForm_Heading_Label;
        private GroupBox LoginForm_Login_GroupBox;
        private Label LoginForm_Password_Label;
        private Label LoginForm_Username_Label;
        private TextBox LoginForm_Password_Textbox;
        private TextBox LoginForm_Username_Textbox;
        private Button LoginForm_Clear_Button;
        private Button LoginForm_Login_Button;
        private Button LoginForm_Exit_Button;
    }
}