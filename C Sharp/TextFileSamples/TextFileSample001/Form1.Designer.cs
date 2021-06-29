
namespace TextFileSample001
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
            this.BRead = new System.Windows.Forms.Button();
            this.BWrite = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(408, 288);
            this.textBox1.TabIndex = 0;
            // 
            // BRead
            // 
            this.BRead.Location = new System.Drawing.Point(426, 12);
            this.BRead.Name = "BRead";
            this.BRead.Size = new System.Drawing.Size(188, 77);
            this.BRead.TabIndex = 1;
            this.BRead.Text = "讀取";
            this.BRead.UseVisualStyleBackColor = true;
            this.BRead.Click += new System.EventHandler(this.button1_Click);
            // 
            // BWrite
            // 
            this.BWrite.Location = new System.Drawing.Point(426, 95);
            this.BWrite.Name = "BWrite";
            this.BWrite.Size = new System.Drawing.Size(188, 77);
            this.BWrite.TabIndex = 1;
            this.BWrite.Text = "寫入";
            this.BWrite.UseVisualStyleBackColor = true;
            this.BWrite.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 316);
            this.Controls.Add(this.BWrite);
            this.Controls.Add(this.BRead);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button BRead;
        private System.Windows.Forms.Button BWrite;
    }
}

