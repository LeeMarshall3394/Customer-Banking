namespace Assignment_2
{
    partial class frmCustomerAccounts
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
            this.dtaResults = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtaResults)).BeginInit();
            this.SuspendLayout();
            // 
            // dtaResults
            // 
            this.dtaResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtaResults.Location = new System.Drawing.Point(24, 23);
            this.dtaResults.Name = "dtaResults";
            this.dtaResults.ReadOnly = true;
            this.dtaResults.Size = new System.Drawing.Size(395, 150);
            this.dtaResults.TabIndex = 3;
            this.dtaResults.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtaResults_CellClick);
            // 
            // frmCustomerAccounts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 195);
            this.Controls.Add(this.dtaResults);
            this.Name = "frmCustomerAccounts";
            this.Text = "frmCustomerAccounts";
            this.Load += new System.EventHandler(this.frmCustomerAccounts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtaResults)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtaResults;
    }
}