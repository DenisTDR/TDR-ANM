namespace TALibrary
{
    partial class GroupsContainer
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
            this.refreshBtn = new TALibrary.CustomButton();
            this.addUserBtn = new TALibrary.CustomButton();
            this.SuspendLayout();
            // 
            // refreshBtn
            // 
            this.refreshBtn.BackgroundImage = global::v_0_0_0.Properties.Resources.reload1;
            this.refreshBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.refreshBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.refreshBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.refreshBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.refreshBtn.ForeColor = System.Drawing.Color.White;
            this.refreshBtn.Location = new System.Drawing.Point(256, 0);
            this.refreshBtn.Name = "refreshBtn";
            this.refreshBtn.Size = new System.Drawing.Size(50, 38);
            this.refreshBtn.TabIndex = 3;
            this.refreshBtn.UseVisualStyleBackColor = true;
            this.refreshBtn.Click += new System.EventHandler(this.refreshBtn_Click);
            // 
            // addUserBtn
            // 
            this.addUserBtn.BackgroundImage = global::v_0_0_0.Properties.Resources.addicon;
            this.addUserBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.addUserBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addUserBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addUserBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.addUserBtn.ForeColor = System.Drawing.Color.White;
            this.addUserBtn.Location = new System.Drawing.Point(203, 0);
            this.addUserBtn.Name = "addUserBtn";
            this.addUserBtn.Size = new System.Drawing.Size(47, 38);
            this.addUserBtn.TabIndex = 2;
            this.addUserBtn.UseVisualStyleBackColor = true;
            this.addUserBtn.Click += new System.EventHandler(this.addUserBtn_Click);
            // 
            // GroupsContainer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.refreshBtn);
            this.Controls.Add(this.addUserBtn);
            this.Name = "GroupsContainer";
            this.Size = new System.Drawing.Size(349, 240);
            this.ResumeLayout(false);

        }

        #endregion

        private TALibrary.CustomButton refreshBtn;
        private TALibrary.CustomButton addUserBtn;
    }
}
