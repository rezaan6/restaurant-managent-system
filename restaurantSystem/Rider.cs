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
    public partial class Rider : Form
    {
        public Rider()
        {
            InitializeComponent();

        }


        private void delivery_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Delivery delivery = new Delivery();
            delivery.Show();
        }

        private void menu_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu menu = new Menu();
            menu.Show();
        }

        private void salary_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Salary salary = new Salary();
            salary.Show();
        }

        private void info_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Info info = new Info();
            info.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
            
            


           
           
        }

        private void usernametxt_TextChanged(object sender, EventArgs e)
        {
           

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            this.BeginInvoke(new Action(() => {textBox4.Select(0, 0); }));
        }

        private void logout_btn_Click(object sender, EventArgs e)
        {
          
        }

        private void logout_btn_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            User user = new User();
            user.Show();
        }
    }
}
