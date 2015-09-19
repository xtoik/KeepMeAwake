namespace KeepMeAwake
{
    partial class MainView
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainView));
            this.lblInformation = new System.Windows.Forms.Label();
            this.pbxIcon = new System.Windows.Forms.PictureBox();
            this.nicMain = new System.Windows.Forms.NotifyIcon(this.components);
            this.nicMainContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.nicMainCtxMenuItemShow = new System.Windows.Forms.ToolStripMenuItem();
            this.nicMainCtxMenuItemExit = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pbxIcon)).BeginInit();
            this.nicMainContextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblInformation
            // 
            this.lblInformation.AutoSize = true;
            this.lblInformation.Location = new System.Drawing.Point(160, 24);
            this.lblInformation.Name = "lblInformation";
            this.lblInformation.Size = new System.Drawing.Size(316, 104);
            this.lblInformation.TabIndex = 0;
            this.lblInformation.Text = resources.GetString("lblInformation.Text");
            // 
            // pbxIcon
            // 
            this.pbxIcon.Image = global::KeepMeAwake.Properties.Resources.KeepMeAwake;
            this.pbxIcon.Location = new System.Drawing.Point(13, 13);
            this.pbxIcon.Name = "pbxIcon";
            this.pbxIcon.Size = new System.Drawing.Size(128, 128);
            this.pbxIcon.TabIndex = 1;
            this.pbxIcon.TabStop = false;
            // 
            // nicMain
            // 
            this.nicMain.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.nicMain.BalloonTipText = "KeepMeAwake is running in the background. \r\nTo close it right click on this notif" +
    "ication icon and select Exit.";
            this.nicMain.ContextMenuStrip = this.nicMainContextMenuStrip;
            this.nicMain.Icon = ((System.Drawing.Icon)(resources.GetObject("nicMain.Icon")));
            this.nicMain.Text = "KeepMeRunning";
            this.nicMain.DoubleClick += new System.EventHandler(this.nicMain_DoubleClick);
            // 
            // nicMainContextMenuStrip
            // 
            this.nicMainContextMenuStrip.BackColor = System.Drawing.SystemColors.Control;
            this.nicMainContextMenuStrip.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nicMainContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nicMainCtxMenuItemShow,
            this.nicMainCtxMenuItemExit});
            this.nicMainContextMenuStrip.Name = "nicMainContextMenuStrip";
            this.nicMainContextMenuStrip.Size = new System.Drawing.Size(117, 48);
            this.nicMainContextMenuStrip.Text = "KeepMeAwake";
            this.nicMainContextMenuStrip.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.nicMainContextMenuStrip_ItemClicked);
            // 
            // nicMainCtxMenuItemShow
            // 
            this.nicMainCtxMenuItemShow.Name = "nicMainCtxMenuItemShow";
            this.nicMainCtxMenuItemShow.Size = new System.Drawing.Size(116, 22);
            this.nicMainCtxMenuItemShow.Text = "About...";
            // 
            // nicMainCtxMenuItemExit
            // 
            this.nicMainCtxMenuItemExit.Name = "nicMainCtxMenuItemExit";
            this.nicMainCtxMenuItemExit.Size = new System.Drawing.Size(116, 22);
            this.nicMainCtxMenuItemExit.Text = "Exit";
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(510, 150);
            this.Controls.Add(this.pbxIcon);
            this.Controls.Add(this.lblInformation);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainView";
            this.Opacity = 0.8D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KeepMeAwake";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainView_FormClosed);
            this.Load += new System.EventHandler(this.MainView_Load);
            this.Resize += new System.EventHandler(this.MainView_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.pbxIcon)).EndInit();
            this.nicMainContextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInformation;
        private System.Windows.Forms.PictureBox pbxIcon;
        private System.Windows.Forms.NotifyIcon nicMain;
        private System.Windows.Forms.ContextMenuStrip nicMainContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem nicMainCtxMenuItemShow;
        private System.Windows.Forms.ToolStripMenuItem nicMainCtxMenuItemExit;
    }
}

