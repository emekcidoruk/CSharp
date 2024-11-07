using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region double Degiskeni

            //double number; //Ondalıklı sayıları tanımlamak için kullanılır

            //number = 4.85;

            //Console.WriteLine(number);

            //Console.WriteLine("***** Fiyat Listesi *****");
            //Console.WriteLine();

            //double applePrice, orangePrice, strawberryPrice, potatoPrice, tomatoPrice;

            //applePrice = 14.85;
            //orangePrice = 20.95;
            //strawberryPrice = 45;
            //potatoPrice = 9.74;
            //tomatoPrice = 6.88;

            //Console.WriteLine("---- Elma Birim Fiyatı : " + applePrice + " TL");
            //Console.WriteLine("---- Portakal Birim Fiyatı : " + orangePrice + " TL");
            //Console.WriteLine("---- Çilek Birim Fiyatı : " + strawberryPrice + " TL");
            //Console.WriteLine("---- Patates Birim Fiyatı : " + potatoPrice + " TL");
            //Console.WriteLine("---- Domates Birim Fiyatı : " + tomatoPrice + " TL");
            //Console.WriteLine();

            //double appleGram, orangeGram, strawberryGram, potatoGram, tomatoGram;

            //appleGram = 1.245;
            //orangeGram = 2.650;
            //strawberryGram = 0.750;
            //potatoGram = 4.859;
            //tomatoGram = 3.745;

            //double appleTotalPrice = appleGram * applePrice;
            //double orangeTotalPrice = orangeGram * orangePrice;
            //double strawberryTotalPrice = strawberryGram * strawberryPrice;
            //double potatoTotalPrice = potatoGram * potatoPrice;
            //double tomatoTotalPrice = tomatoGram * tomatoPrice;

            //Console.WriteLine("Alınan Ürün : Elma - " + "Birim Fiyat : " + applePrice + " TL" + " - Gramaj : " + appleGram + " gr" + " - Toplam Tutar : " + appleTotalPrice + " TL");
            //Console.WriteLine("Alınan Ürün : Portakal - " + "Birim Fiyat : " + orangePrice + " TL" + " - Gramaj : " + orangeGram + " gr" + " - Toplam Tutar : " + orangeTotalPrice + " TL");
            //Console.WriteLine("Alınan Ürün : Çilek - " + "Birim Fiyat : " + strawberryPrice + " TL" + " - Gramaj : " + strawberryGram + " gr" + " - Toplam Tutar : " + strawberryTotalPrice + " TL");
            //Console.WriteLine("Alınan Ürün : Patates - " + "Birim Fiyat : " + potatoPrice + " TL" + " - Gramaj : " + potatoGram + " gr" + " - Toplam Tutar : " + potatoTotalPrice + " TL");
            //Console.WriteLine("Alınan Ürün : Domates - " + "Birim Fiyat : " + tomatoPrice + " TL" + " - Gramaj : " + tomatoGram + " gr" + " - Toplam Tutar : " + tomatoTotalPrice + " TL");

            //double shoppingTotalPrice = appleTotalPrice + orangeTotalPrice + strawberryTotalPrice + potatoTotalPrice + tomatoTotalPrice;

            //Console.WriteLine();
            //Console.WriteLine();

            //Console.WriteLine("Alışveriş için ödenecek toplam tutar : " + shoppingTotalPrice + " TL");

            #endregion

            #region char Degiskeni

            //char değişkeni sadece karakter için kullanılır
            // "..." yerine '...' kullanılır ***

            //char symbol;
            //symbol = 'a';

            //Console.WriteLine(symbol);

            #endregion

            #region Klavyeden Veri Girisleri/String Degiskenler

            //Console.WriteLine("**** CSharp Hava Yolları Yolcu Bilgisi ****");
            //Console.WriteLine();

            //string passengerName, passengerSurname, passengerDistrict, passengerCity, passengerAge, passengerIdentityNumber;

            //Console.Write("Yolcu Adı : ");
            //passengerName = Console.ReadLine();

            //Console.Write("Yolcu Soyadı : ");
            //passengerSurname = Console.ReadLine();

            //Console.Write("Yolcu Yaş Bilgisi : ");
            //passengerAge = Console.ReadLine();

            //Console.Write("Yolcu İlçe Bilgisi : ");
            //passengerDistrict = Console.ReadLine();

            //Console.Write("Yolcu Şehir Bilgisi : ");
            //passengerCity = Console.ReadLine();

            //Console.Write("Yolcu TC Kimlik Numarası : ");
            //passengerIdentityNumber = Console.ReadLine();

            //Console.WriteLine();

            //Console.WriteLine("----------------------------");
            //Console.WriteLine();

            //Console.WriteLine("Yolcu TC Kimlik No : " + passengerIdentityNumber + " - Yolcu Ad Soyad : " + passengerName + " " + passengerSurname + " " + "- Yolcu Yaş : " + passengerAge + " " + passengerDistrict + "/" + passengerCity);


            #endregion

            #region Klavyeden Tam Sayı Girisleri ve Donusumlar

            //int shoesPrice, computerPrice, chairPrice, tvPrice;
            //shoesPrice = 1000;
            //computerPrice = 20000;
            //chairPrice = 5000;
            //tvPrice = 12000;

            //int shoesCount, computerCount, chairCount, tvCount;

            //Console.Write("Lütfen aldığınız ayakkabı sayısını giriniz : ");
            //shoesCount=int.Parse(Console.ReadLine()); // int.Parse ifadesi, stirng bir ifade olarak algılanan ifadeyi int'e çevirir.

            //Console.Write("Lütfen aldığınız bilgisayar sayısını giriniz : ");
            //computerCount = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen aldığınız sandalye sayısını giriniz : ");
            //chairCount = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen aldığınız televizyon sayısını giriniz : ");
            //tvCount = int.Parse(Console.ReadLine());

            //int totalPrice = (shoesCount * shoesPrice) + (computerCount * computerPrice) + (chairCount * chairPrice) + (tvCount * tvPrice);

            //Console.WriteLine();

            //Console.WriteLine("Toplam Ödenecek Tutar : "+totalPrice);

            #endregion

            #region Klavyeden Ondalıklı Sayı İşlemleri

            //double exam1, exam2, exam3, result;

            //Console.Write("Lütfen 1. sınav notunu giriniz : ");
            //exam1=double.Parse(Console.ReadLine());

            //Console.Write("Lütfen 2. sınav notunu giriniz : ");
            //exam2 = double.Parse(Console.ReadLine());

            //Console.Write("Lütfen 3. sınav notunu giriniz : ");
            //exam3 = double.Parse(Console.ReadLine());

            //result = (exam1 + exam2 + exam3) / 3;
            //Console.WriteLine();

            //Console.WriteLine("Sınav Ortalamanız : " + result);

            #endregion

            #region Klavyeden Karakter Girişleri

            //char gender;

            //Console.Write("Lütfen cinsiyet seçiniz : ");
            //gender=char.Parse(Console.ReadLine());

            //Console.WriteLine("Seçtiğiniz cinsiyet : " + gender);

            #endregion

            Console.Read();
        }
    }
}
