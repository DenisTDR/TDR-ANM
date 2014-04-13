namespace TALibrary
{
    partial class loginControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.passTxt = new TALibrary.CustomTextBox();
            this.label2 = new TALibrary.CustomLabel();
            this.label1 = new TALibrary.CustomLabel();
            this.userTxt = new TALibrary.CustomTextBox();
            this.loginBtn = new TALibrary.CustomButton();
            this.SuspendLayout();
            // 
            // passTxt
            // 
            this.passTxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.passTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.passTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.passTxt.ForeColor = System.Drawing.Color.White;
            this.passTxt.Location = new System.Drawing.Point(100, 46);
            this.passTxt.Name = "passTxt";
            this.passTxt.PasswordChar = '*';
            this.passTxt.Size = new System.Drawing.Size(111, 22);
            this.passTxt.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(3, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 21);
            this.label2.TabIndex = 9;
            this.label2.Text = "Password:";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(38, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 21);
            this.label1.TabIndex = 8;
            this.label1.Text = "User:";
            // 
            // userTxt
            // 
            this.userTxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.userTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.userTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.userTxt.ForeColor = System.Drawing.Color.White;
            this.userTxt.Location = new System.Drawing.Point(100, 18);
            this.userTxt.Name = "userTxt";
            this.userTxt.Size = new System.Drawing.Size(111, 22);
            this.userTxt.TabIndex = 7;
            // 
            // loginBtn
            // 
            this.loginBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.loginBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loginBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.loginBtn.ForeColor = System.Drawing.Color.White;
            this.loginBtn.Location = new System.Drawing.Point(100, 74);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(111, 35);
            this.loginBtn.TabIndex = 6;
            this.loginBtn.Text = "Login";
            this.loginBtn.UseVisualStyleBackColor = true;
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // loginControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.passTxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.userTxt);
            this.Controls.Add(this.loginBtn);
            this.Name = "loginControl";
            this.Size = new System.Drawing.Size(238, 121);
            this.Load += new System.EventHandler(this.loginControl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TALibrary.CustomTextBox passTxt;
        private TALibrary.CustomLabel label2;
        private TALibrary.CustomLabel label1;
        private TALibrary.CustomTextBox userTxt;
        private TALibrary.CustomButton loginBtn;
    }
}
