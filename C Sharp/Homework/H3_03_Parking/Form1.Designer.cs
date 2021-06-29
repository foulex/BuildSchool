namespace H3_03_Parking
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
            this.dateTimePicker_Enter = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker_Leave = new System.Windows.Forms.DateTimePicker();
            this.label_Enter = new System.Windows.Forms.Label();
            this.label_Leave = new System.Windows.Forms.Label();
            this.label_Price = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dateTimePicker_Enter
            // 
            this.dateTimePicker_Enter.CustomFormat = "yyyy/MM/dd HH:mm";
            this.dateTimePicker_Enter.Font = new System.Drawing.Font("Elephant", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker_Enter.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker_Enter.Location = new System.Drawing.Point(144, 13);
            this.dateTimePicker_Enter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePicker_Enter.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker_Enter.Name = "dateTimePicker_Enter";
            this.dateTimePicker_Enter.ShowUpDown = true;
            this.dateTimePicker_Enter.Size = new System.Drawing.Size(243, 29);
            this.dateTimePicker_Enter.TabIndex = 0;
            // 
            // dateTimePicker_Leave
            // 
            this.dateTimePicker_Leave.CustomFormat = "yyyy/MM/dd HH:mm";
            this.dateTimePicker_Leave.Font = new System.Drawing.Font("Elephant", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker_Leave.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker_Leave.Location = new System.Drawing.Point(144, 55);
            this.dateTimePicker_Leave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePicker_Leave.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker_Leave.Name = "dateTimePicker_Leave";
            this.dateTimePicker_Leave.ShowUpDown = true;
            this.dateTimePicker_Leave.Size = new System.Drawing.Size(243, 29);
            this.dateTimePicker_Leave.TabIndex = 1;
            // 
            // label_Enter
            // 
            this.label_Enter.AutoSize = true;
            this.label_Enter.Font = new System.Drawing.Font("源樣黑體 TTF Regular", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label_Enter.Location = new System.Drawing.Point(11, 13);
            this.label_Enter.Name = "label_Enter";
            this.label_Enter.Size = new System.Drawing.Size(127, 33);
            this.label_Enter.TabIndex = 2;
            this.label_Enter.Text = "進場時間";
            // 
            // label_Leave
            // 
            this.label_Leave.AutoSize = true;
            this.label_Leave.Font = new System.Drawing.Font("源樣黑體 TTF Regular", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label_Leave.Location = new System.Drawing.Point(11, 55);
            this.label_Leave.Name = "label_Leave";
            this.label_Leave.Size = new System.Drawing.Size(127, 33);
            this.label_Leave.TabIndex = 2;
            this.label_Leave.Text = "出場時間";
            // 
            // label_Price
            // 
            this.label_Price.AutoSize = true;
            this.label_Price.Font = new System.Drawing.Font("源樣黑體 TTF Regular", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label_Price.Location = new System.Drawing.Point(393, 55);
            this.label_Price.Name = "label_Price";
            this.label_Price.Size = new System.Drawing.Size(99, 33);
            this.label_Price.TabIndex = 2;
            this.label_Price.Text = "價格：";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(398, 13);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(83, 24);
            this.button1.TabIndex = 3;
            this.button1.Text = "計算";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 94);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label_Price);
            this.Controls.Add(this.label_Leave);
            this.Controls.Add(this.label_Enter);
            this.Controls.Add(this.dateTimePicker_Leave);
            this.Controls.Add(this.dateTimePicker_Enter);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "停車場價錢計算";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker_Enter;
        private System.Windows.Forms.DateTimePicker dateTimePicker_Leave;
        private System.Windows.Forms.Label label_Enter;
        private System.Windows.Forms.Label label_Leave;
        private System.Windows.Forms.Label label_Price;
        private System.Windows.Forms.Button button1;
    }
}

