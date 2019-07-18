namespace Assignment_2
{
    partial class frmCustomerSearch
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
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtaResults)).BeginInit();
            this.SuspendLayout();
            // 
            // dtaResults
            // 
            this.dtaResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtaResults.Location = new System.Drawing.Point(55, 91);
            this.dtaResults.Name = "dtaResults";
            this.dtaResults.ReadOnly = true;
            this.dtaResults.Size = new System.Drawing.Size(395, 150);
            this.dtaResults.TabIndex = 0;
            this.dtaResults.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtaResults_CellClick_1);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(270, 51);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 21);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(154, 51);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(100, 20);
            this.txtSearch.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(417, 26);
            this.label1.TabIndex = 3;
            this.label1.Text = "Enter the first name of the person you wish to search for. entering just a letter" +
    " will return \r\neveryone who\'s name begins with that letter. Entering nothing wil" +
    "l return everyone.";
            // 
            // frmCustomerSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 280);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.dtaResults);
            this.Name = "frmCustomerSearch";
            this.Text = "frmCustomerSearch";
            ((System.ComponentModel.ISupportInitialize)(this.dtaResults)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtaResults;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label1;
    }
}