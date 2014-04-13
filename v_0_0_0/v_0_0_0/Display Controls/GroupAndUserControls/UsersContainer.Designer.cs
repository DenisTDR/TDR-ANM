namespace TALibrary
{
    partial class UsersContainer
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupLB = new System.Windows.Forms.ListBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cancelBtn = new TALibrary.CustomButton();
            this.newUserBtn = new TALibrary.CustomButton();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.newUserBtn);
            this.panel1.Controls.Add(this.cancelBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(401, 26);
            this.panel1.TabIndex = 2;
            // 
            // groupLB
            // 
            this.groupLB.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupLB.FormattingEnabled = true;
            this.groupLB.Location = new System.Drawing.Point(0, 26);
            this.groupLB.Name = "groupLB";
            this.groupLB.Size = new System.Drawing.Size(104, 197);
            this.groupLB.TabIndex = 3;
            this.groupLB.SelectedIndexChanged += new System.EventHandler(this.groupLB_SelectedIndexChanged);
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(104, 26);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(297, 197);
            this.panel2.TabIndex = 4;
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(335, 3);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(63, 21);
            this.cancelBtn.TabIndex = 0;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click_1);
            // 
            // newUserBtn
            // 
            this.newUserBtn.Location = new System.Drawing.Point(266, 3);
            this.newUserBtn.Name = "newUserBtn";
            this.newUserBtn.Size = new System.Drawing.Size(63, 21);
            this.newUserBtn.TabIndex = 1;
            this.newUserBtn.Text = "New User";
            this.newUserBtn.UseVisualStyleBackColor = true;
            this.newUserBtn.Click += new System.EventHandler(this.newUserBtn_Click);
            // 
            // UsersContainer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.groupLB);
            this.Controls.Add(this.panel1);
            this.Name = "UsersContainer";
            this.Size = new System.Drawing.Size(401, 223);
            this.Load += new System.EventHandler(this.UserControlNew_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox groupLB;
        private System.Windows.Forms.Panel panel2;
        private TALibrary.CustomButton cancelBtn;
        private TALibrary.CustomButton newUserBtn;

    }
}
