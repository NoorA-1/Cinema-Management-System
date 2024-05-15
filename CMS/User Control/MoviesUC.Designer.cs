namespace CMS.User_Control
{
    partial class MoviesUC
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.AddMovie = new System.Windows.Forms.TabPage();
            this.BrowseImageButton = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.MoviePosterBox = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.MovieReleaseDate = new System.Windows.Forms.DateTimePicker();
            this.RegisterButton = new System.Windows.Forms.Button();
            this.MovieLengthTextBox = new System.Windows.Forms.TextBox();
            this.MovieNameTextBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.MovieGenreComBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.EditMovie = new System.Windows.Forms.TabPage();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.SearchEditMovieTextBox = new System.Windows.Forms.TextBox();
            this.EditMovieBrowseButton = new System.Windows.Forms.Button();
            this.EditMoviePosterBox = new System.Windows.Forms.PictureBox();
            this.EditMovieIDTextBox = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.EditMovieReleaseDate = new System.Windows.Forms.DateTimePicker();
            this.EditMovieLengthTextBox = new System.Windows.Forms.TextBox();
            this.EditMovieNameTextBox = new System.Windows.Forms.TextBox();
            this.EditMovieGenreComBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.EditMovieButton = new System.Windows.Forms.Button();
            this.EditMovieDetailsGridView = new System.Windows.Forms.DataGridView();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.DeleteMovie = new System.Windows.Forms.TabPage();
            this.DelMoviePosterBox = new System.Windows.Forms.PictureBox();
            this.DelMovieDetailsGridView = new System.Windows.Forms.DataGridView();
            this.label20 = new System.Windows.Forms.Label();
            this.SearchDelMovieTextBox = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label18 = new System.Windows.Forms.Label();
            this.DelMovieIDTextBox = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.DelMovieNameTextBox = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.DelMovieButton = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.AddMovie.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MoviePosterBox)).BeginInit();
            this.EditMovie.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EditMoviePosterBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EditMovieDetailsGridView)).BeginInit();
            this.DeleteMovie.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DelMoviePosterBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DelMovieDetailsGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(454, 27);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(106, 31);
            this.Label1.TabIndex = 40;
            this.Label1.Text = "Movies";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.AddMovie);
            this.tabControl1.Controls.Add(this.EditMovie);
            this.tabControl1.Controls.Add(this.DeleteMovie);
            this.tabControl1.Location = new System.Drawing.Point(3, 61);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(918, 591);
            this.tabControl1.TabIndex = 41;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // AddMovie
            // 
            this.AddMovie.Controls.Add(this.BrowseImageButton);
            this.AddMovie.Controls.Add(this.label7);
            this.AddMovie.Controls.Add(this.MoviePosterBox);
            this.AddMovie.Controls.Add(this.label6);
            this.AddMovie.Controls.Add(this.MovieReleaseDate);
            this.AddMovie.Controls.Add(this.RegisterButton);
            this.AddMovie.Controls.Add(this.MovieLengthTextBox);
            this.AddMovie.Controls.Add(this.MovieNameTextBox);
            this.AddMovie.Controls.Add(this.label10);
            this.AddMovie.Controls.Add(this.MovieGenreComBox);
            this.AddMovie.Controls.Add(this.label5);
            this.AddMovie.Controls.Add(this.label4);
            this.AddMovie.Controls.Add(this.label3);
            this.AddMovie.Location = new System.Drawing.Point(4, 22);
            this.AddMovie.Name = "AddMovie";
            this.AddMovie.Padding = new System.Windows.Forms.Padding(3);
            this.AddMovie.Size = new System.Drawing.Size(910, 565);
            this.AddMovie.TabIndex = 0;
            this.AddMovie.Text = "Add Movie";
            this.AddMovie.UseVisualStyleBackColor = true;
            // 
            // BrowseImageButton
            // 
            this.BrowseImageButton.Location = new System.Drawing.Point(768, 405);
            this.BrowseImageButton.Name = "BrowseImageButton";
            this.BrowseImageButton.Size = new System.Drawing.Size(75, 23);
            this.BrowseImageButton.TabIndex = 50;
            this.BrowseImageButton.Text = "Browse";
            this.BrowseImageButton.UseVisualStyleBackColor = true;
            this.BrowseImageButton.Click += new System.EventHandler(this.BrowseImageButton_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(593, 81);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 18);
            this.label7.TabIndex = 49;
            this.label7.Text = "Poster";
            // 
            // MoviePosterBox
            // 
            this.MoviePosterBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.MoviePosterBox.Location = new System.Drawing.Point(596, 111);
            this.MoviePosterBox.Name = "MoviePosterBox";
            this.MoviePosterBox.Size = new System.Drawing.Size(247, 288);
            this.MoviePosterBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.MoviePosterBox.TabIndex = 48;
            this.MoviePosterBox.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(385, 118);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 18);
            this.label6.TabIndex = 47;
            this.label6.Text = "Release Date";
            // 
            // MovieReleaseDate
            // 
            this.MovieReleaseDate.CustomFormat = "yyyy-MM-dd";
            this.MovieReleaseDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MovieReleaseDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.MovieReleaseDate.Location = new System.Drawing.Point(388, 150);
            this.MovieReleaseDate.MaxDate = new System.DateTime(2111, 12, 31, 0, 0, 0, 0);
            this.MovieReleaseDate.MinDate = new System.DateTime(1800, 1, 1, 0, 0, 0, 0);
            this.MovieReleaseDate.Name = "MovieReleaseDate";
            this.MovieReleaseDate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.MovieReleaseDate.Size = new System.Drawing.Size(138, 20);
            this.MovieReleaseDate.TabIndex = 46;
            this.MovieReleaseDate.Value = new System.DateTime(2022, 6, 20, 0, 0, 0, 0);
            // 
            // RegisterButton
            // 
            this.RegisterButton.BackColor = System.Drawing.Color.LightBlue;
            this.RegisterButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.RegisterButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegisterButton.Location = new System.Drawing.Point(688, 455);
            this.RegisterButton.Name = "RegisterButton";
            this.RegisterButton.Size = new System.Drawing.Size(155, 43);
            this.RegisterButton.TabIndex = 44;
            this.RegisterButton.Text = "Add";
            this.RegisterButton.UseVisualStyleBackColor = false;
            this.RegisterButton.Click += new System.EventHandler(this.RegisterButton_Click);
            // 
            // MovieLengthTextBox
            // 
            this.MovieLengthTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MovieLengthTextBox.Location = new System.Drawing.Point(51, 271);
            this.MovieLengthTextBox.MaxLength = 3;
            this.MovieLengthTextBox.Name = "MovieLengthTextBox";
            this.MovieLengthTextBox.Size = new System.Drawing.Size(260, 26);
            this.MovieLengthTextBox.TabIndex = 40;
            this.MovieLengthTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MovieLengthTextBox_KeyPress);
            // 
            // MovieNameTextBox
            // 
            this.MovieNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MovieNameTextBox.Location = new System.Drawing.Point(49, 148);
            this.MovieNameTextBox.MaxLength = 45;
            this.MovieNameTextBox.Name = "MovieNameTextBox";
            this.MovieNameTextBox.Size = new System.Drawing.Size(260, 26);
            this.MovieNameTextBox.TabIndex = 39;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(402, 15);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(150, 31);
            this.label10.TabIndex = 38;
            this.label10.Text = "Add Movie";
            // 
            // MovieGenreComBox
            // 
            this.MovieGenreComBox.BackColor = System.Drawing.SystemColors.Menu;
            this.MovieGenreComBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.MovieGenreComBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.MovieGenreComBox.ForeColor = System.Drawing.Color.Maroon;
            this.MovieGenreComBox.FormattingEnabled = true;
            this.MovieGenreComBox.Items.AddRange(new object[] {
            "Action",
            "Adventure",
            "Comedy",
            "Drama",
            "Fantasy",
            "Horror",
            "Mystery",
            "Romance",
            "Thriller"});
            this.MovieGenreComBox.Location = new System.Drawing.Point(51, 395);
            this.MovieGenreComBox.Name = "MovieGenreComBox";
            this.MovieGenreComBox.Size = new System.Drawing.Size(258, 21);
            this.MovieGenreComBox.TabIndex = 24;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(46, 364);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 18);
            this.label5.TabIndex = 12;
            this.label5.Text = "Genre";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(46, 239);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(152, 18);
            this.label4.TabIndex = 11;
            this.label4.Text = "Length (In Minutes)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(46, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 18);
            this.label3.TabIndex = 10;
            this.label3.Text = "Movie Name";
            // 
            // EditMovie
            // 
            this.EditMovie.Controls.Add(this.label17);
            this.EditMovie.Controls.Add(this.label16);
            this.EditMovie.Controls.Add(this.SearchEditMovieTextBox);
            this.EditMovie.Controls.Add(this.EditMovieBrowseButton);
            this.EditMovie.Controls.Add(this.EditMoviePosterBox);
            this.EditMovie.Controls.Add(this.EditMovieIDTextBox);
            this.EditMovie.Controls.Add(this.label19);
            this.EditMovie.Controls.Add(this.label13);
            this.EditMovie.Controls.Add(this.EditMovieReleaseDate);
            this.EditMovie.Controls.Add(this.EditMovieLengthTextBox);
            this.EditMovie.Controls.Add(this.EditMovieNameTextBox);
            this.EditMovie.Controls.Add(this.EditMovieGenreComBox);
            this.EditMovie.Controls.Add(this.label2);
            this.EditMovie.Controls.Add(this.label8);
            this.EditMovie.Controls.Add(this.label12);
            this.EditMovie.Controls.Add(this.EditMovieButton);
            this.EditMovie.Controls.Add(this.EditMovieDetailsGridView);
            this.EditMovie.Controls.Add(this.label9);
            this.EditMovie.Controls.Add(this.panel1);
            this.EditMovie.Location = new System.Drawing.Point(4, 22);
            this.EditMovie.Name = "EditMovie";
            this.EditMovie.Padding = new System.Windows.Forms.Padding(3);
            this.EditMovie.Size = new System.Drawing.Size(910, 565);
            this.EditMovie.TabIndex = 1;
            this.EditMovie.Text = "Edit Movie";
            this.EditMovie.UseVisualStyleBackColor = true;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.Green;
            this.label17.Location = new System.Drawing.Point(6, 303);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(129, 18);
            this.label17.TabIndex = 75;
            this.label17.Text = "Select a Record";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Gray;
            this.label16.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(368, 268);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(160, 18);
            this.label16.TabIndex = 74;
            this.label16.Text = "Search Movie Name";
            // 
            // SearchEditMovieTextBox
            // 
            this.SearchEditMovieTextBox.BackColor = System.Drawing.Color.White;
            this.SearchEditMovieTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchEditMovieTextBox.Location = new System.Drawing.Point(369, 289);
            this.SearchEditMovieTextBox.MaxLength = 30;
            this.SearchEditMovieTextBox.Name = "SearchEditMovieTextBox";
            this.SearchEditMovieTextBox.Size = new System.Drawing.Size(187, 26);
            this.SearchEditMovieTextBox.TabIndex = 73;
            this.SearchEditMovieTextBox.TextChanged += new System.EventHandler(this.SearchMovieTextBox_TextChanged);
            // 
            // EditMovieBrowseButton
            // 
            this.EditMovieBrowseButton.Location = new System.Drawing.Point(813, 245);
            this.EditMovieBrowseButton.Name = "EditMovieBrowseButton";
            this.EditMovieBrowseButton.Size = new System.Drawing.Size(75, 23);
            this.EditMovieBrowseButton.TabIndex = 72;
            this.EditMovieBrowseButton.Text = "Browse";
            this.EditMovieBrowseButton.UseVisualStyleBackColor = true;
            this.EditMovieBrowseButton.Click += new System.EventHandler(this.EditMovieBrowseButton_Click);
            // 
            // EditMoviePosterBox
            // 
            this.EditMoviePosterBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.EditMoviePosterBox.Location = new System.Drawing.Point(709, 25);
            this.EditMoviePosterBox.Name = "EditMoviePosterBox";
            this.EditMoviePosterBox.Size = new System.Drawing.Size(179, 214);
            this.EditMoviePosterBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.EditMoviePosterBox.TabIndex = 71;
            this.EditMoviePosterBox.TabStop = false;
            // 
            // EditMovieIDTextBox
            // 
            this.EditMovieIDTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditMovieIDTextBox.Location = new System.Drawing.Point(68, 67);
            this.EditMovieIDTextBox.MaxLength = 32768;
            this.EditMovieIDTextBox.Name = "EditMovieIDTextBox";
            this.EditMovieIDTextBox.ReadOnly = true;
            this.EditMovieIDTextBox.Size = new System.Drawing.Size(260, 26);
            this.EditMovieIDTextBox.TabIndex = 70;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(65, 46);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(24, 18);
            this.label19.TabIndex = 69;
            this.label19.Text = "ID";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(365, 126);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(109, 18);
            this.label13.TabIndex = 68;
            this.label13.Text = "Release Date";
            // 
            // EditMovieReleaseDate
            // 
            this.EditMovieReleaseDate.CustomFormat = "yyyy-MM-dd";
            this.EditMovieReleaseDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditMovieReleaseDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.EditMovieReleaseDate.Location = new System.Drawing.Point(368, 158);
            this.EditMovieReleaseDate.MaxDate = new System.DateTime(2111, 12, 31, 0, 0, 0, 0);
            this.EditMovieReleaseDate.MinDate = new System.DateTime(1800, 1, 1, 0, 0, 0, 0);
            this.EditMovieReleaseDate.Name = "EditMovieReleaseDate";
            this.EditMovieReleaseDate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.EditMovieReleaseDate.Size = new System.Drawing.Size(138, 20);
            this.EditMovieReleaseDate.TabIndex = 67;
            this.EditMovieReleaseDate.Value = new System.DateTime(2022, 5, 15, 0, 0, 0, 0);
            // 
            // EditMovieLengthTextBox
            // 
            this.EditMovieLengthTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditMovieLengthTextBox.Location = new System.Drawing.Point(68, 223);
            this.EditMovieLengthTextBox.MaxLength = 3;
            this.EditMovieLengthTextBox.Name = "EditMovieLengthTextBox";
            this.EditMovieLengthTextBox.Size = new System.Drawing.Size(260, 26);
            this.EditMovieLengthTextBox.TabIndex = 66;
            this.EditMovieLengthTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EditMovieLengthTextBox_KeyPress);
            // 
            // EditMovieNameTextBox
            // 
            this.EditMovieNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditMovieNameTextBox.Location = new System.Drawing.Point(66, 139);
            this.EditMovieNameTextBox.MaxLength = 45;
            this.EditMovieNameTextBox.Name = "EditMovieNameTextBox";
            this.EditMovieNameTextBox.Size = new System.Drawing.Size(260, 26);
            this.EditMovieNameTextBox.TabIndex = 65;
            // 
            // EditMovieGenreComBox
            // 
            this.EditMovieGenreComBox.BackColor = System.Drawing.SystemColors.Menu;
            this.EditMovieGenreComBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.EditMovieGenreComBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.EditMovieGenreComBox.ForeColor = System.Drawing.Color.Maroon;
            this.EditMovieGenreComBox.FormattingEnabled = true;
            this.EditMovieGenreComBox.Items.AddRange(new object[] {
            "Action",
            "Adventure",
            "Comedy",
            "Drama",
            "Fantasy",
            "Horror",
            "Mystery",
            "Romance",
            "Thriller"});
            this.EditMovieGenreComBox.Location = new System.Drawing.Point(368, 85);
            this.EditMovieGenreComBox.Name = "EditMovieGenreComBox";
            this.EditMovieGenreComBox.Size = new System.Drawing.Size(258, 21);
            this.EditMovieGenreComBox.TabIndex = 64;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(365, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 18);
            this.label2.TabIndex = 63;
            this.label2.Text = "Genre";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(63, 191);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(152, 18);
            this.label8.TabIndex = 62;
            this.label8.Text = "Length (In Minutes)";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(63, 109);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(102, 18);
            this.label12.TabIndex = 61;
            this.label12.Text = "Movie Name";
            // 
            // EditMovieButton
            // 
            this.EditMovieButton.BackColor = System.Drawing.Color.LightBlue;
            this.EditMovieButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.EditMovieButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditMovieButton.Location = new System.Drawing.Point(733, 281);
            this.EditMovieButton.Name = "EditMovieButton";
            this.EditMovieButton.Size = new System.Drawing.Size(155, 43);
            this.EditMovieButton.TabIndex = 60;
            this.EditMovieButton.Text = "Submit";
            this.EditMovieButton.UseVisualStyleBackColor = false;
            this.EditMovieButton.Click += new System.EventHandler(this.EditMovieButton_Click);
            // 
            // EditMovieDetailsGridView
            // 
            this.EditMovieDetailsGridView.AllowUserToAddRows = false;
            this.EditMovieDetailsGridView.AllowUserToDeleteRows = false;
            this.EditMovieDetailsGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.EditMovieDetailsGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.EditMovieDetailsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EditMovieDetailsGridView.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EditMovieDetailsGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.EditMovieDetailsGridView.Location = new System.Drawing.Point(6, 327);
            this.EditMovieDetailsGridView.MultiSelect = false;
            this.EditMovieDetailsGridView.Name = "EditMovieDetailsGridView";
            this.EditMovieDetailsGridView.ReadOnly = true;
            this.EditMovieDetailsGridView.RowTemplate.Height = 100;
            this.EditMovieDetailsGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.EditMovieDetailsGridView.Size = new System.Drawing.Size(898, 232);
            this.EditMovieDetailsGridView.TabIndex = 53;
            this.EditMovieDetailsGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.EditMovieDetailsGridView_CellClick);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(402, 3);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(150, 31);
            this.label9.TabIndex = 38;
            this.label9.Text = "Edit Movie";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.ForeColor = System.Drawing.Color.Transparent;
            this.panel1.Location = new System.Drawing.Point(358, 261);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(215, 63);
            this.panel1.TabIndex = 76;
            // 
            // DeleteMovie
            // 
            this.DeleteMovie.Controls.Add(this.DelMoviePosterBox);
            this.DeleteMovie.Controls.Add(this.DelMovieDetailsGridView);
            this.DeleteMovie.Controls.Add(this.label20);
            this.DeleteMovie.Controls.Add(this.SearchDelMovieTextBox);
            this.DeleteMovie.Controls.Add(this.panel2);
            this.DeleteMovie.Controls.Add(this.label18);
            this.DeleteMovie.Controls.Add(this.DelMovieIDTextBox);
            this.DeleteMovie.Controls.Add(this.label14);
            this.DeleteMovie.Controls.Add(this.DelMovieNameTextBox);
            this.DeleteMovie.Controls.Add(this.label15);
            this.DeleteMovie.Controls.Add(this.DelMovieButton);
            this.DeleteMovie.Controls.Add(this.label11);
            this.DeleteMovie.Location = new System.Drawing.Point(4, 22);
            this.DeleteMovie.Name = "DeleteMovie";
            this.DeleteMovie.Padding = new System.Windows.Forms.Padding(3);
            this.DeleteMovie.Size = new System.Drawing.Size(910, 565);
            this.DeleteMovie.TabIndex = 2;
            this.DeleteMovie.Text = "Delete Movie";
            this.DeleteMovie.UseVisualStyleBackColor = true;
            // 
            // DelMoviePosterBox
            // 
            this.DelMoviePosterBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DelMoviePosterBox.Location = new System.Drawing.Point(595, 24);
            this.DelMoviePosterBox.Name = "DelMoviePosterBox";
            this.DelMoviePosterBox.Size = new System.Drawing.Size(155, 168);
            this.DelMoviePosterBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.DelMoviePosterBox.TabIndex = 80;
            this.DelMoviePosterBox.TabStop = false;
            // 
            // DelMovieDetailsGridView
            // 
            this.DelMovieDetailsGridView.AllowUserToAddRows = false;
            this.DelMovieDetailsGridView.AllowUserToDeleteRows = false;
            this.DelMovieDetailsGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DelMovieDetailsGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DelMovieDetailsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DelMovieDetailsGridView.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DelMovieDetailsGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.DelMovieDetailsGridView.Location = new System.Drawing.Point(6, 294);
            this.DelMovieDetailsGridView.Name = "DelMovieDetailsGridView";
            this.DelMovieDetailsGridView.ReadOnly = true;
            this.DelMovieDetailsGridView.RowTemplate.Height = 100;
            this.DelMovieDetailsGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.DelMovieDetailsGridView.Size = new System.Drawing.Size(898, 265);
            this.DelMovieDetailsGridView.TabIndex = 54;
            this.DelMovieDetailsGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DelMovieDetailsGridView_CellClick);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.BackColor = System.Drawing.Color.Gray;
            this.label20.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.White;
            this.label20.Location = new System.Drawing.Point(406, 230);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(160, 18);
            this.label20.TabIndex = 78;
            this.label20.Text = "Search Movie Name";
            // 
            // SearchDelMovieTextBox
            // 
            this.SearchDelMovieTextBox.BackColor = System.Drawing.Color.White;
            this.SearchDelMovieTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchDelMovieTextBox.Location = new System.Drawing.Point(407, 251);
            this.SearchDelMovieTextBox.MaxLength = 30;
            this.SearchDelMovieTextBox.Name = "SearchDelMovieTextBox";
            this.SearchDelMovieTextBox.Size = new System.Drawing.Size(187, 26);
            this.SearchDelMovieTextBox.TabIndex = 77;
            this.SearchDelMovieTextBox.TextChanged += new System.EventHandler(this.SearchDelMovieTextBox_TextChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gray;
            this.panel2.ForeColor = System.Drawing.Color.Transparent;
            this.panel2.Location = new System.Drawing.Point(394, 225);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(215, 63);
            this.panel2.TabIndex = 79;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.Green;
            this.label18.Location = new System.Drawing.Point(6, 270);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(129, 18);
            this.label18.TabIndex = 76;
            this.label18.Text = "Select a Record";
            // 
            // DelMovieIDTextBox
            // 
            this.DelMovieIDTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DelMovieIDTextBox.Location = new System.Drawing.Point(214, 79);
            this.DelMovieIDTextBox.MaxLength = 32768;
            this.DelMovieIDTextBox.Name = "DelMovieIDTextBox";
            this.DelMovieIDTextBox.ReadOnly = true;
            this.DelMovieIDTextBox.Size = new System.Drawing.Size(260, 26);
            this.DelMovieIDTextBox.TabIndex = 74;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(211, 58);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(24, 18);
            this.label14.TabIndex = 73;
            this.label14.Text = "ID";
            // 
            // DelMovieNameTextBox
            // 
            this.DelMovieNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DelMovieNameTextBox.Location = new System.Drawing.Point(214, 150);
            this.DelMovieNameTextBox.MaxLength = 30;
            this.DelMovieNameTextBox.Name = "DelMovieNameTextBox";
            this.DelMovieNameTextBox.ReadOnly = true;
            this.DelMovieNameTextBox.Size = new System.Drawing.Size(260, 26);
            this.DelMovieNameTextBox.TabIndex = 72;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(211, 120);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(102, 18);
            this.label15.TabIndex = 71;
            this.label15.Text = "Movie Name";
            // 
            // DelMovieButton
            // 
            this.DelMovieButton.BackColor = System.Drawing.Color.LightBlue;
            this.DelMovieButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.DelMovieButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DelMovieButton.Location = new System.Drawing.Point(628, 198);
            this.DelMovieButton.Name = "DelMovieButton";
            this.DelMovieButton.Size = new System.Drawing.Size(122, 43);
            this.DelMovieButton.TabIndex = 61;
            this.DelMovieButton.Text = "Delete";
            this.DelMovieButton.UseVisualStyleBackColor = false;
            this.DelMovieButton.Click += new System.EventHandler(this.DelMovieButton_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(388, 3);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(184, 31);
            this.label11.TabIndex = 38;
            this.label11.Text = "Delete Movie";
            // 
            // MoviesUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.Label1);
            this.Name = "MoviesUC";
            this.Size = new System.Drawing.Size(924, 668);
            this.Enter += new System.EventHandler(this.MoviesUC_Enter);
            this.Leave += new System.EventHandler(this.MoviesUC_Leave);
            this.tabControl1.ResumeLayout(false);
            this.AddMovie.ResumeLayout(false);
            this.AddMovie.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MoviePosterBox)).EndInit();
            this.EditMovie.ResumeLayout(false);
            this.EditMovie.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EditMoviePosterBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EditMovieDetailsGridView)).EndInit();
            this.DeleteMovie.ResumeLayout(false);
            this.DeleteMovie.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DelMoviePosterBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DelMovieDetailsGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage AddMovie;
        private System.Windows.Forms.Button RegisterButton;
        private System.Windows.Forms.TextBox MovieLengthTextBox;
        private System.Windows.Forms.TextBox MovieNameTextBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabPage EditMovie;
        private System.Windows.Forms.Button EditMovieButton;
        private System.Windows.Forms.DataGridView EditMovieDetailsGridView;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TabPage DeleteMovie;
        private System.Windows.Forms.Button DelMovieButton;
        private System.Windows.Forms.DataGridView DelMovieDetailsGridView;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox MovieGenreComBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button BrowseImageButton;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox MoviePosterBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker MovieReleaseDate;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DateTimePicker EditMovieReleaseDate;
        private System.Windows.Forms.TextBox EditMovieLengthTextBox;
        private System.Windows.Forms.TextBox EditMovieNameTextBox;
        private System.Windows.Forms.ComboBox EditMovieGenreComBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button EditMovieBrowseButton;
        private System.Windows.Forms.PictureBox EditMoviePosterBox;
        private System.Windows.Forms.TextBox EditMovieIDTextBox;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox SearchEditMovieTextBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox DelMovieIDTextBox;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox DelMovieNameTextBox;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox SearchDelMovieTextBox;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.PictureBox DelMoviePosterBox;
    }
}
