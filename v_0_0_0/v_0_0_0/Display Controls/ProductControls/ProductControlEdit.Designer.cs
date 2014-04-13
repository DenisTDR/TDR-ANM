namespace TALibrary
{
    partial class ProductControlEdit
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
            this.label2 = new TALibrary.CustomLabel();
            this.label3 = new TALibrary.CustomLabel();
            this.votePNr = new TALibrary.CustomNumeric();
            this.priceTxt = new TALibrary.CustomTextBox();
            this.categoryCB = new System.Windows.Forms.ComboBox();
            this.label4 = new TALibrary.CustomLabel();
            ((System.ComponentModel.ISupportInitialize)(this.votePNr)).BeginInit();
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
            this.saveBtn.Location = new System.Drawing.Point(215, 60);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(87, 46);
            this.saveBtn.TabIndex = 2;
            this.saveBtn.Text = "OK";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(215, 4);
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
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(5, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Vote points:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            // votePNr
            // 
            this.votePNr.Location = new System.Drawing.Point(98, 59);
            this.votePNr.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.votePNr.Name = "votePNr";
            this.votePNr.Size = new System.Drawing.Size(100, 20);
            this.votePNr.TabIndex = 7;
            this.votePNr.ThousandsSeparator = true;
            this.votePNr.ValueChanged += new System.EventHandler(this.Txt_TextChanged);
            // 
            // priceTxt
            // 
            this.priceTxt.Location = new System.Drawing.Point(98, 33);
            this.priceTxt.Name = "priceTxt";
            this.priceTxt.Size = new System.Drawing.Size(100, 20);
            this.priceTxt.TabIndex = 8;
            this.priceTxt.TextChanged += new System.EventHandler(this.Txt_TextChanged);
            // 
            // categoryCB
            // 
            this.categoryCB.FormattingEnabled = true;
            this.categoryCB.Location = new System.Drawing.Point(98, 85);
            this.categoryCB.Name = "categoryCB";
            this.categoryCB.Size = new System.Drawing.Size(100, 21);
            this.categoryCB.TabIndex = 12;
            this.categoryCB.SelectedIndexChanged += new System.EventHandler(this.Txt_TextChanged);
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(3, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "Category:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ProductControlEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.categoryCB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.priceTxt);
            this.Controls.Add(this.votePNr);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.nameTxt);
            this.Name = "ProductControlEdit";
            this.Size = new System.Drawing.Size(318, 115);
            this.Load += new System.EventHandler(this.ProductControlEditable_Load);
            ((System.ComponentModel.ISupportInitialize)(this.votePNr)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TALibrary.CustomTextBox nameTxt;
        private TALibrary.CustomButton saveBtn;
        private TALibrary.CustomButton cancelBtn;
        private TALibrary.CustomLabel label1;
        private TALibrary.CustomLabel label2;
        private TALibrary.CustomLabel label3;
        private TALibrary.CustomNumeric votePNr;
        private TALibrary.CustomTextBox priceTxt;
        private System.Windows.Forms.ComboBox categoryCB;
        private TALibrary.CustomLabel label4;
    }
}
