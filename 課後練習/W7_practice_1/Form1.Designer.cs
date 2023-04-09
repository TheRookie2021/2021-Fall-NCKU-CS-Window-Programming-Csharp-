namespace W7_practice_1
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
            this.components = new System.ComponentModel.Container();
            this.label_cur_score = new System.Windows.Forms.Label();
            this.label_cur_num = new System.Windows.Forms.Label();
            this.button_mode_easy = new System.Windows.Forms.Button();
            this.button_mode_hard = new System.Windows.Forms.Button();
            this.label_timer = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // label_cur_score
            // 
            this.label_cur_score.AutoSize = true;
            this.label_cur_score.Location = new System.Drawing.Point(685, 62);
            this.label_cur_score.Name = "label_cur_score";
            this.label_cur_score.Size = new System.Drawing.Size(85, 18);
            this.label_cur_score.TabIndex = 0;
            this.label_cur_score.Text = "你的分數:";
            this.label_cur_score.Visible = false;
            // 
            // label_cur_num
            // 
            this.label_cur_num.AutoSize = true;
            this.label_cur_num.Location = new System.Drawing.Point(685, 104);
            this.label_cur_num.Name = "label_cur_num";
            this.label_cur_num.Size = new System.Drawing.Size(85, 18);
            this.label_cur_num.TabIndex = 1;
            this.label_cur_num.Text = "當前數字:";
            this.label_cur_num.Visible = false;
            // 
            // button_mode_easy
            // 
            this.button_mode_easy.Location = new System.Drawing.Point(349, 174);
            this.button_mode_easy.Name = "button_mode_easy";
            this.button_mode_easy.Size = new System.Drawing.Size(131, 33);
            this.button_mode_easy.TabIndex = 0;
            this.button_mode_easy.Text = "簡單模式";
            this.button_mode_easy.UseVisualStyleBackColor = true;
            this.button_mode_easy.Click += new System.EventHandler(this.button_mode_easy_Click);
            // 
            // button_mode_hard
            // 
            this.button_mode_hard.Location = new System.Drawing.Point(349, 221);
            this.button_mode_hard.Name = "button_mode_hard";
            this.button_mode_hard.Size = new System.Drawing.Size(131, 33);
            this.button_mode_hard.TabIndex = 1;
            this.button_mode_hard.Text = "普通模式";
            this.button_mode_hard.UseVisualStyleBackColor = true;
            this.button_mode_hard.Click += new System.EventHandler(this.button_mode_hard_Click);
            // 
            // label_timer
            // 
            this.label_timer.AutoSize = true;
            this.label_timer.Location = new System.Drawing.Point(685, 142);
            this.label_timer.Name = "label_timer";
            this.label_timer.Size = new System.Drawing.Size(49, 18);
            this.label_timer.TabIndex = 1;
            this.label_timer.Text = "時間:";
            this.label_timer.Visible = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 509);
            this.Controls.Add(this.button_mode_hard);
            this.Controls.Add(this.button_mode_easy);
            this.Controls.Add(this.label_timer);
            this.Controls.Add(this.label_cur_num);
            this.Controls.Add(this.label_cur_score);
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_cur_score;
        private System.Windows.Forms.Label label_cur_num;
        private System.Windows.Forms.Button button_mode_easy;
        private System.Windows.Forms.Button button_mode_hard;
        private System.Windows.Forms.Label label_timer;
        private System.Windows.Forms.Timer timer1;
    }
}

