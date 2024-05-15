namespace CMS.User_Control
{
    partial class NowPlayingUC
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
            this.label1 = new System.Windows.Forms.Label();
            this.PlayingDataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.PlayingDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(371, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "Now Playing";
            // 
            // PlayingDataGridView
            // 
            this.PlayingDataGridView.AllowUserToAddRows = false;
            this.PlayingDataGridView.AllowUserToDeleteRows = false;
            this.PlayingDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PlayingDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PlayingDataGridView.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PlayingDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.PlayingDataGridView.Location = new System.Drawing.Point(3, 65);
            this.PlayingDataGridView.Name = "PlayingDataGridView";
            this.PlayingDataGridView.ReadOnly = true;
            this.PlayingDataGridView.RowTemplate.Height = 100;
            this.PlayingDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.PlayingDataGridView.Size = new System.Drawing.Size(909, 600);
            this.PlayingDataGridView.TabIndex = 55;
            // 
            // NowPlayingUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.PlayingDataGridView);
            this.Controls.Add(this.label1);
            this.Name = "NowPlayingUC";
            this.Size = new System.Drawing.Size(924, 668);
            this.Load += new System.EventHandler(this.NowPlayingUC_Load);
            this.Enter += new System.EventHandler(this.NowPlayingUC_Enter);
            ((System.ComponentModel.ISupportInitialize)(this.PlayingDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView PlayingDataGridView;
    }
}
