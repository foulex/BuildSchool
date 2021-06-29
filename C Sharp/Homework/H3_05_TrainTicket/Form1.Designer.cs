namespace H3_05_TrainTicket
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
            this.radioButton_NS = new System.Windows.Forms.RadioButton();
            this.radioButton_SN = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox_NS = new System.Windows.Forms.ComboBox();
            this.comboBox_SN = new System.Windows.Forms.ComboBox();
            this.checkBox_Return = new System.Windows.Forms.CheckBox();
            this.checkBox_Discount = new System.Windows.Forms.CheckBox();
            this.button_Cal = new System.Windows.Forms.Button();
            this.label_Price = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // radioButton_NS
            // 
            this.radioButton_NS.AutoSize = true;
            this.radioButton_NS.Location = new System.Drawing.Point(12, 12);
            this.radioButton_NS.Name = "radioButton_NS";
            this.radioButton_NS.Size = new System.Drawing.Size(58, 19);
            this.radioButton_NS.TabIndex = 0;
            this.radioButton_NS.TabStop = true;
            this.radioButton_NS.Text = "南下";
            this.radioButton_NS.UseVisualStyleBackColor = true;
            this.radioButton_NS.CheckedChanged += new System.EventHandler(this.radioButton_NS_CheckedChanged);
            // 
            // radioButton_SN
            // 
            this.radioButton_SN.AutoSize = true;
            this.radioButton_SN.Location = new System.Drawing.Point(9, 57);
            this.radioButton_SN.Name = "radioButton_SN";
            this.radioButton_SN.Size = new System.Drawing.Size(58, 19);
            this.radioButton_SN.TabIndex = 0;
            this.radioButton_SN.TabStop = true;
            this.radioButton_SN.Text = "北上";
            this.radioButton_SN.UseVisualStyleBackColor = true;
            this.radioButton_SN.CheckedChanged += new System.EventHandler(this.radioButton_SN_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(76, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "起站";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(73, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "迄站";
            // 
            // comboBox_NS
            // 
            this.comboBox_NS.FormattingEnabled = true;
            this.comboBox_NS.Location = new System.Drawing.Point(76, 31);
            this.comboBox_NS.Name = "comboBox_NS";
            this.comboBox_NS.Size = new System.Drawing.Size(121, 23);
            this.comboBox_NS.TabIndex = 2;
            // 
            // comboBox_SN
            // 
            this.comboBox_SN.FormattingEnabled = true;
            this.comboBox_SN.Location = new System.Drawing.Point(76, 75);
            this.comboBox_SN.Name = "comboBox_SN";
            this.comboBox_SN.Size = new System.Drawing.Size(121, 23);
            this.comboBox_SN.TabIndex = 2;
            // 
            // checkBox_Return
            // 
            this.checkBox_Return.AutoSize = true;
            this.checkBox_Return.Location = new System.Drawing.Point(216, 9);
            this.checkBox_Return.Name = "checkBox_Return";
            this.checkBox_Return.Size = new System.Drawing.Size(74, 19);
            this.checkBox_Return.TabIndex = 3;
            this.checkBox_Return.Text = "來回票";
            this.checkBox_Return.UseVisualStyleBackColor = true;
            // 
            // checkBox_Discount
            // 
            this.checkBox_Discount.AutoSize = true;
            this.checkBox_Discount.Location = new System.Drawing.Point(216, 33);
            this.checkBox_Discount.Name = "checkBox_Discount";
            this.checkBox_Discount.Size = new System.Drawing.Size(74, 19);
            this.checkBox_Discount.TabIndex = 3;
            this.checkBox_Discount.Text = "優惠票";
            this.checkBox_Discount.UseVisualStyleBackColor = true;
            // 
            // button_Cal
            // 
            this.button_Cal.Location = new System.Drawing.Point(215, 58);
            this.button_Cal.Name = "button_Cal";
            this.button_Cal.Size = new System.Drawing.Size(75, 23);
            this.button_Cal.TabIndex = 4;
            this.button_Cal.Text = "計算";
            this.button_Cal.UseVisualStyleBackColor = true;
            // 
            // label_Price
            // 
            this.label_Price.AutoSize = true;
            this.label_Price.Location = new System.Drawing.Point(213, 84);
            this.label_Price.Name = "label_Price";
            this.label_Price.Size = new System.Drawing.Size(37, 15);
            this.label_Price.TabIndex = 1;
            this.label_Price.Text = "票價";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(325, 116);
            this.Controls.Add(this.button_Cal);
            this.Controls.Add(this.checkBox_Discount);
            this.Controls.Add(this.checkBox_Return);
            this.Controls.Add(this.comboBox_SN);
            this.Controls.Add(this.comboBox_NS);
            this.Controls.Add(this.label_Price);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.radioButton_SN);
            this.Controls.Add(this.radioButton_NS);
            this.Name = "Form1";
            this.Text = "高鐵票價";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioButton_NS;
        private System.Windows.Forms.RadioButton radioButton_SN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox_NS;
        private System.Windows.Forms.ComboBox comboBox_SN;
        private System.Windows.Forms.CheckBox checkBox_Return;
        private System.Windows.Forms.CheckBox checkBox_Discount;
        private System.Windows.Forms.Button button_Cal;
        private System.Windows.Forms.Label label_Price;
    }
}

