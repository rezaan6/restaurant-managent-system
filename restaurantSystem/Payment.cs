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
    public partial class Payment : Form
    {
        public Payment()
        {
            InitializeComponent();
        }

        private void back_btn_Click(object sender, EventArgs e)
        {

            this.Hide();
            Main main = new Main();
            main.Show();
        }

        private void p_add_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddPayment addPayment = new AddPayment();
            addPayment.Show();
        }

        private void Payment_Load(object sender, EventArgs e)
        {
            payment_table.DataSource = paymentlist();
        }

        private DataTable paymentlist()
        {
            DB db = new DB();
            DataTable table = new DataTable();
            MySqlCommand command = new MySqlCommand("SELECT * FROM payments", db.getConnection());

            db.openConnection();

            MySqlDataReader rdr = command.ExecuteReader();

            table.Load(rdr);

            return table;
        }

        private void p_remove_Click(object sender, EventArgs e)
        {
            string idLocRemv = payment_table.SelectedRows[0].Cells[0].Value.ToString();

            DB db = new DB();
            DataTable table = new DataTable();

            db.openConnection();

            MySqlCommand command = new MySqlCommand("DELETE FROM payments WHERE id = " + idLocRemv, db.getConnection());

            MySqlDataReader rdr = command.ExecuteReader();

            table.Load(rdr);

            this.Hide();
            Payment payment = new Payment();
            payment.Show();

            MessageBox.Show("Row with ID " + idLocRemv + "  got removed.", "Removed Row", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
