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
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(7, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Name:";
            // 
            // nameTxt
            // 
            this.nameTxt.BackColor = System.Drawing.Color.DimGray;
            this.nameTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nameTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.nameTxt.ForeColor = System.Drawing.Color.White;
            this.nameTxt.Location = new System.Drawing.Point(96, 6);
            this.nameTxt.Name = "nameTxt";
            this.nameTxt.Size = new System.Drawing.Size(191, 22);
            this.nameTxt.TabIndex = 6;
            this.nameTxt.TextChanged += new System.EventHandler(this.nameTxt_TextChanged);
            // 
            // cancelBtn
            // 
            this.cancelBtn.BackgroundImage = global::v_0_0_0.Properties.Resources.backicon;
            this.cancelBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cancelBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cancelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.cancelBtn.ForeColor = System.Drawing.Color.White;
            this.cancelBtn.Location = new System.Drawing.Point(307, 3);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(40, 40);
            this.cancelBtn.TabIndex = 5;
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // saveBtn
            // 
            this.saveBtn.BackgroundImage = global::v_0_0_0.Properties.Resources.save_icon;
            this.saveBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.saveBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.saveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.saveBtn.ForeColor = System.Drawing.Color.White;
            this.saveBtn.Location = new System.Drawing.Point(307, 45);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(40, 40);
            this.saveBtn.TabIndex = 4;
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // label77
            // 
            this.label77.AutoSize = true;
            this.label77.BackColor = System.Drawing.Color.Transparent;
            this.label77.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label77.ForeColor = System.Drawing.Color.White;
            this.label77.Location = new System.Drawing.Point(7, 35);
            this.label77.Name = "label77";
            this.label77.Size = new System.Drawing.Size(85, 20);
            this.label77.TabIndex = 9;
            this.label77.Text = "UserName";
            // 
            // userNameTxt
            // 
            this.userNameTxt.BackColor = System.Drawing.Color.DimGray;
            this.userNameTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.userNameTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.userNameTxt.ForeColor = System.Drawing.Color.White;
            this.userNameTxt.Location = new System.Drawing.Point(96, 32);
            this.userNameTxt.Name = "userNameTxt";
            this.userNameTxt.Size = new System.Drawing.Size(191, 22);
            this.userNameTxt.TabIndex = 8;
            this.userNameTxt.TextChanged += new System.EventHandler(this.nameTxt_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(7, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Group:";
            // 
            // groupCB
            // 
            this.groupCB.FormattingEnabled = true;
            this.groupCB.Location = new System.Drawing.Point(96, 58);
            this.groupCB.Name = "groupCB";
            this.groupCB.Size = new System.Drawing.Size(191, 21);
            this.groupCB.TabIndex = 12;
            this.groupCB.SelectedIndexChanged += new System.EventHandler(this.groupCB_SelectedIndexChanged);
            // 
            // UserControlEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.groupCB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label77);
            this.Controls.Add(this.userNameTxt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nameTxt);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.saveBtn);
            this.Name = "UserControlEdit";
            this.Size = new System.Drawing.Size(361, 101);
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
