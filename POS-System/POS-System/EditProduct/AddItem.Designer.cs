namespace POS_System.EditProduct
{
    partial class AddItem
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
            this.label2 = new System.Windows.Forms.Label();
            this.ProductIDInput = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ProductName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ProductDescription = new System.Windows.Forms.RichTextBox();
            this.ConfirmAddItem = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.ProductCost = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label1.Location = new System.Drawing.Point(157, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add a new item";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label2.Location = new System.Drawing.Point(212, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Product ID";
            // 
            // ProductIDInput
            // 
            this.ProductIDInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.ProductIDInput.Location = new System.Drawing.Point(110, 125);
            this.ProductIDInput.Name = "ProductIDInput";
            this.ProductIDInput.Size = new System.Drawing.Size(300, 30);
            this.ProductIDInput.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label3.Location = new System.Drawing.Point(196, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Product Name";
            // 
            // ProductName
            // 
            this.ProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.ProductName.Location = new System.Drawing.Point(110, 210);
            this.ProductName.Name = "ProductName";
            this.ProductName.Size = new System.Drawing.Size(300, 30);
            this.ProductName.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label4.Location = new System.Drawing.Point(175, 353);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(181, 25);
            this.label4.TabIndex = 5;
            this.label4.Text = "Product Description";
            // 
            // ProductDescription
            // 
            this.ProductDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ProductDescription.Location = new System.Drawing.Point(110, 392);
            this.ProductDescription.Name = "ProductDescription";
            this.ProductDescription.Size = new System.Drawing.Size(300, 116);
            this.ProductDescription.TabIndex = 6;
            this.ProductDescription.Text = "";
            // 
            // ConfirmAddItem
            // 
            this.ConfirmAddItem.Location = new System.Drawing.Point(163, 523);
            this.ConfirmAddItem.Name = "ConfirmAddItem";
            this.ConfirmAddItem.Size = new System.Drawing.Size(193, 59);
            this.ConfirmAddItem.TabIndex = 7;
            this.ConfirmAddItem.Text = "Add New Item";
            this.ConfirmAddItem.UseVisualStyleBackColor = true;
            this.ConfirmAddItem.Click += new System.EventHandler(this.ConfirmAddItem_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label5.Location = new System.Drawing.Point(143, 275);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(250, 25);
            this.label5.TabIndex = 8;
            this.label5.Text = "Product Cost (No Symbols)";
            // 
            // ProductCost
            // 
            this.ProductCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.ProductCost.Location = new System.Drawing.Point(110, 303);
            this.ProductCost.Name = "ProductCost";
            this.ProductCost.Size = new System.Drawing.Size(300, 30);
            this.ProductCost.TabIndex = 9;
            this.ProductCost.TextChanged += new System.EventHandler(this.ProductCost_TextChanged);
            // 
            // AddItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 607);
            this.Controls.Add(this.ProductCost);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ConfirmAddItem);
            this.Controls.Add(this.ProductDescription);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ProductName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ProductIDInput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddItem";
            this.Text = "AddItem";
            this.Load += new System.EventHandler(this.AddItem_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ProductIDInput;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ProductName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox ProductDescription;
        private System.Windows.Forms.Button ConfirmAddItem;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox ProductCost;
    }
}