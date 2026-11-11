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

            lstBox_items.DataSource = shoppinglist;
        }

        private void updateGUI()
        {
            lstBox_items.DataSource = null;
            lstBox_items.DataSource = shoppinglist;
        }
        private void btn_add_Click(object sender, EventArgs e)
        {
            string item = txtBox_description.Text;
            double amount = double.Parse(txtBox_amount.Text);
            string unit = cmb_unit.SelectedText.ToString();

            if (!string.IsNullOrEmpty(unit) && !string.IsNullOrEmpty(item) && !
                string.IsNullOrEmpty(amount.ToString()))
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
    }
}
