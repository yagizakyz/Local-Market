using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aKyzMarket.Pages
{
    public partial class SoldTodayPage : Form
    {
        public SoldTodayPage()
        {
            InitializeComponent();
        }
        String connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Market;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        private void showBTN_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            SqlDataAdapter sda = new SqlDataAdapter("select * from Sold where Date like '" + maskedTextBox1.Text + "'", connection);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void SoldTodayPage_Load(object sender, EventArgs e)
        {
            dateLAB.Text = DateTime.Now.ToShortDateString();
            SqlConnection connection = new SqlConnection(connectionString);
            SqlDataAdapter sda = new SqlDataAdapter("select * from Sold where Date like '" + dateLAB.Text + "'", connection);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }
    }
}
