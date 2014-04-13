namespace TALibrary
{
    partial class ProductControl
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
            this.pNameLbl = new TALibrary.CustomButton();
            this.deleteBtn = new TALibrary.CustomButton();
            this.voteBtn = new TALibrary.CustomButton();
            this.editBtn = new TALibrary.CustomButton();
            this.SuspendLayout();
            // 
            // pNameLbl
            // 
            this.pNameLbl.BackColor = System.Drawing.Color.Transparent;
            this.pNameLbl.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pNameLbl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pNameLbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pNameLbl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pNameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.pNameLbl.ForeColor = System.Drawing.Color.White;
            this.pNameLbl.Location = new System.Drawing.Point(0, 0);
            this.pNameLbl.Name = "pNameLbl";
            this.pNameLbl.Size = new System.Drawing.Size(223, 31);
            this.pNameLbl.TabIndex = 0;
            this.pNameLbl.Text = "Product Name";
            this.pNameLbl.UseVisualStyleBackColor = false;
            // 
            // deleteBtn
            // 
            this.deleteBtn.BackgroundImage = global::v_0_0_0.Properties.Resources.Delete_IconOrange;
            this.deleteBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.deleteBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deleteBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.deleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.deleteBtn.ForeColor = System.Drawing.Color.White;
            this.deleteBtn.Location = new System.Drawing.Point(223, 0);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(43, 31);
            this.deleteBtn.TabIndex = 1;
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // voteBtn
            // 
            this.voteBtn.BackgroundImage = global::v_0_0_0.Properties.Resources.votelike;
            this.voteBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.voteBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.voteBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.voteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.voteBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.voteBtn.ForeColor = System.Drawing.Color.White;
            this.voteBtn.Location = new System.Drawing.Point(306, 0);
            this.voteBtn.Name = "voteBtn";
            this.voteBtn.Size = new System.Drawing.Size(37, 31);
            this.voteBtn.TabIndex = 2;
            this.voteBtn.UseVisualStyleBackColor = true;
            this.voteBtn.Click += new System.EventHandler(this.voteBtn_Click);
            // 
            // editBtn
            // 
            this.editBtn.BackgroundImage = global::v_0_0_0.Properties.Resources.EDIT;
            this.editBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.editBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.editBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.editBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.editBtn.ForeColor = System.Drawing.Color.White;
            this.editBtn.Location = new System.Drawing.Point(266, 0);
            this.editBtn.Name = "editBtn";
            this.editBtn.Size = new System.Drawing.Size(40, 31);
            this.editBtn.TabIndex = 3;
            this.editBtn.UseVisualStyleBackColor = true;
            this.editBtn.Click += new System.EventHandler(this.editBtn_Click);
            // 
            // ProductControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.Controls.Add(this.pNameLbl);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.editBtn);
            this.Controls.Add(this.voteBtn);
            this.Name = "ProductControl";
            this.Size = new System.Drawing.Size(343, 31);
            this.Load += new System.EventHandler(this.ProductControl_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private TALibrary.CustomButton pNameLbl;
        private TALibrary.CustomButton deleteBtn;
        private TALibrary.CustomButton voteBtn;
        private TALibrary.CustomButton editBtn;
    }
}
