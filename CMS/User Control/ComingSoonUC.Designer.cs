namespace CMS.User_Control
{
    partial class ComingSoonUC
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
            this.ComingSoonDataGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ComingSoonDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // ComingSoonDataGridView
            // 
            this.ComingSoonDataGridView.AllowUserToAddRows = false;
            this.ComingSoonDataGridView.AllowUserToDeleteRows = false;
            this.ComingSoonDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ComingSoonDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ComingSoonDataGridView.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ComingSoonDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.ComingSoonDataGridView.Location = new System.Drawing.Point(3, 51);
            this.ComingSoonDataGridView.Name = "ComingSoonDataGridView";
            this.ComingSoonDataGridView.ReadOnly = true;
            this.ComingSoonDataGridView.RowTemplate.Height = 100;
            this.ComingSoonDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.ComingSoonDataGridView.Size = new System.Drawing.Size(918, 614);
            this.ComingSoonDataGridView.TabIndex = 57;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(392, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 29);
            this.label1.TabIndex = 56;
            this.label1.Text = "Coming Soon";
            // 
            // ComingSoonUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ComingSoonDataGridView);
            this.Controls.Add(this.label1);
            this.Name = "ComingSoonUC";
            this.Size = new System.Drawing.Size(924, 668);
            this.Load += new System.EventHandler(this.ComingSoonUC_Load);
            this.Enter += new System.EventHandler(this.ComingSoonUC_Enter);
            ((System.ComponentModel.ISupportInitialize)(this.ComingSoonDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView ComingSoonDataGridView;
        private System.Windows.Forms.Label label1;
    }
}
