using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOKUZUNCU_DERS_database
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ado.net  c# da sql yapılarını kullanmayı sağlar

            Console.WriteLine("----- C# ÜRÜN BİLGİ SİSTEMİ -----");
            Console.WriteLine();

            string tableNumber;

            Console.WriteLine("---------------------------------");
            Console.WriteLine("1-Kategoriler");
            Console.WriteLine("2-Ürünler");
            Console.WriteLine("3-Siparişler");
            Console.WriteLine("4-Çıkış Yap");
            Console.Write("Lütffen getirmek istediğiniz tablo numarasını giriniz : ");
            tableNumber = Console.ReadLine();
            Console.WriteLine("---------------------------------");

            SqlConnection connection = new SqlConnection("Data Source=MSI\\SQLEXPRESS;initial Catalog=EGITIMKAMPIDB;integrated security=true");
            connection.Open();
            SqlCommand command = new SqlCommand("Select * from tblcategory",connection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            connection.Close();

            foreach (DataRow row in dataTable.Rows)
            {
                foreach(var item in row.ItemArray)
                {
                    Console.Write(" " + item.ToString());
                }
                Console.WriteLine();
            }
            Console.Read();


        }
    }
}
