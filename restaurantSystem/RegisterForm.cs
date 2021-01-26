using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace restaurantSystem
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {


        }

        private void textBoxFirstName_Enter(object sender, EventArgs e)
        {
            string fname = textBoxFirstName.Text;
            if (fname.ToLower().Trim().Equals("first name"))
            {
                textBoxFirstName.Text = "";
                textBoxFirstName.ForeColor = Color.Black;



            }
        }

        private void textBoxFirstName_Leave(object sender, EventArgs e)
        {
            string fname = textBoxFirstName.Text;
            if (fname.ToLower().Trim().Equals("first name") || fname.Trim().Equals(""))
            {
                textBoxFirstName.Text = "first name";
                textBoxFirstName.ForeColor = Color.Gray;

            }

        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {
            // remove the focus from the textboxes

        }

        private void textBoxLastname_Enter(object sender, EventArgs e)
        {
            string lname = textBoxLastname.Text;
            if (lname.ToLower().Trim().Equals("last name"))
            {
                textBoxLastname.Text = "";
                textBoxLastname.ForeColor = Color.Black;



            }
        }

        private void textBoxLastname_Leave(object sender, EventArgs e)
        {
            string lname = textBoxLastname.Text;
            if (lname.ToLower().Trim().Equals("last name") || lname.Trim().Equals(""))
            {
                textBoxLastname.Text = "last name";
                textBoxLastname.ForeColor = Color.Gray;

            }

        }

        private void textBoxEmail_Enter(object sender, EventArgs e)
        {
            string email = textBoxEmail.Text;
            if (email.ToLower().Trim().Equals("email address"))
            {
                textBoxEmail.Text = "";
                textBoxEmail.ForeColor = Color.Black;



            }
        }

        private void textBoxEmail_Leave(object sender, EventArgs e)
        {
            string email = textBoxEmail.Text;
            if (email.ToLower().Trim().Equals("email address") || email.Trim().Equals(""))
            {
                textBoxEmail.Text = "email address";
                textBoxEmail.ForeColor = Color.Gray;

            }
        }

        private void txtUsername_Enter(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            if (username.ToLower().Trim().Equals("username"))
            {
                txtUsername.Text = "";
                txtUsername.ForeColor = Color.Black;



            }
        }

        private void txtUsername_Leave(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            if (username.ToLower().Trim().Equals("username") || username.Trim().Equals(""))
            {
                txtUsername.Text = "username";
                txtUsername.ForeColor = Color.Gray;

            }
        }

        private void textpassword_Enter(object sender, EventArgs e)
        {
            string password = textpassword.Text;
            if (password.ToLower().Trim().Equals("password"))
            {
                textpassword.Text = "";
                textpassword.UseSystemPasswordChar = true;
                textpassword.ForeColor = Color.Black;



            }
        }

        private void textpassword_Leave(object sender, EventArgs e)
        {
            string password = textpassword.Text;
            if (password.ToLower().Trim().Equals("password") || password.Trim().Equals(""))
            {
                textpassword.Text = "password";
                textpassword.UseSystemPasswordChar = true;
                textpassword.ForeColor = Color.Gray;

            }
        }

        private void textBoxPasswordConfirm_Enter(object sender, EventArgs e)
        {
            string cpassword = textBoxPasswordConfirm.Text;
            if (cpassword.ToLower().Trim().Equals("confirm password"))
            {
                textBoxPasswordConfirm.Text = "";
                textBoxPasswordConfirm.UseSystemPasswordChar = true;
                textBoxPasswordConfirm.ForeColor = Color.Black;



            }
        }

        private void textBoxPasswordConfirm_Leave(object sender, EventArgs e)
        {
            string cpassword = textBoxPasswordConfirm.Text;
            if (cpassword.ToLower().Trim().Equals("confirm password") ||
                cpassword.ToLower().Trim().Equals("password") ||
                cpassword.Trim().Equals(""))
            {
                textBoxPasswordConfirm.Text = "confirm password";
                textBoxPasswordConfirm.UseSystemPasswordChar = true;
                textBoxPasswordConfirm.ForeColor = Color.Gray;

            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //add a new user

            DB db = new DB();
            MySqlCommand command = new MySqlCommand("INSERT INTO `users`(`firstname`, `lastname`, `emailaddress`, `username`, `password`) VALUES (@fn, @ln, @email, @usn, @pass)", db.getConnection());

            command.Parameters.Add("@fn", MySqlDbType.VarChar).Value = textBoxFirstName.Text;
            command.Parameters.Add("@ln", MySqlDbType.VarChar).Value = textBoxLastname.Text;
            command.Parameters.Add("@email", MySqlDbType.VarChar).Value = textBoxEmail.Text;
            command.Parameters.Add("@usn", MySqlDbType.VarChar).Value = txtUsername.Text;
            command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = textpassword.Text;


            //open connection
            db.openConnection();

            if (!checkTextBoxesValues())
            {



                //check if password matched the confirm password
                if (textpassword.Text.Equals(textBoxPasswordConfirm.Text))
                {

                    //CHECK if username already exist
                    if (checkUsername())
                    {



                        MessageBox.Show("This Username already exist, select another username", "Duplicate Username", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                    }



                    else
                    {

                        //execute the query
                        if (command.ExecuteNonQuery() == 1)
                        {



                            this.Hide();
                            User user = new User();
                            user.Show();

                            MessageBox.Show("Your Acccount has been Created", "Account Created", MessageBoxButtons.OK, MessageBoxIcon.Information);


                        }

                        else
                        {

                            string message = "Error";
                            string title = "Title";
                            MessageBox.Show(message, title);


                        }


                    }
                }

                else
                {



                    MessageBox.Show("Wrong Confirmation Password", "Password Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);


                }

            }



            else
            {

                MessageBox.Show("Enter Your information first", "Empty Data", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }






            //close connection
            db.closeConnection();



        }


        //check if the username already exist

        public Boolean checkUsername()
        {

            DB db = new DB();

            String username = txtUsername.Text;


            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE  username = @usn", db.getConnection());

            command.Parameters.Add("@usn", MySqlDbType.VarChar).Value = username;


            adapter.SelectCommand = command;

            adapter.Fill(table);

            //check if this username already exists int the database
            if (table.Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }



        }

        //check if the textboxes contains the default values
        public Boolean checkTextBoxesValues()
        {


            String fname = textBoxFirstName.Text;
            String lname = textBoxLastname.Text;
            String email = textBoxEmail.Text;
            String uname = txtUsername.Text;
            String pass = textpassword.Text;



            if (fname.Equals("first name") || lname.Equals("last name") || email.Equals("email address")
                || uname.Equals("username") || pass.Equals("password"))
            {


                return true;



            }

            else
            {
                return false;
            }




        }

        private void textBoxLastname_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void textpassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxPasswordConfirm_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            User user = new User();
            user.Show();

        }
    }
}

