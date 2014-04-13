namespace TALibrary
{
    partial class ProductControlNew
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
            this.nameTxt = new TALibrary.CustomTextBox();
            this.saveBtn = new TALibrary.CustomButton();
            this.cancelBtn = new TALibrary.CustomButton();
            this.label1 = new TALibrary.CustomLabel();
            this.label3 = new TALibrary.CustomLabel();
            this.priceTxt = new TALibrary.CustomTextBox();
            this.label4 = new TALibrary.CustomLabel();
            this.categoryCB = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // nameTxt
            // 
            this.nameTxt.Location = new System.Drawing.Point(98, 7);
            this.nameTxt.Name = "nameTxt";
            this.nameTxt.Size = new System.Drawing.Size(100, 20);
            this.nameTxt.TabIndex = 1;
            this.nameTxt.TextChanged += new System.EventHandler(this.Txt_TextChanged);
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(215, 33);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(87, 46);
            this.saveBtn.TabIndex = 2;
            this.saveBtn.Text = "Add";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(215, 5);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(87, 23);
            this.cancelBtn.TabIndex = 3;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(5, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Name:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(5, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Price:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // priceTxt
            // 
            this.priceTxt.Location = new System.Drawing.Point(98, 33);
            this.priceTxt.Name = "priceTxt";
            this.priceTxt.Size = new System.Drawing.Size(100, 20);
            this.priceTxt.TabIndex = 8;
            this.priceTxt.TextChanged += new System.EventHandler(this.Txt_TextChanged);
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(3, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Category:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // categoryCB
            // 
            this.categoryCB.FormattingEnabled = true;
            this.categoryCB.Location = new System.Drawing.Point(98, 59);
            this.categoryCB.Name = "categoryCB";
            this.categoryCB.Size = new System.Drawing.Size(100, 21);
            this.categoryCB.TabIndex = 10;
            this.categoryCB.SelectedIndexChanged += new System.EventHandler(this.categoryCB_SelectedIndexChanged);
            // 
            // ProductControlNew
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.categoryCB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.priceTxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.nameTxt);
            this.Name = "ProductControlNew";
            this.Size = new System.Drawing.Size(317, 96);
            this.Load += new System.EventHandler(this.ProductControlEditable_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TALibrary.CustomTextBox nameTxt;
        private TALibrary.CustomButton saveBtn;
        private TALibrary.CustomButton cancelBtn;
        private TALibrary.CustomLabel label1;
        private TALibrary.CustomLabel label3;
        private TALibrary.CustomTextBox priceTxt;
        private TALibrary.CustomLabel label4;
        private System.Windows.Forms.ComboBox categoryCB;
    }
}
