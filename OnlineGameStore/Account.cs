﻿using System;
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
    public partial class Account : Form
    {
        public Account()
        {
            InitializeComponent();
            textBox1.ForeColor = Color.Gray;
            textBox1.Text = "Search...";
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
                int index = listView1.Items.Count - 1;
                //for(int i = 1; i <= 5; i++)
                //{
                //    listView1.Items[index].SubItems.Add(reader[i].ToString());
                //}
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

        private void Button3_Click(object sender, EventArgs e)
        {

        }

        private void Account_Load(object sender, EventArgs e)
        {
            detail.Enabled = false;
            listView1.FullRowSelect = true;
            listView2.FullRowSelect = true;
            listView3.FullRowSelect = true;
            Load_Data();
        }

        private void listView1_Enter(object sender, EventArgs e)
        {
            detail.Enabled = true;
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox1.ForeColor = Color.Black;
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if(textBox1.Text.Length == 0)
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
                String query = "Select user_id, username, password, balance, display_name, creation_date, total_hours From Account where username = '" + name + "';";
                String uid = "";
                String uname = "";
                String pass = "";
                String balance = "";
                String disp = "";
                String date = "";
                String hours = "";

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
                }

                display_name.Text = uname;
                hours_played.Text = hours;
                date_joined.Text = date;

                reader.Close();
                command.Dispose();

                listView2.Items.Clear();

                query = "Select Games.title, Library.hours_played, Games.genre from((Library Inner Join Games on Library.game_id = Games.game_id) " +
                        "Inner Join Account on Library.user_id = Account.user_id) where username = '" + name + "';";
                command = new SqlCommand(query, connection);

                reader = command.ExecuteReader();

                while (reader.Read())
                {
                    listView2.Items.Add(reader[0].ToString());
                    int index = listView2.Items.Count - 1;
                    listView2.Items[index].SubItems.Add(reader[1].ToString());
                    listView2.Items[index].SubItems.Add(reader[2].ToString());
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
                    query = "Select display_name from Account where user_id = " + arr[i].ToString() + ";";
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

        private void detail_Click(object sender, EventArgs e)
        {
            Load_Profile();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}