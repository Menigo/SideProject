namespace ControlWindows
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Hide_Btn = new System.Windows.Forms.Button();
            this.Show_Btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Hide_Btn
            // 
            this.Hide_Btn.Location = new System.Drawing.Point(20, 16);
            this.Hide_Btn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Hide_Btn.Name = "Hide_Btn";
            this.Hide_Btn.Size = new System.Drawing.Size(148, 50);
            this.Hide_Btn.TabIndex = 0;
            this.Hide_Btn.Text = "HIDE";
            this.Hide_Btn.UseVisualStyleBackColor = true;
            this.Hide_Btn.Click += new System.EventHandler(this.Hide_Btn_Click);
            // 
            // Show_Btn
            // 
            this.Show_Btn.Enabled = false;
            this.Show_Btn.Location = new System.Drawing.Point(20, 70);
            this.Show_Btn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Show_Btn.Name = "Show_Btn";
            this.Show_Btn.Size = new System.Drawing.Size(148, 50);
            this.Show_Btn.TabIndex = 1;
            this.Show_Btn.Text = "SHOW";
            this.Show_Btn.UseVisualStyleBackColor = true;
            this.Show_Btn.Click += new System.EventHandler(this.Show_Btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(186, 138);
            this.Controls.Add(this.Show_Btn);
            this.Controls.Add(this.Hide_Btn);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Button Hide_Btn;
        private Button Show_Btn;
    }
}