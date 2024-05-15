﻿namespace CMS.User_Control
{
    partial class EmpChangePassword
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
            this.label1 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.ChangePassButton = new System.Windows.Forms.Button();
            this.NewPassTextBox = new System.Windows.Forms.TextBox();
            this.CurrentPassTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.ForestGreen;
            this.label1.Location = new System.Drawing.Point(470, 232);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 16);
            this.label1.TabIndex = 81;
            this.label1.Text = "Min Length: 5";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.ForeColor = System.Drawing.Color.ForestGreen;
            this.label27.Location = new System.Drawing.Point(470, 355);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(97, 16);
            this.label27.TabIndex = 80;
            this.label27.Text = "Min Length: 5";
            // 
            // ChangePassButton
            // 
            this.ChangePassButton.BackColor = System.Drawing.Color.SkyBlue;
            this.ChangePassButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ChangePassButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChangePassButton.Location = new System.Drawing.Point(424, 408);
            this.ChangePassButton.Name = "ChangePassButton";
            this.ChangePassButton.Size = new System.Drawing.Size(143, 45);
            this.ChangePassButton.TabIndex = 79;
            this.ChangePassButton.Text = "Change";
            this.ChangePassButton.UseVisualStyleBackColor = false;
            this.ChangePassButton.Click += new System.EventHandler(this.ChangePassButton_Click);
            // 
            // NewPassTextBox
            // 
            this.NewPassTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewPassTextBox.Location = new System.Drawing.Point(307, 326);
            this.NewPassTextBox.MaxLength = 15;
            this.NewPassTextBox.Name = "NewPassTextBox";
            this.NewPassTextBox.PasswordChar = '●';
            this.NewPassTextBox.Size = new System.Drawing.Size(260, 26);
            this.NewPassTextBox.TabIndex = 78;
            this.NewPassTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NewPassTextBox_KeyPress);
            this.NewPassTextBox.Leave += new System.EventHandler(this.NewPassTextBox_Leave);
            // 
            // CurrentPassTextBox
            // 
            this.CurrentPassTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CurrentPassTextBox.Location = new System.Drawing.Point(305, 203);
            this.CurrentPassTextBox.MaxLength = 15;
            this.CurrentPassTextBox.Name = "CurrentPassTextBox";
            this.CurrentPassTextBox.PasswordChar = '●';
            this.CurrentPassTextBox.Size = new System.Drawing.Size(260, 26);
            this.CurrentPassTextBox.TabIndex = 77;
            this.CurrentPassTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CurrentPassTextBox_KeyPress);
            this.CurrentPassTextBox.Leave += new System.EventHandler(this.CurrentPassTextBox_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(302, 294);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 18);
            this.label4.TabIndex = 76;
            this.label4.Text = "New Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(302, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 18);
            this.label3.TabIndex = 75;
            this.label3.Text = "Current Password";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(270, 69);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(314, 39);
            this.label10.TabIndex = 74;
            this.label10.Text = "Change Password";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // EmpChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label27);
            this.Controls.Add(this.ChangePassButton);
            this.Controls.Add(this.NewPassTextBox);
            this.Controls.Add(this.CurrentPassTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label10);
            this.Name = "EmpChangePassword";
            this.Size = new System.Drawing.Size(924, 668);
            this.Load += new System.EventHandler(this.EmpChangePassword_Load);
            this.Enter += new System.EventHandler(this.EmpChangePassword_Enter);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Button ChangePassButton;
        private System.Windows.Forms.TextBox NewPassTextBox;
        private System.Windows.Forms.TextBox CurrentPassTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
    }
}
