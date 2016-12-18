namespace POS_System
{
    partial class HelpMenuPOS
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
            this.ChangeLogo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ChangeLogo
            // 
            this.ChangeLogo.Location = new System.Drawing.Point(27, 12);
            this.ChangeLogo.Name = "ChangeLogo";
            this.ChangeLogo.Size = new System.Drawing.Size(231, 31);
            this.ChangeLogo.TabIndex = 0;
            this.ChangeLogo.Text = "Changing Logo";
            this.ChangeLogo.UseVisualStyleBackColor = true;
            this.ChangeLogo.Click += new System.EventHandler(this.ChangeLogo_Click);
            // 
            // HelpMenuPOS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.ChangeLogo);
            this.HelpButton = true;
            this.MaximizeBox = false;
            this.Name = "HelpMenuPOS";
            this.ShowInTaskbar = false;
            this.Text = "HelpMenuPOS";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ChangeLogo;
    }
}