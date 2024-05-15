namespace CMS.User_Control
{
    partial class AllShowsUC
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
            this.Label1 = new System.Windows.Forms.Label();
            this.AllShowsGridView = new System.Windows.Forms.DataGridView();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.AllShowsGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(373, 21);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(142, 31);
            this.Label1.TabIndex = 41;
            this.Label1.Text = "All Shows";
            // 
            // AllShowsGridView
            // 
            this.AllShowsGridView.AllowUserToAddRows = false;
            this.AllShowsGridView.AllowUserToDeleteRows = false;
            this.AllShowsGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.AllShowsGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.AllShowsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AllShowsGridView.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AllShowsGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.AllShowsGridView.Location = new System.Drawing.Point(3, 55);
            this.AllShowsGridView.Name = "AllShowsGridView";
            this.AllShowsGridView.ReadOnly = true;
            this.AllShowsGridView.RowTemplate.Height = 100;
            this.AllShowsGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.AllShowsGridView.Size = new System.Drawing.Size(909, 610);
            this.AllShowsGridView.TabIndex = 55;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // AllShowsUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.AllShowsGridView);
            this.Controls.Add(this.Label1);
            this.Name = "AllShowsUC";
            this.Size = new System.Drawing.Size(924, 668);
            this.Load += new System.EventHandler(this.AllShowsUC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AllShowsGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.DataGridView AllShowsGridView;
        private System.Windows.Forms.Timer timer1;
    }
}
