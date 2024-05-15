namespace CMS.User_Control
{
    partial class CustDetails
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
            this.CustGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.CustFilterComBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.CustGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // CustGridView
            // 
            this.CustGridView.AllowUserToAddRows = false;
            this.CustGridView.AllowUserToDeleteRows = false;
            this.CustGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.CustGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.CustGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CustGridView.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.CustGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.CustGridView.Location = new System.Drawing.Point(3, 55);
            this.CustGridView.Name = "CustGridView";
            this.CustGridView.ReadOnly = true;
            this.CustGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.CustGridView.Size = new System.Drawing.Size(918, 610);
            this.CustGridView.TabIndex = 56;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(391, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 29);
            this.label1.TabIndex = 57;
            this.label1.Text = "Customer Details";
            // 
            // CustFilterComBox
            // 
            this.CustFilterComBox.BackColor = System.Drawing.Color.White;
            this.CustFilterComBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CustFilterComBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CustFilterComBox.ForeColor = System.Drawing.Color.Maroon;
            this.CustFilterComBox.FormattingEnabled = true;
            this.CustFilterComBox.Items.AddRange(new object[] {
            "All Customers",
            "Customer With Transactions",
            "Customer With No Transactions"});
            this.CustFilterComBox.Location = new System.Drawing.Point(666, 28);
            this.CustFilterComBox.Name = "CustFilterComBox";
            this.CustFilterComBox.Size = new System.Drawing.Size(258, 21);
            this.CustFilterComBox.TabIndex = 58;
            this.CustFilterComBox.SelectedIndexChanged += new System.EventHandler(this.CustFilterComBox_SelectedIndexChanged);
            // 
            // CustDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.CustFilterComBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CustGridView);
            this.Name = "CustDetails";
            this.Size = new System.Drawing.Size(924, 668);
            this.Load += new System.EventHandler(this.CustDetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CustGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView CustGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CustFilterComBox;
    }
}
