namespace Assignment_2
{
    partial class frmCustomerMenu
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
            this.btnNewCust = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnNewCust
            // 
            this.btnNewCust.Location = new System.Drawing.Point(27, 26);
            this.btnNewCust.Name = "btnNewCust";
            this.btnNewCust.Size = new System.Drawing.Size(72, 63);
            this.btnNewCust.TabIndex = 0;
            this.btnNewCust.Text = "New Customer";
            this.btnNewCust.UseVisualStyleBackColor = true;
            this.btnNewCust.Click += new System.EventHandler(this.btnNewCust_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(130, 26);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(72, 63);
            this.button1.TabIndex = 1;
            this.button1.Text = "Customer Search";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmCustomerMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(228, 106);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnNewCust);
            this.Name = "frmCustomerMenu";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnNewCust;
        private System.Windows.Forms.Button button1;
    }
}