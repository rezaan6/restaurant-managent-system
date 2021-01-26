using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace restaurantSystem
{
    public partial class AddItems : Form
    {
        public AddItems()
        {
            InitializeComponent();
        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Inventory inventory = new Inventory();
            inventory.Show();
        }

        private void additem_btn_Click(object sender, EventArgs e)
        {
            
            DB db = new DB();
            db.openConnection();
            MySqlCommand command = new MySqlCommand("INSERT INTO `items`(`name`, `category`, `price_per_quantity`, `quantity`) VALUES (@n, @c, @pr, @q)", db.getConnection());

            command.Parameters.Add("@n", MySqlDbType.VarChar).Value = i_name.Text;
            command.Parameters.Add("@c", MySqlDbType.VarChar).Value = i_category.Text;
            command.Parameters.Add("@pr", MySqlDbType.VarChar).Value = i_price.Text;
            command.Parameters.Add("@q", MySqlDbType.VarChar).Value = i_quantity.Text;

            command.ExecuteNonQuery();

            this.Hide();
            Inventory inventory = new Inventory();
            inventory.Show();

            MessageBox.Show("Item Added Successfully", "Added Item", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);



            //open connection
          
        }
    }
}
