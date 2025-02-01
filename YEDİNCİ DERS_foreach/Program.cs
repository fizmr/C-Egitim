using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YEDİNCİ_DERS_foreach
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region FOREACH

            //Foreach(1;2;3;4)
            //1:Değişken türü
            //2:Değişken adı
            //3:IN
            //4:Liste,Koleksiyon,Dizi

            //string[] cities = {"milano", "roma", "budapeste", "ankara", "istanbul", "varşova"};

            //foreach (string city in cities) //bu işlem for döngüsü gibi ancak kaç kaç artacak başını sonunu belirlem gibi işlemlerle uğraşmaya gerek olmaz
            //{
            //    Console.WriteLine(city);
            //}

            //int[] numbers = { 34, 28, 77, 63, 22, 846, 7034, 631, 782, 207, 378, 13271 };

            //foreach (int i in numbers)
            //{
            //    Console.WriteLine(i);
            //}

            //int[] numbers = { 34, 28, 77, 63, 22, 846, 7034, 631, 782, 207, 378, 13271 };

            //foreach (int i in numbers)
            //{
            //    if(i %2 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}


            //int[] numbers = { 34, 28, 77, 63, 22, 846, 7034, 631, 782, 207, 378, 13271 };

            //int total = 0;
            //foreach (int i in numbers)
            //{
            //    total += i;
            //}
            //Console.WriteLine(total);

            //List<int> numbers = new List<int>()
            //{
            //    1,2,3,4,5,8
            //};
            //foreach (int i in numbers)
            //{
            //    Console.WriteLine(i);
            //}

            //string words = "Merhaba";

            //foreach (char c in words)
            //{
            //    Console.WriteLine(c);
            //}

            #endregion

            #region EXE

            ////öğrenci sayısı aldık
            //Console.WriteLine("*******ÖRNEK*******");
            //Console.Write("Sınıftaki öğrenci sayısı: ");
            //int studentcount=int.Parse(Console.ReadLine());

            ////öğrenci isimlerini ve notlarını saklayacak diziler
            //string[] studentname = new string[studentcount];
            //double[] stdexamavg = new double[studentcount];


            //for(int i=0; i<studentcount; i++)
            //{
            //    Console.Write($"{i + 1}. öğrenci adı: ");  //öğrenci ismi kaydı
            //    studentname[i] = Console.ReadLine();

            //    double examavg = 0;


            //    for(int j = 0; j < 3; j++)  //her öğrenciye 3 sınav notu atadık
            //    {
            //        Console.Write($"{studentname[i]} adlı öğrencinin {j + 1}.Notu: ");
            //        double value = double.Parse( Console.ReadLine() );

            //        examavg += value;
            //    }
            //    stdexamavg[i] = examavg/3; //öğrencinin ortalamasını aldık
            //}

            //for(int i = 0; i < studentcount; i++)
            //{
            //    Console.WriteLine("-------------------------");

            //    if (stdexamavg[i] < 50) //<50 ise kaldı
            //    {
            //        Console.WriteLine($"{studentname[i]} adlı öğrenci KALDI ortalaması: {stdexamavg[i]}");
            //    }
            //    else if (stdexamavg[i] >= 50) // >= 50 ise geçti yazdırdık
            //    {
            //        Console.WriteLine($"{studentname[i]} adlı öğrenci GEÇTİ ortalaması: {stdexamavg[i]}");
            //    }

            //    Console.WriteLine("-------------------------");
            //}



            #endregion

            #region SIRA BENDE
            double ageavg = 0;
            Console.WriteLine("********YAŞ ORT********");
            Console.WriteLine("");
            Console.Write("KİŞİ SAYISI GİRİNİZ: ");
            int people = int.Parse(Console.ReadLine());
            Console.WriteLine("");
            Console.WriteLine("***********************");

            string[] names = new string[people];
            int[] ages = new int[people];

            for (int i = 0; i < names.Length; i++)
            {

                Console.Write($"{i + 1}. Kişinin Adı: ");
                names[i] = Console.ReadLine();
                Console.Write($"{names[i]} yaşı: ");
                ages[i] = int.Parse(Console.ReadLine());
                Console.WriteLine("***********************");

                ageavg += ages[i] / people;

            }
            Console.WriteLine("Gruptaki " + people + " kişinin yaşları ortalaması: " + ageavg);
            #endregion
        }
    }
}
