
namespace H4_02_滷味
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
            this.LFood1 = new System.Windows.Forms.Label();
            this.TFood1 = new System.Windows.Forms.TextBox();
            this.LFood2 = new System.Windows.Forms.Label();
            this.TFood2 = new System.Windows.Forms.TextBox();
            this.LFood3 = new System.Windows.Forms.Label();
            this.TFood3 = new System.Windows.Forms.TextBox();
            this.LFood4 = new System.Windows.Forms.Label();
            this.TFood4 = new System.Windows.Forms.TextBox();
            this.button = new System.Windows.Forms.Button();
            this.LMPrice = new System.Windows.Forms.Label();
            this.LM1000 = new System.Windows.Forms.Label();
            this.LM500 = new System.Windows.Forms.Label();
            this.LM100 = new System.Windows.Forms.Label();
            this.LM50 = new System.Windows.Forms.Label();
            this.LM10 = new System.Windows.Forms.Label();
            this.LM5 = new System.Windows.Forms.Label();
            this.LM1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LFood1
            // 
            this.LFood1.AutoSize = true;
            this.LFood1.Location = new System.Drawing.Point(12, 9);
            this.LFood1.Name = "LFood1";
            this.LFood1.Size = new System.Drawing.Size(98, 18);
            this.LFood1.TabIndex = 0;
            this.LFood1.Text = "高麗菜(30$)";
            // 
            // TFood1
            // 
            this.TFood1.Location = new System.Drawing.Point(116, 6);
            this.TFood1.Name = "TFood1";
            this.TFood1.Size = new System.Drawing.Size(100, 29);
            this.TFood1.TabIndex = 1;
            this.TFood1.Text = "0";
            // 
            // LFood2
            // 
            this.LFood2.AutoSize = true;
            this.LFood2.Location = new System.Drawing.Point(12, 43);
            this.LFood2.Name = "LFood2";
            this.LFood2.Size = new System.Drawing.Size(80, 18);
            this.LFood2.TabIndex = 0;
            this.LFood2.Text = "豆干(17$)";
            // 
            // TFood2
            // 
            this.TFood2.Location = new System.Drawing.Point(116, 40);
            this.TFood2.Name = "TFood2";
            this.TFood2.Size = new System.Drawing.Size(100, 29);
            this.TFood2.TabIndex = 1;
            this.TFood2.Text = "0";
            // 
            // LFood3
            // 
            this.LFood3.AutoSize = true;
            this.LFood3.Location = new System.Drawing.Point(12, 78);
            this.LFood3.Name = "LFood3";
            this.LFood3.Size = new System.Drawing.Size(80, 18);
            this.LFood3.TabIndex = 0;
            this.LFood3.Text = "海帶(15$)";
            // 
            // TFood3
            // 
            this.TFood3.Location = new System.Drawing.Point(116, 75);
            this.TFood3.Name = "TFood3";
            this.TFood3.Size = new System.Drawing.Size(100, 29);
            this.TFood3.TabIndex = 1;
            this.TFood3.Text = "0";
            // 
            // LFood4
            // 
            this.LFood4.AutoSize = true;
            this.LFood4.Location = new System.Drawing.Point(12, 113);
            this.LFood4.Name = "LFood4";
            this.LFood4.Size = new System.Drawing.Size(80, 18);
            this.LFood4.TabIndex = 0;
            this.LFood4.Text = "肉片(40$)";
            // 
            // TFood4
            // 
            this.TFood4.Location = new System.Drawing.Point(116, 110);
            this.TFood4.Name = "TFood4";
            this.TFood4.Size = new System.Drawing.Size(100, 29);
            this.TFood4.TabIndex = 1;
            this.TFood4.Text = "0";
            // 
            // button
            // 
            this.button.Location = new System.Drawing.Point(222, 6);
            this.button.Name = "button";
            this.button.Size = new System.Drawing.Size(126, 133);
            this.button.TabIndex = 2;
            this.button.Text = "買買買";
            this.button.UseVisualStyleBackColor = true;
            this.button.Click += new System.EventHandler(this.button1_Click);
            // 
            // LMPrice
            // 
            this.LMPrice.AutoSize = true;
            this.LMPrice.Location = new System.Drawing.Point(354, 9);
            this.LMPrice.Name = "LMPrice";
            this.LMPrice.Size = new System.Drawing.Size(44, 18);
            this.LMPrice.TabIndex = 0;
            this.LMPrice.Text = "總價";
            // 
            // LM1000
            // 
            this.LM1000.AutoSize = true;
            this.LM1000.Location = new System.Drawing.Point(354, 43);
            this.LM1000.Name = "LM1000";
            this.LM1000.Size = new System.Drawing.Size(63, 18);
            this.LM1000.TabIndex = 0;
            this.LM1000.Text = "1000鈔:";
            // 
            // LM500
            // 
            this.LM500.AutoSize = true;
            this.LM500.Location = new System.Drawing.Point(354, 78);
            this.LM500.Name = "LM500";
            this.LM500.Size = new System.Drawing.Size(55, 18);
            this.LM500.TabIndex = 0;
            this.LM500.Text = "500鈔:";
            // 
            // LM100
            // 
            this.LM100.AutoSize = true;
            this.LM100.Location = new System.Drawing.Point(354, 113);
            this.LM100.Name = "LM100";
            this.LM100.Size = new System.Drawing.Size(55, 18);
            this.LM100.TabIndex = 0;
            this.LM100.Text = "100鈔:";
            // 
            // LM50
            // 
            this.LM50.AutoSize = true;
            this.LM50.Location = new System.Drawing.Point(483, 9);
            this.LM50.Name = "LM50";
            this.LM50.Size = new System.Drawing.Size(47, 18);
            this.LM50.TabIndex = 0;
            this.LM50.Text = "50元:";
            // 
            // LM10
            // 
            this.LM10.AutoSize = true;
            this.LM10.Location = new System.Drawing.Point(483, 44);
            this.LM10.Name = "LM10";
            this.LM10.Size = new System.Drawing.Size(47, 18);
            this.LM10.TabIndex = 0;
            this.LM10.Text = "10元:";
            // 
            // LM5
            // 
            this.LM5.AutoSize = true;
            this.LM5.Location = new System.Drawing.Point(483, 79);
            this.LM5.Name = "LM5";
            this.LM5.Size = new System.Drawing.Size(39, 18);
            this.LM5.TabIndex = 0;
            this.LM5.Text = "5元:";
            // 
            // LM1
            // 
            this.LM1.AutoSize = true;
            this.LM1.Location = new System.Drawing.Point(483, 113);
            this.LM1.Name = "LM1";
            this.LM1.Size = new System.Drawing.Size(39, 18);
            this.LM1.TabIndex = 0;
            this.LM1.Text = "1元:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 156);
            this.Controls.Add(this.button);
            this.Controls.Add(this.TFood4);
            this.Controls.Add(this.TFood3);
            this.Controls.Add(this.TFood2);
            this.Controls.Add(this.TFood1);
            this.Controls.Add(this.LFood4);
            this.Controls.Add(this.LFood3);
            this.Controls.Add(this.LFood2);
            this.Controls.Add(this.LM1);
            this.Controls.Add(this.LM5);
            this.Controls.Add(this.LM10);
            this.Controls.Add(this.LM50);
            this.Controls.Add(this.LM100);
            this.Controls.Add(this.LM500);
            this.Controls.Add(this.LM1000);
            this.Controls.Add(this.LMPrice);
            this.Controls.Add(this.LFood1);
            this.Name = "Form1";
            this.Text = "滷味";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LFood1;
        private System.Windows.Forms.TextBox TFood1;
        private System.Windows.Forms.Label LFood2;
        private System.Windows.Forms.TextBox TFood2;
        private System.Windows.Forms.Label LFood3;
        private System.Windows.Forms.TextBox TFood3;
        private System.Windows.Forms.Label LFood4;
        private System.Windows.Forms.TextBox TFood4;
        private System.Windows.Forms.Button button;
        private System.Windows.Forms.Label LMPrice;
        private System.Windows.Forms.Label LM1000;
        private System.Windows.Forms.Label LM500;
        private System.Windows.Forms.Label LM100;
        private System.Windows.Forms.Label LM50;
        private System.Windows.Forms.Label LM10;
        private System.Windows.Forms.Label LM5;
        private System.Windows.Forms.Label LM1;
    }
}

