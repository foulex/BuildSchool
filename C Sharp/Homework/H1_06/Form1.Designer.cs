
namespace D2_06
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.L_Sat = new System.Windows.Forms.Label();
            this.L_Sun = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(48, 44);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(150, 29);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "請輸入西元年份";
            // 
            // L_Sat
            // 
            this.L_Sat.AutoSize = true;
            this.L_Sat.Location = new System.Drawing.Point(48, 184);
            this.L_Sat.Name = "L_Sat";
            this.L_Sat.Size = new System.Drawing.Size(62, 18);
            this.L_Sat.TabIndex = 1;
            this.L_Sat.Text = "星期六";
            // 
            // L_Sun
            // 
            this.L_Sun.AutoSize = true;
            this.L_Sun.Location = new System.Drawing.Point(48, 224);
            this.L_Sun.Name = "L_Sun";
            this.L_Sun.Size = new System.Drawing.Size(62, 18);
            this.L_Sun.TabIndex = 2;
            this.L_Sun.Text = "星期日";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(48, 92);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 46);
            this.button1.TabIndex = 3;
            this.button1.Text = "確認";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(270, 300);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.L_Sun);
            this.Controls.Add(this.L_Sat);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label L_Sat;
        private System.Windows.Forms.Label L_Sun;
        private System.Windows.Forms.Button button1;
    }
}

