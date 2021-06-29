
namespace FarmerShip
{
    partial class Form
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
            this.ShipButton = new System.Windows.Forms.Button();
            this.LeftSide = new System.Windows.Forms.ListBox();
            this.RightSide = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // ShipButton
            // 
            this.ShipButton.Location = new System.Drawing.Point(188, 100);
            this.ShipButton.Name = "ShipButton";
            this.ShipButton.Size = new System.Drawing.Size(164, 135);
            this.ShipButton.TabIndex = 0;
            this.ShipButton.Text = "←→";
            this.ShipButton.UseVisualStyleBackColor = true;
            this.ShipButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // LeftSide
            // 
            this.LeftSide.FormattingEnabled = true;
            this.LeftSide.ItemHeight = 18;
            this.LeftSide.Location = new System.Drawing.Point(10, 10);
            this.LeftSide.Name = "LeftSide";
            this.LeftSide.Size = new System.Drawing.Size(153, 292);
            this.LeftSide.TabIndex = 1;
            // 
            // RightSide
            // 
            this.RightSide.FormattingEnabled = true;
            this.RightSide.ItemHeight = 18;
            this.RightSide.Location = new System.Drawing.Point(380, 10);
            this.RightSide.Name = "RightSide";
            this.RightSide.Size = new System.Drawing.Size(179, 292);
            this.RightSide.TabIndex = 2;
            // 
            // Form
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(578, 314);
            this.Controls.Add(this.RightSide);
            this.Controls.Add(this.LeftSide);
            this.Controls.Add(this.ShipButton);
            this.Name = "Form";
            this.Text = "農夫渡河";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ShipButton;
        private System.Windows.Forms.ListBox LeftSide;
        private System.Windows.Forms.ListBox RightSide;
    }
}

