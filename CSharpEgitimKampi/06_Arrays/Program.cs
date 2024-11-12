using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Temel Dizi Örnekleri

            //DeğişkenTürü [] DiziAdı = new DeğişkenTürü[Eleman sayısı]

            //string[] colors = new string[4];
            //colors[0] = "Kırmızı";
            //colors[1] = "Sarı";
            //colors[2] = "Lacivert";
            //colors[3] = "Beyaz";

            //Console.WriteLine(colors[2]);




            //string[] cities = new string[5];
            //cities[0] = "Milano";
            //cities[1] = "Budapeşte";
            //cities[2] = "Lyon";
            //cities[3] = "Kahire";
            //cities[4] = "Üsküp";

            //Console.WriteLine(cities[3]);




            //int[] numbers = new int[10];
            //numbers[0] = 2;
            //numbers[1] = 4;           
            //numbers[3] = 8;
            //numbers[4] = 10;            
            //numbers[6] = 14;          
            //numbers[8] = 18;
            //numbers[9] = 20;

            //Console.WriteLine(numbers[2]); //Dizinin içinde olmayan fakat sınırının içine giren ifadelerde sonucu sıfır (0) olarak döndürür




            //string[] cities = { "Prag", "Roma", "Atina", "Ankara", "İstanbul" };

            //Console.WriteLine(cities[3]);

            #endregion

            #region Dizideki Tüm Elemanları Listeleme

            //string[] colors = { "Siyah", "Kırmızı", "Mavi", "Mor", "Sarı", "Lacivert", "Beyaz" };

            //for (int i = 0; i < colors.Length; i++)
            //{
            //    Console.WriteLine("Dizinin " + i + ". Elemanı : " + colors[i]);
            //}



            //int[] numbers = { 4, 85, 96, 75, 125, 635, 488, 522, 7456, 2365, 1120 };

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] % 3 == 0)
            //    {
            //        Console.WriteLine(numbers[i]);
            //    }
            //}



            //char[] symbols = { 'a', 'b', 'c', '*', '/', '-' };

            //for (int i = 0; i < symbols.Length; i++)
            //{
            //    Console.WriteLine(symbols[i]);
            //}

            #endregion

            #region Dizideki En Büyük Elemanı Bulup Ekrana Yazan Program

            //int[] myArray = new int[8];

            //int maxNumber = myArray[0];

            //for (int i = 0; i < myArray.Length; i++)
            //{
            //    Console.Write("Lütfen dizinin "+i+". elemanını giriniz : ");
            //    myArray[i] = int.Parse(Console.ReadLine());
            //    maxNumber = myArray[0];
            //    if (myArray[i] > maxNumber)
            //    {
            //        maxNumber = myArray[i];
            //    } 
            //}
            //Console.WriteLine("-------------------------------------------------");
            //Console.WriteLine("Dizinin en büyük elemanı : "+maxNumber);

            #endregion

            #region Dizi Metotları

            //.Length() ---> Dizinin uzunluğunu bulur 

            //string[] people = { "Ali", "Ahmet", "Ayşe", "Hira", "Doruk", "Cesur" };
            //Console.WriteLine(people.Length);



            //Array.Sort() ---> Dizinin elemanlarını küçükten büyüğe sıralar

            //int[] numbers = { 1, 2, -5, 88, 78, -99 };
            //Array.Sort(numbers);

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.Write(", " + numbers[i]);
            //}



            //Array.IndexOf() ---> Dizideki bir elemanın kaçıncı indiste olduğunu gösterir

            //string[] names = { "Doruk", "Hira", "Reyyan", "Gonca", "Kazım", "Ömer" };

            //int index = Array.IndexOf(names, "Hira");

            //Console.WriteLine(index);



            //.SetValue()---> Dizideki bir elemanı başka bir elemanın yerine yazar

            //string[] names = { "Doruk", "Hira", "Reyyan", "Gonca", "Kazım", "Ömer" };

            //names.SetValue("Cesur", 5);

            //Console.WriteLine(names[5]);



            //Array.Reverse() ---> Diziyi komple tersten sıralıyor

            //int[] numbers = { 1, 2, -5, 88, 78, -99 };
            //Array.Reverse(numbers);

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.Write(", " + numbers[i]);
            //}



            //Array.Clear() ---> Dizi içerisinden eleman silmek için kullanılır

            //string[] names = { "Doruk", "Hira", "Reyyan", "Gonca", "Kazım", "Ömer" };

            //Array.Clear(names,5,1);

            //for(int i = 0;i < names.Length; i++)
            //{
            //    Console.WriteLine(names[i]);
            //}



            //.Max() ---> Dizideki en büyük elemanı bulur

            //int[] numbers = { 1, 2, -5, 88, 78, -99 };

            //Console.WriteLine("Dizinin en büyük değeri : " + numbers.Max());



            //.Min() ---> Dizideki en küçük elemanı bulur

            //int[] numbers = { 1, 2, -5, 88, 78, -99 };

            //Console.WriteLine("Dizinin en küçük değeri : " + numbers.Min());

            #endregion

            #region Kullanıcıdan Değer Alma

            //string[] cities = new string[5];

            //for (int i = 0; i < cities.Length; i++)
            //{
            //    Console.Write($"Lütfen {i+1}. şehri giriniz : "); //"$" işareti çift tırnak ("...") içerisinde parametresel ifadeler kullanmamıza olanak sağlar
            //    cities[i] = Console.ReadLine();
            //}

            //Console.WriteLine();
            //Console.WriteLine("----------------------------------------------");

            //for(int i = 0; i < cities.Length; i++)
            //{
            //    Console.WriteLine($"Dizinin {i + 1}. şehri : " + cities[i]);
            //}



            //KLavyeden girilen dizinin elemanlarının toplamı

            //int[] numbers = new int[5];
            //int sum = 0;

            //for(int i=0; i < numbers.Length; i++)
            //{
            //    Console.Write($"Lütfen dizinin {i + 1}. elemanını giriniz : ");
            //    numbers[i] = int.Parse(Console.ReadLine());
            //    sum += numbers[i];
            //}

            //Console.WriteLine("-------------------------------------------------------");
            //Console.WriteLine("Dizideki elemanların toplamı : " + sum);



            //Klavyeden girilen dizinin elemanlarının çift olanlarını toplayan program

            int[] numbers = new int[5];
            int sum = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write($"Lütfen dizinin {i + 1}. elemanını giriniz : ");
                numbers[i] = int.Parse(Console.ReadLine());
            }

            for(int i = 0;i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    sum += numbers[i];
                }
            }

            Console.WriteLine("-------------------------------------------------------");
            Console.WriteLine("Dizideki çift elemanların toplamı : " + sum);

            #endregion

            Console.Read();

        }
    }
}
