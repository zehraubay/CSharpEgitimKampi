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

            //Değişken Türü [] diziAdı = new DeğişkenTürü [Eleman Sayısı];

            //string[] colors = new string[4]; // 5 elemanlı bir string dizisi oluşturduk.
            //colors[0] = "Kırmızı"; // 0. indise Kırmızı değerini atadık.
            //colors[1] = "Mavi"; // 1. indise Mavi değerini atadık.
            //colors[2] = "Yeşil"; // 2. indise Yeşil değerini atadık.
            //colors[3] = "Sarı"; // 3. indise Sarı değerini atadık.

            //Console.WriteLine("Dizinin Boyutu: " + colors.Length); // Dizinin boyutunu yazdırdık.
            //Console.WriteLine(colors[0]); // 0. indisteki elemanı yazdırdık.

            //string[] cities = new string[5]; // 5 elemanlı bir string dizisi oluşturduk.
            //cities[0] = "İstanbul"; // 0. indise İstanbul değerini atadık.
            //cities[1] = "Ankara"; // 1. indise Ankara değerini atadık.
            //cities[2] = "İzmir"; // 2. indise İzmir değerini atadık.
            //cities[3] = "Bursa"; // 3. indise Bursa değerini atadık.
            //cities[4] = "Antalya"; // 4. indise Antalya değerini atadık.

            //Console.WriteLine("Dizinin Boyutu: " + cities.Length);
            //Console.WriteLine(cities[0]); // 0. indisteki elemanı yazdırdık.

            //int[] ciftSayilar = new int[10];

            //ciftSayilar[0] = 50;
            //ciftSayilar[1] = 100;
            //ciftSayilar[2] = 698;
            //ciftSayilar[3] = 748;
            //ciftSayilar[8] = 200;

            //Console.WriteLine(ciftSayilar[7]); // default değeri 0 verir
            //Console.WriteLine(ciftSayilar[8]);

            //string[] cities = {"Istanbul", "Roma", "Atina", "Ankara" };

            //Console.WriteLine(cities[0]);




            #endregion

            #region Dizideki Tüm Elemanları Listeleme

            //string[] colors = { "Sarı", "Kırmızı", "Mavi", "Beyaz", "Yeşil", "Pembe" };

            //for (int i = 0; i < colors.Length; i++) //length = 6
            //{
            //    Console.WriteLine(colors[i]);
            //}

            //int[] numbers = { 1, 2, 3, 4, 5, 6 };

            //for(int i = 0; i < numbers.Length; i++)
            //{
            //    if(numbers[i] % 3 == 0)
            //    {
            //        Console.WriteLine(numbers[i]);
            //    }
            //}

            //char[] symbols = { '!', '@', '#', '$', '%', '^', '&', '*', 'a', 'b', 'c' };

            //for(int i = 0; i < symbols.Length; i++)
            //{
            //        Console.WriteLine(symbols[i]);
            //}

            //dizideki en büyük elemanı bulma

            //int[] myArray = { 471, 852, 953, 414, 255, 636, 787, 86, 9, 100 };

            //int maxNumber = myArray[0]; // ilk elemanı en büyük olarak kabul ediyoruz

            //for(int i = 0; i<myArray.Length; i++)
            //{
            //    if (myArray[i] > maxNumber) // eğer şu anki eleman, en büyük elemandan büyükse
            //    {
            //        maxNumber = myArray[i]; // o zaman en büyük elemanı güncelliyoruz
            //    }
            //}
            //Console.WriteLine("Dizideki en büyük eleman: " + maxNumber); // en büyük elemanı yazdırıyoruz


            //2.yol

            //for(int i = 0; i < myArray.Length; i++)
            //{
            //    if (i == 0) // ilk elemanı en büyük olarak kabul ediyoruz
            //    {
            //        continue;
            //    }
            //    if (myArray[i] > myArray[0]) // eğer şu anki eleman, ilk elemandan büyükse
            //    {
            //        myArray[0] = myArray[i]; // o zaman ilk elemanı güncelliyoruz
            //    }
            //}

            //Console.WriteLine("Dizideki en büyük eleman: " + myArray[0]); // en büyük elemanı yazdırıyoruz

            #endregion

            #region Dizi Metotları

            //string[] persons = { "Ali", "Ahmet", "Ayşe", "Fatma", "Mehmet", "Ahmet" };

            //Console.WriteLine(persons.Length); //6


            //int[] numbers = { 45, 85, 52, 41, 86, 10, 22, 35 };
            //Array.Sort(numbers); // Diziyi küçükten büyüğe sıralar

            //for(int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]); // Sıralanmış diziyi yazdırır
            //}


            //int[] numbers = { 45, 85, 52, 41, 86, 10, 22, 35 };
            //Array.Reverse(numbers); // Diziyi ters çevirir

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]); // Diziyi ters çevirir ve yazdırır
            //}


            //string[] customers = { "Seray", "Kerem", "Melisa", "Buse", "Yazgı", "Pelin" };

            //int index = Array.IndexOf(customers, "Melisa"); // Melisa'nın dizideki indeksini bulur

            //Console.WriteLine("Melisa'nın dizideki indeksi: " + index); // Melisa'nın dizideki indeksini yazdırır

            //int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //Console.WriteLine("Dizinin En Büyük Elemanı: " + numbers.Max() + "Dizinin En Küçük " +
            //    "Elamanı: " + numbers.Min());

            #endregion


            #region Kullanıcıdan Değer Alma

            //string[] cities = new string[5];

            //for(int i = 0; i < cities.Length; i++)
            //{
            //    Console.Write($"Lütfen {i + 1}. Şehri giriniz: "); // Kullanıcıdan şehir ismi alıyoruz
            //    // i + 1 ile kullanıcıya 1'den başlatıyoruz, çünkü diziler 0'dan başlar
            //    // $ sembolü, parametresel kullanılmasına olanak sağlar 
            //    cities[i] = Console.ReadLine(); // Kullanıcının girdiği değeri diziye atıyoruz
            //}
            //Console.WriteLine();
            //Console.WriteLine("--------------------------");

            //for(int i = 0; i < cities.Length; i++)
            //{
            //    Console.WriteLine(cities[i]);
            //}

            //Bir tam sayı dizisi oluşturun ve kullanıcıdan sayı alarak bu dizideki elemanları toplama

            //int[] numbers = new int[10];
            //int sum = 0;

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.Write($"Lütfen {i + 1}. Sayıyı giriniz: ");
            //    numbers[i] = int.Parse(Console.ReadLine()); // int.Parse ile kullanıcıdan alınan değeri int tipine çeviriyoruz
            //}

            //Console.WriteLine();
            //Console.WriteLine("--------------------------");

            //for(int i = 0; i < numbers.Length; i++)
            //{     
            //    sum += numbers[i];
            //}
            //Console.WriteLine(sum);


            //Dizi içindeki sayıları tek ve çift olarak ayırma

            int[] tekCift = new int[10];

            for(int i = 0; i < tekCift.Length; i++)
            {
                Console.Write($"Lütfen {i + 1}. Sayıyı giriniz: ");
                tekCift[i] = int.Parse(Console.ReadLine()); // Kullanıcıdan sayı alıyoruz
            }

            Console.WriteLine();
            Console.WriteLine("Çift Sayılar");

            for (int i = 0; i < tekCift.Length; i++)
            {
                if(tekCift[i] % 2 == 0) // Eğer sayı çift ise
                {
                    Console.WriteLine(tekCift[i]);
                }
            }

            Console.WriteLine();
            Console.WriteLine("--------------------------");
            Console.WriteLine("Tek Sayılar");


            for (int i = 0; i < tekCift.Length; i++)
            {
                if (tekCift[i] % 2 == 1) // Eğer sayı tek ise
                {
                    Console.WriteLine(tekCift[i]);
                }
            }


            #endregion

            Console.Read();
        }
    }
}
