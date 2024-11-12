using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_LoopsWthStars
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Alt alta 10 tane yıldız oluşturma

            //for (int i = 1; i <= 10; i++)
            //{
            //    Console.WriteLine("*");
            //}

            #endregion

            #region Yan yana 10 tane yıldız oluşturma

            //for (int i = 1; i <= 10; i++)
            //{
            //    Console.Write("*");
            //}

            #endregion

            #region Alt alta 10 tane yıldız oluşturma her satırda 10 tane yıldız olsun

            //for (int i = 1; i <= 10; i++)
            //{
            //    Console.WriteLine("**********");
            //}

            #endregion

            #region Yıldızlarla Dik Üçgen

            //for (int i = 1; i <= 5; i++)
            //{
            //    for (int j = 1; j <= i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            #endregion

            #region Yıldızlarla Ters Dik Üçgen

            //for (int i = 5; i >= 1; i--)
            //{
            //    for (int j = 1; j <= i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            #endregion

            #region Yıldızlarla Dik ve Ters Dik Üçgen Beraber

            //for (int i = 1;i <= 10;i++)
            //{
            //    for(int j = 1;j <= i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            //for(int k = 9; k >= 1; k--)
            //{
            //    for(int t = 1; t <= k; t++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            #endregion

            #region Yıldızlarla Baklava Dilimi 

            //int n = 10;

            //Üst yarısı
            //for (int i = 1; i<=n; i++)
            //{
            //    for(int m = n; m >= i; m--)
            //    {
            //        Console.Write(" ");
            //    }
            //    for (int j = n - 1; j > 0; j--)
            //    {
            //        Console.Write(" ");
            //    }

            //    for (int k = 1; k <= 2 * i - 1; k++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            //alt yarısı
            //for(int i = n - 1; i >= 1; i--)
            //{
            //    for (int h = n; h >= i; h--)
            //    {
            //        Console.Write(" ");
            //    }
            //    for(int j = n - 1;j > 0; j--)
            //    {
            //        Console.Write(" ");
            //    }

            //    for( int k = 1;k <= 2 * i - 1; k++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}   

            #endregion

            #region Yıldızlarla Piramit 

            //int n = 10;

            //for (int i = 1; i <= n; i++)
            //{
                  //başluklar
            //    for (int j = n - i; j > 0; j--)
            //    {
            //        Console.Write(" ");
            //    }

                  //yıldızlar
            //    for (int k = 1; k <= 2*i-1; k++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            #endregion

            #region Yıldızlarla Ters Piramit

            //int n = 10;

            //for(int i = n;i>=1;i--)
            //{
            //    for(int j = n - i; j >= 0; j--)
            //    {
            //        Console.Write(" ");
            //    }

            //    for(int k = 1; k <= 2 * i - 1; k++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            #endregion

            Console.Read();

        }
    }
}
