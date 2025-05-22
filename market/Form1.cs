using AForge.Video;
using AForge.Video.DirectShow;
using aKyzMarket.Pages;
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

namespace aKyzMarket
{
    public partial class Form1 : Form
    {
        String connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Market;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        public Form1()
        {
            InitializeComponent();
        }
        FilterInfoCollection filterInfoCollection;
        VideoCaptureDevice videoCaptureDevice;
        private void Form1_Load(object sender, EventArgs e)
        {
            filterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo device in filterInfoCollection)
                comboBox1.Items.Add(device.Name);
            comboBox1.SelectedIndex = 0;

            List();
        
            dateLAB.Text = DateTime.Now.ToShortDateString();
        }

        public void List()
        {
            SqlConnection connection = new SqlConnection(connectionString);
            SqlDataAdapter sda = new SqlDataAdapter("Select * From Products", connection);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            productsDGV.DataSource = ds.Tables[0];
        }

        public void okButton()
        {
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            SqlCommand command = new SqlCommand("insert into Sold (Barcode, Date)values('" + productBarcod.Text + "', '" + dateLAB.Text + "')", connection);
            command.ExecuteNonQuery();
            connection.Close();
        }

        private void startBTN_Click(object sender, EventArgs e)
        {
            videoCaptureDevice = new VideoCaptureDevice(filterInfoCollection[comboBox1.SelectedIndex].MonikerString);
            videoCaptureDevice.NewFrame += VideoCaptureDevice_NewFrame;
            videoCaptureDevice.Start();
        }

        private void VideoCaptureDevice_NewFrame(object sender, AForge.Video.NewFrameEventArgs eventArgs)
        {
            Bitmap bitmap = (Bitmap)eventArgs.Frame.Clone();
            BarcodeReader reader = new BarcodeReader();
            var result = reader.Decode(bitmap);
            if (result != null)
            {
                productBarcod.Invoke(new MethodInvoker(delegate ()
                {
                    productBarcod.Text = result.ToString();
                }));
            }
            pictureBox1.Image = bitmap;
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            if(videoCaptureDevice != null)
            {
                if (videoCaptureDevice.IsRunning)
                    videoCaptureDevice.Stop();
            }
        }

        private void newProduct_Click(object sender, EventArgs e)
        {
            NewP newP = new NewP();
            newP.Show();
        }

        private void BarcodeMS_Click(object sender, EventArgs e)
        {
            BarcodePage page = new BarcodePage();
            page.Show();
        }

        private void okBTN_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            SqlDataAdapter sda = new SqlDataAdapter("select * from Products where Barcode like '" + productBarcod.Text + "'", connection);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            orderDGV.DataSource = ds.Tables[0];
            okButton();
            productBarcod.Clear();
        }

        private void xBTN_Click(object sender, EventArgs e)
        {
            productBarcod.Clear();
        }

        private void confirmBTN_Click(object sender, EventArgs e)
        {
            productBarcod.Clear();
            orderDGV.Rows.Clear();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void soldToday_Click(object sender, EventArgs e)
        {
            SoldTodayPage sold = new SoldTodayPage();
            sold.Show();
        }

        private void stopBTN_Click(object sender, EventArgs e)
        {
            if (videoCaptureDevice.IsRunning)
                videoCaptureDevice.Stop();
        }
    }
}
