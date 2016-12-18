namespace POS_System
{
    partial class LoadPOS
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
            this.LoadByNameInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LoadFromRecent = new System.Windows.Forms.Button();
            this.LoadFromInput = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LoadByNameInput
            // 
            this.LoadByNameInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.LoadByNameInput.Location = new System.Drawing.Point(99, 82);
            this.LoadByNameInput.Name = "LoadByNameInput";
            this.LoadByNameInput.Size = new System.Drawing.Size(745, 38);
            this.LoadByNameInput.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label1.Location = new System.Drawing.Point(286, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(363, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Load POS by business name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label2.Location = new System.Drawing.Point(378, 337);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(221, 31);
            this.label2.TabIndex = 2;
            this.label2.Text = "Load recent POS";
            // 
            // LoadFromRecent
            // 
            this.LoadFromRecent.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.LoadFromRecent.Location = new System.Drawing.Point(248, 408);
            this.LoadFromRecent.Name = "LoadFromRecent";
            this.LoadFromRecent.Size = new System.Drawing.Size(487, 67);
            this.LoadFromRecent.TabIndex = 3;
            this.LoadFromRecent.Text = "Load ";
            this.LoadFromRecent.UseVisualStyleBackColor = true;
            this.LoadFromRecent.Click += new System.EventHandler(this.LoadFromRecent_Click);
            // 
            // LoadFromInput
            // 
            this.LoadFromInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.LoadFromInput.Location = new System.Drawing.Point(248, 155);
            this.LoadFromInput.Name = "LoadFromInput";
            this.LoadFromInput.Size = new System.Drawing.Size(487, 67);
            this.LoadFromInput.TabIndex = 4;
            this.LoadFromInput.Text = "Load ";
            this.LoadFromInput.UseVisualStyleBackColor = true;
            this.LoadFromInput.Click += new System.EventHandler(this.LoadFromInput_Click);
            // 
            // LoadPOS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 562);
            this.Controls.Add(this.LoadFromInput);
            this.Controls.Add(this.LoadFromRecent);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LoadByNameInput);
            this.MaximizeBox = false;
            this.Name = "LoadPOS";
            this.Text = "LoadPOS";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LoadPOS_FormClosing);
            this.Load += new System.EventHandler(this.LoadPOS_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox LoadByNameInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button LoadFromRecent;
        private System.Windows.Forms.Button LoadFromInput;
    }
}