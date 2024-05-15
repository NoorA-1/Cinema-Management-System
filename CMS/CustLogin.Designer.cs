namespace CMS
{
    partial class CustLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustLogin));
            this.InvalidUserPass = new System.Windows.Forms.Label();
            this.CustPasswordTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CustUsernameTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CustLoginButton = new System.Windows.Forms.Button();
            this.BackButton = new System.Windows.Forms.Button();
            this.CloseButton = new System.Windows.Forms.Button();
            this.BackPanel = new System.Windows.Forms.Panel();
            this.CustSignUpButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.BackPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // InvalidUserPass
            // 
            this.InvalidUserPass.AutoSize = true;
            this.InvalidUserPass.BackColor = System.Drawing.Color.Transparent;
            this.InvalidUserPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InvalidUserPass.ForeColor = System.Drawing.Color.Red;
            this.InvalidUserPass.Location = new System.Drawing.Point(78, 327);
            this.InvalidUserPass.Name = "InvalidUserPass";
            this.InvalidUserPass.Size = new System.Drawing.Size(238, 18);
            this.InvalidUserPass.TabIndex = 7;
            this.InvalidUserPass.Text = "Invalid Username or Password";
            this.InvalidUserPass.Visible = false;
            // 
            // CustPasswordTextBox
            // 
            this.CustPasswordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustPasswordTextBox.Location = new System.Drawing.Point(86, 154);
            this.CustPasswordTextBox.MaxLength = 12;
            this.CustPasswordTextBox.Name = "CustPasswordTextBox";
            this.CustPasswordTextBox.PasswordChar = '●';
            this.CustPasswordTextBox.Size = new System.Drawing.Size(208, 26);
            this.CustPasswordTextBox.TabIndex = 5;
            this.CustPasswordTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CustPasswordTextBox_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(82, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Password";
            // 
            // CustUsernameTextBox
            // 
            this.CustUsernameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustUsernameTextBox.Location = new System.Drawing.Point(86, 66);
            this.CustUsernameTextBox.MaxLength = 12;
            this.CustUsernameTextBox.Name = "CustUsernameTextBox";
            this.CustUsernameTextBox.Size = new System.Drawing.Size(208, 26);
            this.CustUsernameTextBox.TabIndex = 3;
            this.CustUsernameTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CustUsernameTextBox_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(82, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Username";
            // 
            // CustLoginButton
            // 
            this.CustLoginButton.BackColor = System.Drawing.Color.LightBlue;
            this.CustLoginButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CustLoginButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustLoginButton.Location = new System.Drawing.Point(182, 222);
            this.CustLoginButton.Name = "CustLoginButton";
            this.CustLoginButton.Size = new System.Drawing.Size(112, 43);
            this.CustLoginButton.TabIndex = 1;
            this.CustLoginButton.Text = "Login";
            this.CustLoginButton.UseVisualStyleBackColor = false;
            this.CustLoginButton.Click += new System.EventHandler(this.CustLoginButton_Click);
            // 
            // BackButton
            // 
            this.BackButton.BackColor = System.Drawing.Color.LightCoral;
            this.BackButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BackButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackButton.Location = new System.Drawing.Point(0, 12);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(110, 32);
            this.BackButton.TabIndex = 7;
            this.BackButton.Text = "Go Back";
            this.BackButton.UseVisualStyleBackColor = false;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // CloseButton
            // 
            this.CloseButton.BackColor = System.Drawing.Color.Red;
            this.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CloseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CloseButton.Location = new System.Drawing.Point(753, 12);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(41, 32);
            this.CloseButton.TabIndex = 6;
            this.CloseButton.Text = "X";
            this.CloseButton.UseVisualStyleBackColor = false;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // BackPanel
            // 
            this.BackPanel.Controls.Add(this.CustSignUpButton);
            this.BackPanel.Controls.Add(this.InvalidUserPass);
            this.BackPanel.Controls.Add(this.CustPasswordTextBox);
            this.BackPanel.Controls.Add(this.label2);
            this.BackPanel.Controls.Add(this.CustUsernameTextBox);
            this.BackPanel.Controls.Add(this.label1);
            this.BackPanel.Controls.Add(this.CustLoginButton);
            this.BackPanel.Location = new System.Drawing.Point(200, 95);
            this.BackPanel.Name = "BackPanel";
            this.BackPanel.Size = new System.Drawing.Size(397, 367);
            this.BackPanel.TabIndex = 5;
            // 
            // CustSignUpButton
            // 
            this.CustSignUpButton.BackColor = System.Drawing.Color.Azure;
            this.CustSignUpButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CustSignUpButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustSignUpButton.Location = new System.Drawing.Point(66, 222);
            this.CustSignUpButton.Name = "CustSignUpButton";
            this.CustSignUpButton.Size = new System.Drawing.Size(102, 43);
            this.CustSignUpButton.TabIndex = 8;
            this.CustSignUpButton.Text = "Sign Up";
            this.CustSignUpButton.UseVisualStyleBackColor = false;
            this.CustSignUpButton.Click += new System.EventHandler(this.CustSignUpButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(301, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(177, 25);
            this.label3.TabIndex = 8;
            this.label3.Text = "Customer Login";
            // 
            // CustLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(799, 517);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.BackPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CustLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CustLogin";
            this.BackPanel.ResumeLayout(false);
            this.BackPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label InvalidUserPass;
        private System.Windows.Forms.TextBox CustPasswordTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox CustUsernameTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button CustLoginButton;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Panel BackPanel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button CustSignUpButton;
    }
}