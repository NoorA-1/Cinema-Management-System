namespace CMS.User_Control
{
    partial class ViewTransactionsUC
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
            this.TransactionDataGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.SaveButton = new System.Windows.Forms.Button();
            this.TrxNumberTextBox = new System.Windows.Forms.TextBox();
            this.ScreeningTextBox = new System.Windows.Forms.TextBox();
            this.ReceiptTextBox = new System.Windows.Forms.RichTextBox();
            this.transactionlabel = new System.Windows.Forms.Label();
            this.RefreshButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.TransactionDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // TransactionDataGridView
            // 
            this.TransactionDataGridView.AllowUserToAddRows = false;
            this.TransactionDataGridView.AllowUserToDeleteRows = false;
            this.TransactionDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TransactionDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.TransactionDataGridView.Location = new System.Drawing.Point(12, 52);
            this.TransactionDataGridView.Name = "TransactionDataGridView";
            this.TransactionDataGridView.ReadOnly = true;
            this.TransactionDataGridView.Size = new System.Drawing.Size(704, 548);
            this.TransactionDataGridView.TabIndex = 0;
            this.TransactionDataGridView.Visible = false;
            this.TransactionDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TransactionDataGridView_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(360, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Transactions";
            // 
            // SaveButton
            // 
            this.SaveButton.BackColor = System.Drawing.Color.LightCyan;
            this.SaveButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SaveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveButton.Location = new System.Drawing.Point(722, 512);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(168, 58);
            this.SaveButton.TabIndex = 80;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = false;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // TrxNumberTextBox
            // 
            this.TrxNumberTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TrxNumberTextBox.Location = new System.Drawing.Point(853, 85);
            this.TrxNumberTextBox.MaxLength = 2;
            this.TrxNumberTextBox.Name = "TrxNumberTextBox";
            this.TrxNumberTextBox.ReadOnly = true;
            this.TrxNumberTextBox.Size = new System.Drawing.Size(159, 26);
            this.TrxNumberTextBox.TabIndex = 82;
            this.TrxNumberTextBox.Visible = false;
            // 
            // ScreeningTextBox
            // 
            this.ScreeningTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScreeningTextBox.Location = new System.Drawing.Point(853, 150);
            this.ScreeningTextBox.MaxLength = 2;
            this.ScreeningTextBox.Name = "ScreeningTextBox";
            this.ScreeningTextBox.ReadOnly = true;
            this.ScreeningTextBox.Size = new System.Drawing.Size(159, 26);
            this.ScreeningTextBox.TabIndex = 83;
            this.ScreeningTextBox.Visible = false;
            // 
            // ReceiptTextBox
            // 
            this.ReceiptTextBox.Location = new System.Drawing.Point(853, 324);
            this.ReceiptTextBox.Name = "ReceiptTextBox";
            this.ReceiptTextBox.Size = new System.Drawing.Size(211, 276);
            this.ReceiptTextBox.TabIndex = 84;
            this.ReceiptTextBox.Text = "";
            this.ReceiptTextBox.Visible = false;
            // 
            // transactionlabel
            // 
            this.transactionlabel.AutoSize = true;
            this.transactionlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.transactionlabel.Location = new System.Drawing.Point(252, 293);
            this.transactionlabel.Name = "transactionlabel";
            this.transactionlabel.Size = new System.Drawing.Size(304, 29);
            this.transactionlabel.TabIndex = 85;
            this.transactionlabel.Text = "You have no transactions";
            // 
            // RefreshButton
            // 
            this.RefreshButton.BackColor = System.Drawing.Color.Pink;
            this.RefreshButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.RefreshButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RefreshButton.Location = new System.Drawing.Point(12, 606);
            this.RefreshButton.Name = "RefreshButton";
            this.RefreshButton.Size = new System.Drawing.Size(139, 43);
            this.RefreshButton.TabIndex = 86;
            this.RefreshButton.Text = "Refresh";
            this.RefreshButton.UseVisualStyleBackColor = false;
            this.RefreshButton.Click += new System.EventHandler(this.RefreshButton_Click);
            // 
            // ViewTransactionsUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.RefreshButton);
            this.Controls.Add(this.transactionlabel);
            this.Controls.Add(this.ScreeningTextBox);
            this.Controls.Add(this.TrxNumberTextBox);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TransactionDataGridView);
            this.Controls.Add(this.ReceiptTextBox);
            this.Name = "ViewTransactionsUC";
            this.Size = new System.Drawing.Size(924, 668);
            this.Load += new System.EventHandler(this.ViewTransactionsUC_Load);
            this.Enter += new System.EventHandler(this.ViewTransactionsUC_Enter);
            ((System.ComponentModel.ISupportInitialize)(this.TransactionDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView TransactionDataGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.TextBox TrxNumberTextBox;
        private System.Windows.Forms.TextBox ScreeningTextBox;
        private System.Windows.Forms.RichTextBox ReceiptTextBox;
        private System.Windows.Forms.Label transactionlabel;
        private System.Windows.Forms.Button RefreshButton;
    }
}
