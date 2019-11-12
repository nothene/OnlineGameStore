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
    public partial class Games : Form
    {
        bool mouseDown;
        private Point last;
        public Games()
        {
            InitializeComponent();
        }

        private void Account_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            last = e.Location;
        }

        private void Account_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - last.X) + e.X, (this.Location.Y - last.Y) + e.Y);
                this.Update();
            }
        }

        private void Account_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void Load_Data()
        {
            SqlConnection connection = new SqlConnection(@"Data Source=LAPTOP-FC8BFOQ9\SQLEXPRESS; Database=OnlineGameStore; Integrated Security=SSPI;");

            //String query = @"Select username, password, balance, display_name, creation_date, total_hours From Account";
            String query = @"Select username From Account";

            SqlCommand command = new SqlCommand(query, connection);

            connection.Open();
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                listView1.Items.Add(reader[0].ToString());
            }

            reader.Close();
            command.Dispose();
            connection.Close();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Close();
            Index index = new Index();
            index.Show();
        }

        private void Games_Load(object sender, EventArgs e)
        {
            Load_Data();
        }
    }
}
