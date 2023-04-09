namespace W5_practice_2
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
            this.label_title_money = new System.Windows.Forms.Label();
            this.label_title_status = new System.Windows.Forms.Label();
            this.textBox_display = new System.Windows.Forms.TextBox();
            this.label_title_event = new System.Windows.Forms.Label();
            this.label_para_money = new System.Windows.Forms.Label();
            this.label_status_health = new System.Windows.Forms.Label();
            this.label_status_weight = new System.Windows.Forms.Label();
            this.label_status_hunger = new System.Windows.Forms.Label();
            this.label_status_mood = new System.Windows.Forms.Label();
            this.label_para_event = new System.Windows.Forms.Label();
            this.label_para_health = new System.Windows.Forms.Label();
            this.label_para_weight = new System.Windows.Forms.Label();
            this.label_para_hunger = new System.Windows.Forms.Label();
            this.label_para_mood = new System.Windows.Forms.Label();
            this.button_feed = new System.Windows.Forms.Button();
            this.button_play = new System.Windows.Forms.Button();
            this.button_clean = new System.Windows.Forms.Button();
            this.button_doctor = new System.Windows.Forms.Button();
            this.button_end_day = new System.Windows.Forms.Button();
            this.button_name = new System.Windows.Forms.Button();
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label_title_money
            // 
            this.label_title_money.AutoSize = true;
            this.label_title_money.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label_title_money.Location = new System.Drawing.Point(515, 52);
            this.label_title_money.Name = "label_title_money";
            this.label_title_money.Size = new System.Drawing.Size(71, 35);
            this.label_title_money.TabIndex = 0;
            this.label_title_money.Text = "金錢";
            // 
            // label_title_status
            // 
            this.label_title_status.AutoSize = true;
            this.label_title_status.Font = new System.Drawing.Font("微軟正黑體", 14F);
            this.label_title_status.Location = new System.Drawing.Point(517, 145);
            this.label_title_status.Name = "label_title_status";
            this.label_title_status.Size = new System.Drawing.Size(71, 35);
            this.label_title_status.TabIndex = 0;
            this.label_title_status.Text = "狀態";
            // 
            // textBox_display
            // 
            this.textBox_display.Location = new System.Drawing.Point(79, 49);
            this.textBox_display.Multiline = true;
            this.textBox_display.Name = "textBox_display";
            this.textBox_display.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_display.Size = new System.Drawing.Size(410, 370);
            this.textBox_display.TabIndex = 1;
            // 
            // label_title_event
            // 
            this.label_title_event.AutoSize = true;
            this.label_title_event.Font = new System.Drawing.Font("微軟正黑體", 14F);
            this.label_title_event.Location = new System.Drawing.Point(517, 289);
            this.label_title_event.Name = "label_title_event";
            this.label_title_event.Size = new System.Drawing.Size(71, 35);
            this.label_title_event.TabIndex = 0;
            this.label_title_event.Text = "事件";
            // 
            // label_para_money
            // 
            this.label_para_money.AutoSize = true;
            this.label_para_money.Location = new System.Drawing.Point(545, 104);
            this.label_para_money.Name = "label_para_money";
            this.label_para_money.Size = new System.Drawing.Size(0, 18);
            this.label_para_money.TabIndex = 0;
            // 
            // label_status_health
            // 
            this.label_status_health.AutoSize = true;
            this.label_status_health.Location = new System.Drawing.Point(545, 189);
            this.label_status_health.Name = "label_status_health";
            this.label_status_health.Size = new System.Drawing.Size(44, 18);
            this.label_status_health.TabIndex = 0;
            this.label_status_health.Text = "健康";
            // 
            // label_status_weight
            // 
            this.label_status_weight.AutoSize = true;
            this.label_status_weight.Location = new System.Drawing.Point(545, 211);
            this.label_status_weight.Name = "label_status_weight";
            this.label_status_weight.Size = new System.Drawing.Size(44, 18);
            this.label_status_weight.TabIndex = 0;
            this.label_status_weight.Text = "體重";
            // 
            // label_status_hunger
            // 
            this.label_status_hunger.AutoSize = true;
            this.label_status_hunger.Location = new System.Drawing.Point(545, 233);
            this.label_status_hunger.Name = "label_status_hunger";
            this.label_status_hunger.Size = new System.Drawing.Size(62, 18);
            this.label_status_hunger.TabIndex = 0;
            this.label_status_hunger.Text = "飽足感";
            // 
            // label_status_mood
            // 
            this.label_status_mood.AutoSize = true;
            this.label_status_mood.Location = new System.Drawing.Point(545, 255);
            this.label_status_mood.Name = "label_status_mood";
            this.label_status_mood.Size = new System.Drawing.Size(44, 18);
            this.label_status_mood.TabIndex = 0;
            this.label_status_mood.Text = "心情";
            // 
            // label_para_event
            // 
            this.label_para_event.AutoSize = true;
            this.label_para_event.Location = new System.Drawing.Point(545, 341);
            this.label_para_event.Name = "label_para_event";
            this.label_para_event.Size = new System.Drawing.Size(0, 18);
            this.label_para_event.TabIndex = 0;
            // 
            // label_para_health
            // 
            this.label_para_health.AutoSize = true;
            this.label_para_health.Location = new System.Drawing.Point(660, 189);
            this.label_para_health.Name = "label_para_health";
            this.label_para_health.Size = new System.Drawing.Size(0, 18);
            this.label_para_health.TabIndex = 0;
            // 
            // label_para_weight
            // 
            this.label_para_weight.AutoSize = true;
            this.label_para_weight.Location = new System.Drawing.Point(660, 207);
            this.label_para_weight.Name = "label_para_weight";
            this.label_para_weight.Size = new System.Drawing.Size(0, 18);
            this.label_para_weight.TabIndex = 0;
            // 
            // label_para_hunger
            // 
            this.label_para_hunger.AutoSize = true;
            this.label_para_hunger.Location = new System.Drawing.Point(660, 225);
            this.label_para_hunger.Name = "label_para_hunger";
            this.label_para_hunger.Size = new System.Drawing.Size(0, 18);
            this.label_para_hunger.TabIndex = 0;
            // 
            // label_para_mood
            // 
            this.label_para_mood.AutoSize = true;
            this.label_para_mood.Location = new System.Drawing.Point(660, 243);
            this.label_para_mood.Name = "label_para_mood";
            this.label_para_mood.Size = new System.Drawing.Size(0, 18);
            this.label_para_mood.TabIndex = 0;
            // 
            // button_feed
            // 
            this.button_feed.Location = new System.Drawing.Point(518, 388);
            this.button_feed.Name = "button_feed";
            this.button_feed.Size = new System.Drawing.Size(77, 31);
            this.button_feed.TabIndex = 2;
            this.button_feed.Text = "餵食";
            this.button_feed.UseVisualStyleBackColor = true;
            this.button_feed.Click += new System.EventHandler(this.button_feed_Click);
            // 
            // button_play
            // 
            this.button_play.Location = new System.Drawing.Point(599, 388);
            this.button_play.Name = "button_play";
            this.button_play.Size = new System.Drawing.Size(77, 31);
            this.button_play.TabIndex = 2;
            this.button_play.Text = "玩耍";
            this.button_play.UseVisualStyleBackColor = true;
            this.button_play.Click += new System.EventHandler(this.button_play_Click);
            // 
            // button_clean
            // 
            this.button_clean.Location = new System.Drawing.Point(680, 388);
            this.button_clean.Name = "button_clean";
            this.button_clean.Size = new System.Drawing.Size(77, 31);
            this.button_clean.TabIndex = 2;
            this.button_clean.Text = "打掃";
            this.button_clean.UseVisualStyleBackColor = true;
            this.button_clean.Click += new System.EventHandler(this.button_clean_Click);
            // 
            // button_doctor
            // 
            this.button_doctor.Location = new System.Drawing.Point(761, 388);
            this.button_doctor.Name = "button_doctor";
            this.button_doctor.Size = new System.Drawing.Size(77, 31);
            this.button_doctor.TabIndex = 2;
            this.button_doctor.Text = "看醫生";
            this.button_doctor.UseVisualStyleBackColor = true;
            this.button_doctor.Click += new System.EventHandler(this.button_doctor_Click);
            // 
            // button_end_day
            // 
            this.button_end_day.Location = new System.Drawing.Point(680, 455);
            this.button_end_day.Name = "button_end_day";
            this.button_end_day.Size = new System.Drawing.Size(158, 29);
            this.button_end_day.TabIndex = 2;
            this.button_end_day.Text = "結束這天";
            this.button_end_day.UseVisualStyleBackColor = true;
            this.button_end_day.Click += new System.EventHandler(this.button_end_day_Click);
            // 
            // button_name
            // 
            this.button_name.Location = new System.Drawing.Point(383, 455);
            this.button_name.Name = "button_name";
            this.button_name.Size = new System.Drawing.Size(106, 29);
            this.button_name.TabIndex = 2;
            this.button_name.Text = "輸入名字";
            this.button_name.UseVisualStyleBackColor = true;
            this.button_name.Click += new System.EventHandler(this.button_name_Click);
            // 
            // textBox_name
            // 
            this.textBox_name.Location = new System.Drawing.Point(79, 455);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(298, 29);
            this.textBox_name.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(871, 514);
            this.Controls.Add(this.textBox_name);
            this.Controls.Add(this.button_name);
            this.Controls.Add(this.button_end_day);
            this.Controls.Add(this.button_doctor);
            this.Controls.Add(this.button_clean);
            this.Controls.Add(this.button_play);
            this.Controls.Add(this.button_feed);
            this.Controls.Add(this.textBox_display);
            this.Controls.Add(this.label_para_event);
            this.Controls.Add(this.label_title_event);
            this.Controls.Add(this.label_para_mood);
            this.Controls.Add(this.label_status_mood);
            this.Controls.Add(this.label_para_hunger);
            this.Controls.Add(this.label_status_hunger);
            this.Controls.Add(this.label_para_weight);
            this.Controls.Add(this.label_para_health);
            this.Controls.Add(this.label_status_weight);
            this.Controls.Add(this.label_status_health);
            this.Controls.Add(this.label_title_status);
            this.Controls.Add(this.label_para_money);
            this.Controls.Add(this.label_title_money);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_title_money;
        private System.Windows.Forms.Label label_title_status;
        private System.Windows.Forms.TextBox textBox_display;
        private System.Windows.Forms.Label label_title_event;
        private System.Windows.Forms.Label label_para_money;
        private System.Windows.Forms.Label label_status_health;
        private System.Windows.Forms.Label label_status_weight;
        private System.Windows.Forms.Label label_status_hunger;
        private System.Windows.Forms.Label label_status_mood;
        private System.Windows.Forms.Label label_para_event;
        private System.Windows.Forms.Label label_para_health;
        private System.Windows.Forms.Label label_para_weight;
        private System.Windows.Forms.Label label_para_hunger;
        private System.Windows.Forms.Label label_para_mood;
        private System.Windows.Forms.Button button_feed;
        private System.Windows.Forms.Button button_play;
        private System.Windows.Forms.Button button_clean;
        private System.Windows.Forms.Button button_doctor;
        private System.Windows.Forms.Button button_end_day;
        private System.Windows.Forms.Button button_name;
        private System.Windows.Forms.TextBox textBox_name;
    }
}

