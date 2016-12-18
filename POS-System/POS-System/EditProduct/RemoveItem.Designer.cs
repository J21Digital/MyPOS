namespace POS_System.EditProduct
{
    partial class RemoveItem
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
            this.ProductIDInput = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ConfirmRemoveItem = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ProductIDInput
            // 
            this.ProductIDInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.ProductIDInput.Location = new System.Drawing.Point(66, 113);
            this.ProductIDInput.Name = "ProductIDInput";
            this.ProductIDInput.Size = new System.Drawing.Size(300, 30);
            this.ProductIDInput.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label2.Location = new System.Drawing.Point(129, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(175, 31);
            this.label2.TabIndex = 3;
            this.label2.Text = "Remove Item";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label1.Location = new System.Drawing.Point(172, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Product ID";
            // 
            // ConfirmRemoveItem
            // 
            this.ConfirmRemoveItem.Location = new System.Drawing.Point(122, 162);
            this.ConfirmRemoveItem.Name = "ConfirmRemoveItem";
            this.ConfirmRemoveItem.Size = new System.Drawing.Size(193, 59);
            this.ConfirmRemoveItem.TabIndex = 8;
            this.ConfirmRemoveItem.Text = "Remove Item";
            this.ConfirmRemoveItem.UseVisualStyleBackColor = true;
            this.ConfirmRemoveItem.Click += new System.EventHandler(this.ConfirmRemoveItem_Click);
            // 
            // RemoveItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 262);
            this.Controls.Add(this.ConfirmRemoveItem);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ProductIDInput);
            this.Controls.Add(this.label2);
            this.Name = "RemoveItem";
            this.Text = "RemoveItem";
            this.Load += new System.EventHandler(this.RemoveItem_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ProductIDInput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ConfirmRemoveItem;
    }
}