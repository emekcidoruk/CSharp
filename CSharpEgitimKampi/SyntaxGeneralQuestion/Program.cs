using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SyntaxGeneralQuestion
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Bir öğrencinin adını, soyadını, notlarını ve not ortalamasını alığ ekrana yazan program

            Console.Write("***** C# Eğitim Kampı Sınav Uygulaması *****");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            //Sınıftaki öğrenci sayısını kullanıcıdan alma
            Console.WriteLine("------------------------------");
            Console.Write("Sınıfınızda kaç öğrenci var? : ");
            int studentCount=int.Parse(Console.ReadLine());
            Console.WriteLine("------------------------------");

            //Öğrenci isimlerini ve not ortalamalarını saklayacak diziler
            string[] studentNames = new string[studentCount];
            double[] studentExamAvg = new double[studentCount];

            for (int i = 0; i < studentCount; i++)
            {
                Console.Write($"{i + 1}. öğrencinin ismini giriniz : ");
                studentNames[i] = Console.ReadLine();

                double totalExamResult = 0;

                //Her öğrenci için 3 sınav notu girişi
                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"{studentNames[i]} adlı öğrencinin {j + 1}. sınav notunu giriniz : ");
                    double value = double.Parse(Console.ReadLine());
                    totalExamResult += value;//notları topluyoruz
                }
                studentExamAvg[i] = totalExamResult / 3;
                Console.WriteLine("-----------------------------------------------------");
            }

            //Sınav ortalamaları
            for (int k = 0;k < studentCount; k++)
            {
                Console.WriteLine("-----------------------------------------------------");
                
                Console.WriteLine($"{studentNames[k]} adlı öğrencinin ortalaması : {studentExamAvg[k]}");

                //Öğrencilerin ortalamsı ve geçip/kalma durumları
                if(studentExamAvg[k] >= 50)
                {
                    Console.WriteLine($"{studentNames[k]} adlı öğrenci dersi geçti") ;
                }
                else
                {
                    Console.WriteLine($"{studentNames[k]} adlı öğrenci dersten kaldı");
                }
                Console.WriteLine("-----------------------------------------------------");
            }

            #endregion

            Console.Read();

        }
    }
}
