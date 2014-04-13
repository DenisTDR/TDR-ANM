namespace TALibrary
{
    partial class CategoriesContainer
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
            this.addBtn = new TALibrary.CustomButton();
            this.refreshBtn = new TALibrary.CustomButton();
            this.SuspendLayout();
            // 
            // addBtn
            // 
            this.addBtn.BackgroundImage = global::v_0_0_0.Properties.Resources.addicon;
            this.addBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.addBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.addBtn.ForeColor = System.Drawing.Color.White;
            this.addBtn.Location = new System.Drawing.Point(2, 128);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(90, 90);
            this.addBtn.TabIndex = 1;
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // refreshBtn
            // 
            this.refreshBtn.BackgroundImage = global::v_0_0_0.Properties.Resources.reload1;
            this.refreshBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.refreshBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.refreshBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.refreshBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.refreshBtn.ForeColor = System.Drawing.Color.White;
            this.refreshBtn.Location = new System.Drawing.Point(649, 5);
            this.refreshBtn.Name = "refreshBtn";
            this.refreshBtn.Size = new System.Drawing.Size(45, 45);
            this.refreshBtn.TabIndex = 0;
            this.refreshBtn.UseVisualStyleBackColor = true;
            this.refreshBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // CategoriesContainer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.DimGray;
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.refreshBtn);
            this.DoubleBuffered = true;
            this.Name = "CategoriesContainer";
            this.Size = new System.Drawing.Size(701, 375);
            this.Load += new System.EventHandler(this.categoryContainer_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private TALibrary.CustomButton refreshBtn;
        private TALibrary.CustomButton addBtn;
    }
}
