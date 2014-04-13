namespace TALibrary
{
    partial class graphControl
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Node6");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Node7");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Node0", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2});
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Node3");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Node4");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Node5");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Node1", new System.Windows.Forms.TreeNode[] {
            treeNode4,
            treeNode5,
            treeNode6});
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Node8");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Node9");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("Node10");
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("Node2", new System.Windows.Forms.TreeNode[] {
            treeNode8,
            treeNode9,
            treeNode10});
            this.copac = new System.Windows.Forms.TreeView();
            this.selectNoneBtn = new TALibrary.CustomButton();
            this.selectAllBtn = new TALibrary.CustomButton();
            this.drawBtn = new TALibrary.CustomButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.exportXlsBtn = new TALibrary.CustomButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // copac
            // 
            this.copac.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.copac.Dock = System.Windows.Forms.DockStyle.Left;
            this.copac.ForeColor = System.Drawing.SystemColors.Info;
            this.copac.Location = new System.Drawing.Point(0, 0);
            this.copac.Name = "copac";
            treeNode1.Name = "Node6";
            treeNode1.Text = "Node6";
            treeNode2.Name = "Node7";
            treeNode2.Text = "Node7";
            treeNode3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            treeNode3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            treeNode3.Name = "Node0";
            treeNode3.Text = "Node0";
            treeNode4.Name = "Node3";
            treeNode4.Text = "Node3";
            treeNode5.Name = "Node4";
            treeNode5.Text = "Node4";
            treeNode6.Name = "Node5";
            treeNode6.Text = "Node5";
            treeNode7.Name = "Node1";
            treeNode7.Text = "Node1";
            treeNode8.Name = "Node8";
            treeNode8.Text = "Node8";
            treeNode9.Name = "Node9";
            treeNode9.Text = "Node9";
            treeNode10.Name = "Node10";
            treeNode10.Text = "Node10";
            treeNode11.Name = "Node2";
            treeNode11.Text = "Node2";
            this.copac.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode3,
            treeNode7,
            treeNode11});
            this.copac.Size = new System.Drawing.Size(103, 270);
            this.copac.TabIndex = 1;
            this.copac.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.copac_NodeMouseClick);
            // 
            // selectNoneBtn
            // 
            this.selectNoneBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.selectNoneBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.selectNoneBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.selectNoneBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectNoneBtn.ForeColor = System.Drawing.Color.White;
            this.selectNoneBtn.Location = new System.Drawing.Point(6, 35);
            this.selectNoneBtn.Name = "selectNoneBtn";
            this.selectNoneBtn.Size = new System.Drawing.Size(61, 31);
            this.selectNoneBtn.TabIndex = 2;
            this.selectNoneBtn.Text = "None";
            this.selectNoneBtn.UseVisualStyleBackColor = true;
            this.selectNoneBtn.Click += new System.EventHandler(this.selectNoneBtn_Click);
            // 
            // selectAllBtn
            // 
            this.selectAllBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.selectAllBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.selectAllBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.selectAllBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectAllBtn.ForeColor = System.Drawing.Color.White;
            this.selectAllBtn.Location = new System.Drawing.Point(6, 3);
            this.selectAllBtn.Name = "selectAllBtn";
            this.selectAllBtn.Size = new System.Drawing.Size(61, 31);
            this.selectAllBtn.TabIndex = 3;
            this.selectAllBtn.Text = "All";
            this.selectAllBtn.UseVisualStyleBackColor = true;
            this.selectAllBtn.Click += new System.EventHandler(this.selectAllBtn_Click);
            // 
            // drawBtn
            // 
            this.drawBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.drawBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.drawBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.drawBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drawBtn.ForeColor = System.Drawing.Color.White;
            this.drawBtn.Location = new System.Drawing.Point(6, 67);
            this.drawBtn.Name = "drawBtn";
            this.drawBtn.Size = new System.Drawing.Size(61, 31);
            this.drawBtn.TabIndex = 4;
            this.drawBtn.Text = "Draw";
            this.drawBtn.UseVisualStyleBackColor = true;
            this.drawBtn.Click += new System.EventHandler(this.drawBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(176, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(442, 270);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.exportXlsBtn);
            this.panel1.Controls.Add(this.selectAllBtn);
            this.panel1.Controls.Add(this.selectNoneBtn);
            this.panel1.Controls.Add(this.drawBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(103, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(73, 270);
            this.panel1.TabIndex = 6;
            // 
            // exportXlsBtn
            // 
            this.exportXlsBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.exportXlsBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exportXlsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exportXlsBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exportXlsBtn.ForeColor = System.Drawing.Color.White;
            this.exportXlsBtn.Location = new System.Drawing.Point(6, 99);
            this.exportXlsBtn.Name = "exportXlsBtn";
            this.exportXlsBtn.Size = new System.Drawing.Size(61, 31);
            this.exportXlsBtn.TabIndex = 5;
            this.exportXlsBtn.Text = "Exp";
            this.exportXlsBtn.UseVisualStyleBackColor = true;
            this.exportXlsBtn.Click += new System.EventHandler(this.exportXlsBtn_Click);
            // 
            // graphControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.copac);
            this.Name = "graphControl";
            this.Size = new System.Drawing.Size(618, 270);
            this.Load += new System.EventHandler(this.graphControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView copac;
        private TALibrary.CustomButton selectNoneBtn;
        private TALibrary.CustomButton selectAllBtn;
        private TALibrary.CustomButton drawBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private CustomButton exportXlsBtn;
    }
}
