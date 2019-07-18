namespace Assignment_2
{
    partial class frmProductEdit
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
            this.cboID = new System.Windows.Forms.ComboBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtIntRate = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.cboTransin = new System.Windows.Forms.ComboBox();
            this.cboStatus = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // cboID
            // 
            this.cboID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboID.FormattingEnabled = true;
            this.cboID.Location = new System.Drawing.Point(127, 28);
            this.cboID.Name = "cboID";
            this.cboID.Size = new System.Drawing.Size(62, 21);
            this.cboID.TabIndex = 0;
            this.cboID.SelectedIndexChanged += new System.EventHandler(this.cboID_SelectedIndexChanged);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(127, 55);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(175, 20);
            this.txtName.TabIndex = 1;
            // 
            // txtIntRate
            // 
            this.txtIntRate.Location = new System.Drawing.Point(127, 132);
            this.txtIntRate.Name = "txtIntRate";
            this.txtIntRate.Size = new System.Drawing.Size(48, 20);
            this.txtIntRate.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Transactions in?";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Interest rate";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Status";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Product ID";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(100, 168);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 12;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // cboTransin
            // 
            this.cboTransin.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTransin.FormattingEnabled = true;
            this.cboTransin.Items.AddRange(new object[] {
            "Not Allowed",
            "Allowed"});
            this.cboTransin.Location = new System.Drawing.Point(127, 106);
            this.cboTransin.Name = "cboTransin";
            this.cboTransin.Size = new System.Drawing.Size(62, 21);
            this.cboTransin.TabIndex = 13;
            // 
            // cboStatus
            // 
            this.cboStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboStatus.FormattingEnabled = true;
            this.cboStatus.Items.AddRange(new object[] {
            "open",
            "closed"});
            this.cboStatus.Location = new System.Drawing.Point(127, 80);
            this.cboStatus.Name = "cboStatus";
            this.cboStatus.Size = new System.Drawing.Size(62, 21);
            this.cboStatus.TabIndex = 14;
            // 
            // frmProductEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 216);
            this.Controls.Add(this.cboStatus);
            this.Controls.Add(this.cboTransin);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtIntRate);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.cboID);
            this.Name = "frmProductEdit";
            this.Text = "Edit products";
            this.Load += new System.EventHandler(this.frmProductEdit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboID;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtIntRate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.ComboBox cboTransin;
        private System.Windows.Forms.ComboBox cboStatus;
    }
}