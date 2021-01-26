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
    public partial class AddPayment : Form
    {
        public AddPayment()
        {
            InitializeComponent();
        }

        private void addpayment_btn_Click(object sender, EventArgs e)
        {
            DB db = new DB();
            db.openConnection();
            MySqlCommand command = new MySqlCommand("INSERT INTO `payments`(`method`, `total_amount`, `balance`, `time`) VALUES (@method, @total, @balance, @time)", db.getConnection());

            command.Parameters.Add("@method", MySqlDbType.VarChar).Value = ap_comboBox.Text;
            command.Parameters.Add("@total", MySqlDbType.VarChar).Value = ap_total.Text;
            command.Parameters.Add("@balance", MySqlDbType.VarChar).Value = ap_balance.Text;
            command.Parameters.Add("@time", MySqlDbType.VarChar).Value = ap_timestamp.Text;

            command.ExecuteNonQuery();

            this.Hide();
            Payment payment = new Payment();
            payment.Show();

            MessageBox.Show("Item Added Successfully", "Added Item", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);

        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Payment payment = new Payment();
            payment.Show();
        }

        private void ap_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.BeginInvoke(new Action(() => { ap_comboBox.Select(0, 0); }));
        }

        private void ap_timestamp_Enter(object sender, EventArgs e)
        {
            string timestamp = ap_timestamp.Text;
            if (timestamp.ToLower().Trim().Equals("e.g. 2020-10-10 18:29:13"))
            {
                ap_timestamp.Text = "";              
                ap_timestamp.ForeColor = Color.Black;



            }
        }

        private void ap_timestamp_Leave(object sender, EventArgs e)
        {
            string timestamp = ap_timestamp.Text;
            if (timestamp.ToLower().Trim().Equals("e.g. 2020-10-10 18:29:13") ||
                timestamp.Trim().Equals(""))
            {
                ap_timestamp.Text = "e.g. 2020-10-10 18:29:13";               
                ap_timestamp.ForeColor = Color.Gray;



            }
        }
    }
}
