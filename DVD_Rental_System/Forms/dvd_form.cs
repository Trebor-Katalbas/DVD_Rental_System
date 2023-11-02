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
    public partial class dvd_form : Form
    {
        // SQL CONNECTION INSTANTIATIONS
        SqlConnection conn = new SqlConnection(@"Data Source=PC\SQLEXPRESS;Initial Catalog=dvd_rental_system;Persist Security Info=True;User ID=sa;Password=123");
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dr;

        public dvd_form()
        {
            InitializeComponent();
            Load_DVD();

        }

        // LOAD ALL DATAS FROM THE TABLES
        public void Load_DVD()
        {
            dvd_table.Rows.Clear();
            cmd = new SqlCommand("SELECT * FROM dvd_entries", conn);
            conn.Open();
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                dvd_table.Rows.Add(dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString());
            }
            dr.Close();
            conn.Close();
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dvd_table.Columns[e.ColumnIndex].Name;
            if(colName == "Edit")
            {
                add_dvd add = new add_dvd();
                add.DVD_ID.Text = dvd_table.Rows[e.RowIndex].Cells[0].Value.ToString();
                add.TitleBox.Text = dvd_table.Rows[e.RowIndex].Cells[1].Value.ToString();
                add.GenreBox.Text = dvd_table.Rows[e.RowIndex].Cells[2].Value.ToString();
                add.PriceBox.Text = dvd_table.Rows[e.RowIndex].Cells[3].Value.ToString();
                string statusValue = dvd_table.Rows[e.RowIndex].Cells[4].Value.ToString();

                if (statusValue == "Available")
                {
                    add.available.Checked = true;
                }
                else if (statusValue == "Returned")
                {
                    add.returned.Checked = true;
                }
                else if (statusValue == "Rented")
                {
                    add.rented.Checked = true;
                }

                add.Add.Enabled = false;
                add.Edit.Enabled = true;
                add.ShowDialog();
            } 
            else if(colName == "Delete")
            {
                if (MessageBox.Show("Are you sure you want to delete this DVD entry?", "Deleting Entry", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    conn.Open();
                    cmd = new SqlCommand("DELETE FROM dvd_entries WHERE dvd_id LIKE '"+ dvd_table.Rows[e.RowIndex].Cells[0].Value.ToString() +"' ", conn);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Entry has been successfully deleted.");
                }
            }
            Load_DVD();
        }

        private void addbtn_Click(object sender, EventArgs e)
        {
            add_dvd add_Dvd = new add_dvd();
            add_Dvd.ShowDialog();
            Load_DVD();
        }
    }
}
