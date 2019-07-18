namespace Assignment_2
{
    partial class frmProductsMenu
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
            this.btnEditProducts = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnEditProducts
            // 
            this.btnEditProducts.Location = new System.Drawing.Point(22, 22);
            this.btnEditProducts.Name = "btnEditProducts";
            this.btnEditProducts.Size = new System.Drawing.Size(76, 58);
            this.btnEditProducts.TabIndex = 0;
            this.btnEditProducts.Text = "Edit products";
            this.btnEditProducts.UseVisualStyleBackColor = true;
            this.btnEditProducts.Click += new System.EventHandler(this.btnEditProducts_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(121, 22);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(76, 58);
            this.button1.TabIndex = 1;
            this.button1.Text = "Close open products";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmProductsMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(219, 99);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnEditProducts);
            this.Name = "frmProductsMenu";
            this.Text = "frmProducts";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnEditProducts;
        private System.Windows.Forms.Button button1;
    }
}