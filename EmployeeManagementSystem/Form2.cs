using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RoomBookingSystem
{
    public partial class Form2 : Form
    {
        DatabaseConnection connection = new DatabaseConnection();
        
        public Form2()
        {
            InitializeComponent();
        }

        private void employeeBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.employeeBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bookingDatabaseDataSet);

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bookingDatabaseDataSet.Employee' table. You can move, or remove it, as needed.
            this.employeeTableAdapter.Fill(this.bookingDatabaseDataSet.Employee);

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
            
            string ename = employeenameTextBox.Text;
            string eemail = employeeemailTextBox.Text;
            string eaddress = employeeaddressTextBox.Text;
            string edepartment = comboBox1.SelectedItem.ToString();
            // int age = Convert.ToInt32(numericUpDownAge.Value);
            DateTime edob = employeedobDateTimePicker.Value;
            string ephone = employeephoneTextBox.Text;
            string egender = "";
            if (radioButton1.Checked)
            {
                egender = "Male";
            }
            else if (radioButton2.Checked)
            {
                egender = "Female";
            }


            if (connection.AddUser(ename, eemail,eaddress,edepartment,edob,ephone, egender))
            {
                MessageBox.Show("User information insert successfully.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            
            
        }

        private void employeeBindingNavigator_RefreshItems(object sender, EventArgs e)
        {
                    }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnclose2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main mform = new Main();
            mform.Show();
        }

        private void employeeemailTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void employeedobDateTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}

