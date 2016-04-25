using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Invoices
{
    class Program
    {
        static void Main(string[] args)
        {
            List<object> products = new List<object>();

            string query = @"
SELECT
 co.DateCreated,
 co.OrderNumber,
 p.Name,
 pt.Name as ProductTypeName,
 c.FirstName + ' ' + c.LastName AS CustomerName,
 po.Name as Payment
FROM CustomerOrder co
INNER JOIN OrderProducts op ON op.IdCustomerOrder = co.IdCustomerOrder 
INNER JOIN Product p ON p.IdProduct = op.IdProduct
INNER JOIN ProductType pt ON pt.IdProductType = p.IdProductType
INNER JOIN Customer c ON c.IdCustomer = co.IdCustomer 
INNER JOIN PaymentOption po ON po.IdPaymentOption = co.IdPaymentOption
";

            using (SqlConnection connection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\USERS\\DYLAN\\DOCUMENTS\\VISUAL STUDIO 2015\\PROJECTS\\DOTNET-EXERCISES\\INVOICES\\INVOICES\\INVOICES.MDF\""))
            using (SqlCommand cmd = new SqlCommand(query, connection))
            {
                connection.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    // Check is the reader has any rows at all before starting to read.
                    if (reader.HasRows)
                    {
                        // Read advances to the next row.
                        while (reader.Read())
                        {
                            // eventual goal: get this stuff to a browser through JSON, HTML, etc
                            // the world is our oyster
                            Console.WriteLine("<div>{0}, {1}, {2}, {3}, {4}, {5}</div>",
                                reader[0], reader[1], reader[2], reader[3], reader[4], reader[5]);
                        }
                        Console.ReadLine();
                    }
                }
            }
        }
    }
}