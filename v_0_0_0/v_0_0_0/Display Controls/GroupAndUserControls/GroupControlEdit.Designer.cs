namespace TALibrary
{
    partial class GroupControlEdit
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
            this.okBtn = new TALibrary.CustomButton();
            this.label1 = new TALibrary.CustomLabel();
            this.nameTxt = new TALibrary.CustomTextBox();
            this.cancelBtn = new TALibrary.CustomButton();
            this.SuspendLayout();
            // 
            // okBtn
            // 
            this.okBtn.BackgroundImage = global::v_0_0_0.Properties.Resources.save_icon;
            this.okBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.okBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.okBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.okBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.okBtn.ForeColor = System.Drawing.Color.White;
            this.okBtn.Location = new System.Drawing.Point(272, 6);
            this.okBtn.Name = "okBtn";
            this.okBtn.Size = new System.Drawing.Size(33, 30);
            this.okBtn.TabIndex = 5;
            this.okBtn.UseVisualStyleBackColor = true;
            this.okBtn.Click += new System.EventHandler(this.okBtn_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "New name";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nameTxt
            // 
            this.nameTxt.BackColor = System.Drawing.Color.DimGray;
            this.nameTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nameTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.nameTxt.ForeColor = System.Drawing.Color.White;
            this.nameTxt.Location = new System.Drawing.Point(98, 10);
            this.nameTxt.Name = "nameTxt";
            this.nameTxt.Size = new System.Drawing.Size(168, 22);
            this.nameTxt.TabIndex = 1;
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
            this.cancelBtn.Location = new System.Drawing.Point(311, 6);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(33, 30);
            this.cancelBtn.TabIndex = 0;
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // GroupControlEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.okBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nameTxt);
            this.Controls.Add(this.cancelBtn);
            this.Name = "GroupControlEdit";
            this.Size = new System.Drawing.Size(345, 40);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TALibrary.CustomButton cancelBtn;
        private TALibrary.CustomTextBox nameTxt;
        private TALibrary.CustomLabel label1;
        private TALibrary.CustomButton okBtn;
    }
}
