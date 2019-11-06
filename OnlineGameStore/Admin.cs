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
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void PlaceCenter()
        {
            Screen center = Screen.AllScreens[0];
            this.Left = center.WorkingArea.Width / 2 - this.Width / 2;
            this.Top = center.WorkingArea.Height / 2 - this.Height / 2;
        }
        private void Admin_Load(object sender, EventArgs e)
        {
            this.login.Enabled = false;
            this.login.FlatAppearance.BorderSize = 0;
            this.cancel.FlatAppearance.BorderSize = 0;
        }

        protected override void OnLoad(EventArgs e)
        {
            PlaceCenter();
            base.OnLoad(e);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TextBox1_Enter(object sender, EventArgs e)
        {
            textBox1.BorderStyle = BorderStyle.Fixed3D;
            label1.ForeColor = Color.White;
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            if(textBox1.Text.Length > 0 && textBox2.Text.Length > 0)
            {
                login.Enabled = true;
            } else
            {
                login.Enabled = false;
            }
        }

        private void TextBox1_Leave(object sender, EventArgs e)
        {
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            label1.ForeColor = Color.Silver;
        }

        private void TextBox2_Enter(object sender, EventArgs e)
        {
            textBox2.BorderStyle = BorderStyle.Fixed3D;
            label2.ForeColor = Color.White;
        }

        private void TextBox2_Leave(object sender, EventArgs e)
        {
            textBox2.BorderStyle = BorderStyle.FixedSingle;
            label2.ForeColor = Color.Silver;
        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0 && textBox2.Text.Length > 0)
            {
                login.Enabled = true;
            }
            else
            {
                login.Enabled = false;
            }
        }

        private void Login_Click(object sender, EventArgs e)
        {
            if(textBox1.Text == "admin" && textBox2.Text == "admin")
            {
                this.Close();

            } else
            {
                MessageBox.Show("Username or Password is invalid!", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
