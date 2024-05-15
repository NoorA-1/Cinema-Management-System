namespace CMS.User_Control
{
    partial class CinemaCUC
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
            this.TransactionPanel = new System.Windows.Forms.Panel();
            this.CancelButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.ReceiptTextBox = new System.Windows.Forms.RichTextBox();
            this.ConfirmButton = new System.Windows.Forms.Button();
            this.PaymentMethodComBox = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.seat1 = new System.Windows.Forms.Button();
            this.seat2 = new System.Windows.Forms.Button();
            this.ResetButton = new System.Windows.Forms.Button();
            this.seat3 = new System.Windows.Forms.Button();
            this.CheckOutButton = new System.Windows.Forms.Button();
            this.seat4 = new System.Windows.Forms.Button();
            this.BookButton = new System.Windows.Forms.Button();
            this.seat5 = new System.Windows.Forms.Button();
            this.seat9 = new System.Windows.Forms.Button();
            this.seat10 = new System.Windows.Forms.Button();
            this.PriceLabel = new System.Windows.Forms.Label();
            this.seat6 = new System.Windows.Forms.Button();
            this.SeatNumberTextBox = new System.Windows.Forms.TextBox();
            this.seat7 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.seat8 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.TransactionPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.MainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // TransactionPanel
            // 
            this.TransactionPanel.BackColor = System.Drawing.Color.Beige;
            this.TransactionPanel.Controls.Add(this.CancelButton);
            this.TransactionPanel.Controls.Add(this.SaveButton);
            this.TransactionPanel.Controls.Add(this.ReceiptTextBox);
            this.TransactionPanel.Controls.Add(this.ConfirmButton);
            this.TransactionPanel.Controls.Add(this.PaymentMethodComBox);
            this.TransactionPanel.Controls.Add(this.label8);
            this.TransactionPanel.Location = new System.Drawing.Point(293, 3);
            this.TransactionPanel.Name = "TransactionPanel";
            this.TransactionPanel.Size = new System.Drawing.Size(416, 639);
            this.TransactionPanel.TabIndex = 84;
            this.TransactionPanel.Visible = false;
            this.TransactionPanel.Enter += new System.EventHandler(this.TransactionPanel_Enter);
            // 
            // CancelButton
            // 
            this.CancelButton.BackColor = System.Drawing.Color.Pink;
            this.CancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelButton.Location = new System.Drawing.Point(30, 441);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(96, 32);
            this.CancelButton.TabIndex = 72;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = false;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.BackColor = System.Drawing.Color.LightCyan;
            this.SaveButton.Enabled = false;
            this.SaveButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SaveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveButton.Location = new System.Drawing.Point(259, 327);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(127, 37);
            this.SaveButton.TabIndex = 79;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = false;
            this.SaveButton.Visible = false;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // ReceiptTextBox
            // 
            this.ReceiptTextBox.BackColor = System.Drawing.Color.White;
            this.ReceiptTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReceiptTextBox.Location = new System.Drawing.Point(30, 34);
            this.ReceiptTextBox.Name = "ReceiptTextBox";
            this.ReceiptTextBox.ReadOnly = true;
            this.ReceiptTextBox.Size = new System.Drawing.Size(372, 342);
            this.ReceiptTextBox.TabIndex = 75;
            this.ReceiptTextBox.Text = "";
            // 
            // ConfirmButton
            // 
            this.ConfirmButton.BackColor = System.Drawing.Color.DodgerBlue;
            this.ConfirmButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ConfirmButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConfirmButton.Location = new System.Drawing.Point(224, 434);
            this.ConfirmButton.Name = "ConfirmButton";
            this.ConfirmButton.Size = new System.Drawing.Size(154, 39);
            this.ConfirmButton.TabIndex = 78;
            this.ConfirmButton.Text = "Confirm";
            this.ConfirmButton.UseVisualStyleBackColor = false;
            this.ConfirmButton.Click += new System.EventHandler(this.ConfirmButton_Click);
            // 
            // PaymentMethodComBox
            // 
            this.PaymentMethodComBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PaymentMethodComBox.FormattingEnabled = true;
            this.PaymentMethodComBox.Location = new System.Drawing.Point(30, 410);
            this.PaymentMethodComBox.Name = "PaymentMethodComBox";
            this.PaymentMethodComBox.Size = new System.Drawing.Size(133, 21);
            this.PaymentMethodComBox.TabIndex = 76;
            this.PaymentMethodComBox.SelectedIndexChanged += new System.EventHandler(this.PaymentMethodComBox_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(27, 389);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(134, 18);
            this.label8.TabIndex = 77;
            this.label8.Text = "Payment Method";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(1, 118);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(21, 20);
            this.label6.TabIndex = 24;
            this.label6.Text = "B";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(1, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(21, 20);
            this.label4.TabIndex = 23;
            this.label4.Text = "A";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(177, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "label5";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.ForestGreen;
            this.label2.Location = new System.Drawing.Point(707, 292);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(190, 20);
            this.label2.TabIndex = 72;
            this.label2.Text = "One Ticket Price = 800";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(385, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cinema Hall C";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Red;
            this.panel1.Controls.Add(this.label3);
            this.panel1.ForeColor = System.Drawing.Color.Red;
            this.panel1.Location = new System.Drawing.Point(164, 112);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(600, 22);
            this.panel1.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(280, 2);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Screen";
            // 
            // seat1
            // 
            this.seat1.BackColor = System.Drawing.Color.LightBlue;
            this.seat1.FlatAppearance.BorderSize = 0;
            this.seat1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.seat1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seat1.Location = new System.Drawing.Point(277, 236);
            this.seat1.Name = "seat1";
            this.seat1.Size = new System.Drawing.Size(43, 35);
            this.seat1.TabIndex = 2;
            this.seat1.Text = "1";
            this.seat1.UseVisualStyleBackColor = false;
            this.seat1.Click += new System.EventHandler(this.seat1_Click);
            // 
            // seat2
            // 
            this.seat2.BackColor = System.Drawing.Color.LightBlue;
            this.seat2.FlatAppearance.BorderSize = 0;
            this.seat2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.seat2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seat2.Location = new System.Drawing.Point(361, 236);
            this.seat2.Name = "seat2";
            this.seat2.Size = new System.Drawing.Size(43, 35);
            this.seat2.TabIndex = 3;
            this.seat2.Text = "2";
            this.seat2.UseVisualStyleBackColor = false;
            this.seat2.Click += new System.EventHandler(this.seat2_Click);
            // 
            // ResetButton
            // 
            this.ResetButton.BackColor = System.Drawing.Color.Azure;
            this.ResetButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ResetButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResetButton.Location = new System.Drawing.Point(729, 412);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(143, 32);
            this.ResetButton.TabIndex = 71;
            this.ResetButton.Text = "Reset";
            this.ResetButton.UseVisualStyleBackColor = false;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // seat3
            // 
            this.seat3.BackColor = System.Drawing.Color.LightBlue;
            this.seat3.FlatAppearance.BorderSize = 0;
            this.seat3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.seat3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seat3.Location = new System.Drawing.Point(446, 236);
            this.seat3.Name = "seat3";
            this.seat3.Size = new System.Drawing.Size(43, 35);
            this.seat3.TabIndex = 4;
            this.seat3.Text = "3";
            this.seat3.UseVisualStyleBackColor = false;
            this.seat3.Click += new System.EventHandler(this.seat3_Click);
            // 
            // CheckOutButton
            // 
            this.CheckOutButton.BackColor = System.Drawing.Color.SkyBlue;
            this.CheckOutButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CheckOutButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckOutButton.Location = new System.Drawing.Point(544, 463);
            this.CheckOutButton.Name = "CheckOutButton";
            this.CheckOutButton.Size = new System.Drawing.Size(143, 32);
            this.CheckOutButton.TabIndex = 70;
            this.CheckOutButton.Text = "Check Out";
            this.CheckOutButton.UseVisualStyleBackColor = false;
            this.CheckOutButton.Click += new System.EventHandler(this.CheckOutButton_Click);
            // 
            // seat4
            // 
            this.seat4.BackColor = System.Drawing.Color.LightBlue;
            this.seat4.FlatAppearance.BorderSize = 0;
            this.seat4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.seat4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seat4.Location = new System.Drawing.Point(536, 236);
            this.seat4.Name = "seat4";
            this.seat4.Size = new System.Drawing.Size(43, 35);
            this.seat4.TabIndex = 5;
            this.seat4.Text = "4";
            this.seat4.UseVisualStyleBackColor = false;
            this.seat4.Click += new System.EventHandler(this.seat4_Click);
            // 
            // BookButton
            // 
            this.BookButton.BackColor = System.Drawing.Color.SkyBlue;
            this.BookButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BookButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BookButton.Location = new System.Drawing.Point(302, 463);
            this.BookButton.Name = "BookButton";
            this.BookButton.Size = new System.Drawing.Size(143, 32);
            this.BookButton.TabIndex = 69;
            this.BookButton.Text = "Book Seat";
            this.BookButton.UseVisualStyleBackColor = false;
            this.BookButton.Click += new System.EventHandler(this.BookButton_Click);
            // 
            // seat5
            // 
            this.seat5.BackColor = System.Drawing.Color.LightBlue;
            this.seat5.FlatAppearance.BorderSize = 0;
            this.seat5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.seat5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seat5.Location = new System.Drawing.Point(620, 236);
            this.seat5.Name = "seat5";
            this.seat5.Size = new System.Drawing.Size(43, 35);
            this.seat5.TabIndex = 6;
            this.seat5.Text = "5";
            this.seat5.UseVisualStyleBackColor = false;
            this.seat5.Click += new System.EventHandler(this.seat5_Click);
            // 
            // seat9
            // 
            this.seat9.BackColor = System.Drawing.Color.LightBlue;
            this.seat9.FlatAppearance.BorderSize = 0;
            this.seat9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.seat9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seat9.Location = new System.Drawing.Point(533, 347);
            this.seat9.Name = "seat9";
            this.seat9.Size = new System.Drawing.Size(43, 35);
            this.seat9.TabIndex = 10;
            this.seat9.Text = "9";
            this.seat9.UseVisualStyleBackColor = false;
            this.seat9.Click += new System.EventHandler(this.seat9_Click);
            // 
            // seat10
            // 
            this.seat10.BackColor = System.Drawing.Color.LightBlue;
            this.seat10.FlatAppearance.BorderSize = 0;
            this.seat10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.seat10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seat10.Location = new System.Drawing.Point(620, 347);
            this.seat10.Name = "seat10";
            this.seat10.Size = new System.Drawing.Size(43, 35);
            this.seat10.TabIndex = 11;
            this.seat10.Text = "10";
            this.seat10.UseVisualStyleBackColor = false;
            this.seat10.Click += new System.EventHandler(this.seat10_Click);
            // 
            // PriceLabel
            // 
            this.PriceLabel.AutoSize = true;
            this.PriceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PriceLabel.ForeColor = System.Drawing.Color.Green;
            this.PriceLabel.Location = new System.Drawing.Point(331, 463);
            this.PriceLabel.Name = "PriceLabel";
            this.PriceLabel.Size = new System.Drawing.Size(0, 20);
            this.PriceLabel.TabIndex = 26;
            // 
            // seat6
            // 
            this.seat6.BackColor = System.Drawing.Color.LightBlue;
            this.seat6.FlatAppearance.BorderSize = 0;
            this.seat6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.seat6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seat6.Location = new System.Drawing.Point(277, 347);
            this.seat6.Name = "seat6";
            this.seat6.Size = new System.Drawing.Size(43, 35);
            this.seat6.TabIndex = 7;
            this.seat6.Text = "6";
            this.seat6.UseVisualStyleBackColor = false;
            this.seat6.Click += new System.EventHandler(this.seat6_Click);
            // 
            // SeatNumberTextBox
            // 
            this.SeatNumberTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SeatNumberTextBox.Location = new System.Drawing.Point(61, 469);
            this.SeatNumberTextBox.MaxLength = 2;
            this.SeatNumberTextBox.Name = "SeatNumberTextBox";
            this.SeatNumberTextBox.ReadOnly = true;
            this.SeatNumberTextBox.Size = new System.Drawing.Size(159, 26);
            this.SeatNumberTextBox.TabIndex = 24;
            // 
            // seat7
            // 
            this.seat7.BackColor = System.Drawing.Color.LightBlue;
            this.seat7.FlatAppearance.BorderSize = 0;
            this.seat7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.seat7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seat7.Location = new System.Drawing.Point(361, 347);
            this.seat7.Name = "seat7";
            this.seat7.Size = new System.Drawing.Size(43, 35);
            this.seat7.TabIndex = 8;
            this.seat7.Text = "7";
            this.seat7.UseVisualStyleBackColor = false;
            this.seat7.Click += new System.EventHandler(this.seat7_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(57, 446);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(123, 20);
            this.label7.TabIndex = 23;
            this.label7.Text = "Selected Seat";
            // 
            // seat8
            // 
            this.seat8.BackColor = System.Drawing.Color.LightBlue;
            this.seat8.FlatAppearance.BorderSize = 0;
            this.seat8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.seat8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seat8.Location = new System.Drawing.Point(446, 347);
            this.seat8.Name = "seat8";
            this.seat8.Size = new System.Drawing.Size(43, 35);
            this.seat8.TabIndex = 9;
            this.seat8.Text = "8";
            this.seat8.UseVisualStyleBackColor = false;
            this.seat8.Click += new System.EventHandler(this.seat8_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightCoral;
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label5);
            this.panel2.ForeColor = System.Drawing.Color.Red;
            this.panel2.Location = new System.Drawing.Point(195, 236);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(25, 155);
            this.panel2.TabIndex = 22;
            // 
            // MainPanel
            // 
            this.MainPanel.BackColor = System.Drawing.Color.White;
            this.MainPanel.Controls.Add(this.label2);
            this.MainPanel.Controls.Add(this.label1);
            this.MainPanel.Controls.Add(this.panel1);
            this.MainPanel.Controls.Add(this.seat1);
            this.MainPanel.Controls.Add(this.seat2);
            this.MainPanel.Controls.Add(this.ResetButton);
            this.MainPanel.Controls.Add(this.seat3);
            this.MainPanel.Controls.Add(this.CheckOutButton);
            this.MainPanel.Controls.Add(this.seat4);
            this.MainPanel.Controls.Add(this.BookButton);
            this.MainPanel.Controls.Add(this.seat5);
            this.MainPanel.Controls.Add(this.PriceLabel);
            this.MainPanel.Controls.Add(this.seat6);
            this.MainPanel.Controls.Add(this.SeatNumberTextBox);
            this.MainPanel.Controls.Add(this.seat7);
            this.MainPanel.Controls.Add(this.label7);
            this.MainPanel.Controls.Add(this.seat8);
            this.MainPanel.Controls.Add(this.panel2);
            this.MainPanel.Controls.Add(this.seat9);
            this.MainPanel.Controls.Add(this.seat10);
            this.MainPanel.Location = new System.Drawing.Point(8, 38);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(913, 498);
            this.MainPanel.TabIndex = 83;
            // 
            // CinemaCUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.TransactionPanel);
            this.Controls.Add(this.MainPanel);
            this.Name = "CinemaCUC";
            this.Size = new System.Drawing.Size(924, 550);
            this.Load += new System.EventHandler(this.CinemaCUC_Load);
            this.TransactionPanel.ResumeLayout(false);
            this.TransactionPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel TransactionPanel;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.RichTextBox ReceiptTextBox;
        private System.Windows.Forms.Button ConfirmButton;
        private System.Windows.Forms.ComboBox PaymentMethodComBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button seat1;
        private System.Windows.Forms.Button seat2;
        private System.Windows.Forms.Button ResetButton;
        private System.Windows.Forms.Button seat3;
        private System.Windows.Forms.Button CheckOutButton;
        private System.Windows.Forms.Button seat4;
        private System.Windows.Forms.Button BookButton;
        private System.Windows.Forms.Button seat5;
        private System.Windows.Forms.Button seat9;
        private System.Windows.Forms.Button seat10;
        private System.Windows.Forms.Label PriceLabel;
        private System.Windows.Forms.Button seat6;
        private System.Windows.Forms.TextBox SeatNumberTextBox;
        private System.Windows.Forms.Button seat7;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button seat8;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel MainPanel;
    }
}
