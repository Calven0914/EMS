using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;

namespace RoomBookingSystem
{
    public class DatabaseConnection
    {
        private OleDbConnection databaseConnection = null;



        public DatabaseConnection()
        { //Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\BookingDatabase.accdb"
            try
            {
                databaseConnection = new OleDbConnection(
                    @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\BookingDatabase.accdb;
                    Persist Security Info=True");

                databaseConnection.Open();
                databaseConnection.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception occurs in DatabaseConnection class", ex);
                databaseConnection = null;
            }
        }

        public bool IsDatabaseAvailable()
        {
            return databaseConnection != null;
        }

        public bool CheckUser(string txtusername, string txtpassword)
        {
            bool found = false;
            string SQLSearchStatement =
                "SELECT [username],[password] " +
                "FROM [Users] WHERE username = ? AND password = ?";

            databaseConnection.Open();
            OleDbCommand command = databaseConnection.CreateCommand();
            command.CommandText = SQLSearchStatement;
            command.Parameters.Add(new OleDbParameter("username", txtusername));
            command.Parameters.Add(new OleDbParameter("password", txtpassword));
            OleDbDataReader reader = command.ExecuteReader();

            if (reader.HasRows)
            {
                found = true;
            }

            databaseConnection.Close();
            return found;
        }

        public bool AddUser(string ename, string eemail, string eaddress, string edepartment,DateTime edob, string ephone, string egender)
        {
            int affectedRows = 0;
            if (IsDatabaseAvailable())
            {
                string insertQuery = "INSERT INTO [Employee] ([employeename], [employeeemail],[employeeaddress],[employeedepartment],[employeedob],[employeephone],[employeegender]) VALUES (?,?,?,?,?,?,?)";
                databaseConnection.Open();
                OleDbCommand command = databaseConnection.CreateCommand();
                command.CommandText = insertQuery;          
                command.Parameters.AddWithValue("Employee Name", ename);
                command.Parameters.AddWithValue("Employee Email", eemail);
                command.Parameters.AddWithValue("Employee Address", eaddress);
                command.Parameters.AddWithValue("Employee Department", edepartment);
                command.Parameters.AddWithValue("Employee Date of Birth", edob);
                command.Parameters.AddWithValue("Employee Phone", ephone);
                command.Parameters.AddWithValue("Employee Gender", egender);
                affectedRows = command.ExecuteNonQuery();
                databaseConnection.Close();
            }
            return affectedRows == 1;
        }

       



    }
}
