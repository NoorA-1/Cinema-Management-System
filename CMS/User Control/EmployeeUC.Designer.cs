namespace CMS.User_Control
{
    partial class EmployeeUC
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
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.AddEmployee = new System.Windows.Forms.TabPage();
            this.label27 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.EmpDob = new System.Windows.Forms.DateTimePicker();
            this.RegisterButton = new System.Windows.Forms.Button();
            this.EmpPasswordTextBox = new System.Windows.Forms.TextBox();
            this.EmpUsernameTextBox = new System.Windows.Forms.TextBox();
            this.EmpEmailTextBox = new System.Windows.Forms.TextBox();
            this.EmpPhoneTextBox = new System.Windows.Forms.TextBox();
            this.EmpNameTextBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.EmpGenderComBox = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.EditEmployee = new System.Windows.Forms.TabPage();
            this.label30 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.EditEmpDob = new System.Windows.Forms.DateTimePicker();
            this.SubmitEdit = new System.Windows.Forms.Button();
            this.EditEmpPasswordTextBox = new System.Windows.Forms.TextBox();
            this.EditEmpUsernameTextBox = new System.Windows.Forms.TextBox();
            this.EditEmpEmailTextBox = new System.Windows.Forms.TextBox();
            this.EditEmpPhoneTextBox = new System.Windows.Forms.TextBox();
            this.EditEmpNameTextBox = new System.Windows.Forms.TextBox();
            this.EditEmpIDTextBox = new System.Windows.Forms.TextBox();
            this.EditEmpDetailsGridView = new System.Windows.Forms.DataGridView();
            this.label19 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.EditEmpGenderComBox = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.DeleteEmployee = new System.Windows.Forms.TabPage();
            this.DelEmpButton = new System.Windows.Forms.Button();
            this.DelEmpNameTextBox = new System.Windows.Forms.TextBox();
            this.DelEmpIDTextBox = new System.Windows.Forms.TextBox();
            this.DelEmpGridView = new System.Windows.Forms.DataGridView();
            this.label12 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider3 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider4 = new System.Windows.Forms.ErrorProvider(this.components);
            this.tabControl1.SuspendLayout();
            this.AddEmployee.SuspendLayout();
            this.EditEmployee.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EditEmpDetailsGridView)).BeginInit();
            this.DeleteEmployee.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DelEmpGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider4)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.AddEmployee);
            this.tabControl1.Controls.Add(this.EditEmployee);
            this.tabControl1.Controls.Add(this.DeleteEmployee);
            this.tabControl1.Location = new System.Drawing.Point(3, 63);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(918, 593);
            this.tabControl1.TabIndex = 38;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // AddEmployee
            // 
            this.AddEmployee.Controls.Add(this.label27);
            this.AddEmployee.Controls.Add(this.label26);
            this.AddEmployee.Controls.Add(this.label23);
            this.AddEmployee.Controls.Add(this.label22);
            this.AddEmployee.Controls.Add(this.label20);
            this.AddEmployee.Controls.Add(this.EmpDob);
            this.AddEmployee.Controls.Add(this.RegisterButton);
            this.AddEmployee.Controls.Add(this.EmpPasswordTextBox);
            this.AddEmployee.Controls.Add(this.EmpUsernameTextBox);
            this.AddEmployee.Controls.Add(this.EmpEmailTextBox);
            this.AddEmployee.Controls.Add(this.EmpPhoneTextBox);
            this.AddEmployee.Controls.Add(this.EmpNameTextBox);
            this.AddEmployee.Controls.Add(this.label10);
            this.AddEmployee.Controls.Add(this.label7);
            this.AddEmployee.Controls.Add(this.label8);
            this.AddEmployee.Controls.Add(this.EmpGenderComBox);
            this.AddEmployee.Controls.Add(this.label6);
            this.AddEmployee.Controls.Add(this.label5);
            this.AddEmployee.Controls.Add(this.label4);
            this.AddEmployee.Controls.Add(this.label3);
            this.AddEmployee.Location = new System.Drawing.Point(4, 22);
            this.AddEmployee.Name = "AddEmployee";
            this.AddEmployee.Padding = new System.Windows.Forms.Padding(3);
            this.AddEmployee.Size = new System.Drawing.Size(910, 567);
            this.AddEmployee.TabIndex = 0;
            this.AddEmployee.Text = "Add Employee";
            this.AddEmployee.UseVisualStyleBackColor = true;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.ForeColor = System.Drawing.Color.ForestGreen;
            this.label27.Location = new System.Drawing.Point(771, 268);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(97, 16);
            this.label27.TabIndex = 54;
            this.label27.Text = "Min Length: 5";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.ForeColor = System.Drawing.Color.ForestGreen;
            this.label26.Location = new System.Drawing.Point(771, 177);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(97, 16);
            this.label26.TabIndex = 53;
            this.label26.Text = "Min Length: 4";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.ForeColor = System.Drawing.Color.ForestGreen;
            this.label23.Location = new System.Drawing.Point(757, 129);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(111, 16);
            this.label23.TabIndex = 52;
            this.label23.Text = "(Alphanumeric)";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.ForeColor = System.Drawing.Color.ForestGreen;
            this.label22.Location = new System.Drawing.Point(193, 216);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(119, 18);
            this.label22.TabIndex = 51;
            this.label22.Text = "(03331234567)";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(364, 118);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(106, 18);
            this.label20.TabIndex = 50;
            this.label20.Text = "Date Of Birth";
            // 
            // EmpDob
            // 
            this.EmpDob.CustomFormat = "yyyy-MM-dd";
            this.EmpDob.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmpDob.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.EmpDob.Location = new System.Drawing.Point(367, 147);
            this.EmpDob.MaxDate = new System.DateTime(2004, 12, 31, 0, 0, 0, 0);
            this.EmpDob.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.EmpDob.Name = "EmpDob";
            this.EmpDob.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.EmpDob.Size = new System.Drawing.Size(184, 20);
            this.EmpDob.TabIndex = 49;
            this.EmpDob.Value = new System.DateTime(1970, 1, 1, 0, 0, 0, 0);
            // 
            // RegisterButton
            // 
            this.RegisterButton.BackColor = System.Drawing.Color.LightBlue;
            this.RegisterButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.RegisterButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegisterButton.Location = new System.Drawing.Point(713, 322);
            this.RegisterButton.Name = "RegisterButton";
            this.RegisterButton.Size = new System.Drawing.Size(155, 43);
            this.RegisterButton.TabIndex = 44;
            this.RegisterButton.Text = "Register";
            this.RegisterButton.UseVisualStyleBackColor = false;
            this.RegisterButton.Click += new System.EventHandler(this.RegisterButton_Click);
            // 
            // EmpPasswordTextBox
            // 
            this.EmpPasswordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmpPasswordTextBox.Location = new System.Drawing.Point(608, 239);
            this.EmpPasswordTextBox.MaxLength = 15;
            this.EmpPasswordTextBox.Name = "EmpPasswordTextBox";
            this.EmpPasswordTextBox.PasswordChar = '●';
            this.EmpPasswordTextBox.Size = new System.Drawing.Size(260, 26);
            this.EmpPasswordTextBox.TabIndex = 43;
            this.EmpPasswordTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EmpPasswordTextBox_KeyPress);
            this.EmpPasswordTextBox.Leave += new System.EventHandler(this.EmpPasswordTextBox_Leave);
            // 
            // EmpUsernameTextBox
            // 
            this.EmpUsernameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmpUsernameTextBox.Location = new System.Drawing.Point(608, 148);
            this.EmpUsernameTextBox.MaxLength = 30;
            this.EmpUsernameTextBox.Name = "EmpUsernameTextBox";
            this.EmpUsernameTextBox.Size = new System.Drawing.Size(260, 26);
            this.EmpUsernameTextBox.TabIndex = 42;
            this.EmpUsernameTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EmpUsernameTextBox_KeyPress);
            this.EmpUsernameTextBox.Leave += new System.EventHandler(this.EmpUsernameTextBox_Leave);
            // 
            // EmpEmailTextBox
            // 
            this.EmpEmailTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmpEmailTextBox.Location = new System.Drawing.Point(49, 410);
            this.EmpEmailTextBox.MaxLength = 30;
            this.EmpEmailTextBox.Name = "EmpEmailTextBox";
            this.EmpEmailTextBox.Size = new System.Drawing.Size(260, 26);
            this.EmpEmailTextBox.TabIndex = 41;
            this.EmpEmailTextBox.Leave += new System.EventHandler(this.EmpEmailTextBox_Leave);
            // 
            // EmpPhoneTextBox
            // 
            this.EmpPhoneTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmpPhoneTextBox.Location = new System.Drawing.Point(51, 239);
            this.EmpPhoneTextBox.MaxLength = 11;
            this.EmpPhoneTextBox.Name = "EmpPhoneTextBox";
            this.EmpPhoneTextBox.Size = new System.Drawing.Size(260, 26);
            this.EmpPhoneTextBox.TabIndex = 40;
            this.EmpPhoneTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EmpPhoneTextBox_KeyPress);
            this.EmpPhoneTextBox.Leave += new System.EventHandler(this.EmpPhoneTextBox_Leave);
            // 
            // EmpNameTextBox
            // 
            this.EmpNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmpNameTextBox.Location = new System.Drawing.Point(49, 148);
            this.EmpNameTextBox.MaxLength = 30;
            this.EmpNameTextBox.Name = "EmpNameTextBox";
            this.EmpNameTextBox.Size = new System.Drawing.Size(260, 26);
            this.EmpNameTextBox.TabIndex = 39;
            this.EmpNameTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EmpNameTextBox_KeyPress);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(402, 15);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(201, 31);
            this.label10.TabIndex = 38;
            this.label10.Text = "Add Employee";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(605, 207);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 18);
            this.label7.TabIndex = 27;
            this.label7.Text = "Password";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(603, 118);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 18);
            this.label8.TabIndex = 26;
            this.label8.Text = "Username";
            // 
            // EmpGenderComBox
            // 
            this.EmpGenderComBox.BackColor = System.Drawing.SystemColors.Menu;
            this.EmpGenderComBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.EmpGenderComBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.EmpGenderComBox.ForeColor = System.Drawing.Color.Maroon;
            this.EmpGenderComBox.FormattingEnabled = true;
            this.EmpGenderComBox.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.EmpGenderComBox.Location = new System.Drawing.Point(51, 322);
            this.EmpGenderComBox.Name = "EmpGenderComBox";
            this.EmpGenderComBox.Size = new System.Drawing.Size(258, 21);
            this.EmpGenderComBox.TabIndex = 24;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(48, 380);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 18);
            this.label6.TabIndex = 13;
            this.label6.Text = "Email";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(46, 291);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 18);
            this.label5.TabIndex = 12;
            this.label5.Text = "Gender";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(46, 207);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 18);
            this.label4.TabIndex = 11;
            this.label4.Text = "Phone Number";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(46, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 18);
            this.label3.TabIndex = 10;
            this.label3.Text = "Name";
            // 
            // EditEmployee
            // 
            this.EditEmployee.Controls.Add(this.label30);
            this.EditEmployee.Controls.Add(this.label28);
            this.EditEmployee.Controls.Add(this.label29);
            this.EditEmployee.Controls.Add(this.label24);
            this.EditEmployee.Controls.Add(this.label25);
            this.EditEmployee.Controls.Add(this.label21);
            this.EditEmployee.Controls.Add(this.EditEmpDob);
            this.EditEmployee.Controls.Add(this.SubmitEdit);
            this.EditEmployee.Controls.Add(this.EditEmpPasswordTextBox);
            this.EditEmployee.Controls.Add(this.EditEmpUsernameTextBox);
            this.EditEmployee.Controls.Add(this.EditEmpEmailTextBox);
            this.EditEmployee.Controls.Add(this.EditEmpPhoneTextBox);
            this.EditEmployee.Controls.Add(this.EditEmpNameTextBox);
            this.EditEmployee.Controls.Add(this.EditEmpIDTextBox);
            this.EditEmployee.Controls.Add(this.EditEmpDetailsGridView);
            this.EditEmployee.Controls.Add(this.label19);
            this.EditEmployee.Controls.Add(this.label13);
            this.EditEmployee.Controls.Add(this.label14);
            this.EditEmployee.Controls.Add(this.EditEmpGenderComBox);
            this.EditEmployee.Controls.Add(this.label15);
            this.EditEmployee.Controls.Add(this.label16);
            this.EditEmployee.Controls.Add(this.label17);
            this.EditEmployee.Controls.Add(this.label18);
            this.EditEmployee.Controls.Add(this.label9);
            this.EditEmployee.Location = new System.Drawing.Point(4, 22);
            this.EditEmployee.Name = "EditEmployee";
            this.EditEmployee.Padding = new System.Windows.Forms.Padding(3);
            this.EditEmployee.Size = new System.Drawing.Size(910, 567);
            this.EditEmployee.TabIndex = 1;
            this.EditEmployee.Text = "Edit Employee ";
            this.EditEmployee.UseVisualStyleBackColor = true;
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label30.ForeColor = System.Drawing.Color.ForestGreen;
            this.label30.Location = new System.Drawing.Point(764, 124);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(121, 18);
            this.label30.TabIndex = 67;
            this.label30.Text = "(Alphanumeric)";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label28.ForeColor = System.Drawing.Color.ForestGreen;
            this.label28.Location = new System.Drawing.Point(788, 174);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(97, 16);
            this.label28.TabIndex = 66;
            this.label28.Text = "Min Length: 5";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label29.ForeColor = System.Drawing.Color.ForestGreen;
            this.label29.Location = new System.Drawing.Point(790, 101);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(97, 16);
            this.label29.TabIndex = 65;
            this.label29.Text = "Min Length: 4";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.ForeColor = System.Drawing.Color.ForestGreen;
            this.label24.Location = new System.Drawing.Point(766, 51);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(121, 18);
            this.label24.TabIndex = 64;
            this.label24.Text = "(Alphanumeric)";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.ForeColor = System.Drawing.Color.ForestGreen;
            this.label25.Location = new System.Drawing.Point(205, 192);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(119, 18);
            this.label25.TabIndex = 63;
            this.label25.Text = "(03331234567)";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(340, 120);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(106, 18);
            this.label21.TabIndex = 62;
            this.label21.Text = "Date Of Birth";
            // 
            // EditEmpDob
            // 
            this.EditEmpDob.CustomFormat = "yyyy-MM-dd";
            this.EditEmpDob.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditEmpDob.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.EditEmpDob.Location = new System.Drawing.Point(343, 149);
            this.EditEmpDob.MaxDate = new System.DateTime(2004, 12, 31, 0, 0, 0, 0);
            this.EditEmpDob.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.EditEmpDob.Name = "EditEmpDob";
            this.EditEmpDob.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.EditEmpDob.Size = new System.Drawing.Size(184, 20);
            this.EditEmpDob.TabIndex = 61;
            this.EditEmpDob.Value = new System.DateTime(1970, 1, 1, 0, 0, 0, 0);
            // 
            // SubmitEdit
            // 
            this.SubmitEdit.BackColor = System.Drawing.Color.LightBlue;
            this.SubmitEdit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SubmitEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubmitEdit.Location = new System.Drawing.Point(730, 213);
            this.SubmitEdit.Name = "SubmitEdit";
            this.SubmitEdit.Size = new System.Drawing.Size(155, 43);
            this.SubmitEdit.TabIndex = 60;
            this.SubmitEdit.Text = "Submit";
            this.SubmitEdit.UseVisualStyleBackColor = false;
            this.SubmitEdit.Click += new System.EventHandler(this.SubmitEdit_Click);
            // 
            // EditEmpPasswordTextBox
            // 
            this.EditEmpPasswordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditEmpPasswordTextBox.Location = new System.Drawing.Point(627, 145);
            this.EditEmpPasswordTextBox.MaxLength = 30;
            this.EditEmpPasswordTextBox.Name = "EditEmpPasswordTextBox";
            this.EditEmpPasswordTextBox.Size = new System.Drawing.Size(260, 26);
            this.EditEmpPasswordTextBox.TabIndex = 59;
            this.EditEmpPasswordTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EditEmpPasswordTextBox_KeyPress);
            this.EditEmpPasswordTextBox.Leave += new System.EventHandler(this.EditEmpPasswordTextBox_Leave);
            // 
            // EditEmpUsernameTextBox
            // 
            this.EditEmpUsernameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditEmpUsernameTextBox.Location = new System.Drawing.Point(627, 72);
            this.EditEmpUsernameTextBox.MaxLength = 30;
            this.EditEmpUsernameTextBox.Name = "EditEmpUsernameTextBox";
            this.EditEmpUsernameTextBox.Size = new System.Drawing.Size(260, 26);
            this.EditEmpUsernameTextBox.TabIndex = 58;
            this.EditEmpUsernameTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EditEmpUsernameTextBox_KeyPress);
            this.EditEmpUsernameTextBox.Leave += new System.EventHandler(this.EditEmpUsernameTextBox_Leave);
            // 
            // EditEmpEmailTextBox
            // 
            this.EditEmpEmailTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditEmpEmailTextBox.Location = new System.Drawing.Point(343, 217);
            this.EditEmpEmailTextBox.MaxLength = 30;
            this.EditEmpEmailTextBox.Name = "EditEmpEmailTextBox";
            this.EditEmpEmailTextBox.Size = new System.Drawing.Size(260, 26);
            this.EditEmpEmailTextBox.TabIndex = 57;
            this.EditEmpEmailTextBox.Leave += new System.EventHandler(this.EditEmpEmailTextBox_Leave);
            // 
            // EditEmpPhoneTextBox
            // 
            this.EditEmpPhoneTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditEmpPhoneTextBox.Location = new System.Drawing.Point(64, 213);
            this.EditEmpPhoneTextBox.MaxLength = 11;
            this.EditEmpPhoneTextBox.Name = "EditEmpPhoneTextBox";
            this.EditEmpPhoneTextBox.Size = new System.Drawing.Size(260, 26);
            this.EditEmpPhoneTextBox.TabIndex = 56;
            this.EditEmpPhoneTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EditEmpPhoneTextBox_KeyPress);
            this.EditEmpPhoneTextBox.Leave += new System.EventHandler(this.EditEmpPhoneTextBox_Leave);
            // 
            // EditEmpNameTextBox
            // 
            this.EditEmpNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditEmpNameTextBox.Location = new System.Drawing.Point(64, 141);
            this.EditEmpNameTextBox.MaxLength = 30;
            this.EditEmpNameTextBox.Name = "EditEmpNameTextBox";
            this.EditEmpNameTextBox.Size = new System.Drawing.Size(260, 26);
            this.EditEmpNameTextBox.TabIndex = 55;
            this.EditEmpNameTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EditEmpNameTextBox_KeyPress);
            // 
            // EditEmpIDTextBox
            // 
            this.EditEmpIDTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditEmpIDTextBox.Location = new System.Drawing.Point(64, 74);
            this.EditEmpIDTextBox.MaxLength = 32768;
            this.EditEmpIDTextBox.Name = "EditEmpIDTextBox";
            this.EditEmpIDTextBox.ReadOnly = true;
            this.EditEmpIDTextBox.Size = new System.Drawing.Size(260, 26);
            this.EditEmpIDTextBox.TabIndex = 54;
            // 
            // EditEmpDetailsGridView
            // 
            this.EditEmpDetailsGridView.AllowUserToAddRows = false;
            this.EditEmpDetailsGridView.AllowUserToDeleteRows = false;
            this.EditEmpDetailsGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.EditEmpDetailsGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.EditEmpDetailsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EditEmpDetailsGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.EditEmpDetailsGridView.Location = new System.Drawing.Point(6, 269);
            this.EditEmpDetailsGridView.Name = "EditEmpDetailsGridView";
            this.EditEmpDetailsGridView.ReadOnly = true;
            this.EditEmpDetailsGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.EditEmpDetailsGridView.Size = new System.Drawing.Size(898, 292);
            this.EditEmpDetailsGridView.TabIndex = 53;
            this.EditEmpDetailsGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.EditEmpDetailsGridView_CellClick);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(61, 53);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(24, 18);
            this.label19.TabIndex = 52;
            this.label19.Text = "ID";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(624, 111);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(83, 18);
            this.label13.TabIndex = 48;
            this.label13.Text = "Password";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(624, 38);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(85, 18);
            this.label14.TabIndex = 47;
            this.label14.Text = "Username";
            // 
            // EditEmpGenderComBox
            // 
            this.EditEmpGenderComBox.BackColor = System.Drawing.SystemColors.Menu;
            this.EditEmpGenderComBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.EditEmpGenderComBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.EditEmpGenderComBox.ForeColor = System.Drawing.Color.Maroon;
            this.EditEmpGenderComBox.FormattingEnabled = true;
            this.EditEmpGenderComBox.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.EditEmpGenderComBox.Location = new System.Drawing.Point(343, 78);
            this.EditEmpGenderComBox.Name = "EditEmpGenderComBox";
            this.EditEmpGenderComBox.Size = new System.Drawing.Size(258, 21);
            this.EditEmpGenderComBox.TabIndex = 45;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(340, 192);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(50, 18);
            this.label15.TabIndex = 42;
            this.label15.Text = "Email";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(340, 53);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(63, 18);
            this.label16.TabIndex = 41;
            this.label16.Text = "Gender";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(61, 192);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(120, 18);
            this.label17.TabIndex = 40;
            this.label17.Text = "Phone Number";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(61, 120);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(52, 18);
            this.label18.TabIndex = 39;
            this.label18.Text = "Name";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(368, 3);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(201, 31);
            this.label9.TabIndex = 38;
            this.label9.Text = "Edit Employee";
            // 
            // DeleteEmployee
            // 
            this.DeleteEmployee.Controls.Add(this.DelEmpButton);
            this.DeleteEmployee.Controls.Add(this.DelEmpNameTextBox);
            this.DeleteEmployee.Controls.Add(this.DelEmpIDTextBox);
            this.DeleteEmployee.Controls.Add(this.DelEmpGridView);
            this.DeleteEmployee.Controls.Add(this.label12);
            this.DeleteEmployee.Controls.Add(this.label2);
            this.DeleteEmployee.Controls.Add(this.label11);
            this.DeleteEmployee.Location = new System.Drawing.Point(4, 22);
            this.DeleteEmployee.Name = "DeleteEmployee";
            this.DeleteEmployee.Padding = new System.Windows.Forms.Padding(3);
            this.DeleteEmployee.Size = new System.Drawing.Size(910, 567);
            this.DeleteEmployee.TabIndex = 2;
            this.DeleteEmployee.Text = "Delete Employee";
            this.DeleteEmployee.UseVisualStyleBackColor = true;
            // 
            // DelEmpButton
            // 
            this.DelEmpButton.BackColor = System.Drawing.Color.LightBlue;
            this.DelEmpButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.DelEmpButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DelEmpButton.Location = new System.Drawing.Point(643, 149);
            this.DelEmpButton.Name = "DelEmpButton";
            this.DelEmpButton.Size = new System.Drawing.Size(155, 43);
            this.DelEmpButton.TabIndex = 61;
            this.DelEmpButton.Text = "Delete";
            this.DelEmpButton.UseVisualStyleBackColor = false;
            this.DelEmpButton.Click += new System.EventHandler(this.DelEmpButton_Click);
            // 
            // DelEmpNameTextBox
            // 
            this.DelEmpNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DelEmpNameTextBox.Location = new System.Drawing.Point(538, 94);
            this.DelEmpNameTextBox.MaxLength = 30;
            this.DelEmpNameTextBox.Name = "DelEmpNameTextBox";
            this.DelEmpNameTextBox.ReadOnly = true;
            this.DelEmpNameTextBox.Size = new System.Drawing.Size(260, 26);
            this.DelEmpNameTextBox.TabIndex = 56;
            // 
            // DelEmpIDTextBox
            // 
            this.DelEmpIDTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DelEmpIDTextBox.Location = new System.Drawing.Point(185, 94);
            this.DelEmpIDTextBox.MaxLength = 32768;
            this.DelEmpIDTextBox.Name = "DelEmpIDTextBox";
            this.DelEmpIDTextBox.ReadOnly = true;
            this.DelEmpIDTextBox.Size = new System.Drawing.Size(260, 26);
            this.DelEmpIDTextBox.TabIndex = 55;
            // 
            // DelEmpGridView
            // 
            this.DelEmpGridView.AllowUserToAddRows = false;
            this.DelEmpGridView.AllowUserToDeleteRows = false;
            this.DelEmpGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DelEmpGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DelEmpGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DelEmpGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.DelEmpGridView.Location = new System.Drawing.Point(9, 208);
            this.DelEmpGridView.Name = "DelEmpGridView";
            this.DelEmpGridView.ReadOnly = true;
            this.DelEmpGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.DelEmpGridView.Size = new System.Drawing.Size(895, 353);
            this.DelEmpGridView.TabIndex = 54;
            this.DelEmpGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DelEmpGridView_CellClick);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(535, 73);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(52, 18);
            this.label12.TabIndex = 43;
            this.label12.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(182, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 18);
            this.label2.TabIndex = 41;
            this.label2.Text = "ID";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(388, 3);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(235, 31);
            this.label11.TabIndex = 38;
            this.label11.Text = "Delete Employee";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(434, 29);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(142, 31);
            this.Label1.TabIndex = 39;
            this.Label1.Text = "Employee";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // errorProvider3
            // 
            this.errorProvider3.ContainerControl = this;
            // 
            // errorProvider4
            // 
            this.errorProvider4.ContainerControl = this;
            // 
            // EmployeeUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.tabControl1);
            this.Name = "EmployeeUC";
            this.Size = new System.Drawing.Size(924, 668);
            this.Load += new System.EventHandler(this.EmployeeUC_Load);
            this.Leave += new System.EventHandler(this.EmployeeUC_Leave);
            this.tabControl1.ResumeLayout(false);
            this.AddEmployee.ResumeLayout(false);
            this.AddEmployee.PerformLayout();
            this.EditEmployee.ResumeLayout(false);
            this.EditEmployee.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EditEmpDetailsGridView)).EndInit();
            this.DeleteEmployee.ResumeLayout(false);
            this.DeleteEmployee.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DelEmpGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage AddEmployee;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox EmpGenderComBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabPage EditEmployee;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox EditEmpGenderComBox;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TabPage DeleteEmployee;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.TextBox EmpUsernameTextBox;
        private System.Windows.Forms.TextBox EmpEmailTextBox;
        private System.Windows.Forms.TextBox EmpPhoneTextBox;
        private System.Windows.Forms.TextBox EmpNameTextBox;
        private System.Windows.Forms.TextBox EmpPasswordTextBox;
        private System.Windows.Forms.Button RegisterButton;
        private System.Windows.Forms.DataGridView EditEmpDetailsGridView;
        private System.Windows.Forms.DataGridView DelEmpGridView;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.Button SubmitEdit;
        private System.Windows.Forms.TextBox EditEmpPasswordTextBox;
        private System.Windows.Forms.TextBox EditEmpUsernameTextBox;
        private System.Windows.Forms.TextBox EditEmpEmailTextBox;
        private System.Windows.Forms.TextBox EditEmpPhoneTextBox;
        private System.Windows.Forms.TextBox EditEmpNameTextBox;
        private System.Windows.Forms.TextBox EditEmpIDTextBox;
        private System.Windows.Forms.TextBox DelEmpNameTextBox;
        private System.Windows.Forms.TextBox DelEmpIDTextBox;
        private System.Windows.Forms.Button DelEmpButton;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.DateTimePicker EmpDob;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.DateTimePicker EditEmpDob;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.ErrorProvider errorProvider3;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.ErrorProvider errorProvider4;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label30;
    }
}
