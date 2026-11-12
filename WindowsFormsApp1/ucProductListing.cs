using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// kv
namespace WindowsFormsApp1
{
    public partial class ucProductListing : UserControl
    {
        public ucProductListing()
        {
            InitializeComponent();
        }

        string[] units = { "Piece", "Box", "Kilogram" };

        List<string> shoppinglist = new List<string>();

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ucProductListing_Load(object sender, EventArgs e)
        {
            cmb_unit.Items.AddRange(units);
            cmb_unit.SelectedIndex = 0;

            listBox_items.DataSource = shoppinglist;
        }

        private void updateGUI()
        {
            listBox_items.DataSource = null;
            listBox_items.DataSource = shoppinglist;
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            string item = txtBox_description.Text;
            double amount = double.Parse(txtBox_amount.Text);
            string unit = cmb_unit.SelectedText?.ToString();

            if (!string.IsNullOrEmpty(unit) && !string.IsNullOrEmpty(item) &&
                !string.IsNullOrEmpty(amount.ToString()))
            {
                string row = $"{item}\t\t{amount}{unit}";
                shoppinglist.Add(row);
                updateGUI();

                MessageBox.Show("Item Added");
                txtBox_amount.Clear();
                txtBox_description.Clear();
                cmb_unit.Refresh();
                txtBox_description.Focus();
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            int index = listBox_items.SelectedIndex;
            if (index != -1)

            {
                DialogResult deleteMessage = MessageBox.Show("Are you sure you want to " +
                    "delete?", "Delete Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                MessageBox.Show(shoppinglist[index] + "deleted.");

                shoppinglist.RemoveAt(index);
                updateGUI();
            }
            else
            {
                lbl_prompt.Text = "Please select an item to delete";
                lbl_prompt.Visible = true;
            }
        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult userResponse = MessageBox.Show("Are you about to exit?",
                "Exit Confirmation?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (userResponse == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void lstBox_items_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbl_prompt.Text = "";
            lbl_prompt.Visible = false;
        }

        private void txtBox_description_TextChanged(object sender, EventArgs e)
        {

        }

        private void pnl_content_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtBox_amount_TextChanged(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }


        private void ShopToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void grpBox_ItemDetails_Enter(object sender, EventArgs e)
        {

        }

        private void shopToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbl_prompt.Text = "";
            lbl_prompt.Visible = false;
        }
    }
}
