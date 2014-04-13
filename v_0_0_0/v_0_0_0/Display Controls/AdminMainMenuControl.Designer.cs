namespace TALibrary
{
    partial class AdminMainMenuControl
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
            this.settingsBtn = new TALibrary.CustomButton();
            this.graphBtn = new TALibrary.CustomButton();
            this.categoriesBtn = new TALibrary.CustomButton();
            this.usersBtn = new TALibrary.CustomButton();
            this.groupsBtn = new TALibrary.CustomButton();
            this.SuspendLayout();
            // 
            // settingsBtn
            // 
            this.settingsBtn.BackgroundImage = global::v_0_0_0.Properties.Resources.settings_icon;
            this.settingsBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.settingsBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.settingsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.settingsBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.settingsBtn.ForeColor = System.Drawing.Color.White;
            this.settingsBtn.Location = new System.Drawing.Point(251, 271);
            this.settingsBtn.Name = "settingsBtn";
            this.settingsBtn.Size = new System.Drawing.Size(64, 58);
            this.settingsBtn.TabIndex = 5;
            this.settingsBtn.UseVisualStyleBackColor = true;
            this.settingsBtn.Click += new System.EventHandler(this.settingsBtn_Click);
            // 
            // graphBtn
            // 
            this.graphBtn.BackgroundImage = global::v_0_0_0.Properties.Resources.graph_icon2;
            this.graphBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.graphBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.graphBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.graphBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.graphBtn.ForeColor = System.Drawing.Color.White;
            this.graphBtn.Location = new System.Drawing.Point(190, 155);
            this.graphBtn.Name = "graphBtn";
            this.graphBtn.Size = new System.Drawing.Size(125, 110);
            this.graphBtn.TabIndex = 4;
            this.graphBtn.UseVisualStyleBackColor = true;
            this.graphBtn.Click += new System.EventHandler(this.graphBtn_Click);
            // 
            // categoriesBtn
            // 
            this.categoriesBtn.BackgroundImage = global::v_0_0_0.Properties.Resources.bread_orange;
            this.categoriesBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.categoriesBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.categoriesBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.categoriesBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.categoriesBtn.ForeColor = System.Drawing.Color.White;
            this.categoriesBtn.Location = new System.Drawing.Point(190, 20);
            this.categoriesBtn.Name = "categoriesBtn";
            this.categoriesBtn.Size = new System.Drawing.Size(125, 110);
            this.categoriesBtn.TabIndex = 2;
            this.categoriesBtn.UseVisualStyleBackColor = true;
            this.categoriesBtn.Click += new System.EventHandler(this.categoriesBtn_Click);
            // 
            // usersBtn
            // 
            this.usersBtn.BackgroundImage = global::v_0_0_0.Properties.Resources.person_orange_final;
            this.usersBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.usersBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.usersBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.usersBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.usersBtn.ForeColor = System.Drawing.Color.White;
            this.usersBtn.Location = new System.Drawing.Point(27, 155);
            this.usersBtn.Name = "usersBtn";
            this.usersBtn.Size = new System.Drawing.Size(125, 110);
            this.usersBtn.TabIndex = 1;
            this.usersBtn.UseVisualStyleBackColor = true;
            this.usersBtn.Click += new System.EventHandler(this.usersBtn_Click);
            // 
            // groupsBtn
            // 
            this.groupsBtn.BackgroundImage = global::v_0_0_0.Properties.Resources.peopleicon;
            this.groupsBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupsBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.groupsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupsBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.groupsBtn.ForeColor = System.Drawing.Color.White;
            this.groupsBtn.Location = new System.Drawing.Point(27, 20);
            this.groupsBtn.Name = "groupsBtn";
            this.groupsBtn.Size = new System.Drawing.Size(125, 110);
            this.groupsBtn.TabIndex = 0;
            this.groupsBtn.UseVisualStyleBackColor = true;
            this.groupsBtn.Click += new System.EventHandler(this.groupsBtn_Click);
            // 
            // AdminMainMenuControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.settingsBtn);
            this.Controls.Add(this.graphBtn);
            this.Controls.Add(this.categoriesBtn);
            this.Controls.Add(this.usersBtn);
            this.Controls.Add(this.groupsBtn);
            this.Name = "AdminMainMenuControl";
            this.Size = new System.Drawing.Size(338, 347);
            this.ResumeLayout(false);

        }

        #endregion

        private TALibrary.CustomButton groupsBtn;
        private TALibrary.CustomButton usersBtn;
        private TALibrary.CustomButton categoriesBtn;
        private TALibrary.CustomButton graphBtn;
        private CustomButton settingsBtn;
    }
}
