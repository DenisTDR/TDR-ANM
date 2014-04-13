namespace TALibrary
{
    partial class GroupAndUsers
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
            this.cancelBtn = new TALibrary.CustomButton();
            this.noGroupUsersLb = new TALibrary.CustomListBox();
            this.thisGroupUsersLB = new TALibrary.CustomListBox();
            this.addTheUsersBtn = new TALibrary.CustomButton();
            this.deleteTheUsersBtn = new TALibrary.CustomButton();
            this.label1 = new TALibrary.CustomLabel();
            this.label2 = new TALibrary.CustomLabel();
            this.label3 = new TALibrary.CustomLabel();
            this.SuspendLayout();
            // 
            // cancelBtn
            // 
            this.cancelBtn.BackgroundImage = global::v_0_0_0.Properties.Resources.backicon;
            this.cancelBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cancelBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cancelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.cancelBtn.ForeColor = System.Drawing.Color.White;
            this.cancelBtn.Location = new System.Drawing.Point(447, 0);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(43, 36);
            this.cancelBtn.TabIndex = 0;
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // noGroupUsersLb
            // 
            this.noGroupUsersLb.FormattingEnabled = true;
            this.noGroupUsersLb.Location = new System.Drawing.Point(287, 75);
            this.noGroupUsersLb.Name = "noGroupUsersLb";
            this.noGroupUsersLb.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.noGroupUsersLb.Size = new System.Drawing.Size(147, 238);
            this.noGroupUsersLb.TabIndex = 1;
            // 
            // thisGroupUsersLB
            // 
            this.thisGroupUsersLB.FormattingEnabled = true;
            this.thisGroupUsersLB.Location = new System.Drawing.Point(3, 62);
            this.thisGroupUsersLB.Name = "thisGroupUsersLB";
            this.thisGroupUsersLB.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.thisGroupUsersLB.Size = new System.Drawing.Size(120, 251);
            this.thisGroupUsersLB.TabIndex = 2;
            // 
            // addTheUsersBtn
            // 
            this.addTheUsersBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.addTheUsersBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addTheUsersBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addTheUsersBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.addTheUsersBtn.ForeColor = System.Drawing.Color.White;
            this.addTheUsersBtn.Location = new System.Drawing.Point(129, 72);
            this.addTheUsersBtn.Name = "addTheUsersBtn";
            this.addTheUsersBtn.Size = new System.Drawing.Size(61, 39);
            this.addTheUsersBtn.TabIndex = 3;
            this.addTheUsersBtn.Text = "<<<";
            this.addTheUsersBtn.UseVisualStyleBackColor = true;
            this.addTheUsersBtn.Click += new System.EventHandler(this.addTheUsersBtn_Click);
            // 
            // deleteTheUsersBtn
            // 
            this.deleteTheUsersBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.deleteTheUsersBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deleteTheUsersBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteTheUsersBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.deleteTheUsersBtn.ForeColor = System.Drawing.Color.White;
            this.deleteTheUsersBtn.Location = new System.Drawing.Point(129, 117);
            this.deleteTheUsersBtn.Name = "deleteTheUsersBtn";
            this.deleteTheUsersBtn.Size = new System.Drawing.Size(61, 39);
            this.deleteTheUsersBtn.TabIndex = 4;
            this.deleteTheUsersBtn.Text = ">>>";
            this.deleteTheUsersBtn.UseVisualStyleBackColor = true;
            this.deleteTheUsersBtn.Click += new System.EventHandler(this.deleteTheUsersBtn_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(459, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "label1";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(217, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Users without group:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(3, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Users in this group:";
            // 
            // GroupAndUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.deleteTheUsersBtn);
            this.Controls.Add(this.addTheUsersBtn);
            this.Controls.Add(this.thisGroupUsersLB);
            
            this.Controls.Add(this.noGroupUsersLb);
            this.Name = "GroupAndUsers";
            this.Size = new System.Drawing.Size(490, 325);
            this.Load += new System.EventHandler(this.GroupAndUsers_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TALibrary.CustomButton cancelBtn;
        private TALibrary.CustomListBox noGroupUsersLb;
        private TALibrary.CustomListBox thisGroupUsersLB;
        private TALibrary.CustomButton addTheUsersBtn;
        private TALibrary.CustomButton deleteTheUsersBtn;
        private TALibrary.CustomLabel label1;
        private TALibrary.CustomLabel label2;
        private TALibrary.CustomLabel label3;

    }
}
