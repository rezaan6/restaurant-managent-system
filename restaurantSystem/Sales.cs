using LiveCharts;
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
    public partial class Sales : Form
    {
        public Sales()
        {
            InitializeComponent();
        }

        private void back_btn_Click(object sender, EventArgs e)
        {

            this.Hide();
            Main main = new Main();
            main.Show();
        }

       

        private void Sales_Load(object sender, EventArgs e)
        {
            sales_table.DataSource = saleslist();
            chart1.DataSource = saleslist();


/*



            DB db = new DB();

           

            int v = 0;
            MySqlCommand command = new MySqlCommand("SELECT year FROM sales where id =" +v+"", db.getConnection());

            db.openConnection();

            MySqlDataReader rdr = command.ExecuteReader();


            v.Load(rdr);

            MessageBox.Show(+rdr+, "test", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);

            */








            this.chart1.Series["Sales"].Points.AddXY("2018", 34905);
            this.chart1.Series["Sales"].Points.AddXY("2019", 43899);



        }

        private DataTable saleslist()
        {
            DB db = new DB();

            DataTable table = new DataTable();

            MySqlCommand command = new MySqlCommand("SELECT * FROM sales", db.getConnection());

            db.openConnection();

            MySqlDataReader rdr = command.ExecuteReader();

            table.Load(rdr);
            

            return table;
        }

        private void pieChart1_ChildChanged(object sender, System.Windows.Forms.Integration.ChildChangedEventArgs e)
        {

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }
    }
}
