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
    public partial class User_Profile : Form
    {
        String name = "";
        private Point last;
        bool mouseDown;
        public User_Profile(String _name)
        {
            InitializeComponent();
            name = _name;
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

        private void User_Profile_Load(object sender, EventArgs e)
        {
            try
            {
                SqlConnection connection = new SqlConnection(@"Data Source=LAPTOP-FC8BFOQ9\SQLEXPRESS; Database=OnlineGameStore; Integrated Security=SSPI;");

                String query = "Select user_id, username, password, balance, display_name, creation_date, total_hours, bio From Account where username = '" + name + "';";
                String uid = "";
                String uname = "";
                String pass = "";
                String balance = "";
                String disp = "";
                String date = "";
                String hours = "";
                String bio = "";

                SqlCommand command = new SqlCommand(query, connection);

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    uid = reader[0].ToString();
                    uname = reader[1].ToString();
                    pass = reader[2].ToString();
                    balance = reader[3].ToString();
                    disp = reader[4].ToString();
                    date = reader[5].ToString();
                    hours = reader[6].ToString();
                    bio = reader[7].ToString();
                }

                DateTime dt = DateTime.Parse(date);
                date_joined.Text = dt.ToString("MM/dd/yyyy");

                display_name.Text = uname;
                hours_played.Text = hours;
                label3.Text = bio;

                reader.Close();
                command.Dispose();

                listView2.Items.Clear();

                query = "Select distinct Games.title, Library.hours_played, Games.genre, Games.link from((Library Inner Join Games on Library.game_id = Games.game_id) " +
                        "Inner Join Account on Library.user_id = Account.user_id) where username = '" + name + "';";
                command = new SqlCommand(query, connection);

                reader = command.ExecuteReader();

                while (reader.Read())
                {
                    listView2.Items.Add(reader[0].ToString());
                    int index = listView2.Items.Count - 1;
                    listView2.Items[index].SubItems.Add(reader[1].ToString());
                    listView2.Items[index].SubItems.Add(reader[2].ToString());
                    listView2.Items[index].SubItems.Add(reader[3].ToString());
                }

                reader.Close();
                command.Dispose();

                listView3.Items.Clear();

                query = "Select Friend.user2_id from(Account Inner Join Friend on Account.user_id = Friend.user1_id) where user_id = " + uid + ";";
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
                    query = "Select distinct display_name from Account where user_id = " + arr[i].ToString() + ";";
                    command = new SqlCommand(query, connection);
                    reader = command.ExecuteReader();
                    reader.Read();
                    listView3.Items.Add(reader[0].ToString());
                    reader.Close();
                    command.Dispose();
                }

                reader.Close();
                command.Dispose();
                connection.Close();
            }
            finally
            {

            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Admin.user_Games.Show();
            this.Hide();
        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
