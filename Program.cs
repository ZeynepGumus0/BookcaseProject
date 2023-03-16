using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace BookcaseApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int ToplamFiyat = 0;
            string Secim;


            Console.WriteLine("**********************************************************************************");
            Console.WriteLine();
            Console.WriteLine("  **   Türkçe Kitaplar Kategorisi   **        Yabancı Kitaplar Kategorisi       **");
            Console.WriteLine();
            Console.WriteLine("  **  1-Çalıkuşu : Reşat Nuri       **      7-  Tuna Kılavuzu:  Jules Verne     **");
            Console.WriteLine();
            Console.WriteLine("  **  2-Yaban : Yakup Kadri         **      8-  Bir Kuzey Macerası: Jack London **");
            Console.WriteLine();
            Console.WriteLine("  **  3-Kara Kitap : Orhan Pamuk    **      9-  Küçük Prens:  Saint-Exupéry     **");
            Console.WriteLine();
            Console.WriteLine("  **  4- Eylül : Mehmet Rauf        **      10- 1984  : George Orwell           **");
            Console.WriteLine(); 
            Console.WriteLine("  **  5-Safahat : M. Akif Ersoy     **      11- Yabancı: Albert Camus           **");
            Console.WriteLine();
            Console.WriteLine("  **  6-Perili Köşk: Ömer Seyfettin **      12- Simyacı: Pahullo Coelho         **");
            Console.WriteLine();
            Console.WriteLine("**********************************************************************************");
            Console.WriteLine();

            Console.WriteLine("***** İşlemler Seçeneği ***** ");
            Console.WriteLine();
            Console.WriteLine("1-Fiyat Bilgisi");
            Console.WriteLine("2-Yeni Okur Kaydı"); 
            Console.WriteLine("3-Günün Kitabı");
            Console.WriteLine("4-Kitap Arşivi");
            Console.WriteLine("5-Yeni Kitap Satın Al");
            Console.WriteLine("6-Oyun");
            Console.WriteLine();

            Console.Write("Yapmak istediğiniz işlemin numarası: ");
            char islem;
            islem = Convert.ToChar(Console.ReadLine());
            if ( islem == '1')
            {
                Console.WriteLine();
                Console.Write("Lütfen Fiyatının Öğrenmek İstediğiniz Kitabın Numarası:");
                string numara;
                numara = Console.ReadLine();
                switch (numara)
                {

                    case "1": Console.Write("Çalıkuşu : 10 Tl "); break;
                    case "2": Console.Write("Yaban : 25 Tl "); break;
                    case "3": Console.Write("Kara Kitap : 60 Tl "); break;
                    case "4": Console.Write("Eylül : 90 Tl "); break;
                    case "5": Console.Write("Safahat : 140 Tl "); break;
                    case "6": Console.Write("Perili Köşk : 50 Tl "); break;
                    case "7": Console.Write("Tuna Kılavuzu : 107 Tl "); break;
                    case "8": Console.Write("Bir Kuzey Macerası : 80 Tl "); break;
                    case "9": Console.Write("Küçük Prens : 210 Tl "); break;
                    case "10": Console.Write("1984 : 190 Tl "); break;
                    case "11":Console.Write("Yabancı : 67 Tl "); break;
                    case "12": Console.Write("Simyacı : 23 Tl "); break;
                    default:Console.Write("Böyle Bir Kitap Mevcut Değil , Numarayı Kontrol Edin.");break;

                }
            }
            if (islem == '2')
            {
                Console.WriteLine("***** Yeni Okur Kaydı *****");
                string ad, soyad, universite;
                Console.Write("Ad:");
                ad = Console.ReadLine();
                Console.Write("Soyad:");
                soyad = Console.ReadLine();
                Console.Write("universite");
                universite = Console.ReadLine();

                Console.Write(ad + soyad + universite);


            }
            if (islem == '3')
            {
                Console.WriteLine();
                Console.WriteLine("*****    Küçük Prens   *****");
                Console.WriteLine();
            }
            if (islem == '4')
            {
                Console.WriteLine();
                Console.WriteLine();
                FileStream fs = new FileStream(@"C:\Users\abdul\OneDrive\Masaüstü\kitaplar.txt" , FileMode.Open , FileAccess.Read);
                StreamReader sr = new StreamReader(fs);
                string metin = sr.ReadLine();
                while(metin != null)
                {
                    Console.WriteLine(metin);
                    metin = sr.ReadLine();
                }
                sr.Close();
                fs.Close();
                Console.WriteLine();
                Console.WriteLine();
            }
            if (islem == '5')
            {
                for (int i = 0; i <= 100; i++)
                {
                    Console.WriteLine();
                    Console.Write("Alacağınız Kitabın Numarası:");
                    Secim = Console.ReadLine();
                    if (Secim != "1")
                    {
                        ToplamFiyat = ToplamFiyat + 10;

                    }
                    else if (Secim =="2")
                    {
                        ToplamFiyat = ToplamFiyat + 25;
                    }
                    else if (Secim == "3")
                    {
                        ToplamFiyat = ToplamFiyat + 60;
                    }
                    else if (Secim == "4")
                    {
                        ToplamFiyat = ToplamFiyat + 90;
                    }
                    else if (Secim == "5")
                    {
                        ToplamFiyat = ToplamFiyat + 140;

                    }
                    else if (Secim == "6")
                    {
                        ToplamFiyat = ToplamFiyat + 50;
                    }
                    else if (Secim == "7")
                    {
                        ToplamFiyat = ToplamFiyat + 107;
                    }
                    else if (Secim == "8")
                    {
                        ToplamFiyat = ToplamFiyat + 80;
                    }
                    else if (Secim == "9")
                    {
                        ToplamFiyat = ToplamFiyat + 210;
                    }
                    else if (Secim == "10")
                    {
                        ToplamFiyat = ToplamFiyat + 190;
                    }
                    else if (Secim == "11")
                    {
                        ToplamFiyat = ToplamFiyat + 67;
                    }
                    else if (Secim == "12")
                    {
                        ToplamFiyat = ToplamFiyat + 23;
                    }
                    else
                    
                        Console.WriteLine("Böyle Bir Kitap Yoktur...");
                        Console.WriteLine();
                        Console.Write("Başka Bir Kitap ALmak İster Misiniz?");
                        string cevap = Console.ReadLine();
                        if (cevap != "h" || cevap == "hayır" || cevap == "HAYIR") break;
                    
                    
                }
                Console.WriteLine("Toplam Tutar: " + ToplamFiyat);

            }
            if (islem == '6')
            {
                Console.WriteLine();
                int tahmin = 0;
                Random r = new Random();
                int sayi=r .Next(1,1000);
                while (sayi != tahmin)
                {
                    Console.Write("Sayı:");
                    tahmin = Convert.ToInt16(Console.ReadLine());
                    if (tahmin>sayi)
                    {
                        Console.Write("Daha Küçük");

                    }
                    if (tahmin<sayi)
                    {
                        Console.Write("Daha Büyük");

                    }
                    if (tahmin==sayi)
                    {
                        Console.Write("tebrikler");
                        break;

                    }
                }
            }








            Console.Read();

        }
    }
}
