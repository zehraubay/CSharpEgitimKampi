using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace _08_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Void Metotlar

            //Metot olup olmadığını anlamak için metot isminin sonuna parantez () eklenir. Mor renkli küp
            //Geriye Değer Döndürmeyen Metotlar = void

            //Customer --> Listele, ekle, sil, güncelle

            //void CustomerList()
            //{
            //    Console.WriteLine("Zehra Ubay");
            //    Console.WriteLine("Ayşe Yıldız");
            //    Console.WriteLine("Hakan Öztürk");
            //    Console.WriteLine("Merve Çınar");
            //}

            //CustomerList(); // Metot çağrılırken parantez () eklenir.
            //CustomerList();
            //CustomerList();
            //CustomerList();

            //void Sum()
            //{
            //    int x = 1;
            //    int y = 2;
            //    int z = x + y;
            //    Console.WriteLine(z);
            //}

            //Sum();

            #endregion

            #region Geriye Değer Döndürmeyen String Parametreli Metotlar

            //void WriteMethod(string customerName)
            //{
            //    Console.WriteLine("Müşteri Adı: " + customerName);
            //}

            //WriteMethod("Zehra Ubay");

            //void CustomerCard(string name,string surname)
            //{
            //    Console.WriteLine("Müşteri Adı: " + name + " " + surname);
            //}

            //CustomerCard("Zehra", "Ubay");
            //CustomerCard("Ayşe", "Yıldız");

            #endregion

            #region Geriye Değer Döndürmeyen Int Parametreli Metotlar

            ////void Sum(int number1, int number2, int number3)
            ////{
            ////    int result = number1 + number2 + number3;
            ////    Console.WriteLine(result);
            ////}

            ////Sum(4, 5, 6);



            #endregion

            #region Geriye Değer Döndüren Metotlar

            //string CustomerName()
            //{
            //    return "Zehra Ubay";
            //}

            //CustomerName();

            //string StudentCard()
            //{
            //    string name = "Zehra";
            //    string surname = "Ubay";

            //    return name + " " + surname;
            //}

            //Console.WriteLine(StudentCard());

            #endregion

            #region Geriye Değer Döndüren String Parametreli Metotlar

            //string CountryCard(string countryName, string capital, string flagColor)
            //{
            //    string cardInfo = "Ülke: " + countryName + "Başkent: " + capital + "Bayrak Rengi: " + flagColor;
            //    return cardInfo;
            //}

            //string x, y, z;

            //Console.Write("Ülke Adını Giriniz: ");
            //x = Console.ReadLine();

            //Console.Write("Başkenti Giriniz: ");
            //y = Console.ReadLine();

            //Console.Write("Bayrak Rengini Giriniz: ");
            //z = Console.ReadLine();

            //Console.WriteLine(CountryCard(x, y, z));
            //Console.WriteLine(CountryCard("Türkiye", "Ankara", "Kırmızı-Beyaz"));

            #endregion

            #region Geriye Değer Döndüren Int Parametreli Metotlar

            //int Sum(int number1, int number2)
            //{
            //    int result = number1 + number2;
            //    return result;
            //}

            //Console.WriteLine(Sum(5, 10));
            //Console.WriteLine(Sum(36, 25));
            //Console.WriteLine(Sum(5, 36));
            //Console.WriteLine(Sum(514, 20));



            #endregion

            #region Örnek Uygulama

            //string ExamResult(string student, int exam1, int exam2, int exam3)
            //{
            //    int result = (exam1 + exam2 + exam3) / 3;
            //    if(result >= 50)
            //    {
            //        return student + " isimli öğrenci Sınavı Geçti" + "Ortalama: " + result;
            //    }
            //    else
            //    {
            //        return student + "isimli öğrenci Başarısız Oldu" + "Ortalama: " + result;
            //    }
            //}

            //Console.Write(ExamResult("Zehra", 92, 78, 95));


            #endregion

            Console.Read();
        }
    }
}
