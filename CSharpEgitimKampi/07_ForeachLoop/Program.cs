using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_ForeachLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Temel Kavramlar

            //Foreach(1;2;3;4)

            //1 : Değişken türü
            //2 : Değişken adı
            //3 : In
            //4 : Liste, Koleksiyon, Dizi adı



            //string[] cities = { "Milano", "Roma", "Budapeşte", "Ankara", "İstanbul", "Varşova" };

            //foreach (string x in cities)
            //{
            //    Console.WriteLine(x);



            //int[] numbers = { 45, 78, 635, 78, 47, 45, 96, 12, 18, 985 };

            //foreach (int number in numbers)
            //{
            //    Console.WriteLine(number);
            //}



            //int[] numbers = { 45, 78, 635, 78, 47, 45, 96, 12, 18, 985 };

            //foreach (int number in numbers)
            //{
            //    if (number % 2 == 0)
            //    {
            //        Console.WriteLine(number);
            //    }
            //}

            #endregion

            #region Foreach ile Matematiksel İşlemler

            ////Toplama

            //int[] numbers = { 45, 78, 635, 78, 47, 45, 96, 12, 18, 985 };

            //int Total = 0;

            //foreach (int i in numbers)
            //{
            //    Total += i;
            //}
            //Console.WriteLine(Total);


            ////Çıkarma

            //int[] numbers = { 45, 78, 635, 78, 47, 45, 96, 12, 18, 985 };

            //int substract = 0;

            //foreach (int i in numbers)
            //{
            //    substract -= i;
            //}
            //Console.WriteLine(substract);


            ////Çarpma

            //int[] numbers = { 45, 78, 635, 78, 47, 45, 96, 12, 18, 985 };

            //int impact = 1;

            //foreach (int i in numbers)
            //{
            //    impact *= i;
            //}
            //Console.WriteLine(impact);


            ////Bölme

            //double[] numbers = { 45.0, 78.0, 635.0, 78.0, 47.0, 45.0, 96.0, 12.0, 18.0, 985.0 };

            //double divide = 1;

            //foreach (int i in numbers)
            //{
            //    divide /= i;
            //}
            //Console.WriteLine(divide);

            #endregion

            #region Listeler ile Kullanımı

            //List<int> numbers = new List<int>()
            //{
            //    458,47,25,1114,55556,885,7774,995
            //};

            //foreach (int number in numbers)   //"foreach" döngüsü sadece diziler ile kullanılmaz. Aynı zamanda listeler ile de kullanılabilir
            //{
            //    Console.WriteLine(number);
            //}

            #endregion

            #region Bir Kelimeyi Harflerine Ayıran Program

            //string word = "Merhaba";

            //foreach(char c in word)
            //{
            //    Console.WriteLine(c);
            //}

            #endregion

            Console.Read();

        }
    }
}
