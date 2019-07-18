namespace Assignment_2
{
    partial class frmAccountInterest
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
            this.btnInterest = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtaResults)).BeginInit();
            this.SuspendLayout();
            // 
            // dtaResults
            // 
            this.dtaResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtaResults.Location = new System.Drawing.Point(12, 12);
            this.dtaResults.Name = "dtaResults";
            this.dtaResults.ReadOnly = true;
            this.dtaResults.Size = new System.Drawing.Size(395, 150);
            this.dtaResults.TabIndex = 5;
            // 
            // btnInterest
            // 
            this.btnInterest.Location = new System.Drawing.Point(104, 179);
            this.btnInterest.Name = "btnInterest";
            this.btnInterest.Size = new System.Drawing.Size(84, 57);
            this.btnInterest.TabIndex = 6;
            this.btnInterest.Text = "Calculate interest";
            this.btnInterest.UseVisualStyleBackColor = true;
            this.btnInterest.Click += new System.EventHandler(this.btnInterest_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(228, 179);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(84, 57);
            this.button1.TabIndex = 7;
            this.button1.Text = "Add interest to balance";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmAccountInterest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 259);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnInterest);
            this.Controls.Add(this.dtaResults);
            this.Name = "frmAccountInterest";
            this.Text = "frmAccountInterest";
            this.Load += new System.EventHandler(this.frmAccountInterest_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtaResults)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtaResults;
        private System.Windows.Forms.Button btnInterest;
        private System.Windows.Forms.Button button1;
    }
}