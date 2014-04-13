namespace v_0_0_0
{
    partial class mainForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.nextBtn = new TALibrary.CustomButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.PrevBtn = new TALibrary.CustomButton();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.customButton1 = new TALibrary.CustomButton();
            this.userPanel = new System.Windows.Forms.Panel();
            this.refreshPointsBtn = new TALibrary.CustomButton();
            this.pointsLbl = new TALibrary.CustomLabel();
            this.userLbl = new TALibrary.CustomLabel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.userPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // nextBtn
            // 
            this.nextBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.nextBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.nextBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.nextBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nextBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.nextBtn.ForeColor = System.Drawing.Color.White;
            this.nextBtn.Location = new System.Drawing.Point(649, 0);
            this.nextBtn.Name = "nextBtn";
            this.nextBtn.Size = new System.Drawing.Size(75, 39);
            this.nextBtn.TabIndex = 0;
            this.nextBtn.Text = "Next";
            this.nextBtn.UseVisualStyleBackColor = true;
            this.nextBtn.Visible = false;
            this.nextBtn.Click += new System.EventHandler(this.nextBtn_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.PrevBtn);
            this.panel1.Controls.Add(this.nextBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 462);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(724, 39);
            this.panel1.TabIndex = 1;
            // 
            // PrevBtn
            // 
            this.PrevBtn.BackgroundImage = global::v_0_0_0.Properties.Resources.previous1;
            this.PrevBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PrevBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PrevBtn.Dock = System.Windows.Forms.DockStyle.Left;
            this.PrevBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PrevBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.PrevBtn.ForeColor = System.Drawing.Color.White;
            this.PrevBtn.Location = new System.Drawing.Point(0, 0);
            this.PrevBtn.Name = "PrevBtn";
            this.PrevBtn.Size = new System.Drawing.Size(39, 39);
            this.PrevBtn.TabIndex = 1;
            this.PrevBtn.UseVisualStyleBackColor = true;
            this.PrevBtn.Click += new System.EventHandler(this.PrevBtn_Click);
            // 
            // mainPanel
            // 
            this.mainPanel.AutoScroll = true;
            this.mainPanel.BackColor = System.Drawing.Color.Transparent;
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 80);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(724, 382);
            this.mainPanel.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.customButton1);
            this.panel2.Controls.Add(this.userPanel);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(724, 80);
            this.panel2.TabIndex = 0;
            // 
            // customButton1
            // 
            this.customButton1.BackgroundImage = global::v_0_0_0.Properties.Resources.unifiedpost;
            this.customButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.customButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.customButton1.FlatAppearance.BorderSize = 0;
            this.customButton1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.customButton1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.customButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.customButton1.ForeColor = System.Drawing.Color.White;
            this.customButton1.Location = new System.Drawing.Point(3, 5);
            this.customButton1.Name = "customButton1";
            this.customButton1.Size = new System.Drawing.Size(299, 70);
            this.customButton1.TabIndex = 3;
            this.customButton1.UseVisualStyleBackColor = true;
            this.customButton1.Click += new System.EventHandler(this.customButton1_Click);
            // 
            // userPanel
            // 
            this.userPanel.Controls.Add(this.refreshPointsBtn);
            this.userPanel.Controls.Add(this.pointsLbl);
            this.userPanel.Controls.Add(this.userLbl);
            this.userPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.userPanel.Location = new System.Drawing.Point(520, 0);
            this.userPanel.Name = "userPanel";
            this.userPanel.Size = new System.Drawing.Size(202, 78);
            this.userPanel.TabIndex = 2;
            // 
            // refreshPointsBtn
            // 
            this.refreshPointsBtn.BackgroundImage = global::v_0_0_0.Properties.Resources.reload1;
            this.refreshPointsBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.refreshPointsBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.refreshPointsBtn.FlatAppearance.BorderSize = 0;
            this.refreshPointsBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.refreshPointsBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.refreshPointsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.refreshPointsBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.refreshPointsBtn.ForeColor = System.Drawing.Color.White;
            this.refreshPointsBtn.Location = new System.Drawing.Point(108, 32);
            this.refreshPointsBtn.Name = "refreshPointsBtn";
            this.refreshPointsBtn.Size = new System.Drawing.Size(25, 25);
            this.refreshPointsBtn.TabIndex = 2;
            this.refreshPointsBtn.UseVisualStyleBackColor = true;
            this.refreshPointsBtn.Click += new System.EventHandler(this.refreshPointsBtn_Click);
            // 
            // pointsLbl
            // 
            this.pointsLbl.AutoSize = true;
            this.pointsLbl.BackColor = System.Drawing.Color.Transparent;
            this.pointsLbl.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pointsLbl.ForeColor = System.Drawing.Color.White;
            this.pointsLbl.Location = new System.Drawing.Point(3, 36);
            this.pointsLbl.Name = "pointsLbl";
            this.pointsLbl.Size = new System.Drawing.Size(66, 19);
            this.pointsLbl.TabIndex = 1;
            this.pointsLbl.Text = "44 Points";
            // 
            // userLbl
            // 
            this.userLbl.AutoSize = true;
            this.userLbl.BackColor = System.Drawing.Color.Transparent;
            this.userLbl.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userLbl.ForeColor = System.Drawing.Color.White;
            this.userLbl.Location = new System.Drawing.Point(3, 8);
            this.userLbl.Name = "userLbl";
            this.userLbl.Size = new System.Drawing.Size(130, 19);
            this.userLbl.TabIndex = 0;
            this.userLbl.Text = "Logged in as: User1";
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.ClientSize = new System.Drawing.Size(724, 501);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MinimumSize = new System.Drawing.Size(574, 393);
            this.Name = "mainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "[UnifiedPost] Delight Application";
            this.Load += new System.EventHandler(this.mainForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.userPanel.ResumeLayout(false);
            this.userPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Panel mainPanel;
        public TALibrary.CustomButton nextBtn;
        public TALibrary.CustomButton PrevBtn;
        private System.Windows.Forms.Panel panel2;
        public TALibrary.CustomLabel pointsLbl;
        public TALibrary.CustomLabel userLbl;
        public System.Windows.Forms.Panel userPanel;
        private TALibrary.CustomButton customButton1;
        public TALibrary.CustomButton refreshPointsBtn;
    }
}