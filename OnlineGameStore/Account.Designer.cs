namespace OnlineGameStore
{
    partial class Account
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Account));
            this.back = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.detail = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.date_joined = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.hours_played = new System.Windows.Forms.Label();
            this.listView3 = new System.Windows.Forms.ListView();
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listView2 = new System.Windows.Forms.ListView();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.unused_1 = new System.Windows.Forms.Label();
            this.display_name = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // back
            // 
            this.back.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.back.FlatAppearance.BorderSize = 0;
            this.back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.back.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back.ForeColor = System.Drawing.Color.White;
            this.back.Location = new System.Drawing.Point(758, 0);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(42, 29);
            this.back.TabIndex = 2;
            this.back.Text = "x";
            this.back.UseVisualStyleBackColor = false;
            this.back.Click += new System.EventHandler(this.Back_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Account";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(16, 71);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(178, 337);
            this.listView1.TabIndex = 5;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.Visible = false;
            this.listView1.Enter += new System.EventHandler(this.listView1_Enter);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Username";
            this.columnHeader1.Width = 173;
            // 
            // detail
            // 
            this.detail.BackColor = System.Drawing.Color.SlateBlue;
            this.detail.FlatAppearance.BorderSize = 0;
            this.detail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.detail.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.detail.ForeColor = System.Drawing.Color.White;
            this.detail.Location = new System.Drawing.Point(16, 414);
            this.detail.Name = "detail";
            this.detail.Size = new System.Drawing.Size(178, 24);
            this.detail.TabIndex = 6;
            this.detail.Text = "CLICK FOR DETAIL";
            this.detail.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.detail.UseVisualStyleBackColor = false;
            this.detail.Click += new System.EventHandler(this.detail_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(16, 45);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(153, 20);
            this.textBox1.TabIndex = 7;
            this.textBox1.Enter += new System.EventHandler(this.textBox1_Enter);
            this.textBox1.Leave += new System.EventHandler(this.textBox1_Leave);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SlateBlue;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(172, 45);
            this.button1.Margin = new System.Windows.Forms.Padding(0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(22, 20);
            this.button1.TabIndex = 8;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.date_joined);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.hours_played);
            this.panel1.Controls.Add(this.listView3);
            this.panel1.Controls.Add(this.listView2);
            this.panel1.Controls.Add(this.unused_1);
            this.panel1.Controls.Add(this.display_name);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(214, 45);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(565, 393);
            this.panel1.TabIndex = 9;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // date_joined
            // 
            this.date_joined.AutoSize = true;
            this.date_joined.Location = new System.Drawing.Point(262, 79);
            this.date_joined.Name = "date_joined";
            this.date_joined.Size = new System.Drawing.Size(35, 13);
            this.date_joined.TabIndex = 9;
            this.date_joined.Text = "label1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(196, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Date Joined:";
            // 
            // hours_played
            // 
            this.hours_played.AutoSize = true;
            this.hours_played.Location = new System.Drawing.Point(262, 53);
            this.hours_played.Name = "hours_played";
            this.hours_played.Size = new System.Drawing.Size(35, 13);
            this.hours_played.TabIndex = 7;
            this.hours_played.Text = "label1";
            // 
            // listView3
            // 
            this.listView3.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader5});
            this.listView3.HideSelection = false;
            this.listView3.Location = new System.Drawing.Point(406, 181);
            this.listView3.Name = "listView3";
            this.listView3.Size = new System.Drawing.Size(146, 200);
            this.listView3.TabIndex = 6;
            this.listView3.UseCompatibleStateImageBehavior = false;
            this.listView3.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Friends";
            this.columnHeader5.Width = 140;
            // 
            // listView2
            // 
            this.listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listView2.HideSelection = false;
            this.listView2.Location = new System.Drawing.Point(15, 181);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(385, 200);
            this.listView2.TabIndex = 5;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Title";
            this.columnHeader2.Width = 156;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Hours Played";
            this.columnHeader3.Width = 89;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Genre";
            this.columnHeader4.Width = 110;
            // 
            // unused_1
            // 
            this.unused_1.AutoSize = true;
            this.unused_1.Location = new System.Drawing.Point(190, 53);
            this.unused_1.Name = "unused_1";
            this.unused_1.Size = new System.Drawing.Size(71, 13);
            this.unused_1.TabIndex = 2;
            this.unused_1.Text = "Hours Online:";
            // 
            // display_name
            // 
            this.display_name.AutoSize = true;
            this.display_name.Location = new System.Drawing.Point(188, 26);
            this.display_name.Name = "display_name";
            this.display_name.Size = new System.Drawing.Size(75, 13);
            this.display_name.TabIndex = 1;
            this.display_name.Text = "Display_Name";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(15, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 150);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Account
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.detail);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.back);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Account";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Account";
            this.Load += new System.EventHandler(this.Account_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Account_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Account_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Account_MouseUp);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.Button detail;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Label unused_1;
        private System.Windows.Forms.Label display_name;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ListView listView3;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Label hours_played;
        private System.Windows.Forms.Label date_joined;
        private System.Windows.Forms.Label label1;
    }
}