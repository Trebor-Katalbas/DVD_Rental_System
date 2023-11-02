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
    public partial class cust_form : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=PC\SQLEXPRESS;Initial Catalog=dvd_rental_system;Persist Security Info=True;User ID=sa;Password=123");
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dr;
        public cust_form()
        {
            InitializeComponent();
            Load_Customers();
        }
        public void Load_Customers()
        {
            customers_table.Rows.Clear();
            cmd = new SqlCommand("SELECT * FROM customers", conn);
            conn.Open();
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                string fullName = dr[1].ToString() + " " + dr[2].ToString();
                customers_table.Rows.Add(dr[0].ToString(), fullName, dr[3].ToString(), dr[4].ToString());
            }
            dr.Close();
            conn.Close();
        }

        private void cust_form_Load(object sender, EventArgs e)
        {

        }

        private void customers_table_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = customers_table.Columns[e.ColumnIndex].Name;
            if (colName == "Edit")
            {
                add_cust add = new add_cust();
                string fullName = customers_table.Rows[e.RowIndex].Cells[1].Value.ToString();
                string[] nameParts = fullName.Split(' '); //SPLIT THE VARCHAR INTO SUBSTRINGS

                if (nameParts.Length >= 2)
                {
                    add.NameBox.Text = string.Join(" ", nameParts.Take(nameParts.Length - 1)); // DETECTS IF THERE ARE MORE STRING IN FIRST NAME
                    add.LastBox.Text = nameParts.Last(); // INDICATES LAST STRING AS LAST NAME
                }
                else if (nameParts.Length == 1)
                {
                    add.NameBox.Text = nameParts[0]; // FIRST NAME
                    add.LastBox.Text = string.Empty; // EMPTY LASTBOX FIELD
                }

                add.Cust_ID.Text = customers_table.Rows[e.RowIndex].Cells[0].Value.ToString();
                add.ContBox.Text = customers_table.Rows[e.RowIndex].Cells[2].Value.ToString();
                add.AddressBox.Text = customers_table.Rows[e.RowIndex].Cells[3].Value.ToString();

                add.Add.Enabled = false;
                add.Edit.Enabled = true;
                add.ShowDialog();
            }
            else if (colName == "Delete")
            {
                if (MessageBox.Show("Are you sure you want to delete this customer?", "Deleting customer", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    conn.Open();
                    cmd = new SqlCommand("DELETE FROM customers WHERE cust_id LIKE '" + customers_table.Rows[e.RowIndex].Cells[0].Value.ToString() + "' ", conn);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Customer has been successfully deleted.");
                }
            }
            Load_Customers();
        }

        private void addbtn_Click(object sender, EventArgs e)
        {
            add_cust add = new add_cust();
            add.ShowDialog();
            Load_Customers();
        }
    }
}
