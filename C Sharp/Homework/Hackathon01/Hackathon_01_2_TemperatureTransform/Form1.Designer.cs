
namespace Hackathon_01_2_TemperatureTransform
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
            this.R_CtoF = new System.Windows.Forms.RadioButton();
            this.R_FtoC = new System.Windows.Forms.RadioButton();
            this.B_7 = new System.Windows.Forms.Button();
            this.B_8 = new System.Windows.Forms.Button();
            this.B_9 = new System.Windows.Forms.Button();
            this.B_4 = new System.Windows.Forms.Button();
            this.B_5 = new System.Windows.Forms.Button();
            this.B_6 = new System.Windows.Forms.Button();
            this.B_1 = new System.Windows.Forms.Button();
            this.B_2 = new System.Windows.Forms.Button();
            this.B_3 = new System.Windows.Forms.Button();
            this.B_0 = new System.Windows.Forms.Button();
            this.B_Dot = new System.Windows.Forms.Button();
            this.textBox = new System.Windows.Forms.TextBox();
            this.B_Convert = new System.Windows.Forms.Button();
            this.B_Clear = new System.Windows.Forms.Button();
            this.Label_Result = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // R_CtoF
            // 
            this.R_CtoF.AutoSize = true;
            this.R_CtoF.Location = new System.Drawing.Point(12, 17);
            this.R_CtoF.Name = "R_CtoF";
            this.R_CtoF.Size = new System.Drawing.Size(159, 22);
            this.R_CtoF.TabIndex = 0;
            this.R_CtoF.TabStop = true;
            this.R_CtoF.Text = "攝氏轉換為華氏";
            this.R_CtoF.UseVisualStyleBackColor = true;
            // 
            // R_FtoC
            // 
            this.R_FtoC.AutoSize = true;
            this.R_FtoC.Location = new System.Drawing.Point(12, 45);
            this.R_FtoC.Name = "R_FtoC";
            this.R_FtoC.Size = new System.Drawing.Size(159, 22);
            this.R_FtoC.TabIndex = 0;
            this.R_FtoC.TabStop = true;
            this.R_FtoC.Text = "華氏轉換為攝氏";
            this.R_FtoC.UseVisualStyleBackColor = true;
            // 
            // B_7
            // 
            this.B_7.Location = new System.Drawing.Point(201, 17);
            this.B_7.Name = "B_7";
            this.B_7.Size = new System.Drawing.Size(50, 50);
            this.B_7.TabIndex = 1;
            this.B_7.Text = "７";
            this.B_7.UseVisualStyleBackColor = true;
            this.B_7.Click += new System.EventHandler(this.B_7_Click);
            // 
            // B_8
            // 
            this.B_8.Location = new System.Drawing.Point(257, 17);
            this.B_8.Name = "B_8";
            this.B_8.Size = new System.Drawing.Size(50, 50);
            this.B_8.TabIndex = 1;
            this.B_8.Text = "８";
            this.B_8.UseVisualStyleBackColor = true;
            this.B_8.Click += new System.EventHandler(this.B_8_Click);
            // 
            // B_9
            // 
            this.B_9.Location = new System.Drawing.Point(313, 17);
            this.B_9.Name = "B_9";
            this.B_9.Size = new System.Drawing.Size(50, 50);
            this.B_9.TabIndex = 1;
            this.B_9.Text = "９";
            this.B_9.UseVisualStyleBackColor = true;
            this.B_9.Click += new System.EventHandler(this.B_9_Click);
            // 
            // B_4
            // 
            this.B_4.Location = new System.Drawing.Point(201, 73);
            this.B_4.Name = "B_4";
            this.B_4.Size = new System.Drawing.Size(50, 50);
            this.B_4.TabIndex = 1;
            this.B_4.Text = "４";
            this.B_4.UseVisualStyleBackColor = true;
            this.B_4.Click += new System.EventHandler(this.B_4_Click);
            // 
            // B_5
            // 
            this.B_5.Location = new System.Drawing.Point(257, 73);
            this.B_5.Name = "B_5";
            this.B_5.Size = new System.Drawing.Size(50, 50);
            this.B_5.TabIndex = 1;
            this.B_5.Text = "５";
            this.B_5.UseVisualStyleBackColor = true;
            this.B_5.Click += new System.EventHandler(this.B_5_Click);
            // 
            // B_6
            // 
            this.B_6.Location = new System.Drawing.Point(313, 73);
            this.B_6.Name = "B_6";
            this.B_6.Size = new System.Drawing.Size(50, 50);
            this.B_6.TabIndex = 1;
            this.B_6.Text = "６";
            this.B_6.UseVisualStyleBackColor = true;
            this.B_6.Click += new System.EventHandler(this.B_6_Click);
            // 
            // B_1
            // 
            this.B_1.Location = new System.Drawing.Point(201, 129);
            this.B_1.Name = "B_1";
            this.B_1.Size = new System.Drawing.Size(50, 50);
            this.B_1.TabIndex = 1;
            this.B_1.Text = "１";
            this.B_1.UseVisualStyleBackColor = true;
            this.B_1.Click += new System.EventHandler(this.B_1_Click);
            // 
            // B_2
            // 
            this.B_2.Location = new System.Drawing.Point(257, 129);
            this.B_2.Name = "B_2";
            this.B_2.Size = new System.Drawing.Size(50, 50);
            this.B_2.TabIndex = 1;
            this.B_2.Text = "２";
            this.B_2.UseVisualStyleBackColor = true;
            this.B_2.Click += new System.EventHandler(this.B_2_Click);
            // 
            // B_3
            // 
            this.B_3.Location = new System.Drawing.Point(313, 129);
            this.B_3.Name = "B_3";
            this.B_3.Size = new System.Drawing.Size(50, 50);
            this.B_3.TabIndex = 1;
            this.B_3.Text = "３";
            this.B_3.UseVisualStyleBackColor = true;
            this.B_3.Click += new System.EventHandler(this.B_3_Click);
            // 
            // B_0
            // 
            this.B_0.Location = new System.Drawing.Point(201, 185);
            this.B_0.Name = "B_0";
            this.B_0.Size = new System.Drawing.Size(106, 50);
            this.B_0.TabIndex = 1;
            this.B_0.Text = "０";
            this.B_0.UseVisualStyleBackColor = true;
            this.B_0.Click += new System.EventHandler(this.B_0_Click);
            // 
            // B_Dot
            // 
            this.B_Dot.Location = new System.Drawing.Point(313, 185);
            this.B_Dot.Name = "B_Dot";
            this.B_Dot.Size = new System.Drawing.Size(50, 50);
            this.B_Dot.TabIndex = 1;
            this.B_Dot.Text = "．";
            this.B_Dot.UseVisualStyleBackColor = true;
            this.B_Dot.Click += new System.EventHandler(this.B_Dot_Click);
            // 
            // textBox
            // 
            this.textBox.Location = new System.Drawing.Point(405, 17);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(180, 29);
            this.textBox.TabIndex = 2;
            this.textBox.Text = "0";
            // 
            // B_Convert
            // 
            this.B_Convert.Location = new System.Drawing.Point(405, 52);
            this.B_Convert.Name = "B_Convert";
            this.B_Convert.Size = new System.Drawing.Size(88, 58);
            this.B_Convert.TabIndex = 3;
            this.B_Convert.Text = "換算";
            this.B_Convert.UseVisualStyleBackColor = true;
            this.B_Convert.Click += new System.EventHandler(this.B_Convert_Click);
            // 
            // B_Clear
            // 
            this.B_Clear.Location = new System.Drawing.Point(497, 52);
            this.B_Clear.Name = "B_Clear";
            this.B_Clear.Size = new System.Drawing.Size(88, 58);
            this.B_Clear.TabIndex = 3;
            this.B_Clear.Text = "清除";
            this.B_Clear.UseVisualStyleBackColor = true;
            this.B_Clear.Click += new System.EventHandler(this.B_Clear_Click);
            // 
            // Label_Result
            // 
            this.Label_Result.AutoSize = true;
            this.Label_Result.Location = new System.Drawing.Point(405, 129);
            this.Label_Result.Name = "Label_Result";
            this.Label_Result.Size = new System.Drawing.Size(44, 18);
            this.Label_Result.TabIndex = 4;
            this.Label_Result.Text = "結果";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 264);
            this.Controls.Add(this.Label_Result);
            this.Controls.Add(this.B_Clear);
            this.Controls.Add(this.B_Convert);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.B_Dot);
            this.Controls.Add(this.B_3);
            this.Controls.Add(this.B_2);
            this.Controls.Add(this.B_6);
            this.Controls.Add(this.B_0);
            this.Controls.Add(this.B_5);
            this.Controls.Add(this.B_1);
            this.Controls.Add(this.B_9);
            this.Controls.Add(this.B_4);
            this.Controls.Add(this.B_8);
            this.Controls.Add(this.B_7);
            this.Controls.Add(this.R_FtoC);
            this.Controls.Add(this.R_CtoF);
            this.Name = "Form1";
            this.Text = "溫度轉換";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton R_CtoF;
        private System.Windows.Forms.RadioButton R_FtoC;
        private System.Windows.Forms.Button B_7;
        private System.Windows.Forms.Button B_8;
        private System.Windows.Forms.Button B_9;
        private System.Windows.Forms.Button B_4;
        private System.Windows.Forms.Button B_5;
        private System.Windows.Forms.Button B_6;
        private System.Windows.Forms.Button B_1;
        private System.Windows.Forms.Button B_2;
        private System.Windows.Forms.Button B_3;
        private System.Windows.Forms.Button B_0;
        private System.Windows.Forms.Button B_Dot;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.Button B_Convert;
        private System.Windows.Forms.Button B_Clear;
        private System.Windows.Forms.Label Label_Result;
    }
}

