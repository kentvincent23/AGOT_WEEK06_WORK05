using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class FrmInventory : Form
    {
        public FrmInventory()
        {
            InitializeComponent();
        }
        private void ShowPage(UserControl page)
        {
            pnl_content.Controls.Clear();
            page.Dock = DockStyle.Fill;
            pnl_content.Controls.Add(page);
        }
        private void btn_logout_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void inventoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void aboutUsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void testToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowPage(new ucProductListing());
        }
    }
}
