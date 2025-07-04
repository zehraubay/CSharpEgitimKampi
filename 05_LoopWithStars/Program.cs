using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_LoopWithStars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Alt Alta 10 tane yıldız yazdırma

            //for (int i = 1; i <= 10; i++)
            //{
            //    Console.WriteLine("*");
            //}

            #endregion

            #region Yan yana 10 tane yıldız yazdırma

            //for (int i = 1; i <= 10; i++)
            //{
            //    Console.Write("*");
            //}







            #endregion

            #region Alt alta 10 tane yıldız yazdırma ve her satırda 10 tane yıldız yazdırma

            //for (int i = 1; i <= 10; i++)
            //{
            //    Console.WriteLine("*********");
            //}


            #endregion

            #region Dik üçgen yıldız yazdırma

            //for (int i = 1; i <= 5; i++)
            //{
            //    for (int j = 1; j <= i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}


            #endregion

            #region Ters Dik üçgen yıldız yazdırma

            //for (int i = 5; i >= 1; i--)
            //{
            //    for (int j = 1; j <= i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            #endregion

            #region Dik ve Ters Dik Üçgen Beraber Yıldız Yazdırma

            //for (int i = 1; i <= 5; i++)
            //{
            //    for (int j = 1; j <= i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            //for (int i = 4; i >= 1; i--)
            //{
            //    for (int j = 1; j <= i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            #endregion

            #region Baklava Dilimi

            //int n = 5; // Baklava diliminin yarı yüksekliği

            //for(int i = 1; i <= n; i++)
            //{
            //    // Boşlukları yazdır
            //    for(int j = 1; j <= n - i; j++)
            //    {
            //        Console.Write(" ");
            //    }
            //    // Yıldızları yazdır
            //    for(int k = 1; 
            //        k <= (2 * i - 1); k++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}   
            
            //for(int i = n - 1; i >= 1; i--)
            //{
            //    // Boşlukları yazdır
            //    for(int j = 1; j <= n - i; j++)
            //    {
            //        Console.Write(" ");
            //    }
            //    // Yıldızları yazdır
            //    for(int k = 1; k <= (2 * i - 1); k++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            #endregion

            #region Piramit

            //int n = 5; // Piramitin yüksekliği

            //for(int i = 1; i <= n; i++)
            //{
            //    // Boşlukları yazdır
            //    for (int j = 1; j <= n - i; j++)
            //    {
            //        Console.Write(" ");
            //    }
            //    // Yıldızları yazdır
            //    for (int k = 1; k <= (2 * i - 1); k++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            #endregion

            #region Ters Piramit

            int n = 5; // Ters piramitin yüksekliği

            for(int i = n; i >= 1; i--)
            {
                // Boşlukları yazdır
                for (int j = 1; j <= n - i; j++)
                {
                    Console.Write(" ");
                }
                // Yıldızları yazdır
                for (int k = 1; k <= (2 * i - 1); k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }


            #endregion

            Console.Read();
        }
    }
}
