using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Double Değişkenler
            //double number;
            //number = 4.32; // Consol ekranında virgüllü şekilde gelir.
            //Console.WriteLine(number);

            //Console.WriteLine("Manav Fiyat Listesi: ");
            //Console.WriteLine();

            //double applePrice, tomatoPrice, strawberryPrice, patatoPrice, orangePrice;
            //applePrice = 10.4;
            //tomatoPrice = 23.5;
            //strawberryPrice = 40;
            //patatoPrice = 9.6;
            //orangePrice = 4.7;


            //Console.WriteLine("Elma Fiyatı: " + applePrice + " TL"); 
            //Console.WriteLine("Domates Fiyatı: " + tomatoPrice + " TL");
            //Console.WriteLine("Çilek Fiyatı: " + strawberryPrice + " TL");
            //Console.WriteLine("Patates Fiyatı: " + patatoPrice + " TL");
            //Console.WriteLine("Portakal Fiyatı: " + orangePrice + " TL");

            //Console.WriteLine();

            //double appleGram , tomatoGram, strawberryGram, patatoGram,orangeGram;
            //appleGram = 2.456;
            //tomatoGram = 3.546;
            //strawberryGram = 0.750;
            //patatoGram = 2.434;
            //orangeGram = 1.045;


            //double appleTotalPrice = appleGram *applePrice;
            //double tomatoTotalPrice = tomatoGram *tomatoPrice;
            //double strawberryTotalPrice = strawberryGram * strawberryPrice;
            //double patatoTotalPrice = patatoGram * patatoPrice;
            //double orangeTotalPrice = orangeGram * orangePrice;

            //Console.WriteLine("Alınan Ürün: Elma - " + "Birim Fiyat : " + applePrice + " - Gramaj: " + appleGram + " - Toplam Tutar:" + appleTotalPrice);
            //Console.WriteLine("Alınan Ürün: Domates - " + "Birim Fiyat : " + tomatoPrice + " - Gramaj: " + tomatoGram + " - Toplam Tutar:" + tomatoTotalPrice);
            //Console.WriteLine("Alınan Ürün: Çilek - " + "Birim Fiyat : " + strawberryPrice + " - Gramaj: " + strawberryGram + " - Toplam Tutar:" + strawberryTotalPrice);
            //Console.WriteLine("Alınan Ürün: Patates - " + "Birim Fiyat : " + patatoPrice + " - Gramaj: " + patatoGram + " - Toplam Tutar:" + patatoTotalPrice);
            //Console.WriteLine("Alınan Ürün: Portakal - " + "Birim Fiyat : " + orangePrice + " - Gramaj: " + orangeGram + " - Toplam Tutar:" + orangeTotalPrice);

            //double shoppingTotalPrice = appleTotalPrice + tomatoTotalPrice + strawberryTotalPrice + patatoTotalPrice + orangeTotalPrice;

            //Console.WriteLine();
            //Console.WriteLine();

            //Console.WriteLine("Toplam Fiyat: " + shoppingTotalPrice +"TL");

            #endregion

            #region Char Karakter
            //char symbol = 'F';
            //Console.WriteLine(symbol);

            #endregion

            #region Klavyeden Veri Girişleri
            //Console.WriteLine("CSharp Hava Yolları :");
            //Console.WriteLine();

            //string passengerName, passengerSurname, passengerAge, passengerCity, passengerDistrict;
            //Console.Write("Yolcu Adı :");
            //passengerName = Console.ReadLine();
            //Console.Write("Yolcu Soyadı :");
            //passengerSurname = Console.ReadLine();
            //Console.Write("Yolcu Yaşı :");
            //passengerAge = Console.ReadLine();
            //Console.Write("Yolcu Memleketi :");
            //passengerCity = Console.ReadLine();
            //Console.Write("Yolcunun İlçesi :");
            //passengerDistrict = Console.ReadLine();
            //Console.WriteLine();
            //Console.WriteLine("Yolcu :  " + passengerName + " " + passengerSurname + " " + passengerAge + " " + passengerCity + " " + passengerDistrict);


            #endregion

            #region Klavyeden Int Veri Girişleri
            //int shoePrice, computerPrice, chairPrice, tvPrice;
            //shoePrice = 200;
            //computerPrice = 20000;
            //chairPrice = 500;
            //tvPrice = 5000;

            //int shoeCount, computerCount,chairCount, tvCount;
            //Console.Write("Lütfen Aldığınız Bilgisayar Sayısını Giriniz : ");
            //computerCount = int.Parse(Console.ReadLine());
            //Console.Write("Lütfen Aldığınız Ayakkabı Sayısını Giriniz : ");
            //shoeCount = int.Parse(Console.ReadLine());
            //Console.Write("Lütfen Aldığınız Sandalye Sayısını Giriniz : ");
            //chairCount = int.Parse(Console.ReadLine());
            //Console.Write("Lütfen Aldığınız Televizyon Sayısını Giriniz : ");
            //tvCount = int.Parse(Console.ReadLine());
            //int toplamAyakkabi = shoePrice * shoeCount;
            //int toplamBilgo = computerPrice * computerCount;
            //int toplamSandalye = chairPrice * chairCount;
            //int toplamTelevizyon = tvPrice*tvCount;
            //int totalPrize = toplamAyakkabi + toplamBilgo + toplamSandalye + toplamTelevizyon;
            //Console.WriteLine();
            //Console.WriteLine("Toplam Tutar: " + totalPrize);

            #endregion

            #region Klavyeden Ondalıklı sayılı işlemleri

            //double exam1 , exam2 , exam3,prize ;
            //Console.Write("Lütfen 1. Sınav Notunu giriniz : ");
            //exam1 = double.Parse(Console.ReadLine());
            //Console.Write("Lütfen 2. Sınav Notunu giriniz : ");
            //exam2 = double.Parse(Console.ReadLine());
            //Console.Write("Lütfen 3. Sınav notunu giriniz : ");
            //exam3= double.Parse(Console.ReadLine());
            //prize = (exam1 + exam2 + exam3) / 3;

            //Console.WriteLine("Sınav Sonucunuz : " + prize);
            //Console.WriteLine();

            #endregion

            #region Klavyeden Karakter Girişleri

            //char gender;
            //Console.Write("Lütfen Cinsiyetinizi Giriniz  (E veya K olarak)  : ");
            //gender = char.Parse(Console.ReadLine());

            //Console.Write("Seçtiğiniz Cinsiyet : " + gender);
            
            #endregion
            Console.Read();
        }
    }
}
