using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_MakingDecision
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region If / Else Yapısı

            //Console.Write("Lütfen Şifreyi Giriniz : ");
            //string password;
            //password = Console.ReadLine();
            //if (password == "abcd")
            //{
            //    Console.WriteLine("Şifre Doğru");
            //}
            //else
            //{
            //    Console.WriteLine("Şifre Yanlış");
            //}

            //string capital, country;
            //Console.Write("Başkenti Giriniz : ");
            //capital = Console.ReadLine();

            //Console.Write("Ülkeyi Giriniz : ");
            //country = Console.ReadLine();

            //if (capital == "ankara" & country == "türkiye") //Karakterler birebir aynı formatta olması lazım. Ya hepsi büyük ya hepsi küçük
            //{
            //    Console.WriteLine("Veriler Doğrulandı");
            //}
            //else
            //{
            //    Console.WriteLine("Hatalı Bilgi");
            //}

            //int number;
            //Console.Write("Sayıyı Giriniz : ");  
            //number=int.Parse(Console.ReadLine());
            //if (number == 5)
            //{
            //    Console.WriteLine("Sayı Doğru");
            //}
            //else
            //{
            //    Console.WriteLine("Sayı Hatalı");
            //}

            //int exam1, exam2, exam3, average;
            //string result = "HATA !!";

            //Console.Write("1. Sınavın Notunu Giriniz : ");
            //exam1=int.Parse(Console.ReadLine());
            //Console.Write("2. Sınavın Notunu Giriniz : ");
            //exam2 = int.Parse(Console.ReadLine());
            //Console.Write("3. Sınavın Notunu Giriniz : ");
            //exam3 = int.Parse(Console.ReadLine());

            //average = (exam1 + exam2 + exam3) / 3;
            //Console.WriteLine("Sınavların Ortalaması : "+average);

            //if (average > 0 & average <= 50)
            //{
            //    result = "Sonuç Vasat";
            //}
            //if(average >51 & average <= 70)
            //{
            //    result = "Sonuç Orta";
            //}
            //if (average >70 & average <= 84)
            //{
            //    result = "Sonuç İyi";
            //}
            //if (average > 84)
            //{
            //    result = "Sonuç Çok İyi";
            //}

            //Console.WriteLine(result);

            //string city;
            //Console.Write("Lütfen Şehir Girişi Yapınız : ");
            //city=Console.ReadLine();

            //if (city == "adana" | city == "ankara" | city == "bursa" | city == "trabzon")
            //{
            //    Console.WriteLine("Şehir Mevcut");
            //}
            //else
            //{
            //    Console.WriteLine("Şehir Mevcut Değil");
            //}

            //Console.Write("Lütfen Kullanıcı Adını Giriniz : ");
            //string userName = Console.ReadLine();

            //if(userName != "admin")
            //{
            //    Console.WriteLine("Bu Kullanıcı Adı Kabul Edilemez !!");
            //}
            //else
            //{
            //    Console.WriteLine("Hoş Geldiniz :)");
            //}

            #endregion

            #region Mod İşlemleri

            //int number;
            //number = 26;
            //int result = number % 5;
            //Console.WriteLine(result);

            //Console.Write("Lütfen 1. sayı giriniz : ");
            //int number1=int.Parse(Console.ReadLine());

            //Console.Write("Lütfen 2. sayıyı giriniz : ");
            //int number2=int.Parse(Console.ReadLine());

            //int result = number1 % number2;

            //Console.Write("1. sayının 2. sayıya bölümünden kalan : " + result);

            //Console.Write("Lütfen sayıyı giriniz : ");
            //int number = int.Parse(Console.ReadLine());

            //if (number % 2 == 0)
            //{
            //    Console.Write("Sayı çifttir");
            //}
            //else
            //{
            //    Console.Write("Sayı tektir");
            //}

            #endregion

            #region Char Değişkenler ve Karar Yapıları

            //char team;
            //Console.Write("Lütfen takım sembolünü griniz : ");
            //team = char.Parse(Console.ReadLine());

            //if (team == 'g' | team == 'G')
            //{
            //    Console.Write("hakemsaray");
            //}

            //if (team == 'f' | team == 'F')
            //{
            //    Console.Write("FENERBAHÇE");
            //}

            //if (team == 'b' | team == 'B')
            //{
            //    Console.Write("Beşiktaş");
            //}

            #endregion

            #region Örnek Uygulama

            //Console.WriteLine("****** C# Eğitim Kampı Restorant ******");
            //Console.WriteLine();
            //Console.WriteLine("----------------------------------");
            //Console.WriteLine("1-Ana Yemekler");
            //Console.WriteLine("2-Çorbalar");
            //Console.WriteLine("3-Pizzalar");
            //Console.WriteLine("4-İçecekler");
            //Console.WriteLine("5-Tatlılar");
            //Console.WriteLine("----------------------------------");
            //Console.WriteLine();

            //string menuItem;

            //Console.Write("Detayını görmek istediğiniz menü seçimi : ");
            //menuItem = Console.ReadLine();

            //if (menuItem == "1")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("------------Ana Yemekler------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Köri Soslu Tavuk");
            //    Console.WriteLine("2-Kızartma Tabağı");
            //    Console.WriteLine("3-Fasulye Pilav");
            //    Console.WriteLine("4-Fırında Somon");
            //    Console.WriteLine("5-Patlıcan Musakka");
            //    Console.WriteLine("------------Ana Yemekler------------");

            //    Console.WriteLine();
            //}

            //if (menuItem == "2")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("------------Çorbalar------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Mercimek");
            //    Console.WriteLine("2-Ezogelin");
            //    Console.WriteLine("------------Çorbalar------------");

            //    Console.WriteLine();
            //}

            //if (menuItem == "3")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("------------Pizzalar------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Gamer Pizza");
            //    Console.WriteLine("2-Kavurmalı Pizza");
            //    Console.WriteLine("3-New York Pizza");
            //    Console.WriteLine("4-Klasik Pizza");
            //    Console.WriteLine("5-Margarita Pizza");
            //    Console.WriteLine("------------Pizzalar------------");

            //    Console.WriteLine();
            //}

            //if (menuItem == "4")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("------------İçecekler------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Coca Cola");
            //    Console.WriteLine("2-Coca Cola Zero");
            //    Console.WriteLine("3-Fanta");
            //    Console.WriteLine("4-Portakal Suyu");
            //    Console.WriteLine("5-Karışık Meyve Suyu");
            //    Console.WriteLine("------------İçecekler------------");

            //    Console.WriteLine();
            //}

            //if (menuItem == "5")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("------------Tatlılar------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Trileçe");
            //    Console.WriteLine("2-Kazandibi");
            //    Console.WriteLine("3-Sütlaç");
            //    Console.WriteLine("4-Baklava");
            //    Console.WriteLine("5-Künefe");
            //    Console.WriteLine("------------Tatlılar------------");

            //    Console.WriteLine();
            //}


            #endregion

            #region Switch Case

            //Console.Write("Lütfen Ay Girişi Yapınız : ");
            //int monthNumber=int.Parse(Console.ReadLine());

            //switch (monthNumber)
            //{
            //    case 1:Console.Write("Ocak"); break;
            //    case 2:Console.Write("Şubat"); break;
            //    case 3:Console.Write("Mart"); break;
            //    case 4:Console.Write("Nisan"); break;
            //    case 5:Console.Write("Mayıs"); break;
            //    case 6:Console.Write("Haziran"); break;
            //    case 7:Console.Write("Temmuz"); break;
            //    case 8:Console.Write("Ağustos"); break;
            //    case 9:Console.Write("Eylül"); break;
            //    case 10:Console.Write("Ekim"); break;
            //    case 11:Console.Write("Kasım"); break;
            //    case 12:Console.Write("Aralık"); break;
            //    default: Console.Write("Hatalı Veri Girişi !!"); break;
            //}

            #endregion

            #region Switch Case Hesap Makinesi

            int number1, number2, result;
            char symbol;

            Console.Write("1. Sayıyı Giriniz : ");
            number1=int.Parse(Console.ReadLine());

            Console.Write("2. Sayıyı Giriniz : ");
            number2 = int.Parse(Console.ReadLine());

            Console.Write("Lütfen Yapmak İstediğiniz İşlemi Giriniz : ");
            symbol=char.Parse(Console.ReadLine());  

            switch (symbol)
            {
                case '+':
                    result=number1 + number2;
                    Console.WriteLine("Toplam : " + result);
                    break;

                case '-':
                    result=number1 - number2;
                    Console.WriteLine("Fark : " + result);
                    break;

                case '/':
                    result = number1 / number2;
                    Console.WriteLine("Bölüm : " + result);
                    break;

                case '*':
                    result = number1 * number2;
                    Console.WriteLine("Çarpım : " + result);
                    break;

                default:
                    Console.WriteLine("YANLIŞ BİR TUŞA BASTINIZ !!");
                    break;
            }   

            #endregion

            Console.Read();

        }
    }
}
