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
    public partial class Salary : Form
    {
        public Salary()
        {
            InitializeComponent();
        }

        private void back_btn_Click(object sender, EventArgs e)
        {




            if (Global.UserID.Trim().Equals("Admin"))
            {

                this.Hide();
                Main main = new Main();
                main.Show();


            }

            else if (Global.UserID.Trim().Equals("Cashier"))
            {

                this.Hide();
                Cashier cashier = new Cashier();
                cashier.Show();


            }

            else if (Global.UserID.Trim().Equals("Rider"))
            {

                this.Hide();
                Rider rider = new Rider();
                rider.Show();


            }

            else if (Global.UserID.Trim().Equals("Waiter"))
            {


                this.Hide();
                Waiter waiter = new Waiter();
                waiter.Show();

            }

            else if (Global.UserID.Trim().Equals("Chef"))
            {


                this.Hide();
                Chef chef = new Chef();
                chef.Show();



            }
        }
    }
}
