namespace TALibrary
{
    partial class GroupControlNew
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
            this.addBtn = new TALibrary.CustomButton();
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
            this.label1.Size = new System.Drawing.Size(104, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Group Name:";
            // 
            // nameTxt
            // 
            this.nameTxt.BackColor = System.Drawing.Color.DimGray;
            this.nameTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nameTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.nameTxt.ForeColor = System.Drawing.Color.White;
            this.nameTxt.Location = new System.Drawing.Point(117, 8);
            this.nameTxt.Name = "nameTxt";
            this.nameTxt.Size = new System.Drawing.Size(226, 22);
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
            this.cancelBtn.Location = new System.Drawing.Point(400, 0);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(36, 32);
            this.cancelBtn.TabIndex = 5;
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // addBtn
            // 
            this.addBtn.BackgroundImage = global::v_0_0_0.Properties.Resources.save_icon;
            this.addBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.addBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.addBtn.ForeColor = System.Drawing.Color.White;
            this.addBtn.Location = new System.Drawing.Point(359, 0);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(36, 32);
            this.addBtn.TabIndex = 4;
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // GroupControlNew
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nameTxt);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.addBtn);
            this.Name = "GroupControlNew";
            this.Size = new System.Drawing.Size(439, 35);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TALibrary.CustomLabel label1;
        private TALibrary.CustomTextBox nameTxt;
        private TALibrary.CustomButton cancelBtn;
        private TALibrary.CustomButton addBtn;
    }
}
