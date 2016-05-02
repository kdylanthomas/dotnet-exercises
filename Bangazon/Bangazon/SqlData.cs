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

        public void CreatePaymentOption(PaymentOption po)
        {
            string command = String.Format("INSERT INTO PaymentOption (IdPaymentOption, IdCustomer, Name, AccountNumber) VALUES ('{0}', '{1}', '{2}', '{3}')", 6, po.IdCustomer, po.Name, po.AccountNumber);
            UpdateBangazon(command);
        }

        public List<Customer> GetCustomers()
        { //create a list so we can have the data from the customer table
            List<Customer> customerList = new List<Customer>();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "SELECT IdCustomer, FirstName, LastName, StreetAddress, City, StateProvince, PostalCode, PhoneNumber FROM Customer ORDER BY IdCustomer";
            cmd.Connection = _sqlConnection;

            _sqlConnection.Open();
            //using will clean up everything... open and close connections
            using (SqlDataReader dataReader = cmd.ExecuteReader())
            {
                while (dataReader.Read())
                {
                    Customer customer = new Customer();
                    customer.IdCustomer = dataReader.GetInt32(0);
                    customer.FirstName = dataReader.GetString(1);
                    customer.LastName = dataReader.GetString(2);
                    customer.StreetAddress = dataReader.GetString(3);
                    customer.City = dataReader.GetString(4);
                    customer.State = dataReader.GetString(5);
                    customer.PostalCode = dataReader.GetString(6);
                    customer.PhoneNumber = dataReader.GetString(7);

                    customerList.Add(customer);
                }
            }
            _sqlConnection.Close();

            return customerList;
        }

        public List<Product> GetProducts()
        {
            List<Product> productList = new List<Product>();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "SELECT IdProduct, Name, Description, Price, IdProductType FROM Product";
            cmd.Connection = _sqlConnection;

            _sqlConnection.Open();
            using (SqlDataReader dataReader = cmd.ExecuteReader())
            {
                while (dataReader.Read())
                {
                    Product prod = new Product();
                    prod.IdProduct = dataReader.GetInt32(0);
                    prod.Name = dataReader.GetString(1);
                    prod.Description = dataReader.GetString(2);
                    prod.Price = dataReader.GetString(3);
                    prod.IdProductType = dataReader.GetInt32(4);

                    productList.Add(prod);
                }
            }
            _sqlConnection.Close();

            return productList;
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
