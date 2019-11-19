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
    public partial class User_Games : Form
    {
        String name = "";
        private Point last;
        bool mouseDown;
        String gid = "";
        String studio = "";
        String genre = "";
        String link = "";
        String path = "";
        String about = "";
        String uid = "";
        public User_Games(String _name, String _uid)
        {
            InitializeComponent();
            name = _name;
            uid = _uid;
            listView1.FullRowSelect = true;
            listView2.FullRowSelect = true;
        }

        public void Load_Data()
        {
            SqlConnection connection = new SqlConnection(@"Data Source=LAPTOP-FC8BFOQ9\SQLEXPRESS; Database=OnlineGameStore; Integrated Security=SSPI;");

            String query = @"Select title from Games";

            SqlCommand command = new SqlCommand(query, connection);

            connection.Open();
            SqlDataReader reader = command.ExecuteReader();

            listView1.Items.Clear();
            while (reader.Read())
            {
                listView1.Items.Add(reader[0].ToString());
            }

            reader.Close();
            command.Dispose();
            connection.Close();
        }

        private void delete_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            User_Profile user_Profile = new User_Profile(name, uid);
            user_Profile.Show();
            this.Hide();
        }

        private void User_Games_Load(object sender, EventArgs e)
        {
            Load_Data();
            if (listView1.Items.Count > 0)
            {
                listView1.Items[0].Selected = true;
                listView1.Select();
            }
            Load_Game();
        }

        private void Load_Game()
        {
            SqlConnection connection = new SqlConnection(@"Data Source=LAPTOP-FC8BFOQ9\SQLEXPRESS; Database=OnlineGameStore; Integrated Security=SSPI;");

            String @title = listView1.SelectedItems[0].Text.ToString();
            title_label.Text = title;
            title = title.Replace("'", "''");
            String query = "Select game_id, studio, genre, link, image_path, about from Games where title = '" + title + "';";


            SqlCommand command = new SqlCommand(query, connection);

            connection.Open();
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                gid = reader[0].ToString();
                studio = reader[1].ToString();
                genre = reader[2].ToString();
                link = reader[3].ToString();
                path = reader[4].ToString();
                about = reader[5].ToString();
            }

            studio_label.Text = studio;
            genre_label.Text = genre;   
            if (path == "")
            {
                pictureBox1.Image = System.Drawing.Bitmap.FromFile("D:/Game_Pictures/replace.jpg");
            }
            else
            {
                pictureBox1.Image = System.Drawing.Bitmap.FromFile(path);
            }
            richTextBox1.Text = about;

            reader.Close();

            listView2.Items.Clear();

            query = "Select distinct user_id from Library where game_id = " + gid + ";";
            command = new SqlCommand(query, connection);

            reader = command.ExecuteReader();

            String[] arr = new String[1000];

            int idx = 0;

            while (reader.Read())
            {
                arr[idx] = reader[0].ToString();
                idx++;
            }

            reader.Close();
            command.Dispose();

            for (int i = 0; i < idx; i++)
            {
                query = "Select display_name from Account where user_id = " + arr[i].ToString() + ";";
                command = new SqlCommand(query, connection);
                reader = command.ExecuteReader();
                reader.Read();
                listView2.Items.Add(reader[0].ToString());
                reader.Close();
                command.Dispose();
            }

            command.Dispose();
            connection.Close();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void link_label_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(@"Data Source=LAPTOP-FC8BFOQ9\SQLEXPRESS; Database=OnlineGameStore; Integrated Security=SSPI;");

            String @title = listView1.SelectedItems[0].Text.ToString();
            title_label.Text = title;
            title = title.Replace("'", "''");
            String query = "update Library set times_visited = (times_visited + 1) where user_id = " + uid + " and game_id = " + gid + ";";
            String query1 = "Insert into Purchase (user_id, game_id) values (" + uid + ", " + gid + ");";


            SqlCommand command = new SqlCommand(query, connection);

            connection.Open();
            SqlDataReader reader = command.ExecuteReader();

            reader.Read();

            reader.Close();

            command = new SqlCommand(query1, connection);
            reader = command.ExecuteReader();

            reader.Read();

            reader.Close();
            command.Dispose();
            connection.Close();

            WebBrowser browser = new WebBrowser(link);
            browser.Show();
            browser.Activate();
        }

        private void ListView1_Click(object sender, EventArgs e)
        {
            Load_Game();
        }
    }
}
