namespace TDebugLogs
{
    partial class LogsWindow
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
            this.logsLb = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.onTopChk = new System.Windows.Forms.CheckBox();
            this.clearBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // logsLb
            // 
            this.logsLb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.logsLb.FormattingEnabled = true;
            this.logsLb.Location = new System.Drawing.Point(0, 28);
            this.logsLb.Name = "logsLb";
            this.logsLb.Size = new System.Drawing.Size(302, 335);
            this.logsLb.TabIndex = 0;
            this.logsLb.SelectedIndexChanged += new System.EventHandler(this.logsLb_SelectedIndexChanged);
            this.logsLb.MouseUp += new System.Windows.Forms.MouseEventHandler(this.logsLb_MouseUp);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.onTopChk);
            this.panel1.Controls.Add(this.clearBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(302, 28);
            this.panel1.TabIndex = 1;
            // 
            // onTopChk
            // 
            this.onTopChk.AutoSize = true;
            this.onTopChk.Dock = System.Windows.Forms.DockStyle.Right;
            this.onTopChk.Location = new System.Drawing.Point(240, 0);
            this.onTopChk.Name = "onTopChk";
            this.onTopChk.Size = new System.Drawing.Size(62, 28);
            this.onTopChk.TabIndex = 1;
            this.onTopChk.Text = "On Top";
            this.onTopChk.UseVisualStyleBackColor = true;
            this.onTopChk.CheckedChanged += new System.EventHandler(this.onTopChk_CheckedChanged);
            // 
            // clearBtn
            // 
            this.clearBtn.Location = new System.Drawing.Point(3, 3);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(75, 23);
            this.clearBtn.TabIndex = 0;
            this.clearBtn.Text = "Clear";
            this.clearBtn.UseVisualStyleBackColor = true;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // LogsWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 363);
            this.Controls.Add(this.logsLb);
            this.Controls.Add(this.panel1);
            this.Name = "LogsWindow";
            this.Text = "LogsWindow";
            this.Load += new System.EventHandler(this.LogsWindow_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox logsLb;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox onTopChk;
        private System.Windows.Forms.Button clearBtn;
    }
}