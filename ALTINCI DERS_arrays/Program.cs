using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALTINCI_DERS_arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Temel diziler
            //2,4,6,8
            //sarı,kırmızı,mavi
            //ankara,adana,afyon,bursa
            //DeğişkenTürü[] DiziAdı = new DeğişkenTürü[ElemanSayısı]
            //string[] colors = new string[4];
            //colors[0] = "Beyaz";
            //colors[1] = "Kırmızı";
            //colors[2] = "Siyah";
            //colors[3] = "Mavi";

            //Console.WriteLine(colors[3]);

            //string[] cities = new string [5];

            //cities[0] = "İstanbul";
            //cities[1] = "Ankara";
            //cities[2] = "İzmir";
            //cities[3] = "Konya";
            //cities[4] = "Eskişehir";

            //Console.WriteLine(cities[2]);


            //int[] numbers = new int[7];
            //numbers[0] = 2;
            //numbers[1] = 4;
            //numbers[2] = 6;
            //numbers[3] = 8;
            //numbers[4] = 10;
            //Console.WriteLine(numbers[3]);
            //Console.WriteLine(numbers[5]);  // dizi sınırları içinde ama tanımlanmamış bir eleman varsa bize 0 çıktısı verir

            //string[] cities = { "Prag","Atina","Ankara","İstanbul" };   //bu şekilde tanımlayıp direkt çıktıda alabiliriz
            //Console.WriteLine(cities[2]);
            #endregion

            #region Dizideki tüm elemanları listeleme
            //string[] colors = { "Red", "Yellow", "Black", "White", "Blue", "Green" };
            //for (int i = 0; i < colors.Length; i++)
            //{
            //    Console.WriteLine(colors[i]);
            //}

            //int[] numbers = { 7, 77, 777, 7777, 77777, 777777, 7777777 };
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}

            //int[] numbers = { 178, 221, 326, 685, 777, 6554, 7777, 9876 };
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] % 3 == 0)
            //    {
            //        Console.WriteLine(numbers[i]);
            //    }
            //}

            //char[] name = { 'f', 'u', 'r', 'k', 'a', 'n', '!', '?'};   //Char şeklinde dize oluştururken tek tırnak kullanılır
            //for (int i = 0; i < name.Length; i++)
            //{
            //    Console.WriteLine(name[i]);
            //}

            //int[] array = { 47, 85, 77, 96, 16, 80, 967, 842, 202 };   //en yüksek değeri bulma
            //int maxnumber = array[0];
            //for (int i = 1; i < array.Length; i++)
            //{
            //    if (array[i] > maxnumber)
            //    {
            //        maxnumber = array[i];
            //    }
            //}
            //Console.WriteLine(maxnumber);

            //string[] persons = { "ali","ahmet","mehmet","ayşe","fatma" };    //Dizinin uzunluğunu hesaplar
            //Console.WriteLine(persons.Length);

            //int[] numbers = { 45, 88, 76, 26, 13, 54, 43 };    //Diziyi küçükten büyüğe sıralar
            //Array.Sort(numbers);
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}

            //int[] numbers = { 45, 88, 76, 26, 13, 54, 43 };    //Diziyi tersten sıralar
            //Array.Reverse(numbers);  
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //{
            #endregion

            #region Dizi Metotlar
            //string[] people = { "furkan", "fatma", "faruk", "fatih","merve","mesut" };    //mervenin kaçıncı indexte olduğunu yazar
            //int index = Array.IndexOf(people, "merve");
            //Console.WriteLine(index);

            //int[] numbers = { 45, 85, 96, 63, 74, 10, 25, 22, 36 };    //dizinin en büyük en küçük elemanını bulur
            //Console.WriteLine("Dizinin en büyük elamanı: " + numbers.Max() + "\n" + "Dizinin en küçük elemanı: " + numbers.Min());
            #endregion

            #region Kullanıcıdan değer alma
            //string[] cities = new string[5];   //diziyi oluştur

            //for (int i = 0; i < cities.Length; i++)   
            //{
            //    Console.Write($"Lütfen {i + 1}. şehri giriniz: ");   //kullanıcıdan şehirleri al
            //    cities[i] = Console.ReadLine();
            //}
            //Console.WriteLine();
            //Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~");     

            //for (int i = 0; i < cities.Length; i++)     // girilen şehirleri yazdır
            //{
            //    Console.WriteLine(cities[i]);
            //}

            //int[] num= new int[4];    // sayı kümesini belirttik
            //int sum =0;   //toplam için başka bir değişken

            //for (int i = 0; i < num.Length; i++)    // kullanıcadan sayı aldık
            //{
            //    Console.Write($"Lütfen {i + 1}. sayıyı giriniz: ");
            //    num[i] = Convert.ToInt32(Console.ReadLine());
            //}

            //Console.WriteLine(" ");

            //for (int i = 0; i < num.Length; i++)    // girilen sayıları yazdırdık
            //{
            //    Console.WriteLine( num[i]);
            //}
            //Console.WriteLine("+");
            //Console.WriteLine("=============");
            //for (int i = 0; i < num.Length; i++)   //girilen sayıları topladık
            //{
            //    sum += num[i];
            //}
            //Console.WriteLine(sum);   // yazdırdık



            //int[] numbers = new int[3];  
            //int total = 0;

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.Write($"Lütfen {i + 1}. sayıyı giriniz: ");
            //    numbers[i] = Convert.ToInt32(Console.ReadLine());
            //}
            //Console.WriteLine();
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}
            //Console.WriteLine("+");
            //Console.WriteLine("======");

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    total += numbers[i];
            //}
            //Console.WriteLine(total);

            int[] num = new int[6];      //dizi tanımla
            int total = 0;    //toplamı bulur

            for (int i = 0; i < num.Length; i++)   //sayı girişi
            {
                Console.Write($"Lütfen {i + 1}. sayıyı giriniz: ");
                num[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine();   //tek ve çift sayıları seçer ve yazdırır
            for (int i = 0; i < num.Length; i++)
            {
                if (num[i] % 2 == 0)
                {
                    Console.WriteLine("Girdiğiniz çift sayı: " + num[i]);
                }
                else
                {
                    Console.WriteLine("Seçtiğiniz tek sayı: " + num[i]);
                }

            }
            for (int i = 0; i < num.Length; i++)     //toplamı hesaplar 
            {
                total += num[i];

            }
            Console.WriteLine("Girdiğiniz sayıların toplamı: " + total);



            #endregion

        }
    }
}
