namespace Assignment_2
{
    partial class frmProductOpen
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
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtaResults)).BeginInit();
            this.SuspendLayout();
            // 
            // dtaResults
            // 
            this.dtaResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtaResults.Location = new System.Drawing.Point(70, 77);
            this.dtaResults.Name = "dtaResults";
            this.dtaResults.Size = new System.Drawing.Size(351, 150);
            this.dtaResults.TabIndex = 0;
            this.dtaResults.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtaResults_CellClick_1);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(198, 248);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(94, 38);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "Close selected product";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmProductOpen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 298);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.dtaResults);
            this.Name = "frmProductOpen";
            this.Text = "frmProductOpen";
            this.Load += new System.EventHandler(this.frmProductOpen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtaResults)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtaResults;
        private System.Windows.Forms.Button btnClose;
    }
}