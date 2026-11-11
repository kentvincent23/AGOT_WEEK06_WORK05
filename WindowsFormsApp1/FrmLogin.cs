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
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void FrmInventory_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void lbl_title_Click(object sender, EventArgs e)
        {

        }

        private void txtBox_username_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            if (txtBox_username.Text == "admin" && txtBox_password.Text == "1234")
            {
                MessageBox.Show(
                    "Login Successfully",
                    "Success!");
                var inventoryForm = new FrmInventory();
                inventoryForm.Show();
                this.Hide();
            } 
            else
            {
                MessageBox.Show("Invalid ni dong");
            }
        }
    }
}

