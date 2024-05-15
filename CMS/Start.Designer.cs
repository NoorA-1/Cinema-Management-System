namespace CMS
{
    partial class Start
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Start));
            this.CloseButton = new System.Windows.Forms.Button();
            this.BackPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.StartEmpButton = new System.Windows.Forms.Button();
            this.StartCustButton = new System.Windows.Forms.Button();
            this.BackPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // CloseButton
            // 
            this.CloseButton.BackColor = System.Drawing.Color.Red;
            this.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CloseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CloseButton.Location = new System.Drawing.Point(762, 12);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(41, 32);
            this.CloseButton.TabIndex = 0;
            this.CloseButton.Text = "X";
            this.CloseButton.UseVisualStyleBackColor = false;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // BackPanel
            // 
            this.BackPanel.Controls.Add(this.label1);
            this.BackPanel.Controls.Add(this.StartEmpButton);
            this.BackPanel.Controls.Add(this.StartCustButton);
            this.BackPanel.Location = new System.Drawing.Point(209, 95);
            this.BackPanel.Name = "BackPanel";
            this.BackPanel.Size = new System.Drawing.Size(397, 367);
            this.BackPanel.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(139, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nplex Cinemas";
            // 
            // StartEmpButton
            // 
            this.StartEmpButton.BackColor = System.Drawing.Color.LightBlue;
            this.StartEmpButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.StartEmpButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartEmpButton.Location = new System.Drawing.Point(107, 208);
            this.StartEmpButton.Name = "StartEmpButton";
            this.StartEmpButton.Size = new System.Drawing.Size(185, 71);
            this.StartEmpButton.TabIndex = 1;
            this.StartEmpButton.Text = "Employee / Admin";
            this.StartEmpButton.UseVisualStyleBackColor = false;
            this.StartEmpButton.Click += new System.EventHandler(this.StartEmpButton_Click);
            // 
            // StartCustButton
            // 
            this.StartCustButton.BackColor = System.Drawing.Color.LightBlue;
            this.StartCustButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.StartCustButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartCustButton.Location = new System.Drawing.Point(117, 91);
            this.StartCustButton.Name = "StartCustButton";
            this.StartCustButton.Size = new System.Drawing.Size(159, 71);
            this.StartCustButton.TabIndex = 0;
            this.StartCustButton.Text = "Customer";
            this.StartCustButton.UseVisualStyleBackColor = false;
            this.StartCustButton.Click += new System.EventHandler(this.StartCustButton_Click);
            // 
            // Start
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(815, 556);
            this.ControlBox = false;
            this.Controls.Add(this.BackPanel);
            this.Controls.Add(this.CloseButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Start";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Start_Load);
            this.BackPanel.ResumeLayout(false);
            this.BackPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Panel BackPanel;
        private System.Windows.Forms.Button StartEmpButton;
        private System.Windows.Forms.Button StartCustButton;
        private System.Windows.Forms.Label label1;
    }
}

