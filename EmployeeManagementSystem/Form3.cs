using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RoomBookingSystem
{
    public partial class Form3 : Form
    {
        

        OleDbConnection con = new OleDbConnection(
                    @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\BookingDatabase.accdb;
                    Persist Security Info=True");



        public Form3()
        {
            InitializeComponent();
        }

        private void employeeBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.employeeBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bookingDatabaseDataSet);

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bookingDatabaseDataSet.Employee' table. You can move, or remove it, as needed.
            this.employeeTableAdapter.Fill(this.bookingDatabaseDataSet.Employee);

        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.employeeBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bookingDatabaseDataSet);

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                OleDbCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "DELETE FROM Employee WHERE employeeid = ?";
                cmd.Parameters.AddWithValue("@eid", employeeidTextBox.Text);
                int result = cmd.ExecuteNonQuery();
                con.Close();
                if (result > 0)
                {
                    MessageBox.Show("Data Deleted");
                    this.employeeTableAdapter.Fill(this.bookingDatabaseDataSet.Employee); // refresh the data table
                }
                else
                {
                    MessageBox.Show("No rows were affected.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {

        }

        private void btnclose2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main mform = new Main();
            mform.Show();
        }
    }
    }

