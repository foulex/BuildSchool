
namespace WinFormSolution
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
            this.foulex = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // foulex
            // 
            this.foulex.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.foulex.BackColor = System.Drawing.Color.MediumAquamarine;
            this.foulex.Font = new System.Drawing.Font("源泉圓體 TTF Regular", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.foulex.ForeColor = System.Drawing.Color.Azure;
            this.foulex.Location = new System.Drawing.Point(36, 215);
            this.foulex.Name = "foulex";
            this.foulex.Size = new System.Drawing.Size(371, 29);
            this.foulex.TabIndex = 0;
            this.foulex.Text = "Top!";
            this.foulex.UseVisualStyleBackColor = false;
            this.foulex.Click += new System.EventHandler(this.bottom_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LemonChiffon;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(500, 600);
            this.Controls.Add(this.foulex);
            this.ForeColor = System.Drawing.Color.SlateGray;
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(522, 656);
            this.Name = "Form1";
            this.Opacity = 0.75D;
            this.Text = "Foulex";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button foulex;
    }
}

