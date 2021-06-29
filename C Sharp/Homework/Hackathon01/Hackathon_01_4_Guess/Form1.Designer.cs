
namespace Hackathon_01_4_Guess
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
            this.B_Start = new System.Windows.Forms.Button();
            this.B_Ans = new System.Windows.Forms.Button();
            this.B_Send = new System.Windows.Forms.Button();
            this.B_Giveup = new System.Windows.Forms.Button();
            this.AnsList = new System.Windows.Forms.ListBox();
            this.textBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // B_Start
            // 
            this.B_Start.Location = new System.Drawing.Point(12, 12);
            this.B_Start.Name = "B_Start";
            this.B_Start.Size = new System.Drawing.Size(101, 33);
            this.B_Start.TabIndex = 0;
            this.B_Start.Text = "開始遊戲";
            this.B_Start.UseVisualStyleBackColor = true;
            this.B_Start.Click += new System.EventHandler(this.B_Start_Click);
            // 
            // B_Ans
            // 
            this.B_Ans.Enabled = false;
            this.B_Ans.Location = new System.Drawing.Point(119, 12);
            this.B_Ans.Name = "B_Ans";
            this.B_Ans.Size = new System.Drawing.Size(101, 33);
            this.B_Ans.TabIndex = 0;
            this.B_Ans.Text = "看答案";
            this.B_Ans.UseVisualStyleBackColor = true;
            this.B_Ans.Click += new System.EventHandler(this.B_Ans_Click);
            // 
            // B_Send
            // 
            this.B_Send.Enabled = false;
            this.B_Send.Location = new System.Drawing.Point(12, 104);
            this.B_Send.Name = "B_Send";
            this.B_Send.Size = new System.Drawing.Size(101, 33);
            this.B_Send.TabIndex = 0;
            this.B_Send.Text = "送出數字";
            this.B_Send.UseVisualStyleBackColor = true;
            this.B_Send.Click += new System.EventHandler(this.B_Send_Click);
            // 
            // B_Giveup
            // 
            this.B_Giveup.Enabled = false;
            this.B_Giveup.Location = new System.Drawing.Point(119, 104);
            this.B_Giveup.Name = "B_Giveup";
            this.B_Giveup.Size = new System.Drawing.Size(101, 33);
            this.B_Giveup.TabIndex = 0;
            this.B_Giveup.Text = "放棄重來";
            this.B_Giveup.UseVisualStyleBackColor = true;
            this.B_Giveup.Click += new System.EventHandler(this.B_Giveup_Click);
            // 
            // AnsList
            // 
            this.AnsList.FormattingEnabled = true;
            this.AnsList.ItemHeight = 18;
            this.AnsList.Location = new System.Drawing.Point(226, 12);
            this.AnsList.Name = "AnsList";
            this.AnsList.Size = new System.Drawing.Size(106, 364);
            this.AnsList.TabIndex = 1;
            // 
            // textBox
            // 
            this.textBox.Location = new System.Drawing.Point(12, 69);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(208, 29);
            this.textBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(75, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "輸入數字";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.AnsList);
            this.Controls.Add(this.B_Giveup);
            this.Controls.Add(this.B_Send);
            this.Controls.Add(this.B_Ans);
            this.Controls.Add(this.B_Start);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button B_Start;
        private System.Windows.Forms.Button B_Ans;
        private System.Windows.Forms.Button B_Send;
        private System.Windows.Forms.Button B_Giveup;
        private System.Windows.Forms.ListBox AnsList;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.Label label1;
    }
}

