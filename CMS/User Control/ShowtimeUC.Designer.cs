namespace CMS.User_Control
{
    partial class ShowtimeUC
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
            this.Label1 = new System.Windows.Forms.Label();
            this.AddShowStartDate = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.AlreadyBkdLabel = new System.Windows.Forms.Label();
            this.AddSTMovieGridView = new System.Windows.Forms.DataGridView();
            this.AddShowtimeCinemaComBox = new System.Windows.Forms.ComboBox();
            this.AddShowtimeComBox = new System.Windows.Forms.ComboBox();
            this.AddShowEndDate = new System.Windows.Forms.DateTimePicker();
            this.AddShowtimeButton = new System.Windows.Forms.Button();
            this.MoviePosterBox = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label15 = new System.Windows.Forms.Label();
            this.SearchEditSTMovieBox = new System.Windows.Forms.TextBox();
            this.EditShowtimeComBox = new System.Windows.Forms.ComboBox();
            this.EditSTMovieNameLabel = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.EditSTIDTextBox = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.EditSTMovieGridView = new System.Windows.Forms.DataGridView();
            this.EditShowtimeCinemaComBox = new System.Windows.Forms.ComboBox();
            this.EditShowtimeEndDate = new System.Windows.Forms.DateTimePicker();
            this.EditShowTimeButton = new System.Windows.Forms.Button();
            this.EditMoviePosterBox = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.EditShowtimeStartDate = new System.Windows.Forms.DateTimePicker();
            this.EditSTGridView = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label22 = new System.Windows.Forms.Label();
            this.SearchDelSTMovieBox = new System.Windows.Forms.TextBox();
            this.DelSTCinemaHallTextBox = new System.Windows.Forms.TextBox();
            this.DelShowtimeTextBox = new System.Windows.Forms.TextBox();
            this.DelSTMovieLabel = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.DelShowIDTextBox = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.DelSTButton = new System.Windows.Forms.Button();
            this.DelSTMoviePoster = new System.Windows.Forms.PictureBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.DelSTGridView = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AddSTMovieGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MoviePosterBox)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EditSTMovieGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EditMoviePosterBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EditSTGridView)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DelSTMoviePoster)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DelSTGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(393, 18);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(141, 31);
            this.Label1.TabIndex = 40;
            this.Label1.Text = "Showtime";
            // 
            // AddShowStartDate
            // 
            this.AddShowStartDate.CustomFormat = "yyyy-MM-dd";
            this.AddShowStartDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddShowStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.AddShowStartDate.Location = new System.Drawing.Point(121, 199);
            this.AddShowStartDate.MaxDate = new System.DateTime(2050, 12, 31, 0, 0, 0, 0);
            this.AddShowStartDate.MinDate = new System.DateTime(2022, 1, 1, 0, 0, 0, 0);
            this.AddShowStartDate.Name = "AddShowStartDate";
            this.AddShowStartDate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.AddShowStartDate.Size = new System.Drawing.Size(138, 20);
            this.AddShowStartDate.TabIndex = 47;
            this.AddShowStartDate.Value = new System.DateTime(2022, 5, 19, 0, 0, 0, 0);
            this.AddShowStartDate.ValueChanged += new System.EventHandler(this.AddShowStartDate_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(118, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 18);
            this.label3.TabIndex = 49;
            this.label3.Text = "Show Timing";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(118, 178);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 18);
            this.label2.TabIndex = 50;
            this.label2.Text = "Show Start Date";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(3, 52);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(918, 613);
            this.tabControl1.TabIndex = 51;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.AlreadyBkdLabel);
            this.tabPage1.Controls.Add(this.AddSTMovieGridView);
            this.tabPage1.Controls.Add(this.AddShowtimeCinemaComBox);
            this.tabPage1.Controls.Add(this.AddShowtimeComBox);
            this.tabPage1.Controls.Add(this.AddShowEndDate);
            this.tabPage1.Controls.Add(this.AddShowtimeButton);
            this.tabPage1.Controls.Add(this.MoviePosterBox);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.AddShowStartDate);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(910, 587);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Add Show Time";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // AlreadyBkdLabel
            // 
            this.AlreadyBkdLabel.AutoSize = true;
            this.AlreadyBkdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AlreadyBkdLabel.ForeColor = System.Drawing.Color.Red;
            this.AlreadyBkdLabel.Location = new System.Drawing.Point(265, 484);
            this.AlreadyBkdLabel.Name = "AlreadyBkdLabel";
            this.AlreadyBkdLabel.Size = new System.Drawing.Size(415, 20);
            this.AlreadyBkdLabel.TabIndex = 62;
            this.AlreadyBkdLabel.Text = "A show is already reserved in the same time frame.";
            this.AlreadyBkdLabel.Visible = false;
            // 
            // AddSTMovieGridView
            // 
            this.AddSTMovieGridView.AllowUserToAddRows = false;
            this.AddSTMovieGridView.AllowUserToDeleteRows = false;
            this.AddSTMovieGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.AddSTMovieGridView.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.AddSTMovieGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.AddSTMovieGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AddSTMovieGridView.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddSTMovieGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.AddSTMovieGridView.Location = new System.Drawing.Point(307, 172);
            this.AddSTMovieGridView.MultiSelect = false;
            this.AddSTMovieGridView.Name = "AddSTMovieGridView";
            this.AddSTMovieGridView.ReadOnly = true;
            this.AddSTMovieGridView.RowTemplate.Height = 20;
            this.AddSTMovieGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.AddSTMovieGridView.Size = new System.Drawing.Size(323, 296);
            this.AddSTMovieGridView.TabIndex = 61;
            this.AddSTMovieGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.AddSTMovieGridView_CellClick);
            // 
            // AddShowtimeCinemaComBox
            // 
            this.AddShowtimeCinemaComBox.BackColor = System.Drawing.SystemColors.Menu;
            this.AddShowtimeCinemaComBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AddShowtimeCinemaComBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AddShowtimeCinemaComBox.ForeColor = System.Drawing.Color.Maroon;
            this.AddShowtimeCinemaComBox.FormattingEnabled = true;
            this.AddShowtimeCinemaComBox.Items.AddRange(new object[] {
            "A",
            "B",
            "C"});
            this.AddShowtimeCinemaComBox.Location = new System.Drawing.Point(307, 116);
            this.AddShowtimeCinemaComBox.Name = "AddShowtimeCinemaComBox";
            this.AddShowtimeCinemaComBox.Size = new System.Drawing.Size(151, 21);
            this.AddShowtimeCinemaComBox.TabIndex = 60;
            this.AddShowtimeCinemaComBox.SelectedIndexChanged += new System.EventHandler(this.AddShowtimeCinemaComBox_SelectedIndexChanged);
            // 
            // AddShowtimeComBox
            // 
            this.AddShowtimeComBox.BackColor = System.Drawing.SystemColors.Menu;
            this.AddShowtimeComBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AddShowtimeComBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AddShowtimeComBox.ForeColor = System.Drawing.Color.Maroon;
            this.AddShowtimeComBox.FormattingEnabled = true;
            this.AddShowtimeComBox.Items.AddRange(new object[] {
            "12:00:00",
            "4:00:00",
            "9:30:00"});
            this.AddShowtimeComBox.Location = new System.Drawing.Point(121, 116);
            this.AddShowtimeComBox.Name = "AddShowtimeComBox";
            this.AddShowtimeComBox.Size = new System.Drawing.Size(138, 21);
            this.AddShowtimeComBox.TabIndex = 59;
            this.AddShowtimeComBox.SelectedIndexChanged += new System.EventHandler(this.AddShowtimeComBox_SelectedIndexChanged);
            // 
            // AddShowEndDate
            // 
            this.AddShowEndDate.CustomFormat = "yyyy-MM-dd";
            this.AddShowEndDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddShowEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.AddShowEndDate.Location = new System.Drawing.Point(121, 265);
            this.AddShowEndDate.MaxDate = new System.DateTime(2050, 12, 31, 0, 0, 0, 0);
            this.AddShowEndDate.MinDate = new System.DateTime(2022, 1, 1, 0, 0, 0, 0);
            this.AddShowEndDate.Name = "AddShowEndDate";
            this.AddShowEndDate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.AddShowEndDate.Size = new System.Drawing.Size(138, 20);
            this.AddShowEndDate.TabIndex = 58;
            this.AddShowEndDate.Value = new System.DateTime(2022, 5, 19, 0, 0, 0, 0);
            this.AddShowEndDate.ValueChanged += new System.EventHandler(this.AddShowEndDate_ValueChanged);
            // 
            // AddShowtimeButton
            // 
            this.AddShowtimeButton.BackColor = System.Drawing.Color.LightBlue;
            this.AddShowtimeButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AddShowtimeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddShowtimeButton.Location = new System.Drawing.Point(707, 291);
            this.AddShowtimeButton.Name = "AddShowtimeButton";
            this.AddShowtimeButton.Size = new System.Drawing.Size(155, 43);
            this.AddShowtimeButton.TabIndex = 57;
            this.AddShowtimeButton.Text = "Add";
            this.AddShowtimeButton.UseVisualStyleBackColor = false;
            this.AddShowtimeButton.Click += new System.EventHandler(this.AddShowtimeButton_Click);
            // 
            // MoviePosterBox
            // 
            this.MoviePosterBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.MoviePosterBox.Location = new System.Drawing.Point(646, 38);
            this.MoviePosterBox.Name = "MoviePosterBox";
            this.MoviePosterBox.Size = new System.Drawing.Size(216, 236);
            this.MoviePosterBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.MoviePosterBox.TabIndex = 56;
            this.MoviePosterBox.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(304, 151);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 18);
            this.label7.TabIndex = 55;
            this.label7.Text = "Movie";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(304, 95);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 18);
            this.label6.TabIndex = 54;
            this.label6.Text = "Cinema Hall";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(118, 244);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 18);
            this.label5.TabIndex = 53;
            this.label5.Text = "Show End Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(343, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(217, 31);
            this.label4.TabIndex = 52;
            this.label4.Text = "Add Show Time";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.panel2);
            this.tabPage2.Controls.Add(this.EditShowtimeComBox);
            this.tabPage2.Controls.Add(this.EditSTMovieNameLabel);
            this.tabPage2.Controls.Add(this.label13);
            this.tabPage2.Controls.Add(this.EditSTIDTextBox);
            this.tabPage2.Controls.Add(this.label19);
            this.tabPage2.Controls.Add(this.label17);
            this.tabPage2.Controls.Add(this.EditSTMovieGridView);
            this.tabPage2.Controls.Add(this.EditShowtimeCinemaComBox);
            this.tabPage2.Controls.Add(this.EditShowtimeEndDate);
            this.tabPage2.Controls.Add(this.EditShowTimeButton);
            this.tabPage2.Controls.Add(this.EditMoviePosterBox);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.EditShowtimeStartDate);
            this.tabPage2.Controls.Add(this.EditSTGridView);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(910, 587);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Edit Show Time";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gray;
            this.panel2.Controls.Add(this.label15);
            this.panel2.Controls.Add(this.SearchEditSTMovieBox);
            this.panel2.ForeColor = System.Drawing.Color.Transparent;
            this.panel2.Location = new System.Drawing.Point(214, 281);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(215, 63);
            this.panel2.TabIndex = 82;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Gray;
            this.label15.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(8, 8);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(160, 18);
            this.label15.TabIndex = 84;
            this.label15.Text = "Search Movie Name";
            // 
            // SearchEditSTMovieBox
            // 
            this.SearchEditSTMovieBox.BackColor = System.Drawing.Color.White;
            this.SearchEditSTMovieBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchEditSTMovieBox.Location = new System.Drawing.Point(9, 29);
            this.SearchEditSTMovieBox.MaxLength = 30;
            this.SearchEditSTMovieBox.Name = "SearchEditSTMovieBox";
            this.SearchEditSTMovieBox.Size = new System.Drawing.Size(187, 26);
            this.SearchEditSTMovieBox.TabIndex = 83;
            this.SearchEditSTMovieBox.TextChanged += new System.EventHandler(this.SearchEditSTMovieBox_TextChanged);
            // 
            // EditShowtimeComBox
            // 
            this.EditShowtimeComBox.BackColor = System.Drawing.SystemColors.Menu;
            this.EditShowtimeComBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.EditShowtimeComBox.ForeColor = System.Drawing.Color.Maroon;
            this.EditShowtimeComBox.FormattingEnabled = true;
            this.EditShowtimeComBox.Items.AddRange(new object[] {
            "12:00:00",
            "4:00:00",
            "9:30:00"});
            this.EditShowtimeComBox.Location = new System.Drawing.Point(50, 137);
            this.EditShowtimeComBox.Name = "EditShowtimeComBox";
            this.EditShowtimeComBox.Size = new System.Drawing.Size(151, 21);
            this.EditShowtimeComBox.TabIndex = 81;
            this.EditShowtimeComBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EditShowtimeComBox_KeyPress);
            // 
            // EditSTMovieNameLabel
            // 
            this.EditSTMovieNameLabel.AutoSize = true;
            this.EditSTMovieNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditSTMovieNameLabel.ForeColor = System.Drawing.Color.Brown;
            this.EditSTMovieNameLabel.Location = new System.Drawing.Point(247, 189);
            this.EditSTMovieNameLabel.Name = "EditSTMovieNameLabel";
            this.EditSTMovieNameLabel.Size = new System.Drawing.Size(99, 20);
            this.EditSTMovieNameLabel.TabIndex = 80;
            this.EditSTMovieNameLabel.Text = "Moviename";
            this.EditSTMovieNameLabel.Visible = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Brown;
            this.label13.Location = new System.Drawing.Point(47, 189);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(206, 18);
            this.label13.TabIndex = 79;
            this.label13.Text = "Current Movie For This Show:";
            // 
            // EditSTIDTextBox
            // 
            this.EditSTIDTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditSTIDTextBox.Location = new System.Drawing.Point(50, 58);
            this.EditSTIDTextBox.MaxLength = 32768;
            this.EditSTIDTextBox.Name = "EditSTIDTextBox";
            this.EditSTIDTextBox.ReadOnly = true;
            this.EditSTIDTextBox.Size = new System.Drawing.Size(149, 26);
            this.EditSTIDTextBox.TabIndex = 78;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(47, 37);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(24, 18);
            this.label19.TabIndex = 77;
            this.label19.Text = "ID";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.Green;
            this.label17.Location = new System.Drawing.Point(6, 322);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(129, 18);
            this.label17.TabIndex = 76;
            this.label17.Text = "Select a Record";
            // 
            // EditSTMovieGridView
            // 
            this.EditSTMovieGridView.AllowUserToAddRows = false;
            this.EditSTMovieGridView.AllowUserToDeleteRows = false;
            this.EditSTMovieGridView.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.EditSTMovieGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.EditSTMovieGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EditSTMovieGridView.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EditSTMovieGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.EditSTMovieGridView.Location = new System.Drawing.Point(456, 104);
            this.EditSTMovieGridView.MultiSelect = false;
            this.EditSTMovieGridView.Name = "EditSTMovieGridView";
            this.EditSTMovieGridView.ReadOnly = true;
            this.EditSTMovieGridView.RowTemplate.Height = 20;
            this.EditSTMovieGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.EditSTMovieGridView.Size = new System.Drawing.Size(244, 195);
            this.EditSTMovieGridView.TabIndex = 73;
            this.EditSTMovieGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.EditSTMovieGridView_CellClick);
            // 
            // EditShowtimeCinemaComBox
            // 
            this.EditShowtimeCinemaComBox.BackColor = System.Drawing.SystemColors.Menu;
            this.EditShowtimeCinemaComBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.EditShowtimeCinemaComBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.EditShowtimeCinemaComBox.ForeColor = System.Drawing.Color.Maroon;
            this.EditShowtimeCinemaComBox.FormattingEnabled = true;
            this.EditShowtimeCinemaComBox.Items.AddRange(new object[] {
            "A",
            "B",
            "C"});
            this.EditShowtimeCinemaComBox.Location = new System.Drawing.Point(456, 48);
            this.EditShowtimeCinemaComBox.Name = "EditShowtimeCinemaComBox";
            this.EditShowtimeCinemaComBox.Size = new System.Drawing.Size(151, 21);
            this.EditShowtimeCinemaComBox.TabIndex = 72;
            this.EditShowtimeCinemaComBox.SelectedIndexChanged += new System.EventHandler(this.EditShowtimeCinemaComBox_SelectedIndexChanged);
            // 
            // EditShowtimeEndDate
            // 
            this.EditShowtimeEndDate.CustomFormat = "yyyy-MM-dd";
            this.EditShowtimeEndDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditShowtimeEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.EditShowtimeEndDate.Location = new System.Drawing.Point(251, 134);
            this.EditShowtimeEndDate.MaxDate = new System.DateTime(2050, 12, 31, 0, 0, 0, 0);
            this.EditShowtimeEndDate.MinDate = new System.DateTime(2022, 1, 1, 0, 0, 0, 0);
            this.EditShowtimeEndDate.Name = "EditShowtimeEndDate";
            this.EditShowtimeEndDate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.EditShowtimeEndDate.Size = new System.Drawing.Size(138, 20);
            this.EditShowtimeEndDate.TabIndex = 70;
            this.EditShowtimeEndDate.Value = new System.DateTime(2022, 5, 15, 0, 0, 0, 0);
            // 
            // EditShowTimeButton
            // 
            this.EditShowTimeButton.BackColor = System.Drawing.Color.LightBlue;
            this.EditShowTimeButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.EditShowTimeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditShowTimeButton.Location = new System.Drawing.Point(749, 281);
            this.EditShowTimeButton.Name = "EditShowTimeButton";
            this.EditShowTimeButton.Size = new System.Drawing.Size(155, 43);
            this.EditShowTimeButton.TabIndex = 69;
            this.EditShowTimeButton.Text = "Submit";
            this.EditShowTimeButton.UseVisualStyleBackColor = false;
            this.EditShowTimeButton.Click += new System.EventHandler(this.EditShowTimeButton_Click);
            // 
            // EditMoviePosterBox
            // 
            this.EditMoviePosterBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.EditMoviePosterBox.Location = new System.Drawing.Point(706, 6);
            this.EditMoviePosterBox.Name = "EditMoviePosterBox";
            this.EditMoviePosterBox.Size = new System.Drawing.Size(198, 259);
            this.EditMoviePosterBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.EditMoviePosterBox.TabIndex = 68;
            this.EditMoviePosterBox.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(453, 83);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 18);
            this.label8.TabIndex = 67;
            this.label8.Text = "Movie";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(453, 27);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(99, 18);
            this.label9.TabIndex = 66;
            this.label9.Text = "Cinema Hall";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(248, 113);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(124, 18);
            this.label10.TabIndex = 65;
            this.label10.Text = "Show End Date";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(248, 47);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(131, 18);
            this.label11.TabIndex = 64;
            this.label11.Text = "Show Start Date";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(47, 114);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(105, 18);
            this.label12.TabIndex = 63;
            this.label12.Text = "Show Timing";
            // 
            // EditShowtimeStartDate
            // 
            this.EditShowtimeStartDate.CustomFormat = "yyyy-MM-dd";
            this.EditShowtimeStartDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditShowtimeStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.EditShowtimeStartDate.Location = new System.Drawing.Point(251, 68);
            this.EditShowtimeStartDate.MaxDate = new System.DateTime(2050, 12, 31, 0, 0, 0, 0);
            this.EditShowtimeStartDate.MinDate = new System.DateTime(2022, 1, 1, 0, 0, 0, 0);
            this.EditShowtimeStartDate.Name = "EditShowtimeStartDate";
            this.EditShowtimeStartDate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.EditShowtimeStartDate.Size = new System.Drawing.Size(138, 20);
            this.EditShowtimeStartDate.TabIndex = 62;
            this.EditShowtimeStartDate.Value = new System.DateTime(2022, 5, 15, 0, 0, 0, 0);
            this.EditShowtimeStartDate.ValueChanged += new System.EventHandler(this.EditShowtimeStartDate_ValueChanged);
            // 
            // EditSTGridView
            // 
            this.EditSTGridView.AllowUserToAddRows = false;
            this.EditSTGridView.AllowUserToDeleteRows = false;
            this.EditSTGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.EditSTGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.EditSTGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EditSTGridView.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EditSTGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.EditSTGridView.Location = new System.Drawing.Point(6, 343);
            this.EditSTGridView.Name = "EditSTGridView";
            this.EditSTGridView.ReadOnly = true;
            this.EditSTGridView.RowTemplate.Height = 100;
            this.EditSTGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.EditSTGridView.Size = new System.Drawing.Size(898, 238);
            this.EditSTGridView.TabIndex = 54;
            this.EditSTGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.EditSTGridView_CellClick);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.panel1);
            this.tabPage3.Controls.Add(this.DelSTCinemaHallTextBox);
            this.tabPage3.Controls.Add(this.DelShowtimeTextBox);
            this.tabPage3.Controls.Add(this.DelSTMovieLabel);
            this.tabPage3.Controls.Add(this.label16);
            this.tabPage3.Controls.Add(this.DelShowIDTextBox);
            this.tabPage3.Controls.Add(this.label18);
            this.tabPage3.Controls.Add(this.DelSTButton);
            this.tabPage3.Controls.Add(this.DelSTMoviePoster);
            this.tabPage3.Controls.Add(this.label20);
            this.tabPage3.Controls.Add(this.label21);
            this.tabPage3.Controls.Add(this.label14);
            this.tabPage3.Controls.Add(this.DelSTGridView);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(910, 587);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Delete Show Time";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Controls.Add(this.label22);
            this.panel1.Controls.Add(this.SearchDelSTMovieBox);
            this.panel1.ForeColor = System.Drawing.Color.Transparent;
            this.panel1.Location = new System.Drawing.Point(189, 238);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(215, 63);
            this.panel1.TabIndex = 93;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.BackColor = System.Drawing.Color.Gray;
            this.label22.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.ForeColor = System.Drawing.Color.White;
            this.label22.Location = new System.Drawing.Point(8, 8);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(160, 18);
            this.label22.TabIndex = 84;
            this.label22.Text = "Search Movie Name";
            // 
            // SearchDelSTMovieBox
            // 
            this.SearchDelSTMovieBox.BackColor = System.Drawing.Color.White;
            this.SearchDelSTMovieBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchDelSTMovieBox.Location = new System.Drawing.Point(9, 29);
            this.SearchDelSTMovieBox.MaxLength = 30;
            this.SearchDelSTMovieBox.Name = "SearchDelSTMovieBox";
            this.SearchDelSTMovieBox.Size = new System.Drawing.Size(187, 26);
            this.SearchDelSTMovieBox.TabIndex = 83;
            this.SearchDelSTMovieBox.TextChanged += new System.EventHandler(this.SearchDelSTMovieBox_TextChanged);
            // 
            // DelSTCinemaHallTextBox
            // 
            this.DelSTCinemaHallTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DelSTCinemaHallTextBox.Location = new System.Drawing.Point(361, 69);
            this.DelSTCinemaHallTextBox.MaxLength = 32768;
            this.DelSTCinemaHallTextBox.Name = "DelSTCinemaHallTextBox";
            this.DelSTCinemaHallTextBox.ReadOnly = true;
            this.DelSTCinemaHallTextBox.Size = new System.Drawing.Size(149, 26);
            this.DelSTCinemaHallTextBox.TabIndex = 92;
            // 
            // DelShowtimeTextBox
            // 
            this.DelShowtimeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DelShowtimeTextBox.Location = new System.Drawing.Point(156, 149);
            this.DelShowtimeTextBox.MaxLength = 32768;
            this.DelShowtimeTextBox.Name = "DelShowtimeTextBox";
            this.DelShowtimeTextBox.ReadOnly = true;
            this.DelShowtimeTextBox.Size = new System.Drawing.Size(149, 26);
            this.DelShowtimeTextBox.TabIndex = 91;
            // 
            // DelSTMovieLabel
            // 
            this.DelSTMovieLabel.AutoSize = true;
            this.DelSTMovieLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DelSTMovieLabel.ForeColor = System.Drawing.Color.Brown;
            this.DelSTMovieLabel.Location = new System.Drawing.Point(357, 150);
            this.DelSTMovieLabel.Name = "DelSTMovieLabel";
            this.DelSTMovieLabel.Size = new System.Drawing.Size(99, 20);
            this.DelSTMovieLabel.TabIndex = 90;
            this.DelSTMovieLabel.Text = "Moviename";
            this.DelSTMovieLabel.Visible = false;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.Brown;
            this.label16.Location = new System.Drawing.Point(358, 128);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(52, 18);
            this.label16.TabIndex = 89;
            this.label16.Text = "Movie:";
            // 
            // DelShowIDTextBox
            // 
            this.DelShowIDTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DelShowIDTextBox.Location = new System.Drawing.Point(156, 60);
            this.DelShowIDTextBox.MaxLength = 32768;
            this.DelShowIDTextBox.Name = "DelShowIDTextBox";
            this.DelShowIDTextBox.ReadOnly = true;
            this.DelShowIDTextBox.Size = new System.Drawing.Size(149, 26);
            this.DelShowIDTextBox.TabIndex = 88;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(153, 39);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(24, 18);
            this.label18.TabIndex = 87;
            this.label18.Text = "ID";
            // 
            // DelSTButton
            // 
            this.DelSTButton.BackColor = System.Drawing.Color.LightBlue;
            this.DelSTButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.DelSTButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DelSTButton.Location = new System.Drawing.Point(426, 191);
            this.DelSTButton.Name = "DelSTButton";
            this.DelSTButton.Size = new System.Drawing.Size(125, 43);
            this.DelSTButton.TabIndex = 85;
            this.DelSTButton.Text = "Delete";
            this.DelSTButton.UseVisualStyleBackColor = false;
            this.DelSTButton.Click += new System.EventHandler(this.DelSTButton_Click);
            // 
            // DelSTMoviePoster
            // 
            this.DelSTMoviePoster.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DelSTMoviePoster.Location = new System.Drawing.Point(577, 14);
            this.DelSTMoviePoster.Name = "DelSTMoviePoster";
            this.DelSTMoviePoster.Size = new System.Drawing.Size(202, 236);
            this.DelSTMoviePoster.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.DelSTMoviePoster.TabIndex = 84;
            this.DelSTMoviePoster.TabStop = false;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(358, 39);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(99, 18);
            this.label20.TabIndex = 83;
            this.label20.Text = "Cinema Hall";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(153, 128);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(105, 18);
            this.label21.TabIndex = 82;
            this.label21.Text = "Show Timing";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Green;
            this.label14.Location = new System.Drawing.Point(3, 279);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(129, 18);
            this.label14.TabIndex = 78;
            this.label14.Text = "Select a Record";
            // 
            // DelSTGridView
            // 
            this.DelSTGridView.AllowUserToAddRows = false;
            this.DelSTGridView.AllowUserToDeleteRows = false;
            this.DelSTGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DelSTGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DelSTGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DelSTGridView.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DelSTGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.DelSTGridView.Location = new System.Drawing.Point(3, 300);
            this.DelSTGridView.Name = "DelSTGridView";
            this.DelSTGridView.ReadOnly = true;
            this.DelSTGridView.RowTemplate.Height = 100;
            this.DelSTGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.DelSTGridView.Size = new System.Drawing.Size(904, 284);
            this.DelSTGridView.TabIndex = 77;
            this.DelSTGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DelSTGridView_CellClick);
            // 
            // ShowtimeUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.tabControl1);
            this.Name = "ShowtimeUC";
            this.Size = new System.Drawing.Size(924, 668);
            this.Load += new System.EventHandler(this.ShowtimeUC_Load);
            this.Enter += new System.EventHandler(this.ShowtimeUC_Enter);
            this.Leave += new System.EventHandler(this.ShowtimeUC_Leave);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AddSTMovieGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MoviePosterBox)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EditSTMovieGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EditMoviePosterBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EditSTGridView)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DelSTMoviePoster)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DelSTGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.DateTimePicker AddShowStartDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.PictureBox MoviePosterBox;
        private System.Windows.Forms.Button AddShowtimeButton;
        private System.Windows.Forms.DateTimePicker AddShowEndDate;
        private System.Windows.Forms.ComboBox AddShowtimeCinemaComBox;
        private System.Windows.Forms.ComboBox AddShowtimeComBox;
        private System.Windows.Forms.DataGridView AddSTMovieGridView;
        private System.Windows.Forms.DataGridView EditSTMovieGridView;
        private System.Windows.Forms.ComboBox EditShowtimeCinemaComBox;
        private System.Windows.Forms.DateTimePicker EditShowtimeEndDate;
        private System.Windows.Forms.Button EditShowTimeButton;
        private System.Windows.Forms.PictureBox EditMoviePosterBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DateTimePicker EditShowtimeStartDate;
        private System.Windows.Forms.DataGridView EditSTGridView;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label AlreadyBkdLabel;
        private System.Windows.Forms.TextBox EditSTIDTextBox;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label EditSTMovieNameLabel;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox EditShowtimeComBox;
        private System.Windows.Forms.TextBox DelSTCinemaHallTextBox;
        private System.Windows.Forms.TextBox DelShowtimeTextBox;
        private System.Windows.Forms.Label DelSTMovieLabel;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox DelShowIDTextBox;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button DelSTButton;
        private System.Windows.Forms.PictureBox DelSTMoviePoster;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DataGridView DelSTGridView;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox SearchEditSTMovieBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox SearchDelSTMovieBox;
    }
}
