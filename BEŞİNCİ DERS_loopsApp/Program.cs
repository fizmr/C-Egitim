using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEŞİNCİ_DERS_loopsApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region yıldız
            //for (int i = 0; i <= 10; i++) //alt alta  10 yıldız
            //{
            //    Console.WriteLine("*");
            //}

            //for (int i = 0; i <= 10; i++) // yan yana 10 yıldız
            //{
            //    Console.Write("*");
            //}

            //for (int i = 0; i <= 10; i++)  // al alta 10 tane 10 yıldız
            //{
            //    Console.WriteLine("**********");
            //}

            //for (int i = 0; i <= 5; i++)   //Dik üçgen şekilinde 
            //{
            //   for(int j = 0; j <= i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            //for (int i = 5; i >=1 ; i--)   //TERS Dik üçgen şekilinde 
            //{
            //    for (int j = 1; j <= i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            //for (int i = 1; i <= 5; i++)   //Yarım baklava dilimi 
            //{
            //    for (int j = 1; j <= i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //   Console.WriteLine();
            //}
            //for (int i = 4;i >= 1; i--)
            //{
            //    for(int j = 1;j <= i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            //int n = 5;  //Baklava dilimi
            //for (int i = 1; i <= n; i++)
            //{
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

            //for (int i = n - 1; i >= 1; i--)
            //{
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
            /////GERÇEK BAKLAVA DİLİMİ\\\\\
            int n = 5;    //piramit
            for (int i = 1; i <= n; i++)
            {
                for (int j = n - i; j > 0; j--)
                {
                    Console.Write(" ");
                }

                for (int k = 1; k <= 2 * i - 1; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }


            //int ni = 4;  //ters piramit
            //for (int i = ni; i >= 1; i--)
            //{
            //    for (int j = ni - i+1; j > 0; j--)
            //    {
            //        Console.Write(" ");
            //    }
            //    for (int k = 1; k <= 2 * i - 1; k++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}


            //int n = 5;    //piramit
            //for (int i = 1; i <= n; i++)
            //{
            //    for (int j = n - i; j > 0; j--)
            //    {
            //        Console.Write(" ");
            //    }

            //    for (int k = 1; k <= 2 * i - 1; k++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}


            //int n = 5;  //ters piramit
            //for (int i = n; i >= 1; i--)
            //{
            //    for (int j = n-i; j > 0; j--)
            //    {
            //        Console.Write(" ");
            //    }
            //    for (int k=1; k <= 2*i-1; k++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();          
            //}



            #endregion
        }
    }
}
