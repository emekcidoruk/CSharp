﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_DatabaseCrud
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Crud-->Create-Read-Update-Delete

            Console.WriteLine("***** Menü Sipariş İşlem Paneli *****");
            Console.WriteLine();

            Console.WriteLine("---------------------------------------");
            #region Kategori Ekleme İşlemi

            //Console.Write("Eklemek İstediğiniz Kategori Adı : ");
            //string categoryName=Console.ReadLine();

            //SqlConnection connection = new SqlConnection("Data Source = DORUKEMEKCI ; initial catalog = EgitimKampiDB ; integrated security = true");

            //connection.Open();

            //SqlCommand command = new SqlCommand("insert into TblCategory (CategoryName) values (@p1)", connection);
            //command.Parameters.AddWithValue("@p1", categoryName);
            //command.ExecuteNonQuery();

            //connection.Close();

            //Console.WriteLine("Kategori Başarıyla Eklendi");

            #endregion

            #region Ürün Ekleme İşlemi

            //string productName;
            //decimal productPrice;
            //bool productStatus;

            //Console.Write("Ürün Adı : ");
            //productName = Console.ReadLine();
            //Console.Write("Ürün Fiyatı : ");
            //productPrice = decimal.Parse(Console.ReadLine());

            //SqlConnection connection = new SqlConnection("Data source = DORUKEMEKCI ; initial catalog = EgitimKampiDB ; integrated security = true");
            //connection.Open();

            //SqlCommand command = new SqlCommand("insert into TblProduct (ProductName , ProductPrice , ProductStatus) values (@productName , @productPrice , @productStatus)", connection);
            //command.Parameters.AddWithValue("@productName", productName);
            //command.Parameters.AddWithValue("@productPrice", productPrice);
            //command.Parameters.AddWithValue("@productStatus", true);
            //command.ExecuteNonQuery();
            //connection.Close();

            //Console.WriteLine("Ürün Eklemesi Başarılı !!");

            #endregion

            #region Ürün Listeleme işlemi

            //SqlConnection connection = new SqlConnection("Data Source=DORUKEMEKCI;initial Catalog=EgitimKampiDB;integrated security=true");

            //connection.Open();

            //SqlCommand command = new SqlCommand("Select * From TblProduct", connection);
            //SqlDataAdapter adapter = new SqlDataAdapter(command);
            //DataTable dataTable = new DataTable();
            //adapter.Fill(dataTable);

            //foreach (DataRow row in dataTable.Rows)
            //{
            //    foreach (var item  in row.ItemArray)
            //    {
            //        Console.Write(item.ToString() + " // ");
            //    }
            //    Console.WriteLine();
            //    Console.WriteLine();
            //}

            //connection.Close();

            #endregion

            #region Ürün Silme İşlemi

            //SqlConnection connection = new SqlConnection("Data Source=DORUKEMEKCI;initial Catalog=EgitimKampiDB;integrated security=true");

            //connection.Open();

            //Console.Write("Silinecek Ürün ID = ");
            //int productID = int.Parse(Console.ReadLine());

            //SqlCommand command = new SqlCommand("Delete From TblProduct Where ProductId=@productID", connection);
            //command.Parameters.AddWithValue("@productID", productID);
            //command.ExecuteNonQuery();

            //connection.Close();

            //Console.WriteLine("Silem işlemi yapıldı");

            #endregion

            #region Ürün Güncelleme İşlemi

            //Console.Write("Güncellenecek Ürün ID : ");
            //int productID=int.Parse(Console.ReadLine());

            //Console.Write("Güncellenecek Ürün Adı : ");
            //string productName=Console.ReadLine();

            //Console.Write("Güncellenecek Ürün Fiyatı : ");
            //decimal productPrice=decimal.Parse(Console.ReadLine());

            //SqlConnection connection = new SqlConnection("Data Source=DORUKEMEKCI;initial Catalog=EgitimKampiDB;integrated security=true");
            
            //connection.Open();

            //SqlCommand command = new SqlCommand("Update TblProduct Set ProductName=@productName , ProductPrice=@productPrice where ProductID=@productID",connection);
            //command.Parameters.AddWithValue("@productName", productName);
            //command.Parameters.AddWithValue("@productPrice", productPrice);
            //command.Parameters.AddWithValue("@productID", productID);
            //command.ExecuteNonQuery();

            //Console.WriteLine("Güncelleme Başarılı !!");

            //connection.Close();

            #endregion

            Console.Read();
        }
    }
}
