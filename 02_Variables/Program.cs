﻿using System;
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
            #region Double Değişkenler

            ////ondalıklı işlemler için, double
            ////double number;
            ////number = 4.85;
            ////Console.WriteLine(number);

            ////Console.WriteLine("***** Fiyat Listesi *****");
            ////Console.WriteLine();

            ////double applePrice, orangePrice, strawberryPrice, potatoPrice, tomatoPrice;

            ////applePrice = 14.85;
            ////orangePrice = 20.95;
            ////strawberryPrice = 45;
            ////potatoPrice = 9.74;
            ////tomatoPrice = 6.88;

            ////Ctrl + space ile tamamlar

            ////Console.WriteLine("----- Elma Birim Fiyatı: " + applePrice + " TL");
            ////Console.WriteLine("---- Portakal Birim Fiyatı: " + orangePrice + " TL");
            ////Console.WriteLine("----- Çilek Birim Fiyatı: " + strawberryPrice + " TL");
            ////Console.WriteLine("----- Patates Birim Fiyatı: " + potatoPrice + " TL");
            ////Console.WriteLine("----- Domates Birim Fiyatı: " + tomatoPrice + " TL");

            ////Console.WriteLine();
            ////Console.WriteLine();

            ////double appleGram, orangeGram, strawberryGram, potatoGram, tomatoGram;

            ////appleGram = 1.245;
            ////orangeGram = 2.650;
            ////strawberryGram = 0.750;
            ////potatoGram = 4.859;
            ////tomatoGram = 3.745;

            ////double appleTotalPrice = appleGram * applePrice;
            ////double orangeTotalPrice = orangeGram * orangePrice;
            ////double strawberryTotalPrice = strawberryGram * strawberryPrice;
            ////double potatoTotalPrice = potatoGram * potatoPrice;
            ////double tomatoTotalPrice = tomatoGram * tomatoPrice;

            ////Console.WriteLine("Alınan Ürün: Elma - " + "Birim Fiyat: " + applePrice + " - " +
            ////    "Gramaj: " + appleGram + " - Toplam Tutar: " + appleTotalPrice + " TL");
            ////Console.WriteLine("Alınan Ürün: Portakal - " + "Birim Fiyat: " + orangePrice + " - " +
            ////    "Gramaj: " + orangeGram + " - Toplam Tutar: " + orangeTotalPrice + " TL");
            ////Console.WriteLine("Alınan Ürün: Çilek - " + "Birim Fiyat: " + strawberryPrice + " - " +
            ////    "Gramaj: " + strawberryGram + " - Toplam Tutar: " + strawberryTotalPrice + " TL");
            ////Console.WriteLine("Alınan Ürün: Patates - " + "Birim Fiyat: " + potatoPrice + " - " +
            ////    "Gramaj: " + potatoGram + " - Toplam Tutar: " + potatoTotalPrice + " TL");
            ////Console.WriteLine("Alınan Ürün: Domates - " + "Birim Fiyat: " + tomatoPrice + " - " +
            ////    "Gramaj: " + tomatoGram + " - Toplam Tutar: " + tomatoTotalPrice + " TL");


            ////double shoppingTotalPrice = appleTotalPrice + orangeTotalPrice + tomatoTotalPrice + strawberryTotalPrice + potatoTotalPrice;

            ////Console.WriteLine();
            ////Console.WriteLine();

            ////Console.WriteLine("Alışveriş Toplam Tutar: " + shoppingTotalPrice + " TL");

            #endregion

            #region Char Değişkenler

            // ' ' tek tırnak ile tanımlanırlar

            //char symbol;
            //symbol = 'a';

            //Console.WriteLine(symbol);

            #endregion

            #region Klavyeden Veri Girişleri String Değişkenler

            //Console.WriteLine("***** CSharp Hava Yolları Yolcu Bilgisi *****");
            //Console.WriteLine();

            //string passengerName, passengerSurname, passengerDistrict, passengerCity, passengerAge,
            //    passengerIdentityNumber;

            //Console.Write("Yolcu Adı: ");
            //passengerName = Console.ReadLine(); //

            //Console.Write("Yolcu Soyadı: ");
            //passengerSurname = Console.ReadLine();

            //Console.Write("İlçe Bilgisi: ");
            //passengerDistrict = Console.ReadLine();

            //Console.Write("Şehir Bilgisi: ");
            //passengerCity = Console.ReadLine();

            //Console.Write("Yolcu Yaş: ");
            //passengerAge = Console.ReadLine();

            //Console.Write("Yolcu TC Kimlik No: ");
            //passengerIdentityNumber = Console.ReadLine();

            //Console.WriteLine();

            //Console.WriteLine("-------------------------------------------");
            //Console.WriteLine("Yolcu TC Kimlik No: " + passengerIdentityNumber + " " + "Yolcu Ad Soyad: " + passengerName + " " + passengerSurname + " " +
            //    passengerDistrict + " / " + passengerCity + " " + passengerAge);

            // ctrl + f ile aynı kelimeleri değiştirmek istediğinde aynı anda değiştiriyor

            #endregion

            #region Klavyeden Tam Sayı Girişleri ve Dönüşümler

            //ABC12D

            //int shoesPrice, computerPrice, chairPrice, tvPrice;

            //shoesPrice = 1000;
            //computerPrice = 20000;
            //chairPrice = 5000;
            //tvPrice = 12000;

            //int shoesCount, computerCount, chairCount, tvCount;

            //Console.Write("Lütfen aldığınız ayakkabı sayısını giriniz: ");
            //shoesCount = int.Parse(Console.ReadLine()); //console.readline string ifadeler için kullanılıyor. Count değişkeni için sayı girmemiz gerektiğinden readline ile girileni int.Parse() ile sayıya dönüştürdük

            //Console.Write("Lütfen aldığınız bilgisayar sayısını giriniz: ");
            //computerCount = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen aldığınız sandalye sayısını giriniz: ");
            //chairCount = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen aldığınız televizyon sayısını giriniz: ");
            //tvCount = int.Parse(Console.ReadLine());

            //int totalPrice = shoesPrice * shoesCount + computerPrice * computerCount + chairPrice * chairCount + tvPrice * tvCount;

            //Console.WriteLine(); //Bir satır boşluk
            //Console.WriteLine("Toplam ödemeniz gereken tutar: " + totalPrice);



            #endregion

            #region Klavyeden Ondalıklı Sayı İşlemleri

            //double exam1, exam2, exam3, result;

            //Console.Write("Lütfen 1.Sınav notunu giriniz: ");
            //exam1 = double.Parse(Console.ReadLine());

            //Console.Write("Lütfen 2.Sınav notunu giriniz: ");
            //exam2= double.Parse(Console.ReadLine());

            //Console.Write("Lütfen 3.Sınav notunu giriniz: ");
            //exam3 = double.Parse(Console.ReadLine());

            //result = (exam1 + exam2 + exam3) / 3;
            //Console.WriteLine("Sınav ortalamanız: " + result);

            ////ondalıklı yazarken burada nokta ile klavyeden virgül ile yazılır.


            #endregion

            #region Klavyeden Karakter Girişleri

            char gender;
            Console.WriteLine("Lütfen Cinsiyet Seçiniz: ");
            gender = char.Parse(Console.ReadLine());

            Console.WriteLine("Seçtiğiniz cinsiyet: " + gender);


            #endregion
            Console.Read();
        }
    }
}