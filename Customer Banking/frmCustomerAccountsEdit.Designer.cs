namespace Assignment_2
{
    partial class frmCustomerAccountsEdit
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
            this.txtCustID = new System.Windows.Forms.TextBox();
            this.txtAccID = new System.Windows.Forms.TextBox();
            this.txtBalance = new System.Windows.Forms.TextBox();
            this.txtAccrued = new System.Windows.Forms.TextBox();
            this.txtAllowance = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtCustID
            // 
            this.txtCustID.Location = new System.Drawing.Point(148, 23);
            this.txtCustID.Name = "txtCustID";
            this.txtCustID.ReadOnly = true;
            this.txtCustID.Size = new System.Drawing.Size(100, 20);
            this.txtCustID.TabIndex = 1;
            // 
            // txtAccID
            // 
            this.txtAccID.Location = new System.Drawing.Point(148, 49);
            this.txtAccID.Name = "txtAccID";
            this.txtAccID.ReadOnly = true;
            this.txtAccID.Size = new System.Drawing.Size(100, 20);
            this.txtAccID.TabIndex = 2;
            // 
            // txtBalance
            // 
            this.txtBalance.Location = new System.Drawing.Point(148, 75);
            this.txtBalance.Name = "txtBalance";
            this.txtBalance.ReadOnly = true;
            this.txtBalance.Size = new System.Drawing.Size(100, 20);
            this.txtBalance.TabIndex = 3;
            // 
            // txtAccrued
            // 
            this.txtAccrued.Location = new System.Drawing.Point(148, 101);
            this.txtAccrued.Name = "txtAccrued";
            this.txtAccrued.ReadOnly = true;
            this.txtAccrued.Size = new System.Drawing.Size(100, 20);
            this.txtAccrued.TabIndex = 4;
            // 
            // txtAllowance
            // 
            this.txtAllowance.Location = new System.Drawing.Point(148, 127);
            this.txtAllowance.Name = "txtAllowance";
            this.txtAllowance.ReadOnly = true;
            this.txtAllowance.Size = new System.Drawing.Size(100, 20);
            this.txtAllowance.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Customer ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "AccountID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Account balance";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Interest accrued";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 130);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Customer allowance";
            // 
            // frmCustomerAccountsEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(269, 167);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAllowance);
            this.Controls.Add(this.txtAccrued);
            this.Controls.Add(this.txtBalance);
            this.Controls.Add(this.txtAccID);
            this.Controls.Add(this.txtCustID);
            this.Name = "frmCustomerAccountsEdit";
            this.Text = "frmCustomerAccountsEdit";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmCustomerAccountsEdit_FormClosed);
            this.Load += new System.EventHandler(this.frmCustomerAccountsEdit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCustID;
        private System.Windows.Forms.TextBox txtAccID;
        private System.Windows.Forms.TextBox txtBalance;
        private System.Windows.Forms.TextBox txtAccrued;
        private System.Windows.Forms.TextBox txtAllowance;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;

    }
}