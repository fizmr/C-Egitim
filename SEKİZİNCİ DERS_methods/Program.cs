using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEKİZİNCİ_DERS_methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Void Metotlar

            //()
            //Geriye Değer Döndürmeyen Metotlar
            //Customer--> Listele,ekle,sil güncelle
            //Void

            //void CustomerList() // burda fonksiyon atadık içine değer verdik 4 tane
            //{
            //    Console.WriteLine("Rüştü Karlı");
            //    Console.WriteLine("Kaan Karlı");
            //    Console.WriteLine("Meryem Çan"); 
            //    Console.WriteLine("Ali Ahmet Çan");
            //}

            //CustomerList(); // burda 2 kere çağırdık 4 ismi 2 kere yazdı ekrana
            //CustomerList();

            //void sum()
            //{
            //    int x = 2;
            //    int y = 1;
            //    int z = x+y;
            //    Console.WriteLine(z);
            //}
            //sum(); 

            #endregion

            #region Geriye değer döndürmeyen string parametreli metotlar

            //void writeMethod(string customerName)
            //{
            //    Console.WriteLine(customerName);
            //}
            //writeMethod("Ayşe Çakır");

            //void CustomerCard(string name, string surname)
            //{
            //    Console.WriteLine("Müşteri: "+ name+ " "+surname);
            //}
            //CustomerCard("Mehmet","Yıldırım");
            //CustomerCard("Ömer", "Altındağ");


            #endregion

            #region Deriye değer döndürmeyen int parametreli metotlar
            //void Sum(int number1, int number2,int number3)
            //{
            //    int result = number1 + number2 + number3;
            //    Console.WriteLine(result);
            //}
            //Sum(3, 6, 9);
            #endregion

            #region Geriye değer döndüren metotlar

            //string StudentCard()
            //{
            //    string name= "Ali";
            //    string surname = "Kaya";
            //    return name + " " + surname;
            //}
            //Console.WriteLine(StudentCard());

            #endregion

            #region Geriye değer döndüren string parametreli metotlar

            //string CountryCard(string countryname, string countrycapital,string flagColor) { 

            //    string cardInfo = "Ülke: " + countryname+ " - Başkent: " + countrycapital + " - Bayrak Rengi: " + flagColor;
            //    return cardInfo;
            //}
            //string x, y, z;
            //Console.Write("Ülke Adını Giriniz: ");
            //x=Console.ReadLine();
            //Console.Write("Başkenti Gİriniz: ");
            //y=Console.ReadLine();
            //Console.Write("Bayrak Rengini giriniz: ");
            //z=Console.ReadLine();
            //Console.WriteLine(CountryCard(x, y, z));
            //Console.WriteLine(CountryCard("İtalya","Roma","Beyaz-Yeşil-Kırmızı"));

            #endregion

            #region Geriye değer döndüren int parametreli metotlar

            //int Sum(int number,int number1)
            //{
            //    int result=number+number1;
            //    return result;
            //}
            //int x, y;
            //Console.Write("Birinci Sayı: ");
            //x= Convert.ToInt32(Console.ReadLine());
            //Console.Write("İkinci Sayı: ");
            //y= Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine(Sum(x,y));
            //Console.WriteLine(Sum(99,1));
            //Console.WriteLine(Sum(77,23));
            //Console.WriteLine(Sum(24,34));
            #endregion

            #region uygulama
            string eresult(string student, int exam1, int exam2, int exam3)
            {
                int result = (exam1 + exam2 + exam3) / 3;
                if (result >= 0)
                {
                    return student + " isimli öğrenci Geçti " + result + " not ortalamasıyla";
                }
                else
                {
                    return student + " isimli öğrenci Kaldı " + result + " not ortalamasıyla";
                }

            }
            Console.WriteLine(eresult("Ali", 50, 70, 66));
            Console.WriteLine(eresult("Ayşe", 77, 42, 35));


            string a;
            int x, y, z;
            Console.Write("öğrenci adı: ");
            a = Console.ReadLine();
            Console.Write("birinci sınav notu: ");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("ikinci sınav notu: ");
            y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("üçüncü sınav notu: ");
            z = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(eresult(a, x, y, z));

            #endregion
        }
    }
}
