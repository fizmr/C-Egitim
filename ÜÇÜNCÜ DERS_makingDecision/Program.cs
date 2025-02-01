using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ÜÇÜNCÜ_DERS_makingDecision
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region if
            /*
            Console.WriteLine("Parolanızı girin: ");
            String password;
            password = Console.ReadLine();
            if (password == "abcd") 
            {
                Console.WriteLine("Hoşgeldiniz");
            }
            else
            {
                Console.WriteLine("Şifre Yanlış");
            }    
            

            int sayi;
            Console.Write("Sayı giriniz: ");
            sayi = Convert.ToInt32(Console.ReadLine());
            if (sayi == 0)
            {
                Console.WriteLine("Sayı doğru");
            }
            else
            {
                Console.WriteLine("Sayı yanlış");
            }
            
            int notort;
            Console.Write("Notunuzu giriniz: ");
            notort=Convert.ToInt32(Console.ReadLine());
            if (notort <= 0 && notort <= 50)
            {
                Console.WriteLine("Kaldı");
            }
            
            if (notort > 100)
            {
                Console.WriteLine("Hatalı not girişi");
            }
            else
            {
                Console.WriteLine("Geçti");
            }
            
            int sinav1, sinav2, sinav3, ortalama;
            Console.Write("Birinci sınav notunu giriniz: ");
            sinav1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("İkinci sınav notunu giriniz: ");
            sinav2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Üçüncü sınav notunu giriniz:");
            sinav3 = Convert.ToInt32(Console.ReadLine());

            ortalama = (sinav1 + sinav2 + sinav3) / 3;
            if (ortalama >= 0 && ortalama < 50)
            {
                Console.WriteLine(ortalama + " Ortalaa ile kaldı");
            }
            if (ortalama > 100)
            {
                Console.WriteLine("Hatalı veri girişi");
            }

            else
            {
                Console.WriteLine(ortalama + " Ortlama ile geçti");
            }
                   
            int exam1,exam2,exam3,average;
            string result= "Hata";
            Console.Write("Birinci sınav notunu giriniz: ");
            exam1= Convert.ToInt32(Console.ReadLine());
            Console.Write("İkinci sınav notunu giriniz: ");
            exam2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Üçüncü sınav notunu giriniz: ");
            exam3 = Convert.ToInt32(Console.ReadLine());

            average=(exam1+exam2 + exam3)/3;
            Console.Write("Sınavların ortalaması: " + average);

            if (average > 0 && average < 49)
            {
                result = "\nKötü";
            }    
            if (average > 50 && average < 69)
            {
                result = "\nOrta";
            }
            if(average > 70 && average < 83)
            {
                result = "\nİyi";
            }
            if (average >= 84)
            {
                result = "\nÇok iyi";
            }
            if (average > 100)
            {
                result = "\nHatalı veri girişi";
            }

            Console.WriteLine(result);
            */
            #endregion

            #region if else
            /*
            Console.Write("Lütfen sayı giriniz: ");
            int number=int.Parse(Console.ReadLine());

            if (number % 2 == 0)
            {
                Console.Write("Sayı çifttir");
            }
            else
            {
                Console.Write("Sayı tektir");
            }
            

            char team;
            Console.Write("Takım adı giriniz: ");
            team = char.Parse(Console.ReadLine());
            if (team == 'g' |team == 'G' )
            {
                Console.Write("Galatasaray");
            } 
            if(team == 'f'|team == 'F')
            {
                Console.Write("Fenerbahçe");
            }
            if (team == 'b' | team == 'B')
            {
                Console.Write("Beşiktaş");
            }
            
            string tatli, yemek, corba,tur;
            Console.WriteLine("Tür şeçiniz(Yemek,Tatlı,Çorba)");
            tur = "tatli,yemek,corba";
            tur=Convert.ToString(Console.ReadLine());
            if (tur == "tatlı") 
            {
                Console.Write("Tatlılarımız:Baklava,Sütlaç,Kazandibi... ");
            }
            if (tur == "yemek")
            {
                Console.Write("Yeneklerimiz:Köfte,Pide,Karnıyarık...");
            }
            if(tur == "çorba")
            {
                Console.Write("Çorbalarımız:Mercimek,Ezogelin,Kelle Paça...");
            }
            */
            #endregion

            #region menü

            Console.WriteLine("------Deneme Lokanta------");
            Console.WriteLine();
            Console.WriteLine("1-Çorba");
            Console.WriteLine("2-Yemek");
            Console.WriteLine("3-Tatlı");
            Console.WriteLine("4-İçecek");
            Console.WriteLine();
            string secim, ssecim;
            Console.Write("Seçim yapınız: ");
            secim = Console.ReadLine();

            if (secim == "1")
            {
                Console.WriteLine();
                Console.WriteLine("1-Mercimek Çorbası");
                Console.WriteLine("2-Ezogelin Çorbası");
                Console.WriteLine("3-Domates Çorbası");
                Console.WriteLine("4-Kelle Paça Çorbası");
                Console.WriteLine();
                Console.Write("Seçim yapınız: ");

                ssecim = Console.ReadLine();
                Console.WriteLine(ssecim + " Numaralı seçiminiz hazırlanıyor");
            }
            if (secim == "2")
            {
                Console.WriteLine();
                Console.WriteLine("1-Köfte");
                Console.WriteLine("2-Taze Fasulye Yemeği");
                Console.WriteLine("3-Karnıyarık");
                Console.WriteLine("4-Et Sote");
                Console.WriteLine();
                Console.Write("Seçim yapınız: ");
                ssecim = Console.ReadLine();
                Console.WriteLine(ssecim + " Numaralı seçiminiz hazırlanıyor");
            }
            if (secim == "3")
            {
                Console.WriteLine();
                Console.WriteLine("1-Sütlaç");
                Console.WriteLine("2-Kazandibi");
                Console.WriteLine("3-Baklava");
                Console.WriteLine("4-Pasta");
                Console.WriteLine();
                Console.Write("Seçim yapınız: ");
                ssecim = Console.ReadLine();
                Console.WriteLine(ssecim + " Numaralı seçiminiz hazırlanıyor");
            }
            if (secim == "4")
            {
                Console.WriteLine();
                Console.WriteLine("1-Kahve");
                Console.WriteLine("2-Çay");
                Console.WriteLine("3-Kola");
                Console.WriteLine("4-Ayran");
                Console.WriteLine();
                Console.Write("Seçim yapınız: ");
                ssecim = Console.ReadLine();
                Console.WriteLine(ssecim + " Numaralı seçiminiz hazırlanıyor");
            }

            #endregion

            #region Swift case
            /*
            Console.Write("Ay girişi yapın: ");
            int monthNumber = Convert.ToInt32(Console.ReadLine());

            switch (monthNumber)
            {
                case 1: Console.WriteLine("Ocak");break;
                case 2: Console.WriteLine("Şubat");break;
                case 3: Console.WriteLine("Mart");break;
                case 4: Console.WriteLine("Nisan");break;
                case 5: Console.WriteLine("Mayıs");break;
                case 6: Console.WriteLine("Haziran");break;
                case 7: Console.WriteLine("Temmuz");break;
                case 8: Console.WriteLine("Ağustos");break;
                case 9: Console.WriteLine("Eylül");break;
                case 10: Console.WriteLine("Ekim");break;
                case 11: Console.WriteLine("Kasım"); break;
                case 12: Console.WriteLine("Aralık"); break;

                default:Console.Write("Hatalı veri girişi");break;
            }
            */
            #endregion

            #region Hesap Makinesi swift case
            //int number1,number2;
            //char symbol;
            //Console.Write("Birinci sayıyı giriniz: ");
            //number1 = Convert.ToInt32(Console.ReadLine());
            //Console.Write("İkinci sayıyı giriniz: ");
            //number2 = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Yapmak istediğiniz işlemi seçiniz (+.-,*,/): ");
            //symbol = Convert.ToChar(Console.ReadLine());
            //switch (symbol)
            //{
            //    case '+': Console.WriteLine("Toplama işlemi sonucunuz:"+(number1 + number2));break;
            //    case '-': Console.WriteLine("Çıkarma işlemi sonucunuz:"+(number2 - number2));break;
            //    case '*': Console.WriteLine("Çarpma işlemi sonucunuz:"+(number1 * number2));break;
            //    case '/': Console.WriteLine("Bölme işlemi sonucunuz:"+(number1 / number2));break;
            //    default:Console.WriteLine("Hatalı veri girişi");break;                
            //}



            #endregion
        }
    }
}
