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
    }
}
