using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DÖRDÜNCÜ_DERS_Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region for 
            //for(x;y;z)
            //x:başlangıç
            //y:bitiş
            //z:artış-azalış

            //int i;
            //for (i = 0; i < 100; i++)
            //{
            //    Console.WriteLine(i);
            //}

            //int i;
            //for (i = 1; i <= 20; i += 2)
            //{
            //    Console.WriteLine(i);
            //}

            //Console.Write("Sayı adedi gir: ");
            //int adet = Convert.ToInt32(Console.ReadLine());

            //for (int i = 0; i < adet; i++)
            //{
            //    Console.WriteLine((i+adet)+1);
            //}
            #endregion
            #region for uygulama
            #region for ile karar yapıları
            //for (int i = 0; i <= 100; i++)
            //{
            //    if(i%5 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}  

            //int total = 0;
            //for (int i = 0; i <= 10; i++)
            //{
            //    total += i;
            //}
            //Console.WriteLine(total);


            //int totalv = 0;       //bu örnekte 1 den 20 ye kadar 2 ye bölünebilen sayıların toplamı
            //for (int i = 0; i < 20; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        totalv += i;
            //    }            
            //}
            //Console.WriteLine(totalv);

            //int count = 0;                   //bu örnekte 1 den 50 ye kadar 7 ye bölünebilen kaç tane sayı varsa onu yazar
            //for (int i = 1; i <= 50; i++)
            //{
            //    if (i % 7 == 0)
            //    {
            //        count++;
            //    }
            //}
            //Console.WriteLine(count);
            #endregion
            #region 24 saat bakteri mik.

            //int bacterium = 1;
            //for (int i = 0; i <= 24; i++)
            //{
            //    bacterium *= 2;
            //    Console.WriteLine(i + ".Saat sonunda bakteri miktarı: " + bacterium);
            //}
            #endregion
            #endregion
            #region while
            //wihile(şart)
            //{
            //işlem
            //}

            //int i = 0;  /on kez ez yazıyor
            //while (i <= 10)
            //{
            //    Console.WriteLine("ez");
            //    i++;
            //}

            //int i = 1;  /birden ona kadar olan üçe bölünebilen sayılar
            //while (i <= 10)
            //{
            //    if (i % 3 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //    i++;
            //}

            //int i = 1; //birden ona kadar olan sayıların toplamı
            //int total = 0;
            //while (i <= 10)
            //{
            //    total += i;
            //    i++;

            //}

            //Console.WriteLine(total);

            int number, ones, tens, hundrets, total;  // girilen üç basamaklı sayının basamakları toplamı
            Console.Write("Üç basamaklı bir sayı giriniz: ");
            number = Convert.ToInt32(Console.ReadLine());
            ones = number % 10;
            tens = (number % 100) / 10;
            hundrets = number / 100;
            total = ones + tens + hundrets;
            Console.WriteLine("Yazdığınız sayının basamakları toplamı: " + total);
            #endregion

        }
    }
}
