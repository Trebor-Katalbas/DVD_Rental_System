using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace DVD_Rental_System
{
    public partial class Form1 : Form
    {

        SqlConnection conn = new SqlConnection(@"Data Source=PC\SQLEXPRESS;Initial Catalog=dvd_rental_system;Persist Security Info=True;User ID=sa;Password=123");

        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void username_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void login_Click(object sender, EventArgs e)
        {
            string user, pass;
            user = username.Text;
            pass = password.Text;

            try
            {
                string query = "SELECT * FROM userdb WHERE username = '"+user+"' AND password = '"+pass+"' ";
                SqlDataAdapter sda = new SqlDataAdapter(query, conn);

                DataTable dt = new DataTable();
                sda.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("Login Successful!","Login", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    MainForm f2 = new MainForm();
                    this.Hide();
                    f2.Show();
                }
                else {
                    MessageBox.Show("Wrong Credentials! Try Again", "Warning", MessageBoxButtons.OK , MessageBoxIcon.Error);
                    password.Clear();
                }
            }
            catch
            {
                MessageBox.Show("Error!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == false) {
                password.UseSystemPasswordChar = true;
            } else { 
                password.UseSystemPasswordChar = false;
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void exit_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
