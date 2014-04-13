namespace TALibrary
{
    partial class GroupControl
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
            this.deleteBtn = new TALibrary.CustomButton();
            this.editPointsBtn = new TALibrary.CustomButton();
            this.usersBtn = new TALibrary.CustomButton();
            this.editBtn = new TALibrary.CustomButton();
            this.nameLbl = new TALibrary.CustomLabel();
            this.SuspendLayout();
            // 
            // deleteBtn
            // 
            this.deleteBtn.BackgroundImage = global::v_0_0_0.Properties.Resources.Delete_IconOrange;
            this.deleteBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.deleteBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.deleteBtn.ForeColor = System.Drawing.Color.White;
            this.deleteBtn.Location = new System.Drawing.Point(3, 53);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(40, 40);
            this.deleteBtn.TabIndex = 4;
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // editPointsBtn
            // 
            this.editPointsBtn.BackgroundImage = global::v_0_0_0.Properties.Resources.votelike;
            this.editPointsBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.editPointsBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.editPointsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editPointsBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.editPointsBtn.ForeColor = System.Drawing.Color.White;
            this.editPointsBtn.Location = new System.Drawing.Point(221, 7);
            this.editPointsBtn.Name = "editPointsBtn";
            this.editPointsBtn.Size = new System.Drawing.Size(40, 40);
            this.editPointsBtn.TabIndex = 3;
            this.editPointsBtn.UseVisualStyleBackColor = true;
            this.editPointsBtn.Click += new System.EventHandler(this.editPointsBtn_Click);
            // 
            // usersBtn
            // 
            this.usersBtn.BackgroundImage = global::v_0_0_0.Properties.Resources.peopleicon;
            this.usersBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.usersBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.usersBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.usersBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.usersBtn.ForeColor = System.Drawing.Color.White;
            this.usersBtn.Location = new System.Drawing.Point(221, 53);
            this.usersBtn.Name = "usersBtn";
            this.usersBtn.Size = new System.Drawing.Size(40, 40);
            this.usersBtn.TabIndex = 2;
            this.usersBtn.UseVisualStyleBackColor = true;
            this.usersBtn.Click += new System.EventHandler(this.usersBtn_Click);
            // 
            // editBtn
            // 
            this.editBtn.BackgroundImage = global::v_0_0_0.Properties.Resources.EDIT;
            this.editBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.editBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.editBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.editBtn.ForeColor = System.Drawing.Color.White;
            this.editBtn.Location = new System.Drawing.Point(3, 7);
            this.editBtn.Name = "editBtn";
            this.editBtn.Size = new System.Drawing.Size(40, 40);
            this.editBtn.TabIndex = 1;
            this.editBtn.UseVisualStyleBackColor = true;
            this.editBtn.Click += new System.EventHandler(this.editBtn_Click);
            // 
            // nameLbl
            // 
            this.nameLbl.BackColor = System.Drawing.Color.Transparent;
            this.nameLbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.nameLbl.ForeColor = System.Drawing.Color.White;
            this.nameLbl.Location = new System.Drawing.Point(0, 0);
            this.nameLbl.Name = "nameLbl";
            this.nameLbl.Size = new System.Drawing.Size(262, 96);
            this.nameLbl.TabIndex = 0;
            this.nameLbl.Text = "Group Name";
            this.nameLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GroupControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.editPointsBtn);
            this.Controls.Add(this.usersBtn);
            this.Controls.Add(this.editBtn);
            this.Controls.Add(this.nameLbl);
            this.Name = "GroupControl";
            this.Size = new System.Drawing.Size(262, 96);
            this.ResumeLayout(false);

        }

        #endregion

        private TALibrary.CustomLabel nameLbl;
        private TALibrary.CustomButton editBtn;
        private TALibrary.CustomButton usersBtn;
        private TALibrary.CustomButton editPointsBtn;
        private TALibrary.CustomButton deleteBtn;
    }
}
