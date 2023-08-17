using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;

namespace RoomBookingSystem
{
    public partial class Form1 : Form
    {
        DatabaseConnection connection = new DatabaseConnection();
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_MouseDown(object sender, MouseEventArgs e)
        {
            txtpassword.UseSystemPasswordChar = false;
        }

        private void pictureBox3_MouseUp(object sender, MouseEventArgs e)
        {
            txtpassword.UseSystemPasswordChar=true;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!connection.IsDatabaseAvailable())
            {
                MessageBox.Show(
                    "Database is not available/connected",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            string username = txtusername.Text.Trim();
            string password = txtpassword.Text.Trim();

            if (connection.CheckUser(username, password))
            {
                MessageBox.Show(
                    "Login Successful",
                    "Status",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                this.Hide();

                Main mform = new Main();
                mform.Show();
                
            }
            else
            {
                MessageBox.Show(
                    "The user is not exists, login unsuccessful",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                    "Please Contact HR Manager.",
                    "Contact",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information );
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBoxshow_Click(object sender, EventArgs e)
        {
            if (txtpassword.UseSystemPasswordChar == true)
            {
                pictureBoxhide.BringToFront();
                txtpassword.UseSystemPasswordChar = false;
            }


        }

        private void pictureBoxhide_Click(object sender, EventArgs e)
        {
            if (txtpassword.UseSystemPasswordChar == false)
            {
                pictureBoxshow.BringToFront();
                txtpassword.UseSystemPasswordChar = true;
            }

        }
    }
}
