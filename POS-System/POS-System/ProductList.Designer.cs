namespace POS_System
{
    partial class ProductList
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Cost = new System.Windows.Forms.RichTextBox();
            this.ProductName = new System.Windows.Forms.RichTextBox();
            this.ProductID = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(288, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Cost";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(112, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Product Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Product ID";
            // 
            // Cost
            // 
            this.Cost.Location = new System.Drawing.Point(286, 32);
            this.Cost.Name = "Cost";
            this.Cost.ReadOnly = true;
            this.Cost.Size = new System.Drawing.Size(91, 527);
            this.Cost.TabIndex = 15;
            this.Cost.Text = "";
            // 
            // ProductName
            // 
            this.ProductName.Location = new System.Drawing.Point(112, 32);
            this.ProductName.Name = "ProductName";
            this.ProductName.ReadOnly = true;
            this.ProductName.Size = new System.Drawing.Size(168, 528);
            this.ProductName.TabIndex = 14;
            this.ProductName.Text = "";
            // 
            // ProductID
            // 
            this.ProductID.Location = new System.Drawing.Point(8, 32);
            this.ProductID.Name = "ProductID";
            this.ProductID.ReadOnly = true;
            this.ProductID.Size = new System.Drawing.Size(94, 526);
            this.ProductID.TabIndex = 13;
            this.ProductID.Text = "";
            // 
            // ProductList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 562);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Cost);
            this.Controls.Add(this.ProductName);
            this.Controls.Add(this.ProductID);
            this.Name = "ProductList";
            this.Text = "ProductList";
            this.Load += new System.EventHandler(this.ProductList_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox Cost;
        private System.Windows.Forms.RichTextBox ProductName;
        private System.Windows.Forms.RichTextBox ProductID;
    }
}