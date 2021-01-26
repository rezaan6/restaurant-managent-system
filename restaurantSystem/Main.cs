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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void Main_Load(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Inventory inventory = new Inventory();
            inventory.Show();
        }

        private void order_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Order order = new Order();
            order.Show();
        }

        private void user_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Users users = new Users();
            users.Show();
        }

        private void payment_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Payment payment = new Payment();
            payment.Show();
        }

        private void sales_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Sales sales = new Sales();
            sales.Show();
        }

        private void inbox_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Inbox inbox = new Inbox();
            inbox.Show();
        }

        private void logout_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            User user = new User();
            user.Show();
        }
    }
}
