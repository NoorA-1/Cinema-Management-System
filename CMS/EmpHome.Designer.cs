namespace CMS
{
    partial class EmpHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmpHome));
            this.panel1 = new System.Windows.Forms.Panel();
            this.HomePageButton = new System.Windows.Forms.Button();
            this.EmpChangePassword = new System.Windows.Forms.Button();
            this.AllShowsButton = new System.Windows.Forms.Button();
            this.EmpBtn = new System.Windows.Forms.Button();
            this.CustDetailBtn = new System.Windows.Forms.Button();
            this.ShowtimeButton = new System.Windows.Forms.Button();
            this.AddMovieBtn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.IDLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BackButton = new System.Windows.Forms.Button();
            this.CloseButton = new System.Windows.Forms.Button();
            this.moviesUC1 = new CMS.User_Control.MoviesUC();
            this.showtimeUC1 = new CMS.User_Control.ShowtimeUC();
            this.allShowsUC1 = new CMS.User_Control.AllShowsUC();
            this.custDetails1 = new CMS.User_Control.CustDetails();
            this.employeeUC1 = new CMS.User_Control.EmployeeUC();
            this.empChangePassword1 = new CMS.User_Control.EmpChangePassword();
            this.empHomePage1 = new CMS.User_Control.EmpHomePage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.HomePageButton);
            this.panel1.Controls.Add(this.EmpChangePassword);
            this.panel1.Controls.Add(this.AllShowsButton);
            this.panel1.Controls.Add(this.EmpBtn);
            this.panel1.Controls.Add(this.CustDetailBtn);
            this.panel1.Controls.Add(this.ShowtimeButton);
            this.panel1.Controls.Add(this.AddMovieBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(228, 743);
            this.panel1.TabIndex = 1;
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
            this.HomePageButton.Location = new System.Drawing.Point(-3, 200);
            this.HomePageButton.Name = "HomePageButton";
            this.HomePageButton.Size = new System.Drawing.Size(270, 42);
            this.HomePageButton.TabIndex = 7;
            this.HomePageButton.Text = "Home";
            this.HomePageButton.UseVisualStyleBackColor = false;
            this.HomePageButton.Click += new System.EventHandler(this.HomePageButton_Click);
            // 
            // EmpChangePassword
            // 
            this.EmpChangePassword.BackColor = System.Drawing.Color.SteelBlue;
            this.EmpChangePassword.FlatAppearance.BorderSize = 0;
            this.EmpChangePassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EmpChangePassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmpChangePassword.ForeColor = System.Drawing.SystemColors.Window;
            this.EmpChangePassword.Image = ((System.Drawing.Image)(resources.GetObject("EmpChangePassword.Image")));
            this.EmpChangePassword.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.EmpChangePassword.Location = new System.Drawing.Point(-3, 679);
            this.EmpChangePassword.Name = "EmpChangePassword";
            this.EmpChangePassword.Size = new System.Drawing.Size(267, 42);
            this.EmpChangePassword.TabIndex = 6;
            this.EmpChangePassword.Text = "Change Password";
            this.EmpChangePassword.UseVisualStyleBackColor = false;
            this.EmpChangePassword.Click += new System.EventHandler(this.EmpChangePassword_Click);
            // 
            // AllShowsButton
            // 
            this.AllShowsButton.BackColor = System.Drawing.Color.SteelBlue;
            this.AllShowsButton.FlatAppearance.BorderSize = 0;
            this.AllShowsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AllShowsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AllShowsButton.ForeColor = System.Drawing.SystemColors.Window;
            this.AllShowsButton.Image = ((System.Drawing.Image)(resources.GetObject("AllShowsButton.Image")));
            this.AllShowsButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AllShowsButton.Location = new System.Drawing.Point(0, 425);
            this.AllShowsButton.Name = "AllShowsButton";
            this.AllShowsButton.Size = new System.Drawing.Size(270, 42);
            this.AllShowsButton.TabIndex = 5;
            this.AllShowsButton.Text = "All Shows List";
            this.AllShowsButton.UseVisualStyleBackColor = false;
            this.AllShowsButton.Click += new System.EventHandler(this.AllShowsButton_Click);
            // 
            // EmpBtn
            // 
            this.EmpBtn.BackColor = System.Drawing.Color.SteelBlue;
            this.EmpBtn.FlatAppearance.BorderSize = 0;
            this.EmpBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EmpBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmpBtn.ForeColor = System.Drawing.SystemColors.Window;
            this.EmpBtn.Image = ((System.Drawing.Image)(resources.GetObject("EmpBtn.Image")));
            this.EmpBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.EmpBtn.Location = new System.Drawing.Point(0, 584);
            this.EmpBtn.Name = "EmpBtn";
            this.EmpBtn.Size = new System.Drawing.Size(267, 42);
            this.EmpBtn.TabIndex = 4;
            this.EmpBtn.Text = "Employee";
            this.EmpBtn.UseVisualStyleBackColor = false;
            this.EmpBtn.Click += new System.EventHandler(this.EmpBtn_Click);
            // 
            // CustDetailBtn
            // 
            this.CustDetailBtn.BackColor = System.Drawing.Color.SteelBlue;
            this.CustDetailBtn.FlatAppearance.BorderSize = 0;
            this.CustDetailBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CustDetailBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustDetailBtn.ForeColor = System.Drawing.SystemColors.Window;
            this.CustDetailBtn.Image = ((System.Drawing.Image)(resources.GetObject("CustDetailBtn.Image")));
            this.CustDetailBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CustDetailBtn.Location = new System.Drawing.Point(0, 505);
            this.CustDetailBtn.Name = "CustDetailBtn";
            this.CustDetailBtn.Size = new System.Drawing.Size(267, 42);
            this.CustDetailBtn.TabIndex = 3;
            this.CustDetailBtn.Text = "Customer Details";
            this.CustDetailBtn.UseVisualStyleBackColor = false;
            this.CustDetailBtn.Click += new System.EventHandler(this.CustDetailBtn_Click);
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
            this.ShowtimeButton.Location = new System.Drawing.Point(0, 344);
            this.ShowtimeButton.Name = "ShowtimeButton";
            this.ShowtimeButton.Size = new System.Drawing.Size(270, 42);
            this.ShowtimeButton.TabIndex = 1;
            this.ShowtimeButton.Text = "Show Time";
            this.ShowtimeButton.UseVisualStyleBackColor = false;
            this.ShowtimeButton.Click += new System.EventHandler(this.ShowtimeButton_Click);
            // 
            // AddMovieBtn
            // 
            this.AddMovieBtn.BackColor = System.Drawing.Color.SteelBlue;
            this.AddMovieBtn.FlatAppearance.BorderSize = 0;
            this.AddMovieBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddMovieBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddMovieBtn.ForeColor = System.Drawing.SystemColors.Window;
            this.AddMovieBtn.Image = ((System.Drawing.Image)(resources.GetObject("AddMovieBtn.Image")));
            this.AddMovieBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AddMovieBtn.Location = new System.Drawing.Point(-3, 272);
            this.AddMovieBtn.Name = "AddMovieBtn";
            this.AddMovieBtn.Size = new System.Drawing.Size(270, 42);
            this.AddMovieBtn.TabIndex = 0;
            this.AddMovieBtn.Text = "Movies";
            this.AddMovieBtn.UseVisualStyleBackColor = false;
            this.AddMovieBtn.Click += new System.EventHandler(this.AddMovieBtn_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SteelBlue;
            this.panel2.Controls.Add(this.IDLabel);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.NameLabel);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.BackButton);
            this.panel2.Controls.Add(this.CloseButton);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(228, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(916, 72);
            this.panel2.TabIndex = 2;
            // 
            // IDLabel
            // 
            this.IDLabel.AutoSize = true;
            this.IDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IDLabel.ForeColor = System.Drawing.Color.GreenYellow;
            this.IDLabel.Location = new System.Drawing.Point(131, 15);
            this.IDLabel.Name = "IDLabel";
            this.IDLabel.Size = new System.Drawing.Size(105, 24);
            this.IDLabel.TabIndex = 14;
            this.IDLabel.Text = "[User\'s ID]";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(6, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 24);
            this.label3.TabIndex = 13;
            this.label3.Text = "Employee ID:";
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameLabel.ForeColor = System.Drawing.Color.GreenYellow;
            this.NameLabel.Location = new System.Drawing.Point(169, 39);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(141, 24);
            this.NameLabel.TabIndex = 12;
            this.NameLabel.Text = "[User\'s Name]";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(6, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(157, 24);
            this.label4.TabIndex = 11;
            this.label4.Text = "Employee Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(369, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(192, 42);
            this.label2.TabIndex = 7;
            this.label2.Text = "Employee";
            // 
            // BackButton
            // 
            this.BackButton.BackColor = System.Drawing.Color.DarkSalmon;
            this.BackButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BackButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackButton.Location = new System.Drawing.Point(766, 12);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(99, 32);
            this.BackButton.TabIndex = 5;
            this.BackButton.Text = "Sign Out";
            this.BackButton.UseVisualStyleBackColor = false;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // CloseButton
            // 
            this.CloseButton.BackColor = System.Drawing.Color.Red;
            this.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CloseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CloseButton.Location = new System.Drawing.Point(871, 12);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(41, 32);
            this.CloseButton.TabIndex = 1;
            this.CloseButton.Text = "X";
            this.CloseButton.UseVisualStyleBackColor = false;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // moviesUC1
            // 
            this.moviesUC1.Location = new System.Drawing.Point(228, 70);
            this.moviesUC1.Name = "moviesUC1";
            this.moviesUC1.Size = new System.Drawing.Size(916, 673);
            this.moviesUC1.TabIndex = 3;
            this.moviesUC1.Visible = false;
            // 
            // showtimeUC1
            // 
            this.showtimeUC1.Location = new System.Drawing.Point(228, 70);
            this.showtimeUC1.Name = "showtimeUC1";
            this.showtimeUC1.Size = new System.Drawing.Size(916, 673);
            this.showtimeUC1.TabIndex = 4;
            this.showtimeUC1.Visible = false;
            // 
            // allShowsUC1
            // 
            this.allShowsUC1.Location = new System.Drawing.Point(228, 70);
            this.allShowsUC1.Name = "allShowsUC1";
            this.allShowsUC1.Size = new System.Drawing.Size(916, 673);
            this.allShowsUC1.TabIndex = 5;
            this.allShowsUC1.Visible = false;
            // 
            // custDetails1
            // 
            this.custDetails1.Location = new System.Drawing.Point(228, 70);
            this.custDetails1.Name = "custDetails1";
            this.custDetails1.Size = new System.Drawing.Size(916, 673);
            this.custDetails1.TabIndex = 6;
            this.custDetails1.Visible = false;
            // 
            // employeeUC1
            // 
            this.employeeUC1.Location = new System.Drawing.Point(228, 70);
            this.employeeUC1.Name = "employeeUC1";
            this.employeeUC1.Size = new System.Drawing.Size(916, 673);
            this.employeeUC1.TabIndex = 7;
            this.employeeUC1.Visible = false;
            // 
            // empChangePassword1
            // 
            this.empChangePassword1.Location = new System.Drawing.Point(228, 70);
            this.empChangePassword1.Name = "empChangePassword1";
            this.empChangePassword1.Size = new System.Drawing.Size(916, 673);
            this.empChangePassword1.TabIndex = 8;
            this.empChangePassword1.Visible = false;
            // 
            // empHomePage1
            // 
            this.empHomePage1.Location = new System.Drawing.Point(228, 70);
            this.empHomePage1.Name = "empHomePage1";
            this.empHomePage1.Size = new System.Drawing.Size(916, 673);
            this.empHomePage1.TabIndex = 9;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(23, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(179, 180);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // EmpHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1144, 743);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.empHomePage1);
            this.Controls.Add(this.empChangePassword1);
            this.Controls.Add(this.custDetails1);
            this.Controls.Add(this.allShowsUC1);
            this.Controls.Add(this.showtimeUC1);
            this.Controls.Add(this.moviesUC1);
            this.Controls.Add(this.employeeUC1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EmpHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.Load += new System.EventHandler(this.EmpHome_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button CustDetailBtn;
        private System.Windows.Forms.Button ShowtimeButton;
        private System.Windows.Forms.Button AddMovieBtn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button EmpBtn;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Button AllShowsButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label IDLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button EmpChangePassword;
        private System.Windows.Forms.Button HomePageButton;
        private User_Control.MoviesUC moviesUC1;
        private User_Control.ShowtimeUC showtimeUC1;
        private User_Control.AllShowsUC allShowsUC1;
        private User_Control.CustDetails custDetails1;
        private User_Control.EmployeeUC employeeUC1;
        private User_Control.EmpChangePassword empChangePassword1;
        private User_Control.EmpHomePage empHomePage1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}