using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace _01_CSharpProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region string_Degiskenler
            //string customerName;
            //string customerSurname;
            //string customerEmail;
            //string customerPhone;
            //string customerCity;

            //customerName = "Fatma Nur";
            //customerSurname = "Zoplan";
            //customerEmail = "FZOPLAN@GMAİL.COM";
            //customerPhone = "050593493402";
            //customerCity = "Manisa";

            //Console.WriteLine("*********** Rezervasyon Kartı *************");
            //Console.WriteLine();
            //Console.WriteLine("Ad Soyad =" + customerName + customerSurname);
            //Console.WriteLine("Email =" + customerEmail);
            //Console.WriteLine("Telefon no =" + customerPhone);
            //Console.WriteLine("Şehir =" + customerCity);
            //Console.WriteLine("********************************************");
            #endregion

            #region Int değişkenler
            //int number = 21;
            //Console.WriteLine(number);

            int hamburgerPrice = 300;
            int pizzaPrice = 200;
            int cokePrice= 35;
            int lemonatePrice = 50;
            int WaterPrice = 10;
            int PatisPrice = 45;

            Console.WriteLine("--------Restorant Menüsü-------------");
            Console.WriteLine();
            Console.WriteLine("Hamburger: " + hamburgerPrice);
            Console.WriteLine("Pizza: " + pizzaPrice);
            Console.WriteLine("Kola: " + cokePrice);
            Console.WriteLine("Limonata: " + lemonatePrice);
            Console.WriteLine("Su :" + WaterPrice);
            Console.WriteLine("Patates Kovası :" + PatisPrice);
            Console.WriteLine();
            Console.WriteLine("--------Restorant Menüsü-------------");
            Console.WriteLine();

            int hamburgerCount = 3;
            int pizzaCount = 3;
            int cokeCount = 2;
            int lemonateCount = 0;
            int waterCount = 5;
            int patisCount = 3;

            int totalHamburger = hamburgerPrice * hamburgerCount;
            int totalPizza = pizzaPrice * pizzaCount;
            int totalCoke = cokePrice * cokeCount;
            int totalLemonate = lemonatePrice * lemonateCount; 
            int totalWater = WaterPrice * waterCount;
            int totalPatis = PatisPrice * patisCount;

            int toplamfiyat = totalHamburger + totalCoke + totalLemonate + totalWater + totalPatis + totalPizza;


            Console.WriteLine("-------------------------HESAP-------------------------");
            Console.WriteLine();
            Console.WriteLine("Hamburger Fiyatı: "  + totalHamburger + " TL");
            Console.WriteLine("Pizza Fiyatı: " + totalPizza + " TL");
            Console.WriteLine("Kola Fiyatı: " + totalCoke + " TL");
            Console.WriteLine("Limonata Fiyatı: " + totalLemonate + " TL");
            Console.WriteLine("Su Fiyatı: " + totalWater + " TL");
            Console.WriteLine("Patates Kovası Fiyatı: " + totalPatis + " TL");
            Console.WriteLine();
            Console.WriteLine("Toplam Fiyat: " + toplamfiyat + " TL");



            #endregion,

            Console.ReadKey();
        }
    }
}
