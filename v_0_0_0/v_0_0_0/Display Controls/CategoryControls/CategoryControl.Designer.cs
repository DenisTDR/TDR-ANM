namespace TALibrary
{
    partial class CategoryControl
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
            this.catBtn = new TALibrary.CustomButton();
            this.catDeleteBtn = new TALibrary.CustomButton();
            this.catEditBtn = new TALibrary.CustomButton();
            this.SuspendLayout();
            // 
            // catBtn
            // 
            this.catBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.catBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.catBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.catBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.catBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.catBtn.ForeColor = System.Drawing.Color.White;
            this.catBtn.Location = new System.Drawing.Point(0, 0);
            this.catBtn.Name = "catBtn";
            this.catBtn.Size = new System.Drawing.Size(257, 37);
            this.catBtn.TabIndex = 3;
            this.catBtn.Text = "Open";
            this.catBtn.UseVisualStyleBackColor = true;
            this.catBtn.Click += new System.EventHandler(this.catBtn_Click);
            // 
            // catDeleteBtn
            // 
            this.catDeleteBtn.BackgroundImage = global::v_0_0_0.Properties.Resources.Delete_IconOrange;
            this.catDeleteBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.catDeleteBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.catDeleteBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.catDeleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.catDeleteBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.catDeleteBtn.ForeColor = System.Drawing.Color.White;
            this.catDeleteBtn.Location = new System.Drawing.Point(257, 0);
            this.catDeleteBtn.Name = "catDeleteBtn";
            this.catDeleteBtn.Size = new System.Drawing.Size(45, 37);
            this.catDeleteBtn.TabIndex = 0;
            this.catDeleteBtn.UseVisualStyleBackColor = true;
            this.catDeleteBtn.Click += new System.EventHandler(this.catDeleteBtn_Click);
            // 
            // catEditBtn
            // 
            this.catEditBtn.BackgroundImage = global::v_0_0_0.Properties.Resources.EDIT;
            this.catEditBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.catEditBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.catEditBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.catEditBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.catEditBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.catEditBtn.ForeColor = System.Drawing.Color.White;
            this.catEditBtn.Location = new System.Drawing.Point(302, 0);
            this.catEditBtn.Name = "catEditBtn";
            this.catEditBtn.Size = new System.Drawing.Size(45, 37);
            this.catEditBtn.TabIndex = 2;
            this.catEditBtn.UseVisualStyleBackColor = true;
            this.catEditBtn.Click += new System.EventHandler(this.catEditBtn_Click);
            // 
            // CategoryControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.Controls.Add(this.catBtn);
            this.Controls.Add(this.catDeleteBtn);
            this.Controls.Add(this.catEditBtn);
            this.Name = "CategoryControl";
            this.Size = new System.Drawing.Size(347, 37);
            this.ResumeLayout(false);

        }

        #endregion

        private TALibrary.CustomButton catDeleteBtn;
        private TALibrary.CustomButton catEditBtn;
        private TALibrary.CustomButton catBtn;
    }
}
