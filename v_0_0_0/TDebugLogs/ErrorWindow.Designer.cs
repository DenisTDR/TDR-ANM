namespace TDebugLogs
{
    partial class ErrorWindow
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
            this.msgTxt = new System.Windows.Forms.TextBox();
            this.dataTxt = new System.Windows.Forms.TextBox();
            this.srcTxt = new System.Windows.Forms.TextBox();
            this.stackTraceTxt = new System.Windows.Forms.TextBox();
            this.targetSiteTxt = new System.Windows.Forms.TextBox();
            this.toStrTxt = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // msgTxt
            // 
            this.msgTxt.Location = new System.Drawing.Point(22, 18);
            this.msgTxt.Multiline = true;
            this.msgTxt.Name = "msgTxt";
            this.msgTxt.Size = new System.Drawing.Size(177, 56);
            this.msgTxt.TabIndex = 0;
            // 
            // dataTxt
            // 
            this.dataTxt.Location = new System.Drawing.Point(-310, 74);
            this.dataTxt.Multiline = true;
            this.dataTxt.Name = "dataTxt";
            this.dataTxt.Size = new System.Drawing.Size(298, 56);
            this.dataTxt.TabIndex = 1;
            // 
            // srcTxt
            // 
            this.srcTxt.Location = new System.Drawing.Point(22, 80);
            this.srcTxt.Multiline = true;
            this.srcTxt.Name = "srcTxt";
            this.srcTxt.Size = new System.Drawing.Size(177, 56);
            this.srcTxt.TabIndex = 2;
            // 
            // stackTraceTxt
            // 
            this.stackTraceTxt.Location = new System.Drawing.Point(22, 142);
            this.stackTraceTxt.Multiline = true;
            this.stackTraceTxt.Name = "stackTraceTxt";
            this.stackTraceTxt.Size = new System.Drawing.Size(177, 56);
            this.stackTraceTxt.TabIndex = 3;
            // 
            // targetSiteTxt
            // 
            this.targetSiteTxt.Location = new System.Drawing.Point(22, 204);
            this.targetSiteTxt.Multiline = true;
            this.targetSiteTxt.Name = "targetSiteTxt";
            this.targetSiteTxt.Size = new System.Drawing.Size(177, 56);
            this.targetSiteTxt.TabIndex = 4;
            // 
            // toStrTxt
            // 
            this.toStrTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toStrTxt.Location = new System.Drawing.Point(234, 0);
            this.toStrTxt.Multiline = true;
            this.toStrTxt.Name = "toStrTxt";
            this.toStrTxt.Size = new System.Drawing.Size(223, 337);
            this.toStrTxt.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.msgTxt);
            this.panel1.Controls.Add(this.srcTxt);
            this.panel1.Controls.Add(this.targetSiteTxt);
            this.panel1.Controls.Add(this.stackTraceTxt);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(234, 337);
            this.panel1.TabIndex = 6;
            // 
            // ErrorWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 337);
            this.Controls.Add(this.toStrTxt);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataTxt);
            this.Name = "ErrorWindow";
            this.Text = "ErrorWindow";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ErrorWindow_FormClosing);
            this.Load += new System.EventHandler(this.ErrorWindow_Load);
            this.Resize += new System.EventHandler(this.ErrorWindow_Resize);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox msgTxt;
        private System.Windows.Forms.TextBox dataTxt;
        private System.Windows.Forms.TextBox srcTxt;
        private System.Windows.Forms.TextBox stackTraceTxt;
        private System.Windows.Forms.TextBox targetSiteTxt;
        private System.Windows.Forms.TextBox toStrTxt;
        private System.Windows.Forms.Panel panel1;
    }
}