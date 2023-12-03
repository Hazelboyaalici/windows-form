using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;



namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=TeknolojikAletlerDB;Integrated Security=True");
        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'teknolojikAletlerDBDataSet.telefon' table. You can move, or remove it, as needed.
            this.telefonTableAdapter.Fill(this.teknolojikAletlerDBDataSet.telefon);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand komut=new SqlCommand();
            komut.CommandText = "SELECT * FROM telefon";
            komut.Connection = baglanti;

            SqlDataAdapter adap = new SqlDataAdapter(komut);
            DataTable tablo = new DataTable();

            adap.Fill(tablo);
            dataGridView1.DataSource = tablo;


                }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
    }
}
