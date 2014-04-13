namespace TALibrary
{
    partial class ProductControlVote
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
            this.pointsNr = new TALibrary.CustomNumeric();
            this.label1 = new TALibrary.CustomLabel();
            this.cancelBtn = new TALibrary.CustomButton();
            this.saveBtn = new TALibrary.CustomButton();
            ((System.ComponentModel.ISupportInitialize)(this.pointsNr)).BeginInit();
            this.SuspendLayout();
            // 
            // pointsNr
            // 
            this.pointsNr.BackColor = System.Drawing.Color.DimGray;
            this.pointsNr.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pointsNr.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.pointsNr.ForeColor = System.Drawing.Color.White;
            this.pointsNr.Location = new System.Drawing.Point(16, 32);
            this.pointsNr.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.pointsNr.Name = "pointsNr";
            this.pointsNr.Size = new System.Drawing.Size(433, 22);
            this.pointsNr.TabIndex = 4;
            this.pointsNr.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.pointsNr.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(13, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(451, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "How many points do you want to spend on ProductNew";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cancelBtn
            // 
            this.cancelBtn.BackgroundImage = global::v_0_0_0.Properties.Resources.backicon;
            this.cancelBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cancelBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cancelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.cancelBtn.ForeColor = System.Drawing.Color.White;
            this.cancelBtn.Location = new System.Drawing.Point(231, 60);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(47, 50);
            this.cancelBtn.TabIndex = 1;
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // saveBtn
            // 
            this.saveBtn.BackgroundImage = global::v_0_0_0.Properties.Resources.votelike;
            this.saveBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.saveBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.saveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.saveBtn.ForeColor = System.Drawing.Color.White;
            this.saveBtn.Location = new System.Drawing.Point(143, 60);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(53, 47);
            this.saveBtn.TabIndex = 0;
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // ProductControlVote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.pointsNr);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.saveBtn);
            this.Name = "ProductControlVote";
            this.Size = new System.Drawing.Size(464, 113);
            ((System.ComponentModel.ISupportInitialize)(this.pointsNr)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TALibrary.CustomButton saveBtn;
        private TALibrary.CustomButton cancelBtn;
        private TALibrary.CustomLabel label1;
        private TALibrary.CustomNumeric pointsNr;
    }
}
