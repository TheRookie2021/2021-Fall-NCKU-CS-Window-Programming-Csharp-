namespace W8_practice_1
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
            this.button_start = new System.Windows.Forms.Button();
            this.label_p2 = new System.Windows.Forms.Label();
            this.label_round = new System.Windows.Forms.Label();
            this.label_p1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // button_start
            // 
            this.button_start.Location = new System.Drawing.Point(293, 159);
            this.button_start.Name = "button_start";
            this.button_start.Size = new System.Drawing.Size(209, 93);
            this.button_start.TabIndex = 0;
            this.button_start.Text = "開始";
            this.button_start.UseVisualStyleBackColor = true;
            this.button_start.Click += new System.EventHandler(this.button_start_Click);
            // 
            // label_p2
            // 
            this.label_p2.AutoSize = true;
            this.label_p2.Location = new System.Drawing.Point(76, 148);
            this.label_p2.Name = "label_p2";
            this.label_p2.Size = new System.Drawing.Size(30, 18);
            this.label_p2.TabIndex = 1;
            this.label_p2.Text = "P2:";
            // 
            // label_round
            // 
            this.label_round.AutoSize = true;
            this.label_round.Location = new System.Drawing.Point(351, 40);
            this.label_round.Name = "label_round";
            this.label_round.Size = new System.Drawing.Size(80, 18);
            this.label_round.TabIndex = 1;
            this.label_round.Text = "第幾回合";
            // 
            // label_p1
            // 
            this.label_p1.AutoSize = true;
            this.label_p1.Location = new System.Drawing.Point(675, 131);
            this.label_p1.Name = "label_p1";
            this.label_p1.Size = new System.Drawing.Size(30, 18);
            this.label_p1.TabIndex = 1;
            this.label_p1.Text = "P1:";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label_p1);
            this.Controls.Add(this.label_round);
            this.Controls.Add(this.label_p2);
            this.Controls.Add(this.button_start);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_start;
        private System.Windows.Forms.Label label_p2;
        private System.Windows.Forms.Label label_round;
        private System.Windows.Forms.Label label_p1;
        private System.Windows.Forms.Timer timer1;
    }
}

