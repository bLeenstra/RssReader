namespace RssReader.Forms {
    partial class Main {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if( disposing&&(components!=null) ) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("All");
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("New");
            System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("Catagory");
            System.Windows.Forms.TreeNode treeNode16 = new System.Windows.Forms.TreeNode("Subscriptions");
            this.trvSideNav=new System.Windows.Forms.TreeView();
            this.mnuOptionBar=new System.Windows.Forms.MenuStrip();
            this.helpToolStripMenuItem=new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem=new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem=new System.Windows.Forms.ToolStripMenuItem();
            this.grdSubscriptions=new System.Windows.Forms.DataGridView();
            this.addFeedToolStripMenuItem=new System.Windows.Forms.ToolStripMenuItem();
            this.removeFeedToolStripMenuItem=new System.Windows.Forms.ToolStripMenuItem();
            this.mnuOptionBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdSubscriptions)).BeginInit();
            this.SuspendLayout();
            // 
            // trvSideNav
            // 
            this.trvSideNav.Dock=System.Windows.Forms.DockStyle.Left;
            this.trvSideNav.Location=new System.Drawing.Point(0, 24);
            this.trvSideNav.Name="trvSideNav";
            treeNode13.Name="nodAll";
            treeNode13.Text="All";
            treeNode14.Name="nodNew";
            treeNode14.Text="New";
            treeNode15.Name="nodCatagory";
            treeNode15.Text="Catagory";
            treeNode16.Name="nodSubs";
            treeNode16.Text="Subscriptions";
            this.trvSideNav.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode13,
            treeNode14,
            treeNode15,
            treeNode16});
            this.trvSideNav.Size=new System.Drawing.Size(121, 338);
            this.trvSideNav.TabIndex=1;
            // 
            // mnuOptionBar
            // 
            this.mnuOptionBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.editToolStripMenuItem});
            this.mnuOptionBar.Location=new System.Drawing.Point(0, 0);
            this.mnuOptionBar.Name="mnuOptionBar";
            this.mnuOptionBar.RenderMode=System.Windows.Forms.ToolStripRenderMode.Professional;
            this.mnuOptionBar.RightToLeft=System.Windows.Forms.RightToLeft.Yes;
            this.mnuOptionBar.Size=new System.Drawing.Size(784, 24);
            this.mnuOptionBar.TabIndex=3;
            this.mnuOptionBar.Text="menuStrip1";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name="helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size=new System.Drawing.Size(52, 20);
            this.helpToolStripMenuItem.Text="About";
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addFeedToolStripMenuItem,
            this.removeFeedToolStripMenuItem});
            this.viewToolStripMenuItem.Name="viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size=new System.Drawing.Size(61, 20);
            this.viewToolStripMenuItem.Text="Settings";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name="editToolStripMenuItem";
            this.editToolStripMenuItem.Size=new System.Drawing.Size(101, 20);
            this.editToolStripMenuItem.Text="Mark all as read";
            // 
            // grdSubscriptions
            // 
            this.grdSubscriptions.ColumnHeadersHeightSizeMode=System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdSubscriptions.Dock=System.Windows.Forms.DockStyle.Fill;
            this.grdSubscriptions.Location=new System.Drawing.Point(121, 24);
            this.grdSubscriptions.Name="grdSubscriptions";
            this.grdSubscriptions.Size=new System.Drawing.Size(663, 338);
            this.grdSubscriptions.TabIndex=4;
            // 
            // addFeedToolStripMenuItem
            // 
            this.addFeedToolStripMenuItem.Name="addFeedToolStripMenuItem";
            this.addFeedToolStripMenuItem.Size=new System.Drawing.Size(152, 22);
            this.addFeedToolStripMenuItem.Text="Add Feed";
            this.addFeedToolStripMenuItem.Click+=new System.EventHandler(this.addFeedToolStripMenuItem_Click);
            // 
            // removeFeedToolStripMenuItem
            // 
            this.removeFeedToolStripMenuItem.Name="removeFeedToolStripMenuItem";
            this.removeFeedToolStripMenuItem.Size=new System.Drawing.Size(152, 22);
            this.removeFeedToolStripMenuItem.Text="Remove Feed";
            this.removeFeedToolStripMenuItem.Click+=new System.EventHandler(this.removeFeedToolStripMenuItem_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions=new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode=System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize=new System.Drawing.Size(784, 362);
            this.Controls.Add(this.grdSubscriptions);
            this.Controls.Add(this.trvSideNav);
            this.Controls.Add(this.mnuOptionBar);
            this.MainMenuStrip=this.mnuOptionBar;
            this.MinimumSize=new System.Drawing.Size(800, 400);
            this.Name="Main";
            this.Text="Simple Rss reader";
            this.mnuOptionBar.ResumeLayout(false);
            this.mnuOptionBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdSubscriptions)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TreeView trvSideNav;
        private System.Windows.Forms.MenuStrip mnuOptionBar;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.DataGridView grdSubscriptions;
        private System.Windows.Forms.ToolStripMenuItem addFeedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeFeedToolStripMenuItem;
    }
}

