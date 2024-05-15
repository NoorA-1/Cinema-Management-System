namespace CMS.User_Control
{
    partial class BookTicketsUC
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.CinemaComBox = new System.Windows.Forms.ComboBox();
            this.ShowtimeComBox = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.MoviesComBox = new System.Windows.Forms.ComboBox();
            this.ChangeButton = new System.Windows.Forms.Button();
            this.ScreeningIDTextBox = new System.Windows.Forms.TextBox();
            this.CinemaIDTextBox = new System.Windows.Forms.TextBox();
            this.ShowDate = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.cinemaAUC1 = new CMS.User_Control.CinemaAUC();
            this.cinemaBUC1 = new CMS.User_Control.CinemaBUC();
            this.cinemaCUC1 = new CMS.User_Control.CinemaCUC();
            this.SuspendLayout();
            // 
            // CinemaComBox
            // 
            this.CinemaComBox.BackColor = System.Drawing.Color.White;
            this.CinemaComBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CinemaComBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CinemaComBox.ForeColor = System.Drawing.Color.Black;
            this.CinemaComBox.FormattingEnabled = true;
            this.CinemaComBox.Location = new System.Drawing.Point(484, 47);
            this.CinemaComBox.Name = "CinemaComBox";
            this.CinemaComBox.Size = new System.Drawing.Size(151, 21);
            this.CinemaComBox.TabIndex = 62;
            this.CinemaComBox.SelectedIndexChanged += new System.EventHandler(this.CinemaComBox_SelectedIndexChanged);
            // 
            // ShowtimeComBox
            // 
            this.ShowtimeComBox.BackColor = System.Drawing.Color.White;
            this.ShowtimeComBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ShowtimeComBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ShowtimeComBox.ForeColor = System.Drawing.Color.Black;
            this.ShowtimeComBox.FormattingEnabled = true;
            this.ShowtimeComBox.Location = new System.Drawing.Point(269, 47);
            this.ShowtimeComBox.Name = "ShowtimeComBox";
            this.ShowtimeComBox.Size = new System.Drawing.Size(138, 21);
            this.ShowtimeComBox.TabIndex = 61;
            this.ShowtimeComBox.SelectedIndexChanged += new System.EventHandler(this.ShowtimeComBox_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(481, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 18);
            this.label6.TabIndex = 64;
            this.label6.Text = "Cinema Hall";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(266, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 18);
            this.label3.TabIndex = 63;
            this.label3.Text = "Show Timing";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(49, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 18);
            this.label1.TabIndex = 66;
            this.label1.Text = "Movies";
            // 
            // MoviesComBox
            // 
            this.MoviesComBox.BackColor = System.Drawing.Color.Silver;
            this.MoviesComBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.MoviesComBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.MoviesComBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MoviesComBox.ForeColor = System.Drawing.Color.Black;
            this.MoviesComBox.FormattingEnabled = true;
            this.MoviesComBox.Location = new System.Drawing.Point(52, 47);
            this.MoviesComBox.Name = "MoviesComBox";
            this.MoviesComBox.Size = new System.Drawing.Size(151, 21);
            this.MoviesComBox.TabIndex = 65;
            this.MoviesComBox.SelectedIndexChanged += new System.EventHandler(this.MoviesComBox_SelectedIndexChanged);
            // 
            // ChangeButton
            // 
            this.ChangeButton.BackColor = System.Drawing.Color.LightCoral;
            this.ChangeButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ChangeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChangeButton.Location = new System.Drawing.Point(52, 87);
            this.ChangeButton.Name = "ChangeButton";
            this.ChangeButton.Size = new System.Drawing.Size(110, 32);
            this.ChangeButton.TabIndex = 68;
            this.ChangeButton.Text = "Change";
            this.ChangeButton.UseVisualStyleBackColor = false;
            this.ChangeButton.Visible = false;
            this.ChangeButton.Click += new System.EventHandler(this.ChangeButton_Click);
            // 
            // ScreeningIDTextBox
            // 
            this.ScreeningIDTextBox.Location = new System.Drawing.Point(842, 8);
            this.ScreeningIDTextBox.Name = "ScreeningIDTextBox";
            this.ScreeningIDTextBox.ReadOnly = true;
            this.ScreeningIDTextBox.Size = new System.Drawing.Size(54, 20);
            this.ScreeningIDTextBox.TabIndex = 69;
            this.ScreeningIDTextBox.Visible = false;
            // 
            // CinemaIDTextBox
            // 
            this.CinemaIDTextBox.Location = new System.Drawing.Point(776, 8);
            this.CinemaIDTextBox.Name = "CinemaIDTextBox";
            this.CinemaIDTextBox.ReadOnly = true;
            this.CinemaIDTextBox.Size = new System.Drawing.Size(54, 20);
            this.CinemaIDTextBox.TabIndex = 72;
            this.CinemaIDTextBox.Visible = false;
            // 
            // ShowDate
            // 
            this.ShowDate.CustomFormat = "yyyy-MM-dd";
            this.ShowDate.Enabled = false;
            this.ShowDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.ShowDate.Location = new System.Drawing.Point(692, 48);
            this.ShowDate.MaxDate = new System.DateTime(2111, 12, 31, 0, 0, 0, 0);
            this.ShowDate.MinDate = new System.DateTime(1800, 1, 1, 0, 0, 0, 0);
            this.ShowDate.Name = "ShowDate";
            this.ShowDate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ShowDate.Size = new System.Drawing.Size(138, 20);
            this.ShowDate.TabIndex = 74;
            this.ShowDate.Value = new System.DateTime(2022, 5, 15, 0, 0, 0, 0);
            this.ShowDate.CloseUp += new System.EventHandler(this.ShowDate_CloseUp);
            this.ShowDate.ValueChanged += new System.EventHandler(this.ShowDate_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(689, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 18);
            this.label2.TabIndex = 75;
            this.label2.Text = "Show Date";
            // 
            // cinemaAUC1
            // 
            this.cinemaAUC1.Location = new System.Drawing.Point(4, 127);
            this.cinemaAUC1.Name = "cinemaAUC1";
            this.cinemaAUC1.Size = new System.Drawing.Size(920, 541);
            this.cinemaAUC1.TabIndex = 76;
            this.cinemaAUC1.Visible = false;
            // 
            // cinemaBUC1
            // 
            this.cinemaBUC1.Location = new System.Drawing.Point(0, 125);
            this.cinemaBUC1.Name = "cinemaBUC1";
            this.cinemaBUC1.Size = new System.Drawing.Size(924, 543);
            this.cinemaBUC1.TabIndex = 77;
            this.cinemaBUC1.Visible = false;
            // 
            // cinemaCUC1
            // 
            this.cinemaCUC1.Location = new System.Drawing.Point(0, 125);
            this.cinemaCUC1.Name = "cinemaCUC1";
            this.cinemaCUC1.Size = new System.Drawing.Size(924, 543);
            this.cinemaCUC1.TabIndex = 78;
            this.cinemaCUC1.Visible = false;
            // 
            // BookTicketsUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cinemaCUC1);
            this.Controls.Add(this.cinemaAUC1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ShowDate);
            this.Controls.Add(this.CinemaIDTextBox);
            this.Controls.Add(this.ScreeningIDTextBox);
            this.Controls.Add(this.ChangeButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MoviesComBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CinemaComBox);
            this.Controls.Add(this.ShowtimeComBox);
            this.Controls.Add(this.cinemaBUC1);
            this.Name = "BookTicketsUC";
            this.Size = new System.Drawing.Size(924, 668);
            this.Enter += new System.EventHandler(this.BookTicketsUC_Enter);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CinemaComBox;
        private System.Windows.Forms.ComboBox ShowtimeComBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox MoviesComBox;
        private System.Windows.Forms.Button ChangeButton;
        private System.Windows.Forms.TextBox ScreeningIDTextBox;
        private System.Windows.Forms.TextBox CinemaIDTextBox;
        private System.Windows.Forms.DateTimePicker ShowDate;
        private System.Windows.Forms.Label label2;
        private CinemaAUC cinemaAUC1;
        private CinemaBUC cinemaBUC1;
        private CinemaCUC cinemaCUC1;
    }
}
