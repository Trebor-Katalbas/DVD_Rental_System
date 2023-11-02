using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace DVD_Rental_System.ModuleForms
{
    public partial class add_cust : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=PC\SQLEXPRESS;Initial Catalog=dvd_rental_system;Persist Security Info=True;User ID=sa;Password=123");
        SqlCommand cmd = new SqlCommand();
        public add_cust()
        {
            InitializeComponent();
        }
        public void Clear()
        {
            NameBox.Clear();
            LastBox.Clear();
            ContBox.Clear();
            AddressBox.Clear();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you sure you want to add this customer?", "Adding customer", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cmd = new SqlCommand("INSERT into customers(firstname, lastname, contact, address)VALUES(@firstname, @lastname, @contact, @address)", conn);
                    cmd.Parameters.AddWithValue("@firstname", NameBox.Text);
                    cmd.Parameters.AddWithValue("@lastname", LastBox.Text);
                    cmd.Parameters.AddWithValue("@contact", ContBox.Text);
                    cmd.Parameters.AddWithValue("@address", AddressBox.Text);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Customer has been successfully added.");
                    Clear();
                    this.Dispose();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ClearFields_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you sure you want to edit this customer?", "Editing customer", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cmd = new SqlCommand("UPDATE customers SET firstname=@firstname, lastname=@lastname, contact=@contact, address=@address WHERE cust_id LIKE '" + Cust_ID.Text + "' ", conn);
                    cmd.Parameters.AddWithValue("@firstname", NameBox.Text);
                    cmd.Parameters.AddWithValue("@lastname", LastBox.Text);
                    cmd.Parameters.AddWithValue("@contact", ContBox.Text);
                    cmd.Parameters.AddWithValue("@address", AddressBox.Text);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Customer has been successfully edited.");
                    this.Dispose();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
