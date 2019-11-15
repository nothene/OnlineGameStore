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
    public partial class Purchase : Form
    {
        public Purchase()
        {
            InitializeComponent();
            try
            {
                SqlConnection connection = new SqlConnection(@"Data Source=LAPTOP-FC8BFOQ9\SQLEXPRESS; Database=OnlineGameStore; Integrated Security=SSPI;");

                String query = "select Account.username, Games.title, Purchase.purchase_date from((Purchase inner join Games on Purchase.game_id = Games.game_id) inner join Account on Account.user_id = Purchase.user_id)";

                SqlCommand command = new SqlCommand(query, connection);

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    listView1.Items.Add(reader[0].ToString());
                    int index = listView1.Items.Count - 1;
                    listView1.Items[index].SubItems.Add(reader[1].ToString());
                    listView1.Items[index].SubItems.Add(reader[2].ToString());
                }

                connection.Close();
                reader.Close();
                command.Dispose();
            }
            finally { }
        }
    }
}
