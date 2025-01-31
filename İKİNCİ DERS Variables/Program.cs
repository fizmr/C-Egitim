using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace İKİNCİ_DERS_Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double number;

            number = 4.99;
            Console.WriteLine(number);


            #region meyve-sebze

            //double applePrice, orangePrice, strawberryPrice, potatoPrice, tomatoPrice;

            //applePrice = 9.90;
            //orangePrice = 9.50;
            //strawberryPrice = 15.60;
            //potatoPrice = 10.50;
            //tomatoPrice = 11.99;

            //Console.WriteLine("---------MEYVE-SEBZE---------");
            //Console.WriteLine();
            //Console.WriteLine("ELMA --------- " + applePrice + " $");
            //Console.WriteLine("PORTAKAL ----- " + orangePrice + " $");
            //Console.WriteLine("CILEK -------- " + strawberryPrice + " $");
            //Console.WriteLine("PATATES ------ " + potatoPrice + " $");
            //Console.WriteLine("DOMATES ------ " + tomatoPrice + " $");
            //Console.WriteLine();
            //Console.WriteLine("-----------------------------"); 


            //double appleWeight,orangeWeight,strawberyWeight,potatoWeight,tomatoWeight;

            //appleWeight = 0.50;
            //orangeWeight = 0.75;
            //strawberyWeight = 0.60;
            //potatoWeight = 2.50;
            //tomatoWeight = 1.50;


            //double appleTotalPrice,orangeTotalPrice,strawberTotalPrice,potatoTotalPrice,tomatoTotalPrice,totalPrice;

            //appleTotalPrice = applePrice * appleWeight;
            //orangeTotalPrice = orangePrice * orangeWeight;
            //strawberTotalPrice = strawberryPrice * strawberyWeight;
            //potatoTotalPrice = potatoPrice * potatoWeight;
            //tomatoTotalPrice = tomatoPrice * tomatoWeight;

            //totalPrice = appleTotalPrice + orangeTotalPrice + strawberTotalPrice + potatoTotalPrice + tomatoTotalPrice;

            //Console.WriteLine("------------SEPET------------");
            //Console.WriteLine();
            //Console.WriteLine("ELMA --------- " + appleTotalPrice);
            //Console.WriteLine("PORTAKAL ----- " + orangeTotalPrice);
            //Console.WriteLine("CILEK -------- " + strawberTotalPrice);
            //Console.WriteLine("PATATES ------ " + potatoTotalPrice);
            //Console.WriteLine("DOMATES ------ " + tomatoTotalPrice);
            //Console.WriteLine();
            //Console.WriteLine("TOPLAM TUTAR ----- " + totalPrice);
            //Console.WriteLine("-----------------------------");

            #endregion

            #region Char

            char symbol;
            symbol = 'a'; 
            Console.WriteLine(symbol);

            #endregion

            #region klavyeden veri girişi

            //Console.WriteLine("~~~~~~ *** HAVA YOLLARI KAYIT ALANI ~~~~~~");
            //Console.WriteLine();

            //string passName, passSurname, passDistrict, passCity, passAge, passID;

            //Console.Write("YOLCU ADI : ");
            //passName = Console.ReadLine();
            //Console.Write("YOLCU SOYADI : ");
            //passSurname = Console.ReadLine();
            //Console.Write("YOLCU İLÇE BİLGİSİ : ");
            //passDistrict = Console.ReadLine();
            //Console.Write("YOLCU İL BİLGİSİ : ");
            //passCity = Console.ReadLine();
            //Console.Write("YOLCU YAŞI : ");
            //passAge = Console.ReadLine();
            //Console.Write("YOLCU ID : ");
            //passID = Console.ReadLine();

            //Console.WriteLine();
            //Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");

            //Console.WriteLine("~~~~~~ *** HAVA YOLLARI KAYITLI YOLCULAR ~~~~~~");
            //Console.WriteLine();
            //Console.WriteLine("YOLCU : "+passName + " " +passSurname);
            //Console.WriteLine("İKAMET : "+passDistrict + "/" + passCity);
            //Console.WriteLine("YAŞI : "+passAge);
            //Console.WriteLine("ID : "+passID);
            #endregion

            #region klavyeden tam sayı girişi/dönüşümler

            //int shoePrice, computerPrice, chairPrice, tvPrice,allPrice;
            //shoePrice = 1000;
            //computerPrice = 20000;
            //chairPrice = 5000;
            //tvPrice = 15000;

            //int shoeCount, computerCount, chairCount, tvCount;
            //Console.Write("Almak istediğiniz ayakkabı sayısı : ");
            //shoeCount = int.Parse(Console.ReadLine());
            //Console.Write("Almak istediğiniz bilgisayar sayısı : ");
            //computerCount = int.Parse(Console.ReadLine());
            //Console.Write("Almak istediğiniz sandalye sayısı : ");
            //chairCount = int.Parse(Console.ReadLine());
            //Console.Write("Almak istediğiniz televizyon sayısı : ");
            //tvCount = int.Parse(Console.ReadLine());

            //allPrice = (shoePrice*shoeCount)+(computerPrice*computerCount)+(chairPrice*chairCount)+(tvPrice*tvCount);
            //Console.WriteLine($"Toplam Ödeyeeğiniz Tutar : {allPrice}");

            //double exam1,exam2,exam3,avg;

            //Console.Write("Birinci Sınav : ");
            //exam1 = double.Parse(Console.ReadLine());
            //Console.Write("İkinci Sınav : ");
            //exam2 = double.Parse(Console.ReadLine());
            //Console.Write("Üçüncü Sınav : ");
            //exam3 = double.Parse(Console.ReadLine());

            //avg = (exam1 +exam2 +exam3)/3;
            //Console.WriteLine($"Girdiğiniz Sınav Notlarına Karşılık Ortalamanız : {avg}");
            #endregion

            #region karakter girişi

            //char gender;
            //Console.Write("Lütfen cinsiyet seçiniz (erkek = e/kadın = k) : ");
            //gender = char.Parse(Console.ReadLine());
            //Console.WriteLine($"Cinsiyetiniz : {gender}");
            #endregion
        }
    }
}
