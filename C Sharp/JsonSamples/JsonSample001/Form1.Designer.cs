
namespace JsonSample001
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.C1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.C1,
            this.C2,
            this.C3,
            this.C4,
            this.C5});
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 31;
            this.dataGridView1.Size = new System.Drawing.Size(1132, 469);
            this.dataGridView1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 487);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(188, 117);
            this.button1.TabIndex = 1;
            this.button1.Text = "取得資料";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // C1
            // 
            this.C1.DataPropertyName = "Seq";
            this.C1.HeaderText = "序號";
            this.C1.MinimumWidth = 8;
            this.C1.Name = "C1";
            this.C1.ReadOnly = true;
            this.C1.Width = 150;
            // 
            // C2
            // 
            this.C2.DataPropertyName = "name";
            this.C2.HeaderText = "菜名";
            this.C2.MinimumWidth = 8;
            this.C2.Name = "C2";
            this.C2.ReadOnly = true;
            this.C2.Width = 150;
            // 
            // C3
            // 
            this.C3.DataPropertyName = "shop";
            this.C3.HeaderText = "店名";
            this.C3.MinimumWidth = 8;
            this.C3.Name = "C3";
            this.C3.ReadOnly = true;
            this.C3.Width = 150;
            // 
            // C4
            // 
            this.C4.DataPropertyName = "address";
            this.C4.HeaderText = "地址";
            this.C4.MinimumWidth = 8;
            this.C4.Name = "C4";
            this.C4.ReadOnly = true;
            this.C4.Width = 150;
            // 
            // C5
            // 
            this.C5.DataPropertyName = "telephone";
            this.C5.HeaderText = "電話";
            this.C5.MinimumWidth = 8;
            this.C5.Name = "C5";
            this.C5.ReadOnly = true;
            this.C5.Width = 150;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1284, 613);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn C1;
        private System.Windows.Forms.DataGridViewTextBoxColumn C2;
        private System.Windows.Forms.DataGridViewTextBoxColumn C3;
        private System.Windows.Forms.DataGridViewTextBoxColumn C4;
        private System.Windows.Forms.DataGridViewTextBoxColumn C5;
    }
}

