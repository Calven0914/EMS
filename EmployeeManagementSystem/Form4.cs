using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RoomBookingSystem
{
    public partial class Form4 : Form
    {

        OleDbConnection con = new OleDbConnection(
                    @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\BookingDatabase.accdb;
                    Persist Security Info=True");
        public Form4()
        {
            InitializeComponent();
        }

        private void employeeBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.employeeBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bookingDatabaseDataSet);

        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bookingDatabaseDataSet.Employee' table. You can move, or remove it, as needed.
            this.employeeTableAdapter.Fill(this.bookingDatabaseDataSet.Employee);

        }

        private void btnclose2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main mform = new Main();
            mform.Show();
        }

        private void btncalculate_Click(object sender, EventArgs e)
        {
            try
            {
                // Get the selected employee's details from the database
                string eid = employeeidTextBox.Text;
                OleDbCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT * FROM Employee WHERE employeeid = ?";
                cmd.Parameters.AddWithValue("@eid", eid);
                con.Open();
                OleDbDataReader reader = cmd.ExecuteReader();
                reader.Read();
                string empid = reader["employeeid"].ToString();
                string ename = reader["employeename"].ToString();
                string ed = reader["employeedepartment"].ToString();
                string ep = reader["employeephone"].ToString();
                double salaryPerHour = double.Parse(comboBox1.Text);
                double workHours = double.Parse(textBox1.Text);
                con.Close();

                // Calculate the total salary
                double totalSalary = salaryPerHour * workHours;

                // Display the employee's details and total salary
                string output =("Employee ID: " + empid + "\nEmployee Name: " + ename + "\nEmployee department: " + ed + "\nEmployee Phone: " + ep +
                    "\nSalary per Hour: " + salaryPerHour.ToString("C") 
                    + "\nWork Hours: " + workHours + "\nTotal Salary: " + totalSalary.ToString("C"));

                richTextBox1.Text = output;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("==========EMPLOYEE SALARY==========", new Font("Times New Roman", 20, FontStyle.Bold), Brushes.Red, new Point(120));
            e.Graphics.DrawString(richTextBox1.Text, new Font("Times New Roman", 14, FontStyle.Bold), Brushes.Black, new PointF(100, 100));
            e.Graphics.DrawString("==========EMPLOYEE SALARY==========", new Font("Times New Roman", 20, FontStyle.Bold), Brushes.Red, new PointF(120, 300));
        }

        private void btnprint_Click(object sender, EventArgs e)
        {
            if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
                printDocument1.Print();

        }
    }
}
