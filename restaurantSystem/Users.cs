using System.Data;
using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace restaurantSystem
{
    public partial class Users : Form
    {
        public Users()
        {
            InitializeComponent();


        }

        private void back_btn_Click(object sender, EventArgs e)
        {

            this.Hide();
            Main main = new Main();
            main.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //  DB db = new DB();
            //  DataTable table = new DataTable();
            /*
                        table.Columns.Add("Name");
                        table.Columns.Add("Color");


                        table.Rows.Add("Mike", "blue");
                        table.Rows.Add("Pat", "yellow");



                        MySqlDataAdapter adapter = new MySqlDataAdapter();
                        MySqlCommand command = new MySqlCommand("SELECT * FROM `users`", db.getConnection());
                        adapter.SelectCommand = command;
                        adapter.Fill(table);
                        dataGridView1.DataSource = table;*/
            /*
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


             */




            /*    String cmdtText = "SELECT * FROM `entry`";
                MySqlCommand cmde = new MySqlCommand(cmdtText, connection);
                MySqlDataAdapter da = new MySqlDataAdapter(cmde);
                DataSet ds = new DataSet();
                da.Fill(ds);
                dataGridView1.DataSource = ds;
                dataGridView1.DataBind();

                */

            /*
            
                        table.Columns.Add("ID", typeof(string));
                        table.Columns.Add("First Name", typeof(int));
                        table.Columns.Add("Last Name", typeof(string));
                        table.Columns.Add("email", typeof(string));
                        table.Columns.Add("username", typeof(string));
                        table.Columns.Add("password", typeof(string));



            
          
                        MySqlDataAdapter adapter = new MySqlDataAdapter();

                        MySqlCommand command = new MySqlCommand("SELECT * FROM `users`;", db.getConnection());



                        adapter.SelectCommand = command;

                        adapter.Fill(table);
                       

            */
            /*
            user_table.DataSource = table;
            */

            //  DB db = new DB();


            // DataTable table = new DataTable();

            //MySqlDataAdapter adapter = new MySqlDataAdapter();

            // MySqlCommand command = new MySqlCommand("SELECT * FROM users", db.getConnection());

            //    command.Parameters.Add("@usn", MySqlDbType.VarChar).Value = username;
            //command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = password;

            /*   for (int y = 0; y < 5; y++)

               {


                   adapter.SelectCommand = command;

                   adapter.Fill(table);
                   user_table.DataSource = table;
               }
            */

            /*  MySqlDataReader rdr = command.ExecuteReader();

               table.Load(rdr);



               */

            //  db.openConnection();


            // MySqlDataReader rdr = command.ExecuteReader();

            // table.Load(rdr);


            // user_table.Columns[0].Name = "column1";
        /*    DataTable dt = new DataTable();
            DataRow dr = dt.NewRow();
            dr["Column1"] = string.Empty;
            dt.Rows.Add(dr);


            user_table.Columns[0].Name = "column1";
            user_table.Columns[1].Name = "column2";

            string[] row1 = new string[] { "column1 value", "column2 value" };
            user_table.Rows.Add(row1);

            user_table.*/
        }

        private void Users_Load(object sender, EventArgs e)
        {
            user_table.DataSource = userlist();
        }

        private DataTable userlist() {


            DB db = new DB();

           
            DataTable table = new DataTable();

            

            MySqlCommand command = new MySqlCommand("SELECT * FROM users", db.getConnection());


            db.openConnection();


             MySqlDataReader rdr = command.ExecuteReader();

            table.Load(rdr);

            return table;
        }

        private void user_table_AllowUserToAddRowsChanged(object sender, EventArgs e)
        {

        }

        private void adduser_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddUsers addUsers = new AddUsers();
            addUsers.Show();
        }

        private void removeuser_btn_Click(object sender, EventArgs e)
        {
            string idLocRemv = user_table.SelectedRows[0].Cells[0].Value.ToString();




       

           // string removeVolCred = "DELETE FROM user WHERE id = " + idLocRemv;

           

            DB db = new DB();
            DataTable table = new DataTable();


            db.openConnection();


            MySqlCommand command = new MySqlCommand("DELETE FROM users WHERE id = " + idLocRemv, db.getConnection());


        


            MySqlDataReader rdr = command.ExecuteReader();

            table.Load(rdr);

            this.Hide();
            Users users = new Users();
            users.Show();

            MessageBox.Show("Row with ID "+idLocRemv+ "  got removed.", "Removed Row", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
