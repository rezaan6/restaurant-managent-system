
using MySql.Data.MySqlClient;
using Sitecore.FakeDb;
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
    

    public partial class User : Form
    { 
                MySqlConnection connection = new MySqlConnection("server=localhost;port=3308;username=root;password=;database=restaurant");

        

        public User()
        {
            InitializeComponent();
            this.txtPassword.AutoSize = false;
            this.txtPassword.Size = new Size(this.txtPassword.Size.Width, 20);
           
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            DB db = new DB();

            String username = txtUsername.Text;
            String password = txtPassword.Text;

            Global.Gusername = txtUsername.Text.ToString();
            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE  username = @usn and password = @pass", db.getConnection());

            command.Parameters.Add("@usn", MySqlDbType.VarChar).Value = username;
            command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = password;

            adapter.SelectCommand = command;

            adapter.Fill(table);

            //check if the user exists or not
            if (table.Rows.Count > 0)
            {
               string type = comboBox1.Text;
                Global.UserID = comboBox1.Text.ToString();
                if (type.Trim().Equals("Admin"))
                {

                    this.Hide();
                    Main main = new Main();
                    main.Show();


                }

                else if (type.Trim().Equals("Cashier"))
                {

                    this.Hide();
                    Cashier cashier = new Cashier();
                    cashier.Show();


                }

                else if (type.Trim().Equals("Chef"))
                {

                    this.Hide();
                    Chef chef = new Chef();
                    chef.Show();

                  




                }

                else if (type.Trim().Equals("Rider"))
                {

                    this.Hide();
                    Rider rider = new Rider();
                    rider.Show();


                }

                else if (type.Trim().Equals("Waiter"))
                {

                    this.Hide();
                    Waiter waiter = new Waiter();
                    waiter.Show();


                }

                else {
                    MessageBox.Show("Select a Type", "Empty Type", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

            }
            else
            {

                if (username.Trim().Equals(""))
                {


                    MessageBox.Show("Enter Your Username to Login", "Empty Username", MessageBoxButtons.OK, MessageBoxIcon.Error);


                }

                else if (password.Trim().Equals(""))
                {


                    MessageBox.Show("Enter Your Password to Login", "Empty Password", MessageBoxButtons.OK, MessageBoxIcon.Error);


                }

                else
                {

                    MessageBox.Show("Wrong Username or Password", "Wrong Data", MessageBoxButtons.OK, MessageBoxIcon.Error);


                }

            }
        }

        private void labelGoToSignUp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            RegisterForm registerform = new RegisterForm();
            registerform.Show();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void comboBox1_Enter(object sender, EventArgs e)
        {

            //        comboBox1.SelectedText.
            comboBox1.ForeColor = Color.Black;

        }

        private void comboBox1_Leave(object sender, EventArgs e)
        {

            comboBox1.SelectionLength = 0;


                comboBox1.ForeColor = Color.Black;

           
        }

        private void comboBox1_MouseClick(object sender, MouseEventArgs e)
        {
           // MessageBox.Show(comboBox1.SelectedText, "Account Created", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.BeginInvoke(new Action(() => { comboBox1.Select(0, 0); }));
        
        }

        private void comboBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
           // MessageBox.Show(comboBox1.SelectedText, "Account Created", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void comboBox1_DropDownClosed(object sender, EventArgs e)
        {
            this.BeginInvoke(new Action(() => { comboBox1.Select(0, 0); }));
        }

        private void comboBox1_DropDownStyleChanged(object sender, EventArgs e)
        {
       //     MessageBox.Show(comboBox1.SelectedText, "Account Created", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void User_Load(object sender, EventArgs e)
        {

        }
    }
}
