namespace FarmerMove2
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
            this.button = new System.Windows.Forms.Button();
            this.LeftSide = new System.Windows.Forms.ListBox();
            this.RightSide = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // button
            // 
            this.button.Location = new System.Drawing.Point(128, 7);
            this.button.Name = "button";
            this.button.Size = new System.Drawing.Size(120, 112);
            this.button.TabIndex = 0;
            this.button.Text = "←移動→";
            this.button.UseVisualStyleBackColor = true;
            // 
            // LeftSide
            // 
            this.LeftSide.FormattingEnabled = true;
            this.LeftSide.ItemHeight = 12;
            this.LeftSide.Location = new System.Drawing.Point(2, 7);
            this.LeftSide.Name = "LeftSide";
            this.LeftSide.Size = new System.Drawing.Size(120, 112);
            this.LeftSide.TabIndex = 1;
            // 
            // RightSide
            // 
            this.RightSide.FormattingEnabled = true;
            this.RightSide.ItemHeight = 12;
            this.RightSide.Location = new System.Drawing.Point(254, 7);
            this.RightSide.Name = "RightSide";
            this.RightSide.Size = new System.Drawing.Size(120, 112);
            this.RightSide.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 121);
            this.Controls.Add(this.RightSide);
            this.Controls.Add(this.LeftSide);
            this.Controls.Add(this.button);
            this.MaximumSize = new System.Drawing.Size(390, 160);
            this.MinimumSize = new System.Drawing.Size(390, 160);
            this.Name = "Form1";
            this.Text = "農夫渡河";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button;
        private System.Windows.Forms.ListBox LeftSide;
        private System.Windows.Forms.ListBox RightSide;
    }
}

