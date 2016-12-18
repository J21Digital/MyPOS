namespace POS_System
{
    partial class EditProducts
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
            this.label1 = new System.Windows.Forms.Label();
            this.AddProduct = new System.Windows.Forms.Button();
            this.DeleteProduct = new System.Windows.Forms.Button();
            this.ChangeProduct = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label1.Location = new System.Drawing.Point(197, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Edit Products";
            // 
            // AddProduct
            // 
            this.AddProduct.Location = new System.Drawing.Point(96, 72);
            this.AddProduct.Name = "AddProduct";
            this.AddProduct.Size = new System.Drawing.Size(396, 64);
            this.AddProduct.TabIndex = 1;
            this.AddProduct.Text = "Add Product";
            this.AddProduct.UseVisualStyleBackColor = true;
            this.AddProduct.Click += new System.EventHandler(this.AddProduct_Click);
            // 
            // DeleteProduct
            // 
            this.DeleteProduct.Location = new System.Drawing.Point(96, 144);
            this.DeleteProduct.Name = "DeleteProduct";
            this.DeleteProduct.Size = new System.Drawing.Size(396, 64);
            this.DeleteProduct.TabIndex = 2;
            this.DeleteProduct.Text = "Remove Product";
            this.DeleteProduct.UseVisualStyleBackColor = true;
            this.DeleteProduct.Click += new System.EventHandler(this.DeleteProduct_Click);
            // 
            // ChangeProduct
            // 
            this.ChangeProduct.Location = new System.Drawing.Point(96, 224);
            this.ChangeProduct.Name = "ChangeProduct";
            this.ChangeProduct.Size = new System.Drawing.Size(396, 64);
            this.ChangeProduct.TabIndex = 3;
            this.ChangeProduct.Text = "Change An Existing Product";
            this.ChangeProduct.UseVisualStyleBackColor = true;
            this.ChangeProduct.Click += new System.EventHandler(this.ChangeProduct_Click);
            // 
            // EditProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 362);
            this.Controls.Add(this.ChangeProduct);
            this.Controls.Add(this.DeleteProduct);
            this.Controls.Add(this.AddProduct);
            this.Controls.Add(this.label1);
            this.Name = "EditProducts";
            this.Text = "EditProducts";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button AddProduct;
        private System.Windows.Forms.Button DeleteProduct;
        private System.Windows.Forms.Button ChangeProduct;
    }
}