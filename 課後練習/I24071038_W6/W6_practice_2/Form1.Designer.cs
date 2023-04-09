namespace W6_practice_2
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
            this.pictureBox_meme = new System.Windows.Forms.PictureBox();
            this.groupBox_Font = new System.Windows.Forms.GroupBox();
            this.radioButton_font_ms = new System.Windows.Forms.RadioButton();
            this.radioButton_font_new = new System.Windows.Forms.RadioButton();
            this.radioButton_font_std = new System.Windows.Forms.RadioButton();
            this.groupBox_position = new System.Windows.Forms.GroupBox();
            this.radioButton_position_DR = new System.Windows.Forms.RadioButton();
            this.radioButton_position_DM = new System.Windows.Forms.RadioButton();
            this.radioButton_position_UM = new System.Windows.Forms.RadioButton();
            this.radioButton_position_DL = new System.Windows.Forms.RadioButton();
            this.radioButton_position_UR = new System.Windows.Forms.RadioButton();
            this.radioButton_position_UL = new System.Windows.Forms.RadioButton();
            this.checkBox_bold = new System.Windows.Forms.CheckBox();
            this.checkBox_italic = new System.Windows.Forms.CheckBox();
            this.label_font_size = new System.Windows.Forms.Label();
            this.textBox_font_size = new System.Windows.Forms.TextBox();
            this.button_last_page = new System.Windows.Forms.Button();
            this.button_next_page = new System.Windows.Forms.Button();
            this.textBox_enter_text = new System.Windows.Forms.TextBox();
            this.label_enter_text = new System.Windows.Forms.Label();
            this.label_view = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_meme)).BeginInit();
            this.groupBox_Font.SuspendLayout();
            this.groupBox_position.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox_meme
            // 
            this.pictureBox_meme.Location = new System.Drawing.Point(62, 89);
            this.pictureBox_meme.Name = "pictureBox_meme";
            this.pictureBox_meme.Size = new System.Drawing.Size(331, 307);
            this.pictureBox_meme.TabIndex = 0;
            this.pictureBox_meme.TabStop = false;
            // 
            // groupBox_Font
            // 
            this.groupBox_Font.Controls.Add(this.radioButton_font_ms);
            this.groupBox_Font.Controls.Add(this.radioButton_font_new);
            this.groupBox_Font.Controls.Add(this.radioButton_font_std);
            this.groupBox_Font.Location = new System.Drawing.Point(457, 59);
            this.groupBox_Font.Name = "groupBox_Font";
            this.groupBox_Font.Size = new System.Drawing.Size(282, 88);
            this.groupBox_Font.TabIndex = 1;
            this.groupBox_Font.TabStop = false;
            this.groupBox_Font.Text = "字體";
            // 
            // radioButton_font_ms
            // 
            this.radioButton_font_ms.AutoSize = true;
            this.radioButton_font_ms.Location = new System.Drawing.Point(16, 58);
            this.radioButton_font_ms.Name = "radioButton_font_ms";
            this.radioButton_font_ms.Size = new System.Drawing.Size(123, 22);
            this.radioButton_font_ms.TabIndex = 0;
            this.radioButton_font_ms.TabStop = true;
            this.radioButton_font_ms.Text = "微軟正黑體";
            this.radioButton_font_ms.UseVisualStyleBackColor = true;
            this.radioButton_font_ms.CheckedChanged += new System.EventHandler(this.radioButton_font_ms_CheckedChanged);
            // 
            // radioButton_font_new
            // 
            this.radioButton_font_new.AutoSize = true;
            this.radioButton_font_new.Location = new System.Drawing.Point(124, 30);
            this.radioButton_font_new.Name = "radioButton_font_new";
            this.radioButton_font_new.Size = new System.Drawing.Size(105, 22);
            this.radioButton_font_new.TabIndex = 0;
            this.radioButton_font_new.TabStop = true;
            this.radioButton_font_new.Text = "新細明體";
            this.radioButton_font_new.UseVisualStyleBackColor = true;
            this.radioButton_font_new.CheckedChanged += new System.EventHandler(this.radioButton_font_new_CheckedChanged);
            // 
            // radioButton_font_std
            // 
            this.radioButton_font_std.AutoSize = true;
            this.radioButton_font_std.Location = new System.Drawing.Point(16, 28);
            this.radioButton_font_std.Name = "radioButton_font_std";
            this.radioButton_font_std.Size = new System.Drawing.Size(87, 22);
            this.radioButton_font_std.TabIndex = 0;
            this.radioButton_font_std.TabStop = true;
            this.radioButton_font_std.Text = "標楷體";
            this.radioButton_font_std.UseVisualStyleBackColor = true;
            this.radioButton_font_std.CheckedChanged += new System.EventHandler(this.radioButton_font_std_CheckedChanged);
            // 
            // groupBox_position
            // 
            this.groupBox_position.Controls.Add(this.radioButton_position_DR);
            this.groupBox_position.Controls.Add(this.radioButton_position_DM);
            this.groupBox_position.Controls.Add(this.radioButton_position_UM);
            this.groupBox_position.Controls.Add(this.radioButton_position_DL);
            this.groupBox_position.Controls.Add(this.radioButton_position_UR);
            this.groupBox_position.Controls.Add(this.radioButton_position_UL);
            this.groupBox_position.Location = new System.Drawing.Point(457, 203);
            this.groupBox_position.Name = "groupBox_position";
            this.groupBox_position.Size = new System.Drawing.Size(297, 110);
            this.groupBox_position.TabIndex = 1;
            this.groupBox_position.TabStop = false;
            this.groupBox_position.Text = "位置";
            // 
            // radioButton_position_DR
            // 
            this.radioButton_position_DR.AutoSize = true;
            this.radioButton_position_DR.Location = new System.Drawing.Point(198, 75);
            this.radioButton_position_DR.Name = "radioButton_position_DR";
            this.radioButton_position_DR.Size = new System.Drawing.Size(69, 22);
            this.radioButton_position_DR.TabIndex = 1;
            this.radioButton_position_DR.TabStop = true;
            this.radioButton_position_DR.Text = "下右";
            this.radioButton_position_DR.UseVisualStyleBackColor = true;
            this.radioButton_position_DR.CheckedChanged += new System.EventHandler(this.radioButton_position_DR_CheckedChanged);
            // 
            // radioButton_position_DM
            // 
            this.radioButton_position_DM.AutoSize = true;
            this.radioButton_position_DM.Location = new System.Drawing.Point(113, 75);
            this.radioButton_position_DM.Name = "radioButton_position_DM";
            this.radioButton_position_DM.Size = new System.Drawing.Size(69, 22);
            this.radioButton_position_DM.TabIndex = 2;
            this.radioButton_position_DM.TabStop = true;
            this.radioButton_position_DM.Text = "下中";
            this.radioButton_position_DM.UseVisualStyleBackColor = true;
            this.radioButton_position_DM.CheckedChanged += new System.EventHandler(this.radioButton_position_DM_CheckedChanged);
            // 
            // radioButton_position_UM
            // 
            this.radioButton_position_UM.AutoSize = true;
            this.radioButton_position_UM.Location = new System.Drawing.Point(113, 34);
            this.radioButton_position_UM.Name = "radioButton_position_UM";
            this.radioButton_position_UM.Size = new System.Drawing.Size(69, 22);
            this.radioButton_position_UM.TabIndex = 3;
            this.radioButton_position_UM.TabStop = true;
            this.radioButton_position_UM.Text = "上中";
            this.radioButton_position_UM.UseVisualStyleBackColor = true;
            this.radioButton_position_UM.CheckedChanged += new System.EventHandler(this.radioButton_position_UM_CheckedChanged);
            // 
            // radioButton_position_DL
            // 
            this.radioButton_position_DL.AutoSize = true;
            this.radioButton_position_DL.Location = new System.Drawing.Point(16, 75);
            this.radioButton_position_DL.Name = "radioButton_position_DL";
            this.radioButton_position_DL.Size = new System.Drawing.Size(69, 22);
            this.radioButton_position_DL.TabIndex = 0;
            this.radioButton_position_DL.TabStop = true;
            this.radioButton_position_DL.Text = "下左";
            this.radioButton_position_DL.UseVisualStyleBackColor = true;
            this.radioButton_position_DL.CheckedChanged += new System.EventHandler(this.radioButton_position_DL_CheckedChanged);
            // 
            // radioButton_position_UR
            // 
            this.radioButton_position_UR.AutoSize = true;
            this.radioButton_position_UR.Location = new System.Drawing.Point(198, 34);
            this.radioButton_position_UR.Name = "radioButton_position_UR";
            this.radioButton_position_UR.Size = new System.Drawing.Size(69, 22);
            this.radioButton_position_UR.TabIndex = 0;
            this.radioButton_position_UR.TabStop = true;
            this.radioButton_position_UR.Text = "上右";
            this.radioButton_position_UR.UseVisualStyleBackColor = true;
            this.radioButton_position_UR.CheckedChanged += new System.EventHandler(this.radioButton_position_UR_CheckedChanged);
            // 
            // radioButton_position_UL
            // 
            this.radioButton_position_UL.AutoSize = true;
            this.radioButton_position_UL.Location = new System.Drawing.Point(19, 34);
            this.radioButton_position_UL.Name = "radioButton_position_UL";
            this.radioButton_position_UL.Size = new System.Drawing.Size(69, 22);
            this.radioButton_position_UL.TabIndex = 0;
            this.radioButton_position_UL.TabStop = true;
            this.radioButton_position_UL.Text = "上左";
            this.radioButton_position_UL.UseVisualStyleBackColor = true;
            this.radioButton_position_UL.CheckedChanged += new System.EventHandler(this.radioButton_position_UL_CheckedChanged);
            // 
            // checkBox_bold
            // 
            this.checkBox_bold.AutoSize = true;
            this.checkBox_bold.Location = new System.Drawing.Point(476, 165);
            this.checkBox_bold.Name = "checkBox_bold";
            this.checkBox_bold.Size = new System.Drawing.Size(70, 22);
            this.checkBox_bold.TabIndex = 2;
            this.checkBox_bold.Text = "粗體";
            this.checkBox_bold.UseVisualStyleBackColor = true;
            this.checkBox_bold.CheckedChanged += new System.EventHandler(this.checkBox_bold_CheckedChanged);
            // 
            // checkBox_italic
            // 
            this.checkBox_italic.AutoSize = true;
            this.checkBox_italic.Location = new System.Drawing.Point(581, 165);
            this.checkBox_italic.Name = "checkBox_italic";
            this.checkBox_italic.Size = new System.Drawing.Size(70, 22);
            this.checkBox_italic.TabIndex = 2;
            this.checkBox_italic.Text = "斜體";
            this.checkBox_italic.UseVisualStyleBackColor = true;
            this.checkBox_italic.CheckedChanged += new System.EventHandler(this.checkBox_italic_CheckedChanged);
            // 
            // label_font_size
            // 
            this.label_font_size.AutoSize = true;
            this.label_font_size.Location = new System.Drawing.Point(500, 340);
            this.label_font_size.Name = "label_font_size";
            this.label_font_size.Size = new System.Drawing.Size(80, 18);
            this.label_font_size.TabIndex = 3;
            this.label_font_size.Text = "字體大小";
            // 
            // textBox_font_size
            // 
            this.textBox_font_size.Location = new System.Drawing.Point(586, 337);
            this.textBox_font_size.Name = "textBox_font_size";
            this.textBox_font_size.Size = new System.Drawing.Size(100, 29);
            this.textBox_font_size.TabIndex = 4;
            this.textBox_font_size.TextChanged += new System.EventHandler(this.textBox_font_size_TextChanged);
            // 
            // button_last_page
            // 
            this.button_last_page.Location = new System.Drawing.Point(52, 480);
            this.button_last_page.Name = "button_last_page";
            this.button_last_page.Size = new System.Drawing.Size(75, 23);
            this.button_last_page.TabIndex = 5;
            this.button_last_page.Text = "前一張";
            this.button_last_page.UseVisualStyleBackColor = true;
            this.button_last_page.Click += new System.EventHandler(this.button_last_page_Click);
            // 
            // button_next_page
            // 
            this.button_next_page.Location = new System.Drawing.Point(308, 480);
            this.button_next_page.Name = "button_next_page";
            this.button_next_page.Size = new System.Drawing.Size(75, 23);
            this.button_next_page.TabIndex = 5;
            this.button_next_page.Text = "下一張";
            this.button_next_page.UseVisualStyleBackColor = true;
            this.button_next_page.Click += new System.EventHandler(this.button_next_page_Click);
            // 
            // textBox_enter_text
            // 
            this.textBox_enter_text.Location = new System.Drawing.Point(457, 422);
            this.textBox_enter_text.Multiline = true;
            this.textBox_enter_text.Name = "textBox_enter_text";
            this.textBox_enter_text.Size = new System.Drawing.Size(297, 91);
            this.textBox_enter_text.TabIndex = 4;
            this.textBox_enter_text.TextChanged += new System.EventHandler(this.textBox_enter_text_TextChanged);
            // 
            // label_enter_text
            // 
            this.label_enter_text.AutoSize = true;
            this.label_enter_text.Location = new System.Drawing.Point(583, 392);
            this.label_enter_text.Name = "label_enter_text";
            this.label_enter_text.Size = new System.Drawing.Size(44, 18);
            this.label_enter_text.TabIndex = 3;
            this.label_enter_text.Text = "文字";
            // 
            // label_view
            // 
            this.label_view.Location = new System.Drawing.Point(12, 20);
            this.label_view.Name = "label_view";
            this.label_view.Size = new System.Drawing.Size(429, 442);
            this.label_view.TabIndex = 3;
            this.label_view.Text = "文字呈現";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 543);
            this.Controls.Add(this.button_next_page);
            this.Controls.Add(this.button_last_page);
            this.Controls.Add(this.textBox_enter_text);
            this.Controls.Add(this.textBox_font_size);
            this.Controls.Add(this.label_enter_text);
            this.Controls.Add(this.label_font_size);
            this.Controls.Add(this.checkBox_italic);
            this.Controls.Add(this.groupBox_position);
            this.Controls.Add(this.checkBox_bold);
            this.Controls.Add(this.groupBox_Font);
            this.Controls.Add(this.pictureBox_meme);
            this.Controls.Add(this.label_view);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_meme)).EndInit();
            this.groupBox_Font.ResumeLayout(false);
            this.groupBox_Font.PerformLayout();
            this.groupBox_position.ResumeLayout(false);
            this.groupBox_position.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox_meme;
        private System.Windows.Forms.GroupBox groupBox_Font;
        private System.Windows.Forms.RadioButton radioButton_font_std;
        private System.Windows.Forms.RadioButton radioButton_font_ms;
        private System.Windows.Forms.RadioButton radioButton_font_new;
        private System.Windows.Forms.GroupBox groupBox_position;
        private System.Windows.Forms.RadioButton radioButton_position_DR;
        private System.Windows.Forms.RadioButton radioButton_position_DM;
        private System.Windows.Forms.RadioButton radioButton_position_UM;
        private System.Windows.Forms.RadioButton radioButton_position_DL;
        private System.Windows.Forms.RadioButton radioButton_position_UR;
        private System.Windows.Forms.RadioButton radioButton_position_UL;
        private System.Windows.Forms.CheckBox checkBox_bold;
        private System.Windows.Forms.CheckBox checkBox_italic;
        private System.Windows.Forms.Label label_font_size;
        private System.Windows.Forms.TextBox textBox_font_size;
        private System.Windows.Forms.Button button_last_page;
        private System.Windows.Forms.Button button_next_page;
        private System.Windows.Forms.TextBox textBox_enter_text;
        private System.Windows.Forms.Label label_enter_text;
        private System.Windows.Forms.Label label_view;
    }
}

