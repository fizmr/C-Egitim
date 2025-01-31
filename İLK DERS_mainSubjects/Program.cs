using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace İLK_DERS_mainSubjects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Hello");
            Console.WriteLine("Merhaba");

            string name = "furkan";
            string customerName = "FURKAN";
            string customerSurname = "İZMİR";
            string customerPhoneNumber = "+90 500 400 30 20";
            string customerEmail = "deneme@gmail.com";
            string district = "Kadıköy";
            string city = "İstanbul";

            int hamburgerPrice = 250;
            int colaPrice = 35;
            int pizzaPrice = 200;
            int lemonadePrice = 25;
            int fryPrice = 100;
            int waterPrice = 15;
            

            Console.WriteLine("********************");
            Console.WriteLine("Rezervasyon Kartı");
            Console.WriteLine("********************");
            Console.WriteLine($"Müşteri: {customerName} {customerSurname}");
            Console.WriteLine($"Müşteri İletişim Bilgileri: {customerPhoneNumber}-{customerEmail}");
            Console.WriteLine($"Müşteri Adresi: {district}/{city}");
            Console.WriteLine("--------------------");
            Console.WriteLine("Restoran Menüsü Fiyatı");
            Console.WriteLine("--------------------");
            Console.WriteLine($"- Hamburger Fiyatı: {hamburgerPrice} TL");
            Console.WriteLine($"- Pizza Fiyatı: {pizzaPrice} TL");
            Console.WriteLine($"- Kola Fiyatı: {colaPrice} TL");
            Console.WriteLine($"- Limonata Fiyatı: {lemonadePrice} TL");
            Console.WriteLine($"- Kızartma Fiyatı: {fryPrice} TL");
            Console.WriteLine($"- Su Fiyatı: {waterPrice} TL");

            int hamburgerCount = 2;
            int pizzaCount = 1;
            int colaCount = 2;
            int lemonadeCount = 1;
            int fryCount = 1;
            int waterCount = 2;
            int totalPrice = 0;

            totalPrice = hamburgerCount * hamburgerPrice + pizzaCount * pizzaPrice + colaCount * colaPrice + lemonadeCount * lemonadePrice + fryCount * fryPrice + waterCount * waterPrice;

            Console.WriteLine($"Toplam Fiyat: {totalPrice} TL");
        }
    }
}
