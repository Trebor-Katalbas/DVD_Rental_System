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
using DVD_Rental_System.Forms;

namespace DVD_Rental_System.ModuleForms
{
    public partial class add_dvd : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=PC\SQLEXPRESS;Initial Catalog=dvd_rental_system;Persist Security Info=True;User ID=sa;Password=123");
        SqlCommand cmd = new SqlCommand();
        string selectedStatus = "";

        public add_dvd()
        {
            InitializeComponent();

        }

        public void Clear()
        {
            TitleBox.Clear();
            PriceBox.Clear(); 
        }

        private void TitleLabel_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Add_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you sure you want to add this DVD entry?", "Adding Entry", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cmd = new SqlCommand("INSERT into dvd_entries(dvd_title, genre, price, status)VALUES(@dvd_title, @genre, @price, @status)", conn);
                    cmd.Parameters.AddWithValue("@dvd_title", TitleBox.Text);
                    cmd.Parameters.AddWithValue("@genre", GenreBox.Text);
                    cmd.Parameters.AddWithValue("@price", PriceBox.Text);

                    if (available.Checked)
                    {
                        selectedStatus = "Available";
                    }
                    else if (returned.Checked)
                    {
                        selectedStatus = "Returned";
                    }
                    else if (rented.Checked)
                    {
                        selectedStatus = "Rented";
                    }
                    cmd.Parameters.AddWithValue("@status", selectedStatus);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("DVD has been successfully added.");
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
                if (MessageBox.Show("Are you sure you want to edit this DVD entry?", "Editing Entry", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cmd = new SqlCommand("UPDATE dvd_entries SET dvd_title=@dvd_title, genre=@genre, price=@price, status=@status WHERE dvd_id LIKE '"+ DVD_ID.Text +"' ", conn);
                    cmd.Parameters.AddWithValue("@dvd_title", TitleBox.Text);
                    cmd.Parameters.AddWithValue("@genre", GenreBox.Text);
                    cmd.Parameters.AddWithValue("@price", PriceBox.Text);

                    if (available.Checked)
                    {
                        selectedStatus = "Available";
                    }
                    else if (returned.Checked)
                    {
                        selectedStatus = "Returned";
                    }
                    else if (rented.Checked)
                    {
                        selectedStatus = "Rented";
                    }
                    cmd.Parameters.AddWithValue("@status", selectedStatus);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("DVD has been successfully edited.");
                    this.Dispose();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
