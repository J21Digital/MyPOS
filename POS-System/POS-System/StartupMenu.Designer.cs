namespace POS_System
{
    partial class StartupMenu
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
            this.CreateNew = new System.Windows.Forms.Button();
            this.LoadExisting = new System.Windows.Forms.Button();
            this.DeleteExisting = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CreateNew
            // 
            this.CreateNew.Location = new System.Drawing.Point(53, 104);
            this.CreateNew.Name = "CreateNew";
            this.CreateNew.Size = new System.Drawing.Size(842, 78);
            this.CreateNew.TabIndex = 0;
            this.CreateNew.Text = "Create a new POS machine";
            this.CreateNew.UseVisualStyleBackColor = true;
            this.CreateNew.Click += new System.EventHandler(this.CreateNew_Click);
            // 
            // LoadExisting
            // 
            this.LoadExisting.Location = new System.Drawing.Point(53, 215);
            this.LoadExisting.Name = "LoadExisting";
            this.LoadExisting.Size = new System.Drawing.Size(842, 78);
            this.LoadExisting.TabIndex = 1;
            this.LoadExisting.Text = "Load an existing POS machine";
            this.LoadExisting.UseVisualStyleBackColor = true;
            this.LoadExisting.Click += new System.EventHandler(this.LoadExisting_Click);
            // 
            // DeleteExisting
            // 
            this.DeleteExisting.Location = new System.Drawing.Point(53, 431);
            this.DeleteExisting.Name = "DeleteExisting";
            this.DeleteExisting.Size = new System.Drawing.Size(842, 78);
            this.DeleteExisting.TabIndex = 2;
            this.DeleteExisting.Text = "Delete an existing POS machine";
            this.DeleteExisting.UseVisualStyleBackColor = true;
            this.DeleteExisting.Click += new System.EventHandler(this.DeleteExisting_Click);
            // 
            // StartupMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 562);
            this.Controls.Add(this.DeleteExisting);
            this.Controls.Add(this.LoadExisting);
            this.Controls.Add(this.CreateNew);
            this.MaximizeBox = false;
            this.Name = "StartupMenu";
            this.Text = "StartupMenu";
            this.Load += new System.EventHandler(this.StartupMenu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CreateNew;
        private System.Windows.Forms.Button LoadExisting;
        private System.Windows.Forms.Button DeleteExisting;
    }
}