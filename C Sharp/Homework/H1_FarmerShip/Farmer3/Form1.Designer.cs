namespace Farmer3
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
            this.LeftSide = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.RightSide = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // LeftSide
            // 
            this.LeftSide.FormattingEnabled = true;
            this.LeftSide.ItemHeight = 12;
            this.LeftSide.Location = new System.Drawing.Point(12, 12);
            this.LeftSide.Name = "LeftSide";
            this.LeftSide.Size = new System.Drawing.Size(120, 124);
            this.LeftSide.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(138, 41);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 69);
            this.button1.TabIndex = 1;
            this.button1.Text = "←渡河→";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // RightSide
            // 
            this.RightSide.FormattingEnabled = true;
            this.RightSide.ItemHeight = 12;
            this.RightSide.Location = new System.Drawing.Point(219, 12);
            this.RightSide.Name = "RightSide";
            this.RightSide.Size = new System.Drawing.Size(120, 124);
            this.RightSide.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 151);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.RightSide);
            this.Controls.Add(this.LeftSide);
            this.MaximumSize = new System.Drawing.Size(370, 190);
            this.MinimumSize = new System.Drawing.Size(370, 190);
            this.Name = "Form1";
            this.Text = "農夫渡河";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox LeftSide;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox RightSide;
    }
}

