using System;
using System.Windows.Forms;

namespace RssReader.Forms {
    public partial class Main : Form {
        public Main() {
            InitializeComponent();
        }

        private void addFeedToolStripMenuItem_Click(object sender, EventArgs e) {
            AddFeed newForm = new AddFeed();
            newForm.ShowDialog(this);
        }

        private void removeFeedToolStripMenuItem_Click(object sender, EventArgs e) {
            RemoveFeed newForm = new RemoveFeed();
            newForm.ShowDialog(this );
        }
    }
}
