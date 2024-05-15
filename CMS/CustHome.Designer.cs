namespace CMS
{
    partial class CustHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustHome));
            this.PicturePanel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.HomePageButton = new System.Windows.Forms.Button();
            this.BookTicketsButton = new System.Windows.Forms.Button();
            this.ChangePassword = new System.Windows.Forms.Button();
            this.ViewTransactionsButton = new System.Windows.Forms.Button();
            this.ShowtimeButton = new System.Windows.Forms.Button();
            this.NowPlayingButton = new System.Windows.Forms.Button();
            this.CloseButton = new System.Windows.Forms.Button();
            this.SignOutButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.IDLabel = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.custChangePassword1 = new CMS.User_Control.CustChangePassword();
            this.custHomePage1 = new CMS.User_Control.CustHomePage();
            this.nowPlayingUC1 = new CMS.User_Control.NowPlayingUC();
            this.comingSoonUC1 = new CMS.User_Control.ComingSoonUC();
            this.bookTicketsUC2 = new CMS.User_Control.BookTicketsUC();
            this.viewTransactionsUC2 = new CMS.User_Control.ViewTransactionsUC();
            this.PicturePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // PicturePanel
            // 
            this.PicturePanel.BackColor = System.Drawing.Color.SteelBlue;
            this.PicturePanel.Controls.Add(this.pictureBox1);
            this.PicturePanel.Controls.Add(this.HomePageButton);
            this.PicturePanel.Controls.Add(this.BookTicketsButton);
            this.PicturePanel.Controls.Add(this.ChangePassword);
            this.PicturePanel.Controls.Add(this.ViewTransactionsButton);
            this.PicturePanel.Controls.Add(this.ShowtimeButton);
            this.PicturePanel.Controls.Add(this.NowPlayingButton);
            this.PicturePanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.PicturePanel.Location = new System.Drawing.Point(0, 0);
            this.PicturePanel.Name = "PicturePanel";
            this.PicturePanel.Size = new System.Drawing.Size(222, 743);
            this.PicturePanel.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(21, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(179, 180);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // HomePageButton
            // 
            this.HomePageButton.BackColor = System.Drawing.Color.SteelBlue;
            this.HomePageButton.FlatAppearance.BorderSize = 0;
            this.HomePageButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HomePageButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HomePageButton.ForeColor = System.Drawing.SystemColors.Window;
            this.HomePageButton.Image = ((System.Drawing.Image)(resources.GetObject("HomePageButton.Image")));
            this.HomePageButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.HomePageButton.Location = new System.Drawing.Point(0, 201);
            this.HomePageButton.Name = "HomePageButton";
            this.HomePageButton.Size = new System.Drawing.Size(270, 42);
            this.HomePageButton.TabIndex = 8;
            this.HomePageButton.Text = "Home";
            this.HomePageButton.UseVisualStyleBackColor = false;
            this.HomePageButton.Click += new System.EventHandler(this.HomePageButton_Click);
            // 
            // BookTicketsButton
            // 
            this.BookTicketsButton.BackColor = System.Drawing.Color.SteelBlue;
            this.BookTicketsButton.FlatAppearance.BorderSize = 0;
            this.BookTicketsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BookTicketsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BookTicketsButton.ForeColor = System.Drawing.SystemColors.Window;
            this.BookTicketsButton.Image = ((System.Drawing.Image)(resources.GetObject("BookTicketsButton.Image")));
            this.BookTicketsButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BookTicketsButton.Location = new System.Drawing.Point(3, 435);
            this.BookTicketsButton.Name = "BookTicketsButton";
            this.BookTicketsButton.Size = new System.Drawing.Size(270, 42);
            this.BookTicketsButton.TabIndex = 5;
            this.BookTicketsButton.Text = "Book Tickets";
            this.BookTicketsButton.UseVisualStyleBackColor = false;
            this.BookTicketsButton.Click += new System.EventHandler(this.BookTicketsButton_Click);
            // 
            // ChangePassword
            // 
            this.ChangePassword.BackColor = System.Drawing.Color.SteelBlue;
            this.ChangePassword.FlatAppearance.BorderSize = 0;
            this.ChangePassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ChangePassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChangePassword.ForeColor = System.Drawing.SystemColors.Window;
            this.ChangePassword.Image = ((System.Drawing.Image)(resources.GetObject("ChangePassword.Image")));
            this.ChangePassword.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ChangePassword.Location = new System.Drawing.Point(6, 643);
            this.ChangePassword.Name = "ChangePassword";
            this.ChangePassword.Size = new System.Drawing.Size(267, 42);
            this.ChangePassword.TabIndex = 4;
            this.ChangePassword.Text = "Change Password";
            this.ChangePassword.UseVisualStyleBackColor = false;
            this.ChangePassword.Click += new System.EventHandler(this.EmpBtn_Click);
            // 
            // ViewTransactionsButton
            // 
            this.ViewTransactionsButton.BackColor = System.Drawing.Color.SteelBlue;
            this.ViewTransactionsButton.FlatAppearance.BorderSize = 0;
            this.ViewTransactionsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ViewTransactionsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewTransactionsButton.ForeColor = System.Drawing.SystemColors.Window;
            this.ViewTransactionsButton.Image = ((System.Drawing.Image)(resources.GetObject("ViewTransactionsButton.Image")));
            this.ViewTransactionsButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ViewTransactionsButton.Location = new System.Drawing.Point(3, 519);
            this.ViewTransactionsButton.Name = "ViewTransactionsButton";
            this.ViewTransactionsButton.Size = new System.Drawing.Size(267, 42);
            this.ViewTransactionsButton.TabIndex = 3;
            this.ViewTransactionsButton.Text = "View Transactions";
            this.ViewTransactionsButton.UseVisualStyleBackColor = false;
            this.ViewTransactionsButton.Click += new System.EventHandler(this.ViewTransactionsButton_Click);
            // 
            // ShowtimeButton
            // 
            this.ShowtimeButton.BackColor = System.Drawing.Color.SteelBlue;
            this.ShowtimeButton.FlatAppearance.BorderSize = 0;
            this.ShowtimeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ShowtimeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowtimeButton.ForeColor = System.Drawing.SystemColors.Window;
            this.ShowtimeButton.Image = ((System.Drawing.Image)(resources.GetObject("ShowtimeButton.Image")));
            this.ShowtimeButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ShowtimeButton.Location = new System.Drawing.Point(3, 354);
            this.ShowtimeButton.Name = "ShowtimeButton";
            this.ShowtimeButton.Size = new System.Drawing.Size(270, 42);
            this.ShowtimeButton.TabIndex = 1;
            this.ShowtimeButton.Text = "Coming Soon";
            this.ShowtimeButton.UseVisualStyleBackColor = false;
            this.ShowtimeButton.Click += new System.EventHandler(this.ShowtimeButton_Click);
            // 
            // NowPlayingButton
            // 
            this.NowPlayingButton.BackColor = System.Drawing.Color.SteelBlue;
            this.NowPlayingButton.FlatAppearance.BorderSize = 0;
            this.NowPlayingButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NowPlayingButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NowPlayingButton.ForeColor = System.Drawing.SystemColors.Window;
            this.NowPlayingButton.Image = ((System.Drawing.Image)(resources.GetObject("NowPlayingButton.Image")));
            this.NowPlayingButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.NowPlayingButton.Location = new System.Drawing.Point(3, 275);
            this.NowPlayingButton.Name = "NowPlayingButton";
            this.NowPlayingButton.Size = new System.Drawing.Size(270, 42);
            this.NowPlayingButton.TabIndex = 0;
            this.NowPlayingButton.Text = "Now Playing";
            this.NowPlayingButton.UseVisualStyleBackColor = false;
            this.NowPlayingButton.Click += new System.EventHandler(this.NowPlayingButton_Click);
            // 
            // CloseButton
            // 
            this.CloseButton.BackColor = System.Drawing.Color.Red;
            this.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CloseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CloseButton.Location = new System.Drawing.Point(869, 9);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(41, 32);
            this.CloseButton.TabIndex = 1;
            this.CloseButton.Text = "X";
            this.CloseButton.UseVisualStyleBackColor = false;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // SignOutButton
            // 
            this.SignOutButton.BackColor = System.Drawing.Color.DarkSalmon;
            this.SignOutButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SignOutButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignOutButton.Location = new System.Drawing.Point(764, 9);
            this.SignOutButton.Name = "SignOutButton";
            this.SignOutButton.Size = new System.Drawing.Size(99, 32);
            this.SignOutButton.TabIndex = 5;
            this.SignOutButton.Text = "Sign Out";
            this.SignOutButton.UseVisualStyleBackColor = false;
            this.SignOutButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(407, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 42);
            this.label1.TabIndex = 6;
            this.label1.Text = "Customer ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(30, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 24);
            this.label2.TabIndex = 7;
            this.label2.Text = "Signed In As:";
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameLabel.ForeColor = System.Drawing.Color.GreenYellow;
            this.NameLabel.Location = new System.Drawing.Point(155, 36);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(141, 24);
            this.NameLabel.TabIndex = 8;
            this.NameLabel.Text = "[User\'s Name]";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(30, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 24);
            this.label3.TabIndex = 9;
            this.label3.Text = "Customer ID:";
            // 
            // IDLabel
            // 
            this.IDLabel.AutoSize = true;
            this.IDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IDLabel.ForeColor = System.Drawing.Color.GreenYellow;
            this.IDLabel.Location = new System.Drawing.Point(155, 9);
            this.IDLabel.Name = "IDLabel";
            this.IDLabel.Size = new System.Drawing.Size(105, 24);
            this.IDLabel.TabIndex = 10;
            this.IDLabel.Text = "[User\'s ID]";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SteelBlue;
            this.panel2.Controls.Add(this.IDLabel);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.NameLabel);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.SignOutButton);
            this.panel2.Controls.Add(this.CloseButton);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(222, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(922, 75);
            this.panel2.TabIndex = 6;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // custChangePassword1
            // 
            this.custChangePassword1.Location = new System.Drawing.Point(220, 73);
            this.custChangePassword1.Name = "custChangePassword1";
            this.custChangePassword1.Size = new System.Drawing.Size(924, 672);
            this.custChangePassword1.TabIndex = 11;
            this.custChangePassword1.Visible = false;
            // 
            // custHomePage1
            // 
            this.custHomePage1.Location = new System.Drawing.Point(220, 75);
            this.custHomePage1.Name = "custHomePage1";
            this.custHomePage1.Size = new System.Drawing.Size(924, 668);
            this.custHomePage1.TabIndex = 17;
            // 
            // nowPlayingUC1
            // 
            this.nowPlayingUC1.Location = new System.Drawing.Point(221, 74);
            this.nowPlayingUC1.Name = "nowPlayingUC1";
            this.nowPlayingUC1.Size = new System.Drawing.Size(923, 669);
            this.nowPlayingUC1.TabIndex = 18;
            this.nowPlayingUC1.Visible = false;
            // 
            // comingSoonUC1
            // 
            this.comingSoonUC1.Location = new System.Drawing.Point(221, 74);
            this.comingSoonUC1.Name = "comingSoonUC1";
            this.comingSoonUC1.Size = new System.Drawing.Size(924, 671);
            this.comingSoonUC1.TabIndex = 19;
            this.comingSoonUC1.Visible = false;
            // 
            // bookTicketsUC2
            // 
            this.bookTicketsUC2.Location = new System.Drawing.Point(221, 74);
            this.bookTicketsUC2.Name = "bookTicketsUC2";
            this.bookTicketsUC2.Size = new System.Drawing.Size(924, 671);
            this.bookTicketsUC2.TabIndex = 20;
            this.bookTicketsUC2.Visible = false;
            // 
            // viewTransactionsUC2
            // 
            this.viewTransactionsUC2.Location = new System.Drawing.Point(221, 74);
            this.viewTransactionsUC2.Name = "viewTransactionsUC2";
            this.viewTransactionsUC2.Size = new System.Drawing.Size(924, 670);
            this.viewTransactionsUC2.TabIndex = 21;
            this.viewTransactionsUC2.Visible = false;
            // 
            // CustHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1144, 743);
            this.Controls.Add(this.custHomePage1);
            this.Controls.Add(this.viewTransactionsUC2);
            this.Controls.Add(this.bookTicketsUC2);
            this.Controls.Add(this.comingSoonUC1);
            this.Controls.Add(this.nowPlayingUC1);
            this.Controls.Add(this.custChangePassword1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.PicturePanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CustHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CustHome";
            this.Load += new System.EventHandler(this.CustHome_Load);
            this.PicturePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private User_Control.BookTicketsUC bookTicketsUC1;
        private User_Control.ViewTransactionsUC viewTransactionsUC1;
        private System.Windows.Forms.Panel PicturePanel;
        private System.Windows.Forms.Button BookTicketsButton;
        private System.Windows.Forms.Button ChangePassword;
        private System.Windows.Forms.Button ViewTransactionsButton;
        private System.Windows.Forms.Button ShowtimeButton;
        private System.Windows.Forms.Button NowPlayingButton;
        private User_Control.CustChangePassword custChangePassword1;
        private System.Windows.Forms.Button HomePageButton;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Button SignOutButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label IDLabel;
        private System.Windows.Forms.Panel panel2;
        private User_Control.CustHomePage custHomePage1;
        private User_Control.NowPlayingUC nowPlayingUC1;
        private User_Control.ComingSoonUC comingSoonUC1;
        private User_Control.BookTicketsUC bookTicketsUC2;
        private User_Control.ViewTransactionsUC viewTransactionsUC2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}