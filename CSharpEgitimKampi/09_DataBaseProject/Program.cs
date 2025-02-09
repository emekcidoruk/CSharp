using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_DataBaseProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ado.net ------ C#'da SQL yapılarını kullanmamızı sağlayan çarçeve

            Console.WriteLine("***** C# Veri Tabanlı Ürün Kategori Bilgi Sistemi *****");
            Console.WriteLine();
            Console.WriteLine();

            string tableNumber;
            Console.WriteLine("------------------------------------------------------------------");
            
            Console.WriteLine("1-Kategoriler");
            Console.WriteLine("2-Ürünler");
            Console.WriteLine("3-Siparişler");
            Console.WriteLine("4-Çıkış yap");
            Console.Write("Lütfen getirmek istediğiniz tablo numarasını giriniz : ");
            tableNumber = Console.ReadLine();
            Console.WriteLine("------------------------------------------------------------------");

            SqlConnection connection = new SqlConnection("Data Source=DORUKEMEKCI;initial Catalog=EgitimKampiDB;integrated security=true"); //Bağlantı oluşturuldu
            connection.Open(); //Bağlantıyı açtık
            SqlCommand command = new SqlCommand("Select * From TblCategory", connection); //
            SqlDataAdapter adapter = new SqlDataAdapter(command);// C#'daki kodlarla SQL sunucusu arasında bir köpri görevi görüyor

            DataTable dataTable = new DataTable(); // Verileri geçici belleğe almamızı sağlar
            adapter.Fill(dataTable);
            connection.Close();

            foreach (DataRow row in dataTable.Rows) 
            {
                foreach(var item in row.ItemArray)
                {
                    Console.Write(item);
                }
                Console.WriteLine();
            }

            Console.Read();
        }
    }
}
