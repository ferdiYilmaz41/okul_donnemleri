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


namespace NesneLabDeneme1
{
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }

        private void Form9_Load(object sender, EventArgs e)
        {
            
            SqlConnection connection = new SqlConnection("Data Source=myFirtsDB.mssql.somee.com;Initial Catalog=myFirtsDB;Persist Security Info=True;User ID=kacarberke_SQLLogin_1;Password=vgb5g6e8cb");
            if (connection.State == ConnectionState.Closed)
            {
               
            }

            connection.Open();

           
            SqlCommand command = new SqlCommand("Select * from puanTablosu", connection);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(command);
            

            DataTable table = new DataTable();
            sqlDataAdapter.Fill(table);

            dataGridView1.DataSource = table;
            connection.Close(); 
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
