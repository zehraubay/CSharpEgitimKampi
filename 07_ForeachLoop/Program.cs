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

            #region Foreach Döngüsü

            //Foreach(1;2;3;4) 4 tane parametre alan bir döngüdür.
            //1:Değişken türü
            //2:Değişken adı
            //3:In
            //3:Koleksiyon adı (Array, List, Dictionary vb.)

            //string[] cities = { "İstanbul", "Ankara", "İzmir", "Bursa", "Antalya" };

            //foreach (string x in cities)
            //{
            //    Console.WriteLine(x);
            //}

            //int[] numbers = { 45, 78, 985, 635, 74, 11, 22, 33, 41, 205, 6578, 10394 };

            //foreach (int number in numbers)
            //{
            //   Console.WriteLine(number);
            //}

            //foreach (int number in numbers)
            //{
            //    if (number % 2 == 0)
            //    {
            //        Console.WriteLine(number);
            //    }
            //}

            //int total = 0;

            //foreach (int i in numbers)
            //{
            //    total += i; // total = total + i;
            //}

            //Console.WriteLine("Toplam: " + total);

            //List<int> numbers = new List<int>()
            //{
            //    1, 2, 3, 4, 5, 6, 7, 8, 9, 10
            //};

            //foreach(int number in numbers)
            //{
            //    Console.WriteLine(number);
            //}

            //string word = "Merhaba";

            //foreach (char c in word)
            //{
            //    Console.WriteLine(c);
            //}

            #endregion

            #region Örnek Sınav Sistemi Uygulaması

            //Klavyeden öğrenci sayısını, isimlerini ve sınav notlarını alıp öğrencilerin ortalamasını hesaplayın.

            //Console.Write("***** C# Eğitim Kampı Sınav Uygulaması");
            //Console.WriteLine();
            //Console.WriteLine();
            //Console.WriteLine();

            //Console.WriteLine("----------------------------------------");
            //Console.Write("Lütfen sınıftaki öğrenci sayısını giriniz: ");
            //int studentCount = int.Parse(Console.ReadLine());
            //Console.WriteLine("----------------------------------------");

            ////Öğrenci isimlerini ve not ortalamalarını saklayacak diziler
            //string[] studentNames = new string[studentCount]; // Öğrenci isimleri dizisinin boyutunu studentCount'tan al
            //double[] studentExamAvg = new double[studentCount];

            //for (int i = 0; i < studentCount; i++)
            //{
            //    Console.Write($"Lütfen {i + 1}. öğrencinin ismini giriniz: ");
            //    studentNames[i] = Console.ReadLine();

            //    double totalExamResult = 0; // Her öğrenci için toplam notu sıfırla

            //    //Her öğrenci için 3 sınav notu al
            //    for (int j = 0; j < 3; j++)
            //    {
            //        Console.Write($"Lütfen {i + 1}. öğrencinin {j + 1}. sınav notunu giriniz: ");
            //        double value = double.Parse(Console.ReadLine());
            //        totalExamResult += value; // Notları topla
            //    }
            //    Console.WriteLine();

            //    studentExamAvg[i] = totalExamResult / 3; // Not ortalamasını hesapla
            //}

            ////Öğrencilerin sınav ortalaması
            //for(int i = 0; i< studentCount; i++)
            //{
            //    Console.WriteLine("----------------------------------------");

            //    Console.WriteLine($"{studentNames[i]} isimli öğrencinin not ortalaması: {studentExamAvg[i]}");

            //    //Öğrencilein geçme durumunu kontrol et
            //    if (studentExamAvg[i] >= 50)
            //    {
            //        Console.WriteLine($"{studentNames[i]} isimli öğrenci dersi geçti.");
            //    }
            //    else
            //    {
            //        Console.WriteLine($"{studentNames[i]} isimli öğrenci dersten kaldı.");
            //    }

            //    Console.WriteLine("----------------------------------------");
            //}

            #endregion

            
            Console.Read();
        }
    }
}
