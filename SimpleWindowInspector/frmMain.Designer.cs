namespace SimpleWindowInspector
{
    partial class frmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            ms_MainMenuStrip = new MenuStrip();
            tsmi_File = new ToolStripMenuItem();
            tsmi_Close = new ToolStripMenuItem();
            ms_MainMenuStrip.SuspendLayout();
            SuspendLayout();
            // 
            // ms_MainMenuStrip
            // 
            resources.ApplyResources(ms_MainMenuStrip, "ms_MainMenuStrip");
            ms_MainMenuStrip.Items.AddRange(new ToolStripItem[] { tsmi_File });
            ms_MainMenuStrip.Name = "ms_MainMenuStrip";
            // 
            // tsmi_File
            // 
            resources.ApplyResources(tsmi_File, "tsmi_File");
            tsmi_File.DropDownItems.AddRange(new ToolStripItem[] { tsmi_Close });
            tsmi_File.Name = "tsmi_File";
            // 
            // tsmi_Close
            // 
            resources.ApplyResources(tsmi_Close, "tsmi_Close");
            tsmi_Close.Name = "tsmi_Close";
            // 
            // frmMain
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(ms_MainMenuStrip);
            MainMenuStrip = ms_MainMenuStrip;
            Name = "frmMain";
            ms_MainMenuStrip.ResumeLayout(false);
            ms_MainMenuStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip ms_MainMenuStrip;
        private ToolStripMenuItem tsmi_File;
        private ToolStripMenuItem tsmi_Close;
    }
}
