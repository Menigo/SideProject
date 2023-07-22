namespace BMI
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
            this.result_btn = new System.Windows.Forms.Button();
            this.height_txtBox = new System.Windows.Forms.TextBox();
            this.width_txtBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.result_txtBox = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // result_btn
            // 
            this.result_btn.Location = new System.Drawing.Point(20, 137);
            this.result_btn.Margin = new System.Windows.Forms.Padding(2);
            this.result_btn.Name = "result_btn";
            this.result_btn.Size = new System.Drawing.Size(127, 35);
            this.result_btn.TabIndex = 0;
            this.result_btn.Text = "計算";
            this.result_btn.UseVisualStyleBackColor = true;
            this.result_btn.Click += new System.EventHandler(this.result_btn_Click);
            // 
            // height_txtBox
            // 
            this.height_txtBox.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.height_txtBox.ImeMode = System.Windows.Forms.ImeMode.Alpha;
            this.height_txtBox.Location = new System.Drawing.Point(20, 40);
            this.height_txtBox.Margin = new System.Windows.Forms.Padding(2);
            this.height_txtBox.Name = "height_txtBox";
            this.height_txtBox.Size = new System.Drawing.Size(129, 28);
            this.height_txtBox.TabIndex = 1;
            this.height_txtBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.text_KeyPress);
            // 
            // width_txtBox
            // 
            this.width_txtBox.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.width_txtBox.ImeMode = System.Windows.Forms.ImeMode.Alpha;
            this.width_txtBox.Location = new System.Drawing.Point(20, 95);
            this.width_txtBox.Margin = new System.Windows.Forms.Padding(2);
            this.width_txtBox.Name = "width_txtBox";
            this.width_txtBox.Size = new System.Drawing.Size(129, 28);
            this.width_txtBox.TabIndex = 2;
            this.width_txtBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.text_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "身高(CM)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 78);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "體重(KG)";
            // 
            // result_txtBox
            // 
            this.result_txtBox.AutoSize = true;
            this.result_txtBox.Location = new System.Drawing.Point(170, 40);
            this.result_txtBox.Name = "result_txtBox";
            this.result_txtBox.Size = new System.Drawing.Size(55, 15);
            this.result_txtBox.TabIndex = 6;
            this.result_txtBox.Text = "尚未計算";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(312, 199);
            this.Controls.Add(this.result_txtBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.width_txtBox);
            this.Controls.Add(this.height_txtBox);
            this.Controls.Add(this.result_btn);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "BMI計算機";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button result_btn;
        private TextBox height_txtBox;
        private TextBox width_txtBox;
        private Label label1;
        private Label label2;
        private Label result_txtBox;
    }
}