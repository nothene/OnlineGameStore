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
using System.Globalization;

namespace OnlineGameStore
{
    public partial class Index : Form
    {
        public Index()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void Index_Load(object sender, EventArgs e)
        {

            SqlConnection connection = new SqlConnection(@"Data Source=LAPTOP-FC8BFOQ9\SQLEXPRESS; Database=OnlineGameStore; Integrated Security=SSPI;");

            String query = @"Select count(*) From Account";
            String query1 = "Select count(*) From Games";
            String query2 = "Select count(*) From Purchase";
            String num = "";

            SqlCommand command = new SqlCommand(query, connection);

            connection.Open();
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                label8.Text = reader[0].ToString();
            }

            reader.Close();

            command = new SqlCommand(query1, connection);
            reader = command.ExecuteReader();

            while (reader.Read())
            {
                label7.Text = reader[0].ToString();   
            }

            reader.Close();

            command = new SqlCommand(query2, connection);
            reader = command.ExecuteReader();

            while (reader.Read())
            {
                label12.Text = reader[0].ToString();
            }

            reader.Close();
            command.Dispose();
            connection.Close();
        }

        private void Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Account_Click(object sender, EventArgs e)
        {
            this.Close();
            Account account = new Account();
            account.Show();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Games games = new Games();
            games.Show();
            this.Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Purchase purchase = new Purchase();
            purchase.Show();
            this.Close();
        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void Label8_Click(object sender, EventArgs e)
        {

        }

        private void Label1_Click_1(object sender, EventArgs e)
        {

        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            DateTime date = DateTime.Now;
            this.label10.Text = date.ToString("G", CultureInfo.CreateSpecificCulture("es-ES"));
        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }
    }
}
