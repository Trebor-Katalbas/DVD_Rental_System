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

namespace DVD_Rental_System.ModuleForms
{
    public partial class add_rents : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=PC\SQLEXPRESS;Initial Catalog=dvd_rental_system;Persist Security Info=True;User ID=sa;Password=123");
        SqlCommand cmd = new SqlCommand();
        public add_rents()
        {
            InitializeComponent();
        }
        public void Clear()
        {
            Customer_ID.Clear();
            DVDid.Clear();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Add_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you sure you want to add this rent entry?", "Adding rent", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cmd = new SqlCommand("INSERT into rents(cust_id, dvd_id, rented_date, returned_date)VALUES(@cust_id, @dvd_id, @rented_date, @returned_date)", conn);
                    cmd.Parameters.AddWithValue("@cust_id", Customer_ID.Text);
                    cmd.Parameters.AddWithValue("@dvd_id", DVDid.Text);
                    cmd.Parameters.AddWithValue("@rented_date", DateReturned.Value);

                    if (Unreturned.Checked)
                    {
                        cmd.Parameters.AddWithValue("@returned_date", DBNull.Value);
                    } else
                    {
                        cmd.Parameters.AddWithValue("@returned_date", DateReturned.Value);
                    }
                    
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Rent entry has been successfully added.");
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
                if (MessageBox.Show("Are you sure you want to edit this rent entry?", "Editing rent", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cmd = new SqlCommand("UPDATE rents SET cust_id=@cust_id, dvd_id=@dvd_id, rented_date=@rented_date, returned_date=@returned_date WHERE rent_id LIKE '" + Rent_ID.Text + "' ", conn);
                    cmd.Parameters.AddWithValue("@cust_id", Customer_ID.Text);
                    cmd.Parameters.AddWithValue("@dvd_id", DVDid.Text);
                    cmd.Parameters.AddWithValue("@rented_date", DateRent.Value);
                    if (Unreturned.Checked)
                    {
                        cmd.Parameters.AddWithValue("@returned_date", DBNull.Value);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@returned_date", DateReturned.Value);
                    }
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Rent entry has been successfully edited.");
                    this.Dispose();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
