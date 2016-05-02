using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;

namespace Bangazon
{
    public class SqlData
    {
        private SqlConnection _sqlConnection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=" +
           "\"C:\\Users\\dylan\\Documents\\Visual Studio 2015\\Projects\\dotnet-exercises\\Bangazon\\Bangazon\\BangazonStore.mdf\";Integrated Security=True");

        public void CreateCustomer(Customer cust)
        {
            string command = String.Format("INSERT INTO Customer (FirstName, LastName, StreetAddress, City, StateProvince, PostalCode, PhoneNumber, IdCustomer) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}')", cust.FirstName, cust.LastName, cust.StreetAddress, cust.City, cust.State, cust.PostalCode, cust.PhoneNumber, cust.IdCustomer);
            UpdateBangazon(command);
        }

        private void UpdateBangazon(string commandString)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = commandString;
            cmd.Connection = _sqlConnection;

            _sqlConnection.Open();
            cmd.ExecuteNonQuery();
            _sqlConnection.Close();
        }

    }
}
