namespace POS_System
{
    partial class RemoveBusiness
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
            this.RemoveByInput = new System.Windows.Forms.TextBox();
            this.RemoveFromInput = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // RemoveByInput
            // 
            this.RemoveByInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.RemoveByInput.Location = new System.Drawing.Point(64, 160);
            this.RemoveByInput.Name = "RemoveByInput";
            this.RemoveByInput.Size = new System.Drawing.Size(432, 38);
            this.RemoveByInput.TabIndex = 0;
            this.RemoveByInput.TextChanged += new System.EventHandler(this.RemoveByInput_TextChanged);
            // 
            // RemoveFromInput
            // 
            this.RemoveFromInput.Location = new System.Drawing.Point(192, 216);
            this.RemoveFromInput.Name = "RemoveFromInput";
            this.RemoveFromInput.Size = new System.Drawing.Size(200, 56);
            this.RemoveFromInput.TabIndex = 1;
            this.RemoveFromInput.Text = "Continue";
            this.RemoveFromInput.UseVisualStyleBackColor = true;
            this.RemoveFromInput.Click += new System.EventHandler(this.RemoveFromInput_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label1.Location = new System.Drawing.Point(80, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(403, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "Enter business name to remove.";
            // 
            // RemoveBusiness
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 413);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RemoveFromInput);
            this.Controls.Add(this.RemoveByInput);
            this.MaximizeBox = false;
            this.Name = "RemoveBusiness";
            this.Text = "RemoveBusiness";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.RemoveBusiness_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox RemoveByInput;
        private System.Windows.Forms.Button RemoveFromInput;
        private System.Windows.Forms.Label label1;
    }
}