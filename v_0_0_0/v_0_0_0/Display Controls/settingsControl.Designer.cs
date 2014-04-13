namespace TALibrary
{
    partial class settingsControl
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
            this.customLabel1 = new TALibrary.CustomLabel();
            this.customLabel2 = new TALibrary.CustomLabel();
            this.customTextBox1 = new TALibrary.CustomTextBox();
            this.customTextBox2 = new TALibrary.CustomTextBox();
            this.customButton1 = new TALibrary.CustomButton();
            this.customButton2 = new TALibrary.CustomButton();
            this.SuspendLayout();
            // 
            // customLabel1
            // 
            this.customLabel1.AutoSize = true;
            this.customLabel1.BackColor = System.Drawing.Color.Transparent;
            this.customLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.customLabel1.ForeColor = System.Drawing.Color.White;
            this.customLabel1.Location = new System.Drawing.Point(3, 0);
            this.customLabel1.Name = "customLabel1";
            this.customLabel1.Size = new System.Drawing.Size(186, 20);
            this.customLabel1.TabIndex = 0;
            this.customLabel1.Text = "User Welcome Message:";
            // 
            // customLabel2
            // 
            this.customLabel2.AutoSize = true;
            this.customLabel2.BackColor = System.Drawing.Color.Transparent;
            this.customLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.customLabel2.ForeColor = System.Drawing.Color.White;
            this.customLabel2.Location = new System.Drawing.Point(3, 93);
            this.customLabel2.Name = "customLabel2";
            this.customLabel2.Size = new System.Drawing.Size(197, 20);
            this.customLabel2.TabIndex = 1;
            this.customLabel2.Text = "Admin Welcome Message:";
            // 
            // customTextBox1
            // 
            this.customTextBox1.BackColor = System.Drawing.Color.DimGray;
            this.customTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.customTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.customTextBox1.ForeColor = System.Drawing.Color.White;
            this.customTextBox1.Location = new System.Drawing.Point(206, -2);
            this.customTextBox1.Multiline = true;
            this.customTextBox1.Name = "customTextBox1";
            this.customTextBox1.Size = new System.Drawing.Size(320, 56);
            this.customTextBox1.TabIndex = 2;
            // 
            // customTextBox2
            // 
            this.customTextBox2.BackColor = System.Drawing.Color.DimGray;
            this.customTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.customTextBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.customTextBox2.ForeColor = System.Drawing.Color.White;
            this.customTextBox2.Location = new System.Drawing.Point(206, 84);
            this.customTextBox2.Multiline = true;
            this.customTextBox2.Name = "customTextBox2";
            this.customTextBox2.Size = new System.Drawing.Size(320, 56);
            this.customTextBox2.TabIndex = 3;
            // 
            // customButton1
            // 
            this.customButton1.BackgroundImage = global::v_0_0_0.Properties.Resources.save_icon;
            this.customButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.customButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.customButton1.FlatAppearance.BorderSize = 0;
            this.customButton1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.customButton1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.customButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.customButton1.ForeColor = System.Drawing.Color.White;
            this.customButton1.Location = new System.Drawing.Point(412, 146);
            this.customButton1.Name = "customButton1";
            this.customButton1.Size = new System.Drawing.Size(54, 53);
            this.customButton1.TabIndex = 4;
            this.customButton1.UseVisualStyleBackColor = true;
            this.customButton1.Click += new System.EventHandler(this.customButton1_Click);
            // 
            // customButton2
            // 
            this.customButton2.BackgroundImage = global::v_0_0_0.Properties.Resources.backicon;
            this.customButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.customButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.customButton2.FlatAppearance.BorderSize = 0;
            this.customButton2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.customButton2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.customButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.customButton2.ForeColor = System.Drawing.Color.White;
            this.customButton2.Location = new System.Drawing.Point(472, 146);
            this.customButton2.Name = "customButton2";
            this.customButton2.Size = new System.Drawing.Size(54, 53);
            this.customButton2.TabIndex = 5;
            this.customButton2.UseVisualStyleBackColor = true;
            this.customButton2.Click += new System.EventHandler(this.customButton2_Click);
            // 
            // settingsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.customButton2);
            this.Controls.Add(this.customButton1);
            this.Controls.Add(this.customTextBox2);
            this.Controls.Add(this.customTextBox1);
            this.Controls.Add(this.customLabel2);
            this.Controls.Add(this.customLabel1);
            this.Name = "settingsControl";
            this.Size = new System.Drawing.Size(536, 210);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CustomLabel customLabel1;
        private CustomLabel customLabel2;
        private CustomTextBox customTextBox1;
        private CustomTextBox customTextBox2;
        private CustomButton customButton1;
        private CustomButton customButton2;
    }
}
