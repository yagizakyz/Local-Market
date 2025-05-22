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
using ZXing;

namespace aKyzMarket.Pages
{
    public partial class BarcodePage : Form
    {
        public BarcodePage()
        {
            InitializeComponent();
        }
        String connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Market;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        public void Search()
        {
            SqlConnection connection = new SqlConnection(connectionString);
            SqlDataAdapter sda = new SqlDataAdapter("select * from Products where Barcode like '" + textBox1.Text + "'", connection);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void okBTN_Click(object sender, EventArgs e)
        {
            BarcodeWriter writer = new BarcodeWriter()
            {
                Format = BarcodeFormat.CODE_128
            };
            pictureBox1.Image = writer.Write(textBox1.Text);
            Search();
        }
    }
}
