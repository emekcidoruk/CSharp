using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Geriye Değer Döndürmeyen Void Metotlar

            // Bir yapının metot olması için "()" gerekli

            // Metotlar ikiye ayrılır:
            // 1) Geriye değer döndürmeyen metotlar

            // Void

            //void CostumerList()
            //{
            //    Console.WriteLine("Ali Yıldız");
            //    Console.WriteLine("Ayşe Yıldız");
            //    Console.WriteLine("Hakan Öztürk");
            //    Console.WriteLine("Merve Çınar");
            //}

            //CostumerList();


            //void Sum()
            //{
            //    int x = 1;
            //    int y = 2;
            //    int z = x + y;
            //    Console.WriteLine(z);
            //}

            //Sum();

            #endregion

            #region Geriye Değer Döndürmeyen string Parametreli Metotlar

            //void WriteMethod(string customerName)
            //{
            //    Console.WriteLine(customerName);
            //}

            //WriteMethod("Mehmet Yıldırım");

            #endregion

            #region Geriye Değer Döndürmeyen Müşteri Kartı Örnek

            //void CustomerCard(string Name,string surName)
            //{
            //    Console.WriteLine("Müşteri : " + Name + " " + surName);
            //}

            //CustomerCard("Doruk", "Emekçi");
            //CustomerCard("Ayşegül", "Kaya");

            #endregion

            #region Geriye Değer Döndürmeyen int Parametreli Metotlar

            //void sum(int number1, int number2,int number3)
            //{
            //    int result=number1 + number2 + number3;
            //    Console.WriteLine(result);
            //}

            //sum(4, 5, 6);

            #endregion

            #region Geriye Değer Döndüren Metotlar

            //string customerName()
            //{
            //    return "Buse Yıldız"; // Geriye değer döndürme işlemleri "return" ile yapılır.
            //}

            //customerName();

            #endregion

            #region Geriye Değer Döndüren Metotlar Öğrenci Kartı Örnek

            //string studentCard()
            //{
            //    string name = "Ali";
            //    string surName = "Yıldız";

            //    return name + " " + surName;
            //}

            //Console.WriteLine(studentCard());

            #endregion

            #region Geriye Değer Döndüren string Parametreli Metotlar

            //string countryCard(string countryName,string capital,string flagColor)
            //{
            //    string cardİnfo = "Ülke : " + countryName + " / Başkent : " + capital + " / Bayrak Rengi : " + flagColor;
            //    return cardİnfo;
            //}

            //string x, y, z;
            //Console.Write("Ülke adını giriniz : ");
            //x= Console.ReadLine();

            //Console.Write("Başkent adını giriniz : ");
            //y = Console.ReadLine();

            //Console.Write("Bayrak rengini giriniz : ");
            //z = Console.ReadLine();

            //Console.WriteLine(countryCard(x, y, z));

            //Console.WriteLine(countryCard("İtalya", "Roma", "Kırmızı-Beyaz-Yeşil"));

            #endregion

            #region Geriye Değer Döndüren int Parametreli Metotlar

            //int sum(int number1, int number2)
            //{
            //    int result=number1 + number2;
            //    return result;
            //}

            //Console.WriteLine(sum(1, 2));
            //Console.WriteLine(sum(3, 4));
            //Console.WriteLine(sum(5, 6));
            //Console.WriteLine(sum(7, 8));

            #endregion

            #region Örnek Uygulama

            //string examResult(string student,int exam1,int exam2,int exam3)
            //{
            //    int result = (exam1 + exam2 + exam3) / 3;
            //    if (result >= 50)
            //    {
            //        return "Ortalama : " + result + " / " + student + " adlı öğrenci sınavı geçti";
            //    }
            //    else
            //    {
            //        return "Ortalama : " + result + " / " + student + " adlı öğrenci başarısız oldu";
            //    }
            //}

            //Console.WriteLine(examResult("Ali", 75, 70, 88));
            //Console.WriteLine(examResult("Ayşe", 41, 70, 28));
            //Console.WriteLine(examResult("Doruk", 65, 72, 68));

            #endregion

            Console.Read();

        }
    }
}
