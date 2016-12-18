namespace POS_System
{
    partial class ChangeItem
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
            this.ProductCost = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ConfirmChangeItem = new System.Windows.Forms.Button();
            this.ProductDescription = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ProductIDInput = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label1.Location = new System.Drawing.Point(120, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(271, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Change Existing Item";
            // 
            // ProductCost
            // 
            this.ProductCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.ProductCost.Location = new System.Drawing.Point(112, 199);
            this.ProductCost.Name = "ProductCost";
            this.ProductCost.Size = new System.Drawing.Size(300, 30);
            this.ProductCost.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label5.Location = new System.Drawing.Point(145, 171);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(250, 25);
            this.label5.TabIndex = 17;
            this.label5.Text = "Product Cost (No Symbols)";
            // 
            // ConfirmChangeItem
            // 
            this.ConfirmChangeItem.Location = new System.Drawing.Point(165, 419);
            this.ConfirmChangeItem.Name = "ConfirmChangeItem";
            this.ConfirmChangeItem.Size = new System.Drawing.Size(193, 59);
            this.ConfirmChangeItem.TabIndex = 16;
            this.ConfirmChangeItem.Text = "Change Item";
            this.ConfirmChangeItem.UseVisualStyleBackColor = true;
            this.ConfirmChangeItem.Click += new System.EventHandler(this.ConfirmChangeItem_Click);
            // 
            // ProductDescription
            // 
            this.ProductDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ProductDescription.Location = new System.Drawing.Point(112, 288);
            this.ProductDescription.Name = "ProductDescription";
            this.ProductDescription.Size = new System.Drawing.Size(300, 116);
            this.ProductDescription.TabIndex = 15;
            this.ProductDescription.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label4.Location = new System.Drawing.Point(177, 249);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(181, 25);
            this.label4.TabIndex = 14;
            this.label4.Text = "Product Description";
            // 
            // ProductIDInput
            // 
            this.ProductIDInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.ProductIDInput.Location = new System.Drawing.Point(112, 112);
            this.ProductIDInput.Name = "ProductIDInput";
            this.ProductIDInput.Size = new System.Drawing.Size(300, 30);
            this.ProductIDInput.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label2.Location = new System.Drawing.Point(184, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 25);
            this.label2.TabIndex = 10;
            this.label2.Text = "Enter Product ID";
            // 
            // ChangeItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 607);
            this.Controls.Add(this.ProductCost);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ConfirmChangeItem);
            this.Controls.Add(this.ProductDescription);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ProductIDInput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ChangeItem";
            this.Text = "ChangeItem";
            this.Load += new System.EventHandler(this.ChangeItem_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ProductCost;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button ConfirmChangeItem;
        private System.Windows.Forms.RichTextBox ProductDescription;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ProductIDInput;
        private System.Windows.Forms.Label label2;
    }
}