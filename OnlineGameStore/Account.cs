using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnlineGameStore
{
    public partial class Account : Form
    {
        public Account()
        {
            InitializeComponent();
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
        }

        private void ListView1_Click(object sender, EventArgs e)
        {
            detail.Enabled = true;
        }
    }
}
