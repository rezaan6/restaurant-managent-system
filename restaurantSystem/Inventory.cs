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
    public partial class Inventory : Form
    {
        public Inventory()
        {
            InitializeComponent();
        }

        private void back_btn_Click(object sender, EventArgs e)
        {

            this.Hide();
            Main main = new Main();
            main.Show();
        }

        private void item_table_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void removeitem_btn_Click(object sender, EventArgs e)
        {
            string idLocRemv = item_table.SelectedRows[0].Cells[0].Value.ToString();

            DB db = new DB();
            DataTable table = new DataTable();

            db.openConnection();

            MySqlCommand command = new MySqlCommand("DELETE FROM items WHERE id = " + idLocRemv, db.getConnection());

            MySqlDataReader rdr = command.ExecuteReader();

            table.Load(rdr);

            this.Hide();
            Inventory inventory = new Inventory();
            inventory.Show();

            MessageBox.Show("Row with ID " + idLocRemv + "  got removed.", "Removed Row", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void additem_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddItems addItems = new AddItems();
            addItems.Show();
        }

        private void Inventory_Load(object sender, EventArgs e)
        {
            item_table.DataSource = itemlist();
        }

        private DataTable itemlist()
        {
            DB db = new DB();

            DataTable table = new DataTable();

            MySqlCommand command = new MySqlCommand("SELECT * FROM items", db.getConnection());

            db.openConnection();

            MySqlDataReader rdr = command.ExecuteReader();

            table.Load(rdr);

            return table;
        }
    }
}
