using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;

namespace RTU_EVENTS_MANAGEMENT_SYSTEM
{
    public partial class login_signup : Form
    {
        public login_signup()
        {
            InitializeComponent();
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void signup_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void accountBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.accountBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.accDatabaseDataSet);

        }

        private void accountBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.accountBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.accDatabaseDataSet);

        }

        private void accountBindingNavigatorSaveItem_Click_2(object sender, EventArgs e)
        {
            this.Validate();
            this.accountBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.accDatabaseDataSet);

        }

        private void login_signup_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'accDatabaseDataSet.Account' table. You can move, or remove it, as needed.
            this.accountTableAdapter.Fill(this.accDatabaseDataSet.Account);

        }

        private void label6_Click(object sender, EventArgs e)
        {
            new login().Show();
         

            this.Hide();
        }
    }
}
