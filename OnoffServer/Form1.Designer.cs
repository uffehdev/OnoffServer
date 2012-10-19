namespace OnoffServer
{
    partial class Form1
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
            this.btnPutOnline = new System.Windows.Forms.Button();
            this.lblTxtA = new System.Windows.Forms.Label();
            this.grp_Info = new System.Windows.Forms.GroupBox();
            this.lstActions = new System.Windows.Forms.ListBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSetName = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblIp = new System.Windows.Forms.Label();
            this.lblAction = new System.Windows.Forms.Label();
            this.txtSrvName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.grp_Info.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnPutOnline
            // 
            this.btnPutOnline.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPutOnline.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPutOnline.Location = new System.Drawing.Point(457, 239);
            this.btnPutOnline.Name = "btnPutOnline";
            this.btnPutOnline.Size = new System.Drawing.Size(119, 34);
            this.btnPutOnline.TabIndex = 0;
            this.btnPutOnline.Text = "Put server online";
            this.btnPutOnline.UseVisualStyleBackColor = true;
            this.btnPutOnline.Click += new System.EventHandler(this.btnPutOnline_Click);
            // 
            // lblTxtA
            // 
            this.lblTxtA.AutoSize = true;
            this.lblTxtA.Location = new System.Drawing.Point(12, 35);
            this.lblTxtA.Name = "lblTxtA";
            this.lblTxtA.Size = new System.Drawing.Size(54, 17);
            this.lblTxtA.TabIndex = 1;
            this.lblTxtA.Text = "Actions";
            // 
            // grp_Info
            // 
            this.grp_Info.Controls.Add(this.lblAction);
            this.grp_Info.Controls.Add(this.lblIp);
            this.grp_Info.Controls.Add(this.lblStatus);
            this.grp_Info.Controls.Add(this.label3);
            this.grp_Info.Controls.Add(this.label2);
            this.grp_Info.Controls.Add(this.label1);
            this.grp_Info.Location = new System.Drawing.Point(298, 35);
            this.grp_Info.Name = "grp_Info";
            this.grp_Info.Size = new System.Drawing.Size(278, 134);
            this.grp_Info.TabIndex = 3;
            this.grp_Info.TabStop = false;
            this.grp_Info.Text = "Server info";
            // 
            // lstActions
            // 
            this.lstActions.FormattingEnabled = true;
            this.lstActions.ItemHeight = 16;
            this.lstActions.Location = new System.Drawing.Point(12, 61);
            this.lstActions.Name = "lstActions";
            this.lstActions.Size = new System.Drawing.Size(280, 212);
            this.lstActions.TabIndex = 4;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(588, 28);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // btnSetName
            // 
            this.btnSetName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSetName.Location = new System.Drawing.Point(298, 239);
            this.btnSetName.Name = "btnSetName";
            this.btnSetName.Size = new System.Drawing.Size(85, 34);
            this.btnSetName.TabIndex = 6;
            this.btnSetName.Text = "Set name";
            this.btnSetName.UseVisualStyleBackColor = true;
            this.btnSetName.Click += new System.EventHandler(this.btnSetName_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Status: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ip-address: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Action:";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(91, 35);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(0, 17);
            this.lblStatus.TabIndex = 3;
            // 
            // lblIp
            // 
            this.lblIp.AutoSize = true;
            this.lblIp.Location = new System.Drawing.Point(87, 62);
            this.lblIp.Name = "lblIp";
            this.lblIp.Size = new System.Drawing.Size(0, 17);
            this.lblIp.TabIndex = 4;
            // 
            // lblAction
            // 
            this.lblAction.AutoSize = true;
            this.lblAction.Location = new System.Drawing.Point(87, 92);
            this.lblAction.Name = "lblAction";
            this.lblAction.Size = new System.Drawing.Size(0, 17);
            this.lblAction.TabIndex = 5;
            // 
            // txtSrvName
            // 
            this.txtSrvName.Location = new System.Drawing.Point(298, 211);
            this.txtSrvName.Name = "txtSrvName";
            this.txtSrvName.Size = new System.Drawing.Size(143, 22);
            this.txtSrvName.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(298, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Server name:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 293);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtSrvName);
            this.Controls.Add(this.btnSetName);
            this.Controls.Add(this.lstActions);
            this.Controls.Add(this.grp_Info);
            this.Controls.Add(this.lblTxtA);
            this.Controls.Add(this.btnPutOnline);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "OnOff Server";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grp_Info.ResumeLayout(false);
            this.grp_Info.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPutOnline;
        private System.Windows.Forms.Label lblTxtA;
        private System.Windows.Forms.GroupBox grp_Info;
        private System.Windows.Forms.ListBox lstActions;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.Button btnSetName;
        private System.Windows.Forms.Label lblAction;
        private System.Windows.Forms.Label lblIp;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSrvName;
        private System.Windows.Forms.Label label4;
    }
}

