using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace OnlineGameStore
{
    public partial class Account : Form
    {
        private bool mouseDown;
        private Point last;
        public Account()
        {
            InitializeComponent();
            textBox1.ForeColor = Color.Gray;
            textBox1.Text = "Search...";
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
            String query = "Select username From Account";

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

        private void Account_Load(object sender, EventArgs e)
        {
            //detail.Enabled = false;
            listView1.FullRowSelect = true;
            listView2.FullRowSelect = true;
            listView3.FullRowSelect = true;
            Load_Data();

            if (listView1.Items.Count > 0)
            {
                listView1.Items[0].Selected = true;
                listView1.Select();
            }
            Load_Profile();
        }

        private void listView1_Enter(object sender, EventArgs e)
        {
            //detail.Enabled = true;
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox1.ForeColor = Color.Black;
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text.Length == 0)
            {
                textBox1.Text = "Search...";
            }
            textBox1.ForeColor = Color.Gray;
        }

        private void Load_Profile()
        {
            try
            {
                SqlConnection connection = new SqlConnection(@"Data Source=LAPTOP-FC8BFOQ9\SQLEXPRESS; Database=OnlineGameStore; Integrated Security=SSPI;");

                String name = listView1.SelectedItems[0].Text;
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

                display_name.Text = uname;
                hours_played.Text = hours;
                date_joined.Text = dt.ToString("MM/dd/yyyy");
                label3.Text = bio;

                reader.Close();
                command.Dispose();

                listView2.Items.Clear();

                query = "Select distinct Games.title, Library.times_visited, Games.genre, Games.link from ((Library Inner Join Games on Library.game_id = Games.game_id) " +
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

                query = "Select distinct Friend.user2_id from(Account Inner Join Friend on Account.user_id = Friend.user1_id) where user_id = " + uid + ";";
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


        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void ListView1_DoubleClick(object sender, EventArgs e)
        {
            Load_Profile();
        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {
            if (textBox2.TextLength > 0)
            {
                listView1.SelectedItems.Clear();
                int cnt = listView1.Items.Count;
                bool found = false;
                for (int i = 0; i < cnt; i++)
                {
                    if (listView1.Items[i].Text == textBox2.Text)
                    {
                        found = true;
                        listView1.Select();
                        listView1.Items[i].Selected = true;
                        listView1.EnsureVisible(i);
                        Load_Profile();
                        break;
                    }
                }


                if (!found)
                {
                    MessageBox.Show("Not found", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void ListView3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
