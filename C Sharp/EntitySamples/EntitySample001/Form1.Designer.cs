
namespace EntitySample001
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Vbutton = new System.Windows.Forms.Button();
            this.Abutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Vbutton
            // 
            this.Vbutton.Location = new System.Drawing.Point(48, 38);
            this.Vbutton.Name = "Vbutton";
            this.Vbutton.Size = new System.Drawing.Size(272, 138);
            this.Vbutton.TabIndex = 0;
            this.Vbutton.Text = "看資料";
            this.Vbutton.UseVisualStyleBackColor = true;
            this.Vbutton.Click += new System.EventHandler(this.button1_Click);
            // 
            // Abutton
            // 
            this.Abutton.Location = new System.Drawing.Point(48, 215);
            this.Abutton.Name = "Abutton";
            this.Abutton.Size = new System.Drawing.Size(272, 138);
            this.Abutton.TabIndex = 0;
            this.Abutton.Text = "新增資料";
            this.Abutton.UseVisualStyleBackColor = true;
            this.Abutton.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(401, 431);
            this.Controls.Add(this.Abutton);
            this.Controls.Add(this.Vbutton);
            this.Name = "Form1";
            this.Text = "ㄗㄌ";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Vbutton;
        private System.Windows.Forms.Button Abutton;
    }
}

