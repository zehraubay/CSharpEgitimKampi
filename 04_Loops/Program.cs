using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region For Döngüsü

            //For (x;y;z)
            //x: başlangıç değeri
            //y: bitiş
            //z: artış-azalış 

            //int i;

            //for (i = 1; i <= 5; i++)

            //{
            //    Console.WriteLine("C# Eğitim Kampı");
            //}

            //for (int i = 1; i <= 20; i++)
            //{
            //    Console.WriteLine(i);
            //}

            //for(int i =3; i <= 50; i += 3)
            //{
            //    Console.WriteLine(i);
            //}


            //Console.Write("Lütfen ekrana yazılmasını istediğiniz adedi giriniz: ");
            //int finishValue = int.Parse(Console.ReadLine());

            //for(int i = 1; i <= finishValue; i++)
            //{
            //    Console.WriteLine("Yaşasın Cumhuriyet");
            //}



            #endregion

            #region For Döngüsü İle Karar Yapıları

            //for (int i = 0; i <= 100; i++)
            //{
            //    if (i % 5 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}

            //int totalvalue = 0;

            //for(int i = 1; i <=10; i++)
            //{
            //    totalvalue += i;
            //}

            //Console.WriteLine(totalvalue);

            //int totalValue = 0;

            //for(int i = 1; i < 20; i++)
            //{
            //    if(i %2 == 0)
            //    {
            //        totalValue += i;
            //        Console.WriteLine(i);
            //    }
            //}

            //Console.WriteLine("---------");
            //Console.WriteLine(totalValue);

            // 1 ile 50 arasında 7 ye tam bölünen kaç tane sayı olduğunu

            //int countNumber = 0;

            //for (int i = 1; i <= 50; i++)
            //{
            //    if(i %7 == 0)
            //    {
            //        countNumber++;
            //    }
            //}

            //Console.WriteLine(countNumber);

            // Bir ortamda bir bakteri türü her saatin sonunda kendini ikiye bölerek çoğalmaktadır.(1-2-4-8-16-...) 24 saatin sonunda bu ortamda kaç bakteri vardır

            //int bakteri = 1;

            //for (int i = 1; i <= 24; i++)
            //{
            //        bakteri *= 2;
            //        Console.WriteLine(i + ".Saat Sonunda: " + bakteri);
            //}

            //Console.WriteLine("-------");
            //Console.WriteLine(bakteri);

            #endregion

            #region While Döngüsü

            //Şart(işlem) sağlandığı müddetçe anlamı taşır.

            //While(şart)
            //{
            //İşlemler
            //}

            //int i = 1;

            //while (i <= 10)
            //{
            //    Console.WriteLine("Merhaba Döngüler");
            //    i++;
            //}

            //int i = 1;

            //while (i <= 10)
            //{
            //    if(i %3 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //    i++;
            //}

            //1 ile 10 arasındaki sayıları toplamak

            //int i = 1;
            //int toplam = 0;

            //while (i <= 10)
            //{
            //   toplam += i;
            //    i++;
            //}

            //Console.WriteLine(toplam);



            #endregion

            #region Örnek Soru

            // Klavyeden girilen 3 basamaklı sayının basamaklarının toplamını bulan programı yazınız.

            //Console.Write("Lütfen 3 basamaklı bir sayı giriniz: ");
            //int sayi = int.Parse(Console.ReadLine());

            //int birler, onlar, yuzler;
            //int toplam;

            //yuzler = sayi / 100; //4.56 --> 4
            //onlar = (sayi % 100) / 10 ;
            //birler = sayi % 10;

            //toplam = yuzler + onlar + birler;

            //Console.WriteLine(birler + "-" + onlar + "-" + yuzler);
            //Console.WriteLine("Basamakların toplamı: " + toplam);

            #endregion



            Console.Read();
        }
    }
}
