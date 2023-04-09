namespace W6_practice_1
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
            this.textBox_height = new System.Windows.Forms.TextBox();
            this.textBox_width = new System.Windows.Forms.TextBox();
            this.textBox_enter_num = new System.Windows.Forms.TextBox();
            this.label_height = new System.Windows.Forms.Label();
            this.label_width = new System.Windows.Forms.Label();
            this.label_enter_num = new System.Windows.Forms.Label();
            this.button_ok = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox_height
            // 
            this.textBox_height.Location = new System.Drawing.Point(133, 75);
            this.textBox_height.Name = "textBox_height";
            this.textBox_height.Size = new System.Drawing.Size(100, 29);
            this.textBox_height.TabIndex = 0;
            this.textBox_height.TextChanged += new System.EventHandler(this.textBox_height_TextChanged);
            // 
            // textBox_width
            // 
            this.textBox_width.Location = new System.Drawing.Point(133, 138);
            this.textBox_width.Name = "textBox_width";
            this.textBox_width.Size = new System.Drawing.Size(100, 29);
            this.textBox_width.TabIndex = 1;
            this.textBox_width.TextChanged += new System.EventHandler(this.textBox_width_TextChanged);
            // 
            // textBox_enter_num
            // 
            this.textBox_enter_num.Location = new System.Drawing.Point(56, 344);
            this.textBox_enter_num.Name = "textBox_enter_num";
            this.textBox_enter_num.Size = new System.Drawing.Size(217, 29);
            this.textBox_enter_num.TabIndex = 4;
            this.textBox_enter_num.TextChanged += new System.EventHandler(this.textBox_enter_num_TextChanged);
            // 
            // label_height
            // 
            this.label_height.AutoSize = true;
            this.label_height.Location = new System.Drawing.Point(61, 81);
            this.label_height.Name = "label_height";
            this.label_height.Size = new System.Drawing.Size(26, 18);
            this.label_height.TabIndex = 1;
            this.label_height.Text = "高";
            // 
            // label_width
            // 
            this.label_width.AutoSize = true;
            this.label_width.Location = new System.Drawing.Point(61, 141);
            this.label_width.Name = "label_width";
            this.label_width.Size = new System.Drawing.Size(26, 18);
            this.label_width.TabIndex = 1;
            this.label_width.Text = "寬";
            // 
            // label_enter_num
            // 
            this.label_enter_num.AutoSize = true;
            this.label_enter_num.Location = new System.Drawing.Point(61, 308);
            this.label_enter_num.Name = "label_enter_num";
            this.label_enter_num.Size = new System.Drawing.Size(149, 18);
            this.label_enter_num.TabIndex = 1;
            this.label_enter_num.Text = "請輸入數字(-9~99)";
            // 
            // button_ok
            // 
            this.button_ok.Location = new System.Drawing.Point(133, 227);
            this.button_ok.Name = "button_ok";
            this.button_ok.Size = new System.Drawing.Size(100, 31);
            this.button_ok.TabIndex = 3;
            this.button_ok.Text = "確定";
            this.button_ok.UseVisualStyleBackColor = true;
            this.button_ok.Click += new System.EventHandler(this.button_ok_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_ok);
            this.Controls.Add(this.label_enter_num);
            this.Controls.Add(this.label_width);
            this.Controls.Add(this.label_height);
            this.Controls.Add(this.textBox_enter_num);
            this.Controls.Add(this.textBox_width);
            this.Controls.Add(this.textBox_height);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_height;
        private System.Windows.Forms.TextBox textBox_width;
        private System.Windows.Forms.TextBox textBox_enter_num;
        private System.Windows.Forms.Label label_height;
        private System.Windows.Forms.Label label_width;
        private System.Windows.Forms.Label label_enter_num;
        private System.Windows.Forms.Button button_ok;
    }
}

