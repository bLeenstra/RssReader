namespace RssReader {
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("All");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("New");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Catagory");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Subscriptions");
            this.trvSideNav = new System.Windows.Forms.TreeView();
            this.grdFeeds = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.grdFeeds)).BeginInit();
            this.SuspendLayout();
            // 
            // trvSideNav
            // 
            this.trvSideNav.Dock = System.Windows.Forms.DockStyle.Left;
            this.trvSideNav.Location = new System.Drawing.Point(0, 0);
            this.trvSideNav.Name = "trvSideNav";
            treeNode1.Name = "nodAll";
            treeNode1.Text = "All";
            treeNode2.Name = "nodNew";
            treeNode2.Text = "New";
            treeNode3.Name = "nodCatagory";
            treeNode3.Text = "Catagory";
            treeNode4.Name = "nodSubs";
            treeNode4.Text = "Subscriptions";
            this.trvSideNav.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4});
            this.trvSideNav.Size = new System.Drawing.Size(121, 433);
            this.trvSideNav.TabIndex = 1;
            // 
            // grdFeeds
            // 
            this.grdFeeds.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdFeeds.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdFeeds.Location = new System.Drawing.Point(121, 0);
            this.grdFeeds.Name = "grdFeeds";
            this.grdFeeds.Size = new System.Drawing.Size(683, 433);
            this.grdFeeds.TabIndex = 2;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 433);
            this.Controls.Add(this.grdFeeds);
            this.Controls.Add(this.trvSideNav);
            this.Name = "Main";
            this.Text = "Simple Rss reader";
            ((System.ComponentModel.ISupportInitialize)(this.grdFeeds)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TreeView trvSideNav;
        private System.Windows.Forms.DataGridView grdFeeds;
    }
}

