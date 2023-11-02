using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVD_Rental_System
{
    public partial class MainForm : Form
    {
        public Point mouseLocation;
        private Button currentButtton;
        private Form activeForm;

        public MainForm()
        {
            InitializeComponent();
            home_btn.Visible = false;
        }

        private void btnActive(object btnSender)
        {
            if (btnSender != null) {
                if (currentButtton != (Button)btnSender) {
                    disableBtn();
                    currentButtton = (Button)btnSender;
                    currentButtton.BackColor = Color.FromArgb(255, 109, 109);
                    currentButtton.ForeColor = Color.White;
                    currentButtton.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point,((byte)(0)));
                    home_btn.Visible = true;
                }
            }
        }

        private void disableBtn()
        {
            foreach(Control previousBtn in panelMenu.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(255, 173, 171);
                    previousBtn.ForeColor = Color.Black;
                    previousBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }

        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            btnActive(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.BodyPanel.Controls.Add(childForm);
            this.BodyPanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            TitleLabel.Text = childForm.Text;
        }

        private void Reset() 
        {
            disableBtn();
            TitleLabel.Text = "HOME";
            home_btn.Visible = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.dvd_form(), sender);
        }

        private void cust_btn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.cust_form(), sender);
        }

        private void rents_btn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.rents_form(), sender);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void home_btn_Click(object sender, EventArgs e)
        {
            if(activeForm != null)
                activeForm.Close();
            Reset();
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void BodyPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void exit_btn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to exit the program?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void mouse_Move(object sender, MouseEventArgs e)
        {

            if (e.Button == MouseButtons.Left)
            {
                Point mousePose = Control.MousePosition;
                mousePose.Offset(mouseLocation.X, mouseLocation.Y);
                Location = mousePose;
            }
        }

        private void mouse_Down(object sender, MouseEventArgs e)
        {
            mouseLocation = new Point(-e.X, -e.Y);
        }
    }
}
