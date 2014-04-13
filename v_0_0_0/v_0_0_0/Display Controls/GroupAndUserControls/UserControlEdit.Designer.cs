namespace TALibrary
{
    partial class UserControlEdit
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
            this.label1 = new TALibrary.CustomLabel();
            this.nameTxt = new TALibrary.CustomTextBox();
            this.cancelBtn = new TALibrary.CustomButton();
            this.saveBtn = new TALibrary.CustomButton();
            this.label77 = new TALibrary.CustomLabel();
            this.userNameTxt = new TALibrary.CustomTextBox();
            this.label3 = new TALibrary.CustomLabel();
            this.groupCB = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Name:";
            // 
            // nameTxt
            // 
            this.nameTxt.Location = new System.Drawing.Point(96, 6);
            this.nameTxt.Name = "nameTxt";
            this.nameTxt.Size = new System.Drawing.Size(113, 20);
            this.nameTxt.TabIndex = 6;
            this.nameTxt.TextChanged += new System.EventHandler(this.nameTxt_TextChanged);
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(292, 3);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(71, 25);
            this.cancelBtn.TabIndex = 5;
            this.cancelBtn.Text = "cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(292, 61);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(71, 25);
            this.saveBtn.TabIndex = 4;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // label77
            // 
            this.label77.AutoSize = true;
            this.label77.Location = new System.Drawing.Point(7, 35);
            this.label77.Name = "label77";
            this.label77.Size = new System.Drawing.Size(57, 13);
            this.label77.TabIndex = 9;
            this.label77.Text = "UserName";
            // 
            // userNameTxt
            // 
            this.userNameTxt.Location = new System.Drawing.Point(96, 32);
            this.userNameTxt.Name = "userNameTxt";
            this.userNameTxt.Size = new System.Drawing.Size(113, 20);
            this.userNameTxt.TabIndex = 8;
            this.userNameTxt.TextChanged += new System.EventHandler(this.nameTxt_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Group:";
            // 
            // groupCB
            // 
            this.groupCB.FormattingEnabled = true;
            this.groupCB.Location = new System.Drawing.Point(96, 58);
            this.groupCB.Name = "groupCB";
            this.groupCB.Size = new System.Drawing.Size(113, 21);
            this.groupCB.TabIndex = 12;
            this.groupCB.SelectedIndexChanged += new System.EventHandler(this.groupCB_SelectedIndexChanged);
            // 
            // UserControlEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupCB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label77);
            this.Controls.Add(this.userNameTxt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nameTxt);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.saveBtn);
            this.Name = "UserControlEdit";
            this.Size = new System.Drawing.Size(374, 101);
            this.Load += new System.EventHandler(this.UserControlNew_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TALibrary.CustomLabel label1;
        private TALibrary.CustomTextBox nameTxt;
        private TALibrary.CustomButton cancelBtn;
        private TALibrary.CustomButton saveBtn;
        private TALibrary.CustomLabel label77;
        private TALibrary.CustomTextBox userNameTxt;
        private TALibrary.CustomLabel label3;
        private System.Windows.Forms.ComboBox groupCB;
    }
}
