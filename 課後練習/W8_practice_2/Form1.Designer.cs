namespace W8_practice_2
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
            this.label_P2 = new System.Windows.Forms.Label();
            this.label_P1 = new System.Windows.Forms.Label();
            this.button_fight_1 = new System.Windows.Forms.Button();
            this.button_magic_1 = new System.Windows.Forms.Button();
            this.button_arch_1 = new System.Windows.Forms.Button();
            this.radioButton_chessA_P1 = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton_chessD_P1 = new System.Windows.Forms.RadioButton();
            this.radioButton_chessC_P1 = new System.Windows.Forms.RadioButton();
            this.radioButton_chessB_P1 = new System.Windows.Forms.RadioButton();
            this.button_fight_2 = new System.Windows.Forms.Button();
            this.button_magic_2 = new System.Windows.Forms.Button();
            this.button_arch_2 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButton_chessD_P2 = new System.Windows.Forms.RadioButton();
            this.radioButton_chessC_P2 = new System.Windows.Forms.RadioButton();
            this.radioButton_chessB_P2 = new System.Windows.Forms.RadioButton();
            this.radioButton_chessA_P2 = new System.Windows.Forms.RadioButton();
            this.button_start = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_P2
            // 
            this.label_P2.AutoSize = true;
            this.label_P2.Location = new System.Drawing.Point(65, 51);
            this.label_P2.Name = "label_P2";
            this.label_P2.Size = new System.Drawing.Size(25, 18);
            this.label_P2.TabIndex = 0;
            this.label_P2.Text = "P2";
            // 
            // label_P1
            // 
            this.label_P1.AutoSize = true;
            this.label_P1.Location = new System.Drawing.Point(894, 51);
            this.label_P1.Name = "label_P1";
            this.label_P1.Size = new System.Drawing.Size(25, 18);
            this.label_P1.TabIndex = 0;
            this.label_P1.Text = "P1";
            // 
            // button_fight_1
            // 
            this.button_fight_1.Location = new System.Drawing.Point(897, 153);
            this.button_fight_1.Name = "button_fight_1";
            this.button_fight_1.Size = new System.Drawing.Size(75, 33);
            this.button_fight_1.TabIndex = 1;
            this.button_fight_1.Text = "戰士";
            this.button_fight_1.UseVisualStyleBackColor = true;
            this.button_fight_1.Click += new System.EventHandler(this.button_fight_1_Click);
            // 
            // button_magic_1
            // 
            this.button_magic_1.Location = new System.Drawing.Point(897, 211);
            this.button_magic_1.Name = "button_magic_1";
            this.button_magic_1.Size = new System.Drawing.Size(75, 33);
            this.button_magic_1.TabIndex = 1;
            this.button_magic_1.Text = "法師";
            this.button_magic_1.UseVisualStyleBackColor = true;
            this.button_magic_1.Click += new System.EventHandler(this.button_magic_1_Click);
            // 
            // button_arch_1
            // 
            this.button_arch_1.Location = new System.Drawing.Point(897, 267);
            this.button_arch_1.Name = "button_arch_1";
            this.button_arch_1.Size = new System.Drawing.Size(75, 33);
            this.button_arch_1.TabIndex = 1;
            this.button_arch_1.Text = "弓箭手";
            this.button_arch_1.UseVisualStyleBackColor = true;
            this.button_arch_1.Click += new System.EventHandler(this.button_arch_1_Click);
            // 
            // radioButton_chessA_P1
            // 
            this.radioButton_chessA_P1.AutoSize = true;
            this.radioButton_chessA_P1.Checked = true;
            this.radioButton_chessA_P1.Location = new System.Drawing.Point(3, 25);
            this.radioButton_chessA_P1.Name = "radioButton_chessA_P1";
            this.radioButton_chessA_P1.Size = new System.Drawing.Size(105, 22);
            this.radioButton_chessA_P1.TabIndex = 0;
            this.radioButton_chessA_P1.TabStop = true;
            this.radioButton_chessA_P1.Text = "普通棋子";
            this.radioButton_chessA_P1.UseVisualStyleBackColor = true;
            this.radioButton_chessA_P1.CheckedChanged += new System.EventHandler(this.radioButton_chessA_P1_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton_chessD_P1);
            this.groupBox1.Controls.Add(this.radioButton_chessC_P1);
            this.groupBox1.Controls.Add(this.radioButton_chessB_P1);
            this.groupBox1.Controls.Add(this.radioButton_chessA_P1);
            this.groupBox1.Location = new System.Drawing.Point(851, 153);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(137, 163);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "P1";
            this.groupBox1.Visible = false;
            // 
            // radioButton_chessD_P1
            // 
            this.radioButton_chessD_P1.AutoSize = true;
            this.radioButton_chessD_P1.Location = new System.Drawing.Point(3, 111);
            this.radioButton_chessD_P1.Name = "radioButton_chessD_P1";
            this.radioButton_chessD_P1.Size = new System.Drawing.Size(105, 22);
            this.radioButton_chessD_P1.TabIndex = 0;
            this.radioButton_chessD_P1.Text = "覆蓋棋子";
            this.radioButton_chessD_P1.UseVisualStyleBackColor = true;
            this.radioButton_chessD_P1.CheckedChanged += new System.EventHandler(this.radioButton_chessD_P1_CheckedChanged);
            // 
            // radioButton_chessC_P1
            // 
            this.radioButton_chessC_P1.AutoSize = true;
            this.radioButton_chessC_P1.Location = new System.Drawing.Point(3, 81);
            this.radioButton_chessC_P1.Name = "radioButton_chessC_P1";
            this.radioButton_chessC_P1.Size = new System.Drawing.Size(105, 22);
            this.radioButton_chessC_P1.TabIndex = 0;
            this.radioButton_chessC_P1.Text = "縱向棋子";
            this.radioButton_chessC_P1.UseVisualStyleBackColor = true;
            this.radioButton_chessC_P1.CheckedChanged += new System.EventHandler(this.radioButton_chessC_P1_CheckedChanged);
            // 
            // radioButton_chessB_P1
            // 
            this.radioButton_chessB_P1.AutoSize = true;
            this.radioButton_chessB_P1.Location = new System.Drawing.Point(3, 53);
            this.radioButton_chessB_P1.Name = "radioButton_chessB_P1";
            this.radioButton_chessB_P1.Size = new System.Drawing.Size(105, 22);
            this.radioButton_chessB_P1.TabIndex = 0;
            this.radioButton_chessB_P1.Text = "橫向棋子";
            this.radioButton_chessB_P1.UseVisualStyleBackColor = true;
            this.radioButton_chessB_P1.CheckedChanged += new System.EventHandler(this.radioButton_chessB_P1_CheckedChanged);
            // 
            // button_fight_2
            // 
            this.button_fight_2.Location = new System.Drawing.Point(82, 153);
            this.button_fight_2.Name = "button_fight_2";
            this.button_fight_2.Size = new System.Drawing.Size(75, 33);
            this.button_fight_2.TabIndex = 1;
            this.button_fight_2.Text = "戰士";
            this.button_fight_2.UseVisualStyleBackColor = true;
            this.button_fight_2.Click += new System.EventHandler(this.button_fight_2_Click);
            // 
            // button_magic_2
            // 
            this.button_magic_2.Location = new System.Drawing.Point(82, 211);
            this.button_magic_2.Name = "button_magic_2";
            this.button_magic_2.Size = new System.Drawing.Size(75, 33);
            this.button_magic_2.TabIndex = 1;
            this.button_magic_2.Text = "法師";
            this.button_magic_2.UseVisualStyleBackColor = true;
            this.button_magic_2.Click += new System.EventHandler(this.button_magic_2_Click);
            // 
            // button_arch_2
            // 
            this.button_arch_2.Location = new System.Drawing.Point(82, 267);
            this.button_arch_2.Name = "button_arch_2";
            this.button_arch_2.Size = new System.Drawing.Size(75, 33);
            this.button_arch_2.TabIndex = 1;
            this.button_arch_2.Text = "弓箭手";
            this.button_arch_2.UseVisualStyleBackColor = true;
            this.button_arch_2.Click += new System.EventHandler(this.button_arch_2_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioButton_chessD_P2);
            this.groupBox2.Controls.Add(this.radioButton_chessC_P2);
            this.groupBox2.Controls.Add(this.radioButton_chessB_P2);
            this.groupBox2.Controls.Add(this.radioButton_chessA_P2);
            this.groupBox2.Cursor = System.Windows.Forms.Cursors.Default;
            this.groupBox2.Enabled = false;
            this.groupBox2.Location = new System.Drawing.Point(65, 153);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(141, 163);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "P2";
            this.groupBox2.Visible = false;
            // 
            // radioButton_chessD_P2
            // 
            this.radioButton_chessD_P2.AutoSize = true;
            this.radioButton_chessD_P2.Location = new System.Drawing.Point(3, 111);
            this.radioButton_chessD_P2.Name = "radioButton_chessD_P2";
            this.radioButton_chessD_P2.Size = new System.Drawing.Size(105, 22);
            this.radioButton_chessD_P2.TabIndex = 0;
            this.radioButton_chessD_P2.Text = "覆蓋棋子";
            this.radioButton_chessD_P2.UseVisualStyleBackColor = true;
            this.radioButton_chessD_P2.CheckedChanged += new System.EventHandler(this.radioButton_chessD_P2_CheckedChanged);
            // 
            // radioButton_chessC_P2
            // 
            this.radioButton_chessC_P2.AutoSize = true;
            this.radioButton_chessC_P2.Location = new System.Drawing.Point(3, 81);
            this.radioButton_chessC_P2.Name = "radioButton_chessC_P2";
            this.radioButton_chessC_P2.Size = new System.Drawing.Size(105, 22);
            this.radioButton_chessC_P2.TabIndex = 0;
            this.radioButton_chessC_P2.Text = "縱向棋子";
            this.radioButton_chessC_P2.UseVisualStyleBackColor = true;
            this.radioButton_chessC_P2.CheckedChanged += new System.EventHandler(this.radioButton_chessC_P2_CheckedChanged);
            // 
            // radioButton_chessB_P2
            // 
            this.radioButton_chessB_P2.AutoSize = true;
            this.radioButton_chessB_P2.Location = new System.Drawing.Point(3, 53);
            this.radioButton_chessB_P2.Name = "radioButton_chessB_P2";
            this.radioButton_chessB_P2.Size = new System.Drawing.Size(105, 22);
            this.radioButton_chessB_P2.TabIndex = 0;
            this.radioButton_chessB_P2.Text = "橫向棋子";
            this.radioButton_chessB_P2.UseVisualStyleBackColor = true;
            this.radioButton_chessB_P2.CheckedChanged += new System.EventHandler(this.radioButton_chessB_P2_CheckedChanged);
            // 
            // radioButton_chessA_P2
            // 
            this.radioButton_chessA_P2.AutoSize = true;
            this.radioButton_chessA_P2.Checked = true;
            this.radioButton_chessA_P2.Location = new System.Drawing.Point(3, 25);
            this.radioButton_chessA_P2.Name = "radioButton_chessA_P2";
            this.radioButton_chessA_P2.Size = new System.Drawing.Size(105, 22);
            this.radioButton_chessA_P2.TabIndex = 0;
            this.radioButton_chessA_P2.TabStop = true;
            this.radioButton_chessA_P2.Text = "普通棋子";
            this.radioButton_chessA_P2.UseVisualStyleBackColor = true;
            this.radioButton_chessA_P2.CheckedChanged += new System.EventHandler(this.radioButton_chessA_P2_CheckedChanged);
            // 
            // button_start
            // 
            this.button_start.Location = new System.Drawing.Point(452, 585);
            this.button_start.Name = "button_start";
            this.button_start.Size = new System.Drawing.Size(131, 41);
            this.button_start.TabIndex = 1;
            this.button_start.Text = "開始遊戲";
            this.button_start.UseVisualStyleBackColor = true;
            this.button_start.Click += new System.EventHandler(this.button_start_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1049, 727);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button_start);
            this.Controls.Add(this.button_arch_2);
            this.Controls.Add(this.button_arch_1);
            this.Controls.Add(this.button_magic_2);
            this.Controls.Add(this.button_magic_1);
            this.Controls.Add(this.button_fight_2);
            this.Controls.Add(this.button_fight_1);
            this.Controls.Add(this.label_P1);
            this.Controls.Add(this.label_P2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_P2;
        private System.Windows.Forms.Label label_P1;
        private System.Windows.Forms.Button button_fight_1;
        private System.Windows.Forms.Button button_magic_1;
        private System.Windows.Forms.Button button_arch_1;
        private System.Windows.Forms.RadioButton radioButton_chessA_P1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton_chessB_P1;
        private System.Windows.Forms.RadioButton radioButton_chessD_P1;
        private System.Windows.Forms.RadioButton radioButton_chessC_P1;
        private System.Windows.Forms.Button button_fight_2;
        private System.Windows.Forms.Button button_magic_2;
        private System.Windows.Forms.Button button_arch_2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioButton_chessD_P2;
        private System.Windows.Forms.RadioButton radioButton_chessC_P2;
        private System.Windows.Forms.RadioButton radioButton_chessB_P2;
        private System.Windows.Forms.RadioButton radioButton_chessA_P2;
        private System.Windows.Forms.Button button_start;
        private System.Windows.Forms.Timer timer1;
    }
}

