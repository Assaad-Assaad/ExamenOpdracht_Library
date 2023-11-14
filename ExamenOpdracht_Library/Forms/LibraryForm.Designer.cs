namespace ExamenOpdracht_Library
{
    partial class LibraryForm
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
            components = new System.ComponentModel.Container();
            DgvBooks = new DataGridView();
            TabLibrary = new TabControl();
            TabMembers = new TabPage();
            BtnSignUp = new Button();
            BtnLogIn = new Button();
            TxtPassword = new TextBox();
            LblPassword = new Label();
            TxtEmail = new TextBox();
            LblEmail = new Label();
            TabEvents = new TabPage();
            BtnEventSignIn = new Button();
            TxtEventPassword = new TextBox();
            TxtEventEmail = new TextBox();
            LblEventPassword = new Label();
            LblEventEmail = new Label();
            LblChooseEvent = new Label();
            CboEvents = new ComboBox();
            TabBooks = new TabPage();
            BtnRent = new Button();
            BtnBuy = new Button();
            eventBindingSource1 = new BindingSource(components);
            eventBindingSource = new BindingSource(components);
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)DgvBooks).BeginInit();
            TabLibrary.SuspendLayout();
            TabMembers.SuspendLayout();
            TabEvents.SuspendLayout();
            TabBooks.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)eventBindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)eventBindingSource).BeginInit();
            SuspendLayout();
            // 
            // DgvBooks
            // 
            DgvBooks.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            DgvBooks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvBooks.Location = new Point(3, 155);
            DgvBooks.Name = "DgvBooks";
            DgvBooks.RowHeadersWidth = 51;
            DgvBooks.RowTemplate.Height = 29;
            DgvBooks.Size = new Size(678, 355);
            DgvBooks.TabIndex = 3;
            // 
            // TabLibrary
            // 
            TabLibrary.Controls.Add(TabMembers);
            TabLibrary.Controls.Add(TabEvents);
            TabLibrary.Controls.Add(TabBooks);
            TabLibrary.Dock = DockStyle.Fill;
            TabLibrary.Location = new Point(0, 0);
            TabLibrary.Name = "TabLibrary";
            TabLibrary.SelectedIndex = 0;
            TabLibrary.Size = new Size(898, 551);
            TabLibrary.TabIndex = 0;
            // 
            // TabMembers
            // 
            TabMembers.Controls.Add(BtnSignUp);
            TabMembers.Controls.Add(BtnLogIn);
            TabMembers.Controls.Add(TxtPassword);
            TabMembers.Controls.Add(LblPassword);
            TabMembers.Controls.Add(TxtEmail);
            TabMembers.Controls.Add(LblEmail);
            TabMembers.Location = new Point(4, 29);
            TabMembers.Name = "TabMembers";
            TabMembers.Padding = new Padding(3);
            TabMembers.Size = new Size(890, 518);
            TabMembers.TabIndex = 0;
            TabMembers.Text = "Members";
            TabMembers.UseVisualStyleBackColor = true;
            // 
            // BtnSignUp
            // 
            BtnSignUp.Location = new Point(286, 294);
            BtnSignUp.Name = "BtnSignUp";
            BtnSignUp.Size = new Size(247, 29);
            BtnSignUp.TabIndex = 5;
            BtnSignUp.Text = "Sign Up";
            BtnSignUp.UseVisualStyleBackColor = true;
            BtnSignUp.Click += BtnSignUp_Click;
            // 
            // BtnLogIn
            // 
            BtnLogIn.Location = new Point(288, 241);
            BtnLogIn.Name = "BtnLogIn";
            BtnLogIn.Size = new Size(245, 29);
            BtnLogIn.TabIndex = 4;
            BtnLogIn.Text = "Log In";
            BtnLogIn.UseVisualStyleBackColor = true;
            BtnLogIn.Click += BtnLogIn_Click;
            // 
            // TxtPassword
            // 
            TxtPassword.Location = new Point(288, 197);
            TxtPassword.Name = "TxtPassword";
            TxtPassword.PasswordChar = '*';
            TxtPassword.Size = new Size(245, 27);
            TxtPassword.TabIndex = 3;
            // 
            // LblPassword
            // 
            LblPassword.AutoSize = true;
            LblPassword.Location = new Point(212, 200);
            LblPassword.Name = "LblPassword";
            LblPassword.Size = new Size(70, 20);
            LblPassword.TabIndex = 2;
            LblPassword.Text = "Password";
            // 
            // TxtEmail
            // 
            TxtEmail.Location = new Point(286, 141);
            TxtEmail.Name = "TxtEmail";
            TxtEmail.Size = new Size(247, 27);
            TxtEmail.TabIndex = 1;
            // 
            // LblEmail
            // 
            LblEmail.AutoSize = true;
            LblEmail.Location = new Point(212, 144);
            LblEmail.Name = "LblEmail";
            LblEmail.Size = new Size(46, 20);
            LblEmail.TabIndex = 0;
            LblEmail.Text = "Email";
            // 
            // TabEvents
            // 
            TabEvents.AutoScroll = true;
            TabEvents.Controls.Add(BtnEventSignIn);
            TabEvents.Controls.Add(TxtEventPassword);
            TabEvents.Controls.Add(TxtEventEmail);
            TabEvents.Controls.Add(LblEventPassword);
            TabEvents.Controls.Add(LblEventEmail);
            TabEvents.Controls.Add(LblChooseEvent);
            TabEvents.Controls.Add(CboEvents);
            TabEvents.Location = new Point(4, 29);
            TabEvents.Name = "TabEvents";
            TabEvents.Padding = new Padding(3);
            TabEvents.Size = new Size(890, 518);
            TabEvents.TabIndex = 1;
            TabEvents.Text = "Events";
            TabEvents.UseVisualStyleBackColor = true;
            // 
            // BtnEventSignIn
            // 
            BtnEventSignIn.Location = new Point(211, 242);
            BtnEventSignIn.Name = "BtnEventSignIn";
            BtnEventSignIn.Size = new Size(287, 29);
            BtnEventSignIn.TabIndex = 7;
            BtnEventSignIn.Text = "Sign In";
            BtnEventSignIn.UseVisualStyleBackColor = true;
            BtnEventSignIn.Click += BtnEventSignIn_Click;
            // 
            // TxtEventPassword
            // 
            TxtEventPassword.Location = new Point(211, 196);
            TxtEventPassword.Name = "TxtEventPassword";
            TxtEventPassword.PasswordChar = '*';
            TxtEventPassword.Size = new Size(287, 27);
            TxtEventPassword.TabIndex = 6;
            // 
            // TxtEventEmail
            // 
            TxtEventEmail.Location = new Point(211, 151);
            TxtEventEmail.Name = "TxtEventEmail";
            TxtEventEmail.Size = new Size(287, 27);
            TxtEventEmail.TabIndex = 5;
            // 
            // LblEventPassword
            // 
            LblEventPassword.AutoSize = true;
            LblEventPassword.Location = new Point(111, 203);
            LblEventPassword.Name = "LblEventPassword";
            LblEventPassword.Size = new Size(70, 20);
            LblEventPassword.TabIndex = 4;
            LblEventPassword.Text = "Password";
            // 
            // LblEventEmail
            // 
            LblEventEmail.AutoSize = true;
            LblEventEmail.Location = new Point(111, 158);
            LblEventEmail.Name = "LblEventEmail";
            LblEventEmail.Size = new Size(46, 20);
            LblEventEmail.TabIndex = 3;
            LblEventEmail.Text = "Email";
            // 
            // LblChooseEvent
            // 
            LblChooseEvent.AutoSize = true;
            LblChooseEvent.Location = new Point(174, 33);
            LblChooseEvent.Name = "LblChooseEvent";
            LblChooseEvent.Size = new Size(118, 20);
            LblChooseEvent.TabIndex = 2;
            LblChooseEvent.Text = "Choose an event";
            // 
            // CboEvents
            // 
            CboEvents.FormattingEnabled = true;
            CboEvents.Location = new Point(161, 68);
            CboEvents.Name = "CboEvents";
            CboEvents.Size = new Size(534, 28);
            CboEvents.TabIndex = 1;
            // 
            // TabBooks
            // 
            TabBooks.Controls.Add(label1);
            TabBooks.Controls.Add(DgvBooks);
            TabBooks.Controls.Add(BtnRent);
            TabBooks.Controls.Add(BtnBuy);
            TabBooks.Location = new Point(4, 29);
            TabBooks.Name = "TabBooks";
            TabBooks.Padding = new Padding(3);
            TabBooks.Size = new Size(890, 518);
            TabBooks.TabIndex = 2;
            TabBooks.Text = "Books";
            TabBooks.UseVisualStyleBackColor = true;
            // 
            // BtnRent
            // 
            BtnRent.Location = new Point(687, 337);
            BtnRent.Name = "BtnRent";
            BtnRent.Size = new Size(195, 161);
            BtnRent.TabIndex = 2;
            BtnRent.Text = "Rent";
            BtnRent.UseVisualStyleBackColor = true;
            BtnRent.Click += BtnRent_Click;
            // 
            // BtnBuy
            // 
            BtnBuy.Location = new Point(687, 155);
            BtnBuy.Name = "BtnBuy";
            BtnBuy.Size = new Size(195, 156);
            BtnBuy.TabIndex = 1;
            BtnBuy.Text = "Buy";
            BtnBuy.UseVisualStyleBackColor = true;
            BtnBuy.Click += BtnBuy_Click;
            // 
            // eventBindingSource1
            // 
            eventBindingSource1.DataSource = typeof(Classes.Event);
            // 
            // eventBindingSource
            // 
            eventBindingSource.DataSource = typeof(Classes.Event);
            // 
            // label1
            // 
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Highlight;
            label1.Location = new Point(3, 3);
            label1.Name = "label1";
            label1.Size = new Size(884, 149);
            label1.TabIndex = 4;
            label1.Text = "The Book list";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // LibraryForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(898, 551);
            Controls.Add(TabLibrary);
            IsMdiContainer = true;
            Name = "LibraryForm";
            Text = "LibraryForm";
            Load += LibraryForm_Load;
            ((System.ComponentModel.ISupportInitialize)DgvBooks).EndInit();
            TabLibrary.ResumeLayout(false);
            TabMembers.ResumeLayout(false);
            TabMembers.PerformLayout();
            TabEvents.ResumeLayout(false);
            TabEvents.PerformLayout();
            TabBooks.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)eventBindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)eventBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl TabLibrary;
        private TabPage TabMembers;
        private TabPage TabEvents;
        private TextBox TxtPassword;
        private Label LblPassword;
        private TextBox TxtEmail;
        private Label LblEmail;
        private Button BtnLogIn;
        private Button BtnSignUp;
        private ComboBox CboEvents;
        private TextBox TxtEventPassword;
        private TextBox TxtEventEmail;
        private Label LblEventPassword;
        private Label LblEventEmail;
        private Label LblChooseEvent;
        private Button BtnEventSignIn;
        private BindingSource eventBindingSource;
        private BindingSource eventBindingSource1;
        private TabPage TabBooks;
        private Button BtnRent;
        private Button BtnBuy;
        private DataGridView DgvBooks;
        private Label label1;
    }
}