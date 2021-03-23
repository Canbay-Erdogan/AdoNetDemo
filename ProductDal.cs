using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdoNetDemo
{
   public class ProductDal
    {
        string connect = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=ETrade;Integrated Security=True;";
        public List<Product> GetAll2()
        {
            SqlConnection connection = new SqlConnection(connect);

            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
            SqlCommand command = new SqlCommand("Select * from Products", connection);
            SqlDataReader reader = command.ExecuteReader();
            List<Product> products = new List<Product>();
            while (reader.Read())
            {
                Product product = new Product
                {
                    Id = Convert.ToInt32(reader["Id"]),
                    Name = reader["Name"].ToString(),
                    StockAmount = Convert.ToInt32(reader["StockAmount"]),
                    UnitPrice = Convert.ToDecimal(reader["UnitPrice"])
                };
                products.Add(product);
            }
            return products;

        }

        public DataTable GetAll()
        {
            SqlConnection connection = new SqlConnection(connect);

            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
            SqlCommand command = new SqlCommand("Select * from Products",connection);
            SqlDataReader reader = command.ExecuteReader();
            DataTable dataTable = new DataTable();
            dataTable.Load(reader);
            reader.Close();
            connection.Close();
            return dataTable;

        }

        public void Add(Product product)
        {
            SqlConnection connection = new SqlConnection(connect);

            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
               // string kayit = "insert into musteriler(tcno,isim,soyisim,telefon,adres) values (@tcno,@isim,@soyisim,@telefon,@adres)";
            }
            SqlCommand command = new SqlCommand("insert into Products (Name,StockAmount,UnitPrice) Values(@Name,@StockAmount,@UnitPrice)", connection);
            command.Parameters.AddWithValue("@Name", product.Name);
            command.Parameters.AddWithValue("@StockAmount", product.StockAmount);
            command.Parameters.AddWithValue("@UnitPrice", product.UnitPrice);
            command.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Eklendi");

        }

        public void Update(Product product)
        {
            SqlConnection connection = new SqlConnection(connect);

            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
            SqlCommand command = new SqlCommand("Update Products Set Name=@Name,StockAmount=@StockAmount,UnitPrice=@UnitPrice Where Id=@id", connection);
            command.Parameters.AddWithValue("@id", product.Id);
            command.Parameters.AddWithValue("@Name", product.Name);
            command.Parameters.AddWithValue("@StockAmount", product.StockAmount);
            command.Parameters.AddWithValue("@UnitPrice", product.UnitPrice);
            command.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Güncellendi");
        }

        public void Delete(int id)
        {
            SqlConnection connection = new SqlConnection(connect);

            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
            SqlCommand command = new SqlCommand("Delete From Products Where Id=@id", connection);
            command.Parameters.AddWithValue("@id",id);
            command.ExecuteNonQuery();
            connection.Close();


        }
    }
}
