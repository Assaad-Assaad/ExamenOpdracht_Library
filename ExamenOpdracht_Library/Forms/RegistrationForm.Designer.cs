namespace ExamenOpdracht_Library.Forms
{
    partial class RegistrationForm
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
            TxtPassword = new TextBox();
            TxtEmail = new TextBox();
            TxtAge = new TextBox();
            TxtLastName = new TextBox();
            LblPassword = new Label();
            LblEmail = new Label();
            LblAge = new Label();
            LblLastName = new Label();
            TxtFirstName = new TextBox();
            LblFirstName = new Label();
            BtnSignUp = new Button();
            SuspendLayout();
            // 
            // TxtPassword
            // 
            TxtPassword.Location = new Point(186, 273);
            TxtPassword.Name = "TxtPassword";
            TxtPassword.PasswordChar = '*';
            TxtPassword.Size = new Size(218, 27);
            TxtPassword.TabIndex = 21;
            // 
            // TxtEmail
            // 
            TxtEmail.Location = new Point(186, 224);
            TxtEmail.Name = "TxtEmail";
            TxtEmail.Size = new Size(218, 27);
            TxtEmail.TabIndex = 20;
            // 
            // TxtAge
            // 
            TxtAge.Location = new Point(187, 170);
            TxtAge.Name = "TxtAge";
            TxtAge.Size = new Size(217, 27);
            TxtAge.TabIndex = 19;
            // 
            // TxtLastName
            // 
            TxtLastName.Location = new Point(187, 125);
            TxtLastName.Name = "TxtLastName";
            TxtLastName.Size = new Size(217, 27);
            TxtLastName.TabIndex = 18;
            // 
            // LblPassword
            // 
            LblPassword.AutoSize = true;
            LblPassword.Location = new Point(95, 280);
            LblPassword.Name = "LblPassword";
            LblPassword.Size = new Size(70, 20);
            LblPassword.TabIndex = 17;
            LblPassword.Text = "Password";
            // 
            // LblEmail
            // 
            LblEmail.AutoSize = true;
            LblEmail.Location = new Point(95, 224);
            LblEmail.Name = "LblEmail";
            LblEmail.Size = new Size(46, 20);
            LblEmail.TabIndex = 16;
            LblEmail.Text = "Email";
            // 
            // LblAge
            // 
            LblAge.AutoSize = true;
            LblAge.Location = new Point(95, 170);
            LblAge.Name = "LblAge";
            LblAge.Size = new Size(36, 20);
            LblAge.TabIndex = 15;
            LblAge.Text = "Age";
            // 
            // LblLastName
            // 
            LblLastName.AutoSize = true;
            LblLastName.Location = new Point(95, 125);
            LblLastName.Name = "LblLastName";
            LblLastName.Size = new Size(79, 20);
            LblLastName.TabIndex = 14;
            LblLastName.Text = "Last Name";
            // 
            // TxtFirstName
            // 
            TxtFirstName.Location = new Point(187, 82);
            TxtFirstName.Name = "TxtFirstName";
            TxtFirstName.Size = new Size(217, 27);
            TxtFirstName.TabIndex = 13;
            // 
            // LblFirstName
            // 
            LblFirstName.AutoSize = true;
            LblFirstName.Location = new Point(95, 82);
            LblFirstName.Name = "LblFirstName";
            LblFirstName.Size = new Size(80, 20);
            LblFirstName.TabIndex = 12;
            LblFirstName.Text = "First Name";
            // 
            // BtnSignUp
            // 
            BtnSignUp.Location = new Point(187, 340);
            BtnSignUp.Name = "BtnSignUp";
            BtnSignUp.Size = new Size(169, 29);
            BtnSignUp.TabIndex = 11;
            BtnSignUp.Text = "Sign up";
            BtnSignUp.UseVisualStyleBackColor = true;
            BtnSignUp.Click += BtnSignUp_Click;
            // 
            // RegistrationForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(493, 450);
            Controls.Add(TxtPassword);
            Controls.Add(TxtEmail);
            Controls.Add(TxtAge);
            Controls.Add(TxtLastName);
            Controls.Add(LblPassword);
            Controls.Add(LblEmail);
            Controls.Add(LblAge);
            Controls.Add(LblLastName);
            Controls.Add(TxtFirstName);
            Controls.Add(LblFirstName);
            Controls.Add(BtnSignUp);
            Name = "RegistrationForm";
            Text = "RegistrationForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TxtPassword;
        private TextBox TxtEmail;
        private TextBox TxtAge;
        private TextBox TxtLastName;
        private Label LblPassword;
        private Label LblEmail;
        private Label LblAge;
        private Label LblLastName;
        private TextBox TxtFirstName;
        private Label LblFirstName;
        private Button BtnSignUp;
    }
}