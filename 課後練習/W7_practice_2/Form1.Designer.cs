namespace W7_practice_2
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
            this.radioButton_water = new System.Windows.Forms.RadioButton();
            this.radioButton_fire = new System.Windows.Forms.RadioButton();
            this.radioButton_gress = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.button_start = new System.Windows.Forms.Button();
            this.label_status = new System.Windows.Forms.Label();
            this.label_score = new System.Windows.Forms.Label();
            this.label_time = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // radioButton_water
            // 
            this.radioButton_water.AutoSize = true;
            this.radioButton_water.Location = new System.Drawing.Point(311, 161);
            this.radioButton_water.Name = "radioButton_water";
            this.radioButton_water.Size = new System.Drawing.Size(51, 22);
            this.radioButton_water.TabIndex = 0;
            this.radioButton_water.TabStop = true;
            this.radioButton_water.Text = "水";
            this.radioButton_water.UseVisualStyleBackColor = true;
            this.radioButton_water.CheckedChanged += new System.EventHandler(this.radioButton_water_CheckedChanged);
            // 
            // radioButton_fire
            // 
            this.radioButton_fire.AutoSize = true;
            this.radioButton_fire.Location = new System.Drawing.Point(311, 222);
            this.radioButton_fire.Name = "radioButton_fire";
            this.radioButton_fire.Size = new System.Drawing.Size(51, 22);
            this.radioButton_fire.TabIndex = 0;
            this.radioButton_fire.TabStop = true;
            this.radioButton_fire.Text = "火";
            this.radioButton_fire.UseVisualStyleBackColor = true;
            this.radioButton_fire.CheckedChanged += new System.EventHandler(this.radioButton_fire_CheckedChanged);
            // 
            // radioButton_gress
            // 
            this.radioButton_gress.AutoSize = true;
            this.radioButton_gress.Location = new System.Drawing.Point(311, 290);
            this.radioButton_gress.Name = "radioButton_gress";
            this.radioButton_gress.Size = new System.Drawing.Size(51, 22);
            this.radioButton_gress.TabIndex = 0;
            this.radioButton_gress.TabStop = true;
            this.radioButton_gress.Text = "木";
            this.radioButton_gress.UseVisualStyleBackColor = true;
            this.radioButton_gress.CheckedChanged += new System.EventHandler(this.radioButton_gress_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(308, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "選擇初始屬性";
            // 
            // button_start
            // 
            this.button_start.Location = new System.Drawing.Point(311, 344);
            this.button_start.Name = "button_start";
            this.button_start.Size = new System.Drawing.Size(75, 40);
            this.button_start.TabIndex = 2;
            this.button_start.Text = "開始";
            this.button_start.UseVisualStyleBackColor = true;
            this.button_start.Click += new System.EventHandler(this.button_start_Click);
            // 
            // label_status
            // 
            this.label_status.AutoSize = true;
            this.label_status.Location = new System.Drawing.Point(529, 35);
            this.label_status.Name = "label_status";
            this.label_status.Size = new System.Drawing.Size(80, 18);
            this.label_status.TabIndex = 1;
            this.label_status.Text = "目前屬性";
            // 
            // label_score
            // 
            this.label_score.AutoSize = true;
            this.label_score.Location = new System.Drawing.Point(529, 67);
            this.label_score.Name = "label_score";
            this.label_score.Size = new System.Drawing.Size(80, 18);
            this.label_score.TabIndex = 1;
            this.label_score.Text = "目前分數";
            // 
            // label_time
            // 
            this.label_time.AutoSize = true;
            this.label_time.Location = new System.Drawing.Point(529, 99);
            this.label_time.Name = "label_time";
            this.label_time.Size = new System.Drawing.Size(80, 18);
            this.label_time.TabIndex = 1;
            this.label_time.Text = "剩餘時間";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 515);
            this.Controls.Add(this.button_start);
            this.Controls.Add(this.label_time);
            this.Controls.Add(this.label_score);
            this.Controls.Add(this.label_status);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.radioButton_gress);
            this.Controls.Add(this.radioButton_fire);
            this.Controls.Add(this.radioButton_water);
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioButton_water;
        private System.Windows.Forms.RadioButton radioButton_fire;
        private System.Windows.Forms.RadioButton radioButton_gress;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_start;
        private System.Windows.Forms.Label label_status;
        private System.Windows.Forms.Label label_score;
        private System.Windows.Forms.Label label_time;
        private System.Windows.Forms.Timer timer1;
    }
}

