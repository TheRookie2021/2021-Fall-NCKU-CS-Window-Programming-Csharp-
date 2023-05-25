namespace practiceMultiFormList
{
    partial class loginForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.constLabAcnt = new System.Windows.Forms.Label();
            this.constLabPwd = new System.Windows.Forms.Label();
            this.txtAcnt = new System.Windows.Forms.TextBox();
            this.txtPwd = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // constLabAcnt
            // 
            this.constLabAcnt.AutoSize = true;
            this.constLabAcnt.Location = new System.Drawing.Point(18, 32);
            this.constLabAcnt.Name = "constLabAcnt";
            this.constLabAcnt.Size = new System.Drawing.Size(62, 18);
            this.constLabAcnt.TabIndex = 0;
            this.constLabAcnt.Text = "帳號：";
            // 
            // constLabPwd
            // 
            this.constLabPwd.AutoSize = true;
            this.constLabPwd.Location = new System.Drawing.Point(18, 80);
            this.constLabPwd.Name = "constLabPwd";
            this.constLabPwd.Size = new System.Drawing.Size(62, 18);
            this.constLabPwd.TabIndex = 1;
            this.constLabPwd.Text = "密碼：";
            // 
            // txtAcnt
            // 
            this.txtAcnt.Location = new System.Drawing.Point(90, 29);
            this.txtAcnt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtAcnt.Name = "txtAcnt";
            this.txtAcnt.Size = new System.Drawing.Size(112, 29);
            this.txtAcnt.TabIndex = 2;
            // 
            // txtPwd
            // 
            this.txtPwd.Location = new System.Drawing.Point(90, 77);
            this.txtPwd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPwd.Name = "txtPwd";
            this.txtPwd.PasswordChar = '*';
            this.txtPwd.Size = new System.Drawing.Size(112, 29);
            this.txtPwd.TabIndex = 3;
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(21, 144);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(84, 28);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "登入";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(132, 144);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(84, 28);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // loginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.ClientSize = new System.Drawing.Size(251, 214);
            this.ControlBox = false;
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtPwd);
            this.Controls.Add(this.txtAcnt);
            this.Controls.Add(this.constLabPwd);
            this.Controls.Add(this.constLabAcnt);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "loginForm";
            this.ShowIcon = false;
            this.Text = "登入";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label constLabAcnt;
        private System.Windows.Forms.Label constLabPwd;
        private System.Windows.Forms.TextBox txtAcnt;
        private System.Windows.Forms.TextBox txtPwd;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnCancel;
    }
}