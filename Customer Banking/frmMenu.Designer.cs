namespace Assignment_2
{
    partial class frmMenu
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
            this.btnCustomers = new System.Windows.Forms.Button();
            this.btnProducts = new System.Windows.Forms.Button();
            this.btnAccounts = new System.Windows.Forms.Button();
            this.btnTransactions = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCustomers
            // 
            this.btnCustomers.Location = new System.Drawing.Point(31, 27);
            this.btnCustomers.Name = "btnCustomers";
            this.btnCustomers.Size = new System.Drawing.Size(88, 57);
            this.btnCustomers.TabIndex = 0;
            this.btnCustomers.Text = "Customers";
            this.btnCustomers.UseVisualStyleBackColor = true;
            this.btnCustomers.Click += new System.EventHandler(this.btnCustomers_Click);
            // 
            // btnProducts
            // 
            this.btnProducts.Location = new System.Drawing.Point(31, 94);
            this.btnProducts.Name = "btnProducts";
            this.btnProducts.Size = new System.Drawing.Size(88, 57);
            this.btnProducts.TabIndex = 1;
            this.btnProducts.Text = "Products";
            this.btnProducts.UseVisualStyleBackColor = true;
            this.btnProducts.Click += new System.EventHandler(this.btnProducts_Click);
            // 
            // btnAccounts
            // 
            this.btnAccounts.Location = new System.Drawing.Point(31, 161);
            this.btnAccounts.Name = "btnAccounts";
            this.btnAccounts.Size = new System.Drawing.Size(88, 57);
            this.btnAccounts.TabIndex = 2;
            this.btnAccounts.Text = "Accounts";
            this.btnAccounts.UseVisualStyleBackColor = true;
            this.btnAccounts.Click += new System.EventHandler(this.btnAccounts_Click);
            // 
            // btnTransactions
            // 
            this.btnTransactions.Location = new System.Drawing.Point(31, 228);
            this.btnTransactions.Name = "btnTransactions";
            this.btnTransactions.Size = new System.Drawing.Size(88, 57);
            this.btnTransactions.TabIndex = 3;
            this.btnTransactions.Text = "Transactions";
            this.btnTransactions.UseVisualStyleBackColor = true;
            this.btnTransactions.Click += new System.EventHandler(this.btnTransactions_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(149, 322);
            this.Controls.Add(this.btnTransactions);
            this.Controls.Add(this.btnAccounts);
            this.Controls.Add(this.btnProducts);
            this.Controls.Add(this.btnCustomers);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCustomers;
        private System.Windows.Forms.Button btnProducts;
        private System.Windows.Forms.Button btnAccounts;
        private System.Windows.Forms.Button btnTransactions;
    }
}

