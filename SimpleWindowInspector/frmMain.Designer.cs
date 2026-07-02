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
            wtv_MainWindowTreeView = new SimpleWindowInspector.UI.Controls.WindowTreeView();
            splt_MainSplitter = new Splitter();
            tsmi_Spy = new ToolStripMenuItem();
            tsmi_Windows = new ToolStripMenuItem();
            processesToolStripMenuItem = new ToolStripMenuItem();
            threadsToolStripMenuItem = new ToolStripMenuItem();
            tsmi_Tree = new ToolStripMenuItem();
            tss_sp1 = new ToolStripSeparator();
            tsmi_ShowOnlyVisibleWindows = new ToolStripMenuItem();
            tsmi_ExpandAll = new ToolStripMenuItem();
            tsmi_ExpandFirstLevel = new ToolStripMenuItem();
            tsmi_CollapseAll = new ToolStripMenuItem();
            tsmi_Filters = new ToolStripMenuItem();
            tsmi_Find = new ToolStripMenuItem();
            ms_MainMenuStrip.SuspendLayout();
            SuspendLayout();
            // 
            // ms_MainMenuStrip
            // 
            resources.ApplyResources(ms_MainMenuStrip, "ms_MainMenuStrip");
            ms_MainMenuStrip.Items.AddRange(new ToolStripItem[] { tsmi_File, tsmi_Spy, tsmi_Tree, tsmi_Filters, tsmi_Find });
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
            // wtv_MainWindowTreeView
            // 
            resources.ApplyResources(wtv_MainWindowTreeView, "wtv_MainWindowTreeView");
            wtv_MainWindowTreeView.Name = "wtv_MainWindowTreeView";
            // 
            // splt_MainSplitter
            // 
            resources.ApplyResources(splt_MainSplitter, "splt_MainSplitter");
            splt_MainSplitter.Name = "splt_MainSplitter";
            splt_MainSplitter.TabStop = false;
            // 
            // tsmi_Spy
            // 
            resources.ApplyResources(tsmi_Spy, "tsmi_Spy");
            tsmi_Spy.DropDownItems.AddRange(new ToolStripItem[] { tsmi_Windows, processesToolStripMenuItem, threadsToolStripMenuItem });
            tsmi_Spy.Name = "tsmi_Spy";
            // 
            // tsmi_Windows
            // 
            resources.ApplyResources(tsmi_Windows, "tsmi_Windows");
            tsmi_Windows.Name = "tsmi_Windows";
            // 
            // processesToolStripMenuItem
            // 
            resources.ApplyResources(processesToolStripMenuItem, "processesToolStripMenuItem");
            processesToolStripMenuItem.Name = "processesToolStripMenuItem";
            // 
            // threadsToolStripMenuItem
            // 
            resources.ApplyResources(threadsToolStripMenuItem, "threadsToolStripMenuItem");
            threadsToolStripMenuItem.Name = "threadsToolStripMenuItem";
            // 
            // tsmi_Tree
            // 
            resources.ApplyResources(tsmi_Tree, "tsmi_Tree");
            tsmi_Tree.DropDownItems.AddRange(new ToolStripItem[] { tsmi_ExpandAll, tsmi_ExpandFirstLevel, tsmi_CollapseAll, tss_sp1, tsmi_ShowOnlyVisibleWindows });
            tsmi_Tree.Name = "tsmi_Tree";
            // 
            // tss_sp1
            // 
            resources.ApplyResources(tss_sp1, "tss_sp1");
            tss_sp1.Name = "tss_sp1";
            // 
            // tsmi_ShowOnlyVisibleWindows
            // 
            resources.ApplyResources(tsmi_ShowOnlyVisibleWindows, "tsmi_ShowOnlyVisibleWindows");
            tsmi_ShowOnlyVisibleWindows.Name = "tsmi_ShowOnlyVisibleWindows";
            // 
            // tsmi_ExpandAll
            // 
            resources.ApplyResources(tsmi_ExpandAll, "tsmi_ExpandAll");
            tsmi_ExpandAll.Name = "tsmi_ExpandAll";
            // 
            // tsmi_ExpandFirstLevel
            // 
            resources.ApplyResources(tsmi_ExpandFirstLevel, "tsmi_ExpandFirstLevel");
            tsmi_ExpandFirstLevel.Name = "tsmi_ExpandFirstLevel";
            // 
            // tsmi_CollapseAll
            // 
            resources.ApplyResources(tsmi_CollapseAll, "tsmi_CollapseAll");
            tsmi_CollapseAll.Name = "tsmi_CollapseAll";
            // 
            // tsmi_Filters
            // 
            resources.ApplyResources(tsmi_Filters, "tsmi_Filters");
            tsmi_Filters.Name = "tsmi_Filters";
            // 
            // tsmi_Find
            // 
            resources.ApplyResources(tsmi_Find, "tsmi_Find");
            tsmi_Find.Name = "tsmi_Find";
            // 
            // frmMain
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(splt_MainSplitter);
            Controls.Add(wtv_MainWindowTreeView);
            Controls.Add(ms_MainMenuStrip);
            IsMdiContainer = true;
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
        private UI.Controls.WindowTreeView wtv_MainWindowTreeView;
        private Splitter splt_MainSplitter;
        private ToolStripMenuItem tsmi_Spy;
        private ToolStripMenuItem tsmi_Windows;
        private ToolStripMenuItem processesToolStripMenuItem;
        private ToolStripMenuItem threadsToolStripMenuItem;
        private ToolStripMenuItem tsmi_Tree;
        private ToolStripSeparator tss_sp1;
        private ToolStripMenuItem tsmi_ShowOnlyVisibleWindows;
        private ToolStripMenuItem tsmi_ExpandAll;
        private ToolStripMenuItem tsmi_ExpandFirstLevel;
        private ToolStripMenuItem tsmi_CollapseAll;
        private ToolStripMenuItem tsmi_Filters;
        private ToolStripMenuItem tsmi_Find;
    }
}
