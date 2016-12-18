namespace POS_System
{
    partial class CreateBusiness
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
            this.companyTitleBox = new System.Windows.Forms.TextBox();
            this.createPOS = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label1.Location = new System.Drawing.Point(321, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(301, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Create A New Business";
            // 
            // companyTitleBox
            // 
            this.companyTitleBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.companyTitleBox.Location = new System.Drawing.Point(210, 151);
            this.companyTitleBox.Name = "companyTitleBox";
            this.companyTitleBox.Size = new System.Drawing.Size(532, 26);
            this.companyTitleBox.TabIndex = 1;
            this.companyTitleBox.Text = "Business Name";
            this.companyTitleBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.companyTitleBox.TextChanged += new System.EventHandler(this.companyTitleBox_textChanged);
            // 
            // createPOS
            // 
            this.createPOS.Location = new System.Drawing.Point(210, 224);
            this.createPOS.Name = "createPOS";
            this.createPOS.Size = new System.Drawing.Size(532, 27);
            this.createPOS.TabIndex = 3;
            this.createPOS.Text = "Create Business POS";
            this.createPOS.UseVisualStyleBackColor = true;
            this.createPOS.Click += new System.EventHandler(this.createPOS_Click);
            // 
            // CreateBusiness
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 562);
            this.Controls.Add(this.createPOS);
            this.Controls.Add(this.companyTitleBox);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "CreateBusiness";
            this.Text = "Create A New Business";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CreateBusiness_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox companyTitleBox;
        private System.Windows.Forms.Button createPOS;
    }
}

