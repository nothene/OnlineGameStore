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

namespace OnlineGameStore
{
    public partial class Index : Form
    {
        public Index()
        {
            InitializeComponent();
        }

        private void Index_Load(object sender, EventArgs e)
        {
            close.FlatAppearance.BorderSize = 0;
            account.FlatAppearance.BorderSize = 0;

            SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-P8ASE2D\SQLEXPRESS; Database=OnlineGameStore; Integrated Security=SSPI;");

            String query = @"Select count(*) From Account";
            String num = "";

            SqlCommand command = new SqlCommand(query, connection);

            connection.Open();
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                num = reader[0].ToString();
            }

            reader.Close();
            command.Dispose();
            connection.Close();

            label8.Text = num;
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

        }

        private void Close_MouseHover(object sender, EventArgs e)
        {
            close.BackColor = Color.Red;
            close.ForeColor = Color.Black;
        }

        private void Close_MouseLeave(object sender, EventArgs e)
        {
            close.BackColor = Color.DarkSlateBlue;
            close.ForeColor = Color.White;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
