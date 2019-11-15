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
            listView1.FullRowSelect = true;
        }

        private void Panel4_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            last = e.Location;
        }

        private void Panel4_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - last.X) + e.X, (this.Location.Y - last.Y) + e.Y);
                this.Update();
            }
        }

        private void Panel4_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void Load_Data()
        {
            SqlConnection connection = new SqlConnection(@"Data Source=LAPTOP-FC8BFOQ9\SQLEXPRESS; Database=OnlineGameStore; Integrated Security=SSPI;");

            //String query = @"Select username, password, balance, display_name, creation_date, total_hours From Account";
            String query = @"Select title from Games";

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

        private void Games_Load(object sender, EventArgs e)
        {
            Load_Data();
            if (listView1.Items.Count > 0)
            {
                listView1.Items[0].Selected = true;
                listView1.Select();
            }
        }

        private void Back_Click_1(object sender, EventArgs e)
        {
            this.Close();
            Index index = new Index();
            index.Show();
        }

        private void ListView1_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(@"Data Source=LAPTOP-FC8BFOQ9\SQLEXPRESS; Database=OnlineGameStore; Integrated Security=SSPI;");

            String title = listView1.SelectedItems[0].Text.ToString();
            String query = "Select studio, genre, link from Games where title = '" + title + "';";
            String studio = "";
            String genre = "";
            String link = "";

            SqlCommand command = new SqlCommand(query, connection);
            MessageBox.Show(query);

            connection.Open();
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                studio = reader[0].ToString();
                genre = reader[1].ToString();
                link = reader[2].ToString();
            }

            title_label.Text = title;
            studio_label.Text = studio;
            genre_label.Text = genre;
            link_label.Text = link;

            reader.Close();
            command.Dispose();
            connection.Close();
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(@"Data Source=LAPTOP-FC8BFOQ9\SQLEXPRESS; Database=OnlineGameStore; Integrated Security=SSPI;");

            String title = listView1.SelectedItems[0].Text;
            String query = "Delete from Games where title = '" + title + "';";

            MessageBox.Show(query);

            SqlCommand command = new SqlCommand(query, connection);

            connection.Open();
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read()) { }

            reader.Close();
            command.Dispose();
            connection.Close();

            listView1.Items.Clear();
            Load_Data();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Add_Games add_Games = new Add_Games(this);
            add_Games.Show();
        }

  

        private void OpenFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
