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
    public partial class Add_Games : Form
    {
        public Add_Games(Form callingForm)
        {
            InitializeComponent();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            if (add_title.Text.Length > 0 && add_genre.Text.Length > 0 && add_link.Text.Length > 0 && add_studio.Text.Length > 0 && richTextBox1.TextLength > 0)
            {
                SqlConnection connection = new SqlConnection(@"Data Source=LAPTOP-FC8BFOQ9\SQLEXPRESS; Database=OnlineGameStore; Integrated Security=SSPI;");

                String query = "Insert into Games (title, studio, genre, link) values ('" + add_title.Text + "', '"
                                + add_studio.Text + "', '" + add_genre.Text + "', '" + add_link.Text + "');";

                SqlCommand command = new SqlCommand(query, connection);

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                }

                reader.Close();
                command.Dispose();
                connection.Close();
                this.Close();
            }
            else
            {
                MessageBox.Show("One or more of the input field is invalid");
            }
        }
    }
}