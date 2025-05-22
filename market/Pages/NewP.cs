using BarcodeLib;
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
    public partial class NewP : Form
    {
        public NewP()
        {
            InitializeComponent();
        }
        String connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Market;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        public void List()
        {
            SqlConnection connection = new SqlConnection(connectionString);
            SqlDataAdapter sda = new SqlDataAdapter("Select * From Products", connection);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void NewP_Load(object sender, EventArgs e)
        {
            List();
            SqlConnection connection = new SqlConnection(connectionString);
            SqlDataAdapter sda = new SqlDataAdapter("Select * From CategoryTable", connection);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            dataGridView2.DataSource = ds.Tables[0];
        }

        private void insertBTN_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            SqlCommand command = new SqlCommand("insert into Products (Barcode, Name, Price, Category)VALUES('" + barcodeTXT.Text+"', '"+nameTXT.Text+"', '"+priceTXT.Text+"', '"+categoryTXT.Text+"')", connection);
            command.ExecuteNonQuery();
            connection.Close();
            List();
        }

        private void updateBTN_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            SqlCommand command = new SqlCommand("update Products set Barcode=@b, Name=@n, Price=@p, Category=@c where Id=@i", connection);
            command.Parameters.AddWithValue("@i", idTXT.Text);
            command.Parameters.AddWithValue("@b", barcodeTXT.Text);
            command.Parameters.AddWithValue("@n", nameTXT.Text);
            command.Parameters.AddWithValue("@p", priceTXT.Text);
            command.Parameters.AddWithValue("@c", categoryTXT.Text);
            command.ExecuteNonQuery();
            connection.Close();
            List();
        }

        private void deleteBTN_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            SqlCommand command = new SqlCommand("delete Products where Id='" + idTXT.Text+"'", connection);
            command.ExecuteNonQuery();
            connection.Close();
            List();
        }

        private void gnrtBTN_Click(object sender, EventArgs e)
        {
            BarcodeWriter writer = new BarcodeWriter()
            {
                Format = BarcodeFormat.CODE_128
            };
            pictureBox.Image = writer.Write(barcodeTXT.Text);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int selected = e.RowIndex;
            DataGridViewRow selectedRow = dataGridView1.Rows[selected];
            idTXT.Text = selectedRow.Cells[0].Value.ToString();
            barcodeTXT.Text = selectedRow.Cells[1].Value.ToString();
            nameTXT.Text = selectedRow.Cells[2].Value.ToString();
            priceTXT.Text = selectedRow.Cells[3].Value.ToString();
            categoryTXT.Text = selectedRow.Cells[4].Value.ToString();
        }
    }
}
