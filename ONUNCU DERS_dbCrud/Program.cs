using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ONUNCU_DERS_dbCrud
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //CRUD -> Create Read Update Delete

            Console.WriteLine("----- Menü Paneli -----");
            Console.WriteLine();
            Console.WriteLine("-----------------------");
            #region kategori ekleme
            //Console.Write("Eklemek istediğiniz kategori adı : ");
            //string categoryName = Console.ReadLine();

            //SqlConnection connection = new SqlConnection("Data Source = MSI\\SQLEXPRESS;initial catalog = EGITIMKAMPIDB;integrated security = true");

            //connection.Open();
            //SqlCommand command = new SqlCommand("insert into tblcategory (CategoryName) values (@p1)", connection);
            //command.Parameters.AddWithValue("@p1", categoryName);
            //command.ExecuteNonQuery();
            //connection.Close();
            //Console.WriteLine("Kategori eklendi! ");

            #endregion

            #region ürün ekleme birden fazla işlem

            //Console.Write("Ürün Adı : ");
            //string productName = Console.ReadLine();
            //Console.Write("Ürün Fiyatı : ");
            //decimal productPrice = Convert.ToDecimal(Console.ReadLine());
            //Console.Write("Ürün Durumu : ");
            //bool productStatus = bool.Parse(Console.ReadLine());
            //Console.WriteLine("-----------------------");

            //SqlConnection connection = new SqlConnection("Data Source = MSI\\SQLEXPRESS;initial catalog = EGITIMKAMPIDB;integrated security = true");
            //connection.Open();
            //SqlCommand command = new SqlCommand("insert into tblProduct (ProductName,ProductPrice,ProductStatus) values (@p1,@p2,@p3)", connection);
            //command.Parameters.AddWithValue("@p1", productName);
            //command.Parameters.AddWithValue("@p2", productPrice);
            //command.Parameters.AddWithValue("@p3", productStatus);
            //command.ExecuteNonQuery();
            //connection.Close();
            //Console.WriteLine("İşlemler Başarıyla Tamamlandı ");

            #endregion

            #region ürün listeleme

            //SqlConnection connection = new SqlConnection("Data Source = MSI\\SQLEXPRESS;initial catalog = EGITIMKAMPIDB;integrated security = true");
            //connection.Open();
            //SqlCommand command = new SqlCommand("Select * from tblProduct",connection);
            //SqlDataAdapter adapter = new SqlDataAdapter(command);
            //DataTable dataTable = new DataTable();
            //adapter.Fill(dataTable);

            //foreach (DataRow row in dataTable.Rows)
            //{
            //    foreach (var item in row.ItemArray)
            //    {
            //        Console.Write(item.ToString() + " ");
            //    }
            //    Console.WriteLine();
            //}
            //connection.Close();
            #endregion

            #region ürün silme
            //Console.WriteLine("Silinecek ürün adı : ");
            //string productName = Console.ReadLine();

            //SqlConnection connection = new SqlConnection("Data Source = MSI\\SQLEXPRESS;initial catalog = EGITIMKAMPIDB;integrated security = true");
            //connection.Open();

            //SqlCommand command = new SqlCommand("Delete From tblProduct Where productName=@prdName", connection);
            //command.Parameters.AddWithValue("@prdName", productName);
            //command.ExecuteNonQuery();
            //connection.Close();

            //Console.WriteLine("Silme işlemi başarılı!");


            #endregion

            #region ürün güncelleme

            Console.Write("Güncellemek istediğiniz ürün numarasını giriniz : ");
            int productID = int.Parse(Console.ReadLine());

            Console.Write("Yeni ürün adı : ");
            string productName = Console.ReadLine();

            Console.Write("Yeni ürün fiyatı : ");
            decimal productPrice = int.Parse(Console.ReadLine());

            SqlConnection connection = new SqlConnection("Data Source = MSI\\SQLEXPRESS;initial catalog = EGITIMKAMPIDB;integrated security = true");
            connection.Open();

            SqlCommand Command = new SqlCommand("Update tblProduct set ProductName=@productName,ProductPrice=@productPrice where ProductID =@productID", connection);

            Command.Parameters.AddWithValue("@productName", productName);
            Command.Parameters.AddWithValue("@productPrice",productPrice);
            Command.Parameters.AddWithValue("@productID",productID);
            Command.ExecuteNonQuery();
            connection.Close();
            Console.WriteLine("Güncelleme İşlemi Başarılı! ");
            #endregion
            Console.Read();
        }
    }
}
