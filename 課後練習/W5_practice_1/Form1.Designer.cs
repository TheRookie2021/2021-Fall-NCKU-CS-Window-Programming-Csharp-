namespace W5_practice_1
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
            this.btm_change = new System.Windows.Forms.Button();
            this.btm_cypto = new System.Windows.Forms.Button();
            this.btm_decode = new System.Windows.Forms.Button();
            this.btm_history = new System.Windows.Forms.Button();
            this.btm_generate = new System.Windows.Forms.Button();
            this.btm_ok = new System.Windows.Forms.Button();
            this.Txt_Table = new System.Windows.Forms.TextBox();
            this.Label_Title_Table = new System.Windows.Forms.Label();
            this.Label_Alpha = new System.Windows.Forms.Label();
            this.Label_Legal = new System.Windows.Forms.Label();
            this.Label_Title_Crypto = new System.Windows.Forms.Label();
            this.Label_String_Enter = new System.Windows.Forms.Label();
            this.Label_Encryp_result = new System.Windows.Forms.Label();
            this.Label_Decrype_Result = new System.Windows.Forms.Label();
            this.Label_Title_Decrypt = new System.Windows.Forms.Label();
            this.Txt_Enter = new System.Windows.Forms.TextBox();
            this.Txt_Encrypt = new System.Windows.Forms.TextBox();
            this.Txt_Decrypt = new System.Windows.Forms.TextBox();
            this.Label_String_Decrypt = new System.Windows.Forms.Label();
            this.Label_Title_History = new System.Windows.Forms.Label();
            this.Txt_Enter_Crypto = new System.Windows.Forms.TextBox();
            this.Label_Illegal = new System.Windows.Forms.Label();
            this.Txt_History = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btm_change
            // 
            this.btm_change.Location = new System.Drawing.Point(607, 79);
            this.btm_change.Name = "btm_change";
            this.btm_change.Size = new System.Drawing.Size(145, 39);
            this.btm_change.TabIndex = 0;
            this.btm_change.Text = "替換表";
            this.btm_change.UseVisualStyleBackColor = true;
            this.btm_change.Click += new System.EventHandler(this.btm_change_Click);
            // 
            // btm_cypto
            // 
            this.btm_cypto.Location = new System.Drawing.Point(607, 156);
            this.btm_cypto.Name = "btm_cypto";
            this.btm_cypto.Size = new System.Drawing.Size(145, 39);
            this.btm_cypto.TabIndex = 1;
            this.btm_cypto.Text = "加密";
            this.btm_cypto.UseVisualStyleBackColor = true;
            this.btm_cypto.Click += new System.EventHandler(this.btm_cypto_Click);
            // 
            // btm_decode
            // 
            this.btm_decode.Location = new System.Drawing.Point(607, 227);
            this.btm_decode.Name = "btm_decode";
            this.btm_decode.Size = new System.Drawing.Size(145, 39);
            this.btm_decode.TabIndex = 2;
            this.btm_decode.Text = "解密";
            this.btm_decode.UseVisualStyleBackColor = true;
            this.btm_decode.Click += new System.EventHandler(this.btm_decode_Click);
            // 
            // btm_history
            // 
            this.btm_history.Location = new System.Drawing.Point(607, 298);
            this.btm_history.Name = "btm_history";
            this.btm_history.Size = new System.Drawing.Size(145, 39);
            this.btm_history.TabIndex = 3;
            this.btm_history.Text = "歷史紀錄";
            this.btm_history.UseVisualStyleBackColor = true;
            this.btm_history.Click += new System.EventHandler(this.btm_history_Click);
            // 
            // btm_generate
            // 
            this.btm_generate.Location = new System.Drawing.Point(433, 289);
            this.btm_generate.Name = "btm_generate";
            this.btm_generate.Size = new System.Drawing.Size(147, 25);
            this.btm_generate.TabIndex = 4;
            this.btm_generate.Text = "隨機生成";
            this.btm_generate.UseVisualStyleBackColor = true;
            this.btm_generate.Click += new System.EventHandler(this.btm_generate_Click);
            // 
            // btm_ok
            // 
            this.btm_ok.Location = new System.Drawing.Point(433, 340);
            this.btm_ok.Name = "btm_ok";
            this.btm_ok.Size = new System.Drawing.Size(147, 25);
            this.btm_ok.TabIndex = 5;
            this.btm_ok.Text = "確定";
            this.btm_ok.UseVisualStyleBackColor = true;
            this.btm_ok.Click += new System.EventHandler(this.btm_ok_Click);
            // 
            // Txt_Table
            // 
            this.Txt_Table.Location = new System.Drawing.Point(59, 235);
            this.Txt_Table.Name = "Txt_Table";
            this.Txt_Table.Size = new System.Drawing.Size(523, 29);
            this.Txt_Table.TabIndex = 6;
            // 
            // Label_Title_Table
            // 
            this.Label_Title_Table.AutoSize = true;
            this.Label_Title_Table.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Label_Title_Table.Location = new System.Drawing.Point(47, 29);
            this.Label_Title_Table.Name = "Label_Title_Table";
            this.Label_Title_Table.Size = new System.Drawing.Size(128, 45);
            this.Label_Title_Table.TabIndex = 7;
            this.Label_Title_Table.Text = "替換表";
            // 
            // Label_Alpha
            // 
            this.Label_Alpha.AutoSize = true;
            this.Label_Alpha.Font = new System.Drawing.Font("微軟正黑體", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Label_Alpha.Location = new System.Drawing.Point(56, 135);
            this.Label_Alpha.Name = "Label_Alpha";
            this.Label_Alpha.Size = new System.Drawing.Size(504, 20);
            this.Label_Alpha.TabIndex = 8;
            this.Label_Alpha.Text = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
            // 
            // Label_Legal
            // 
            this.Label_Legal.AutoSize = true;
            this.Label_Legal.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Label_Legal.Location = new System.Drawing.Point(58, 298);
            this.Label_Legal.Name = "Label_Legal";
            this.Label_Legal.Size = new System.Drawing.Size(100, 23);
            this.Label_Legal.TabIndex = 9;
            this.Label_Legal.Text = "合法替換表";
            // 
            // Label_Title_Crypto
            // 
            this.Label_Title_Crypto.AutoSize = true;
            this.Label_Title_Crypto.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Label_Title_Crypto.Location = new System.Drawing.Point(47, 29);
            this.Label_Title_Crypto.Name = "Label_Title_Crypto";
            this.Label_Title_Crypto.Size = new System.Drawing.Size(92, 45);
            this.Label_Title_Crypto.TabIndex = 10;
            this.Label_Title_Crypto.Text = "加密";
            // 
            // Label_String_Enter
            // 
            this.Label_String_Enter.AutoSize = true;
            this.Label_String_Enter.Location = new System.Drawing.Point(56, 131);
            this.Label_String_Enter.Name = "Label_String_Enter";
            this.Label_String_Enter.Size = new System.Drawing.Size(80, 18);
            this.Label_String_Enter.TabIndex = 11;
            this.Label_String_Enter.Text = "輸入字串";
            // 
            // Label_Encryp_result
            // 
            this.Label_Encryp_result.AutoSize = true;
            this.Label_Encryp_result.Location = new System.Drawing.Point(59, 238);
            this.Label_Encryp_result.Name = "Label_Encryp_result";
            this.Label_Encryp_result.Size = new System.Drawing.Size(80, 18);
            this.Label_Encryp_result.TabIndex = 12;
            this.Label_Encryp_result.Text = "加密結果";
            // 
            // Label_Decrype_Result
            // 
            this.Label_Decrype_Result.AutoSize = true;
            this.Label_Decrype_Result.Location = new System.Drawing.Point(59, 237);
            this.Label_Decrype_Result.Name = "Label_Decrype_Result";
            this.Label_Decrype_Result.Size = new System.Drawing.Size(80, 18);
            this.Label_Decrype_Result.TabIndex = 13;
            this.Label_Decrype_Result.Text = "解密結果";
            // 
            // Label_Title_Decrypt
            // 
            this.Label_Title_Decrypt.AutoSize = true;
            this.Label_Title_Decrypt.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Label_Title_Decrypt.Location = new System.Drawing.Point(52, 36);
            this.Label_Title_Decrypt.Name = "Label_Title_Decrypt";
            this.Label_Title_Decrypt.Size = new System.Drawing.Size(87, 36);
            this.Label_Title_Decrypt.TabIndex = 14;
            this.Label_Title_Decrypt.Text = "解密";
            // 
            // Txt_Enter
            // 
            this.Txt_Enter.Location = new System.Drawing.Point(145, 131);
            this.Txt_Enter.Name = "Txt_Enter";
            this.Txt_Enter.Size = new System.Drawing.Size(279, 29);
            this.Txt_Enter.TabIndex = 15;
            // 
            // Txt_Encrypt
            // 
            this.Txt_Encrypt.Location = new System.Drawing.Point(145, 234);
            this.Txt_Encrypt.Name = "Txt_Encrypt";
            this.Txt_Encrypt.ReadOnly = true;
            this.Txt_Encrypt.Size = new System.Drawing.Size(279, 29);
            this.Txt_Encrypt.TabIndex = 16;
            this.Txt_Encrypt.TextChanged += new System.EventHandler(this.Txt_Encrypt_TextChanged);
            // 
            // Txt_Decrypt
            // 
            this.Txt_Decrypt.Location = new System.Drawing.Point(145, 235);
            this.Txt_Decrypt.Name = "Txt_Decrypt";
            this.Txt_Decrypt.ReadOnly = true;
            this.Txt_Decrypt.Size = new System.Drawing.Size(279, 29);
            this.Txt_Decrypt.TabIndex = 17;
            this.Txt_Decrypt.TextChanged += new System.EventHandler(this.Txt_Decrypt_TextChanged);
            // 
            // Label_String_Decrypt
            // 
            this.Label_String_Decrypt.AutoSize = true;
            this.Label_String_Decrypt.Location = new System.Drawing.Point(55, 131);
            this.Label_String_Decrypt.Name = "Label_String_Decrypt";
            this.Label_String_Decrypt.Size = new System.Drawing.Size(80, 18);
            this.Label_String_Decrypt.TabIndex = 11;
            this.Label_String_Decrypt.Text = "輸入密文";
            // 
            // Label_Title_History
            // 
            this.Label_Title_History.AutoSize = true;
            this.Label_Title_History.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Label_Title_History.Location = new System.Drawing.Point(50, 27);
            this.Label_Title_History.Name = "Label_Title_History";
            this.Label_Title_History.Size = new System.Drawing.Size(164, 45);
            this.Label_Title_History.TabIndex = 7;
            this.Label_Title_History.Text = "歷史紀錄";
            // 
            // Txt_Enter_Crypto
            // 
            this.Txt_Enter_Crypto.Location = new System.Drawing.Point(145, 131);
            this.Txt_Enter_Crypto.Name = "Txt_Enter_Crypto";
            this.Txt_Enter_Crypto.Size = new System.Drawing.Size(279, 29);
            this.Txt_Enter_Crypto.TabIndex = 15;
            // 
            // Label_Illegal
            // 
            this.Label_Illegal.AutoSize = true;
            this.Label_Illegal.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Label_Illegal.Location = new System.Drawing.Point(58, 298);
            this.Label_Illegal.Name = "Label_Illegal";
            this.Label_Illegal.Size = new System.Drawing.Size(226, 23);
            this.Label_Illegal.TabIndex = 9;
            this.Label_Illegal.Text = "替換表不合法，請重新輸入";
            // 
            // Txt_History
            // 
            this.Txt_History.BackColor = System.Drawing.SystemColors.Window;
            this.Txt_History.Location = new System.Drawing.Point(49, 89);
            this.Txt_History.Multiline = true;
            this.Txt_History.Name = "Txt_History";
            this.Txt_History.ReadOnly = true;
            this.Txt_History.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Txt_History.Size = new System.Drawing.Size(533, 276);
            this.Txt_History.TabIndex = 18;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Txt_History);
            this.Controls.Add(this.Txt_Enter);
            this.Controls.Add(this.Label_Decrype_Result);
            this.Controls.Add(this.Label_Encryp_result);
            this.Controls.Add(this.Label_String_Decrypt);
            this.Controls.Add(this.Label_String_Enter);
            this.Controls.Add(this.Label_Illegal);
            this.Controls.Add(this.Label_Legal);
            this.Controls.Add(this.Label_Title_History);
            this.Controls.Add(this.Label_Alpha);
            this.Controls.Add(this.Label_Title_Table);
            this.Controls.Add(this.btm_ok);
            this.Controls.Add(this.btm_generate);
            this.Controls.Add(this.btm_history);
            this.Controls.Add(this.btm_decode);
            this.Controls.Add(this.btm_cypto);
            this.Controls.Add(this.btm_change);
            this.Controls.Add(this.Label_Title_Decrypt);
            this.Controls.Add(this.Label_Title_Crypto);
            this.Controls.Add(this.Txt_Decrypt);
            this.Controls.Add(this.Txt_Encrypt);
            this.Controls.Add(this.Txt_Table);
            this.Controls.Add(this.Txt_Enter_Crypto);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btm_change;
        private System.Windows.Forms.Button btm_cypto;
        private System.Windows.Forms.Button btm_decode;
        private System.Windows.Forms.Button btm_history;
        private System.Windows.Forms.Button btm_generate;
        private System.Windows.Forms.Button btm_ok;
        //
        private System.Windows.Forms.Label Label_Title_Table;
        private System.Windows.Forms.Label Label_Alpha;
        private System.Windows.Forms.Label Label_Legal;

        private System.Windows.Forms.Label Label_Title_Crypto;
        private System.Windows.Forms.Label Label_String_Enter;
        private System.Windows.Forms.Label Label_Encryp_result;

        private System.Windows.Forms.Label Label_Title_Decrypt;
        private System.Windows.Forms.Label Label_Decrype_Result;
        private System.Windows.Forms.Label Label_String_Decrypt;

        private System.Windows.Forms.Label Label_Title_History;
        //
        private System.Windows.Forms.TextBox Txt_Table;
        private System.Windows.Forms.TextBox Txt_Enter;
        private System.Windows.Forms.TextBox Txt_Encrypt;
        private System.Windows.Forms.TextBox Txt_Decrypt;
        private System.Windows.Forms.TextBox Txt_Enter_Crypto;
        private System.Windows.Forms.Label Label_Illegal;
        private System.Windows.Forms.TextBox Txt_History;
    }
}

