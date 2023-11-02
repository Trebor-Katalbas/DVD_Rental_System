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
using DVD_Rental_System.ModuleForms;

namespace DVD_Rental_System.Forms
{
    public partial class rents_form : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=PC\SQLEXPRESS;Initial Catalog=dvd_rental_system;Persist Security Info=True;User ID=sa;Password=123");
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dr;
        public rents_form()
        {
            InitializeComponent();
            Load_Rents();
        }
        public void Load_Rents()
        {
            rents_table.Rows.Clear();
            cmd = new SqlCommand("SELECT r.rent_id, c.cust_id, c.firstname, c.lastname, d.dvd_id, d.dvd_title, r.rented_date, r.returned_date " +
                        "FROM rents r " +
                        "JOIN customers c ON r.cust_id = c.cust_id " +
                        "JOIN dvd_entries d ON r.dvd_id = d.dvd_id", conn);
            conn.Open();
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                DateTime? rentDateNullable = dr.IsDBNull(6) ? (DateTime?)null : dr.GetDateTime(6);
                DateTime? returnDateNullable = dr.IsDBNull(7) ? (DateTime?)null : dr.GetDateTime(7);

                string rentDate = rentDateNullable.HasValue ? rentDateNullable.Value.ToString("yyyy-MM-dd") : "N/A";
                string returnDate = returnDateNullable.HasValue ? returnDateNullable.Value.ToString("yyyy-MM-dd") : "N/A";
                rents_table.Rows.Add(dr[0].ToString(), dr[1].ToString() + " : " + dr[2].ToString() + " " + dr[3].ToString(), dr[4].ToString() + " : " + dr[5].ToString(), rentDate, returnDate);
            }
            dr.Close();
            conn.Close();
        }
        private void rents_table_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = rents_table.Columns[e.ColumnIndex].Name;
            if (colName == "Edit")
            {
                add_rents add = new add_rents();
                add.Rent_ID.Text = rents_table.Rows[e.RowIndex].Cells[0].Value.ToString();
                add.Customer_ID.Text = rents_table.Rows[e.RowIndex].Cells[1].Value.ToString();
                add.DVDid.Text = rents_table.Rows[e.RowIndex].Cells[2].Value.ToString();

                DateTime dateRent = Convert.ToDateTime(rents_table.Rows[e.RowIndex].Cells[3].Value);
                add.DateRent.Text = dateRent.ToString("yyyy-MM-dd");

                string dateReturnedString = rents_table.Rows[e.RowIndex].Cells[4].Value.ToString();

                if (dateReturnedString == "Unreturned")
                {
                    add.DateReturned.Text = "Unreturned";
                }
                else if (DateTime.TryParse(dateReturnedString, out DateTime dateReturned))
                {
                    add.DateReturned.Text = dateReturned.ToString("yyyy-MM-dd");
                }

                add.Add.Enabled = false;
                add.Edit.Enabled = true;
                add.ReminderLabel.Visible = true;
                add.ShowDialog();
            }
            else if (colName == "Delete")
            {
                if (MessageBox.Show("Are you sure you want to delete this rent entry?", "Deleting rent", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    conn.Open();
                    cmd = new SqlCommand("DELETE FROM rents WHERE rent_id LIKE '" + rents_table.Rows[e.RowIndex].Cells[0].Value.ToString() + "' ", conn);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Rent entry has been successfully deleted.");
                }
            }
            Load_Rents();
        }

        private void addbtn_Click(object sender, EventArgs e)
        {
            add_rents add = new add_rents();
            add.ShowDialog();
            Load_Rents();
        }
    }
}
