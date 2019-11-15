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
        private bool mouseDown;
        private Point last;
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
            this.Hide();
            this.login.Enabled = false;
            this.login.FlatAppearance.BorderSize = 0;
            this.cancel.FlatAppearance.BorderSize = 0;
            Account acc = new Account();
            Games games = new Games();
            games.Show();
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
                //this.Close();
                Form index = new Index();
                index.Show();
            } else
            {
                MessageBox.Show("Username or Password is invalid!", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void login_MouseHover(object sender, EventArgs e)
        {
            login.FlatAppearance.BorderColor = Color.White;
        }

        private void login_MouseLeave(object sender, EventArgs e)
        {
            login.FlatAppearance.BorderColor = Color.SlateBlue;
        }

        private void cancel_MouseLeave(object sender, EventArgs e)
        {
            cancel.FlatAppearance.BorderColor = Color.SlateBlue;
        }

        private void cancel_MouseHover(object sender, EventArgs e)
        {
            cancel.FlatAppearance.BorderColor = Color.White;
        }

        private void Admin_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            last = e.Location;
        }

        private void Admin_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - last.X) + e.X, (this.Location.Y - last.Y) + e.Y);
                this.Update();
            }
        }

        private void Admin_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }
    }
}
