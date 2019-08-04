using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DonguSorulari
{
    class Program
    {
        static void Main(string[] args)
        {
            // SORU1: Klavyeden girilen sayının faktöriyelini hesaplayan döngüyü yazınız.(for ve while)
            //Formül: 5 Faktöriyel: 5*4*3*2*1

            // CEVAP1: FOR

            Console.Write("Sayı Giriniz: ");
            int sayi = Convert.ToInt32(Console.ReadLine());
            int faktoriyel = 1;
            for (int i = 1; i <= sayi; i++)
            {
                faktoriyel *= i;
            }
            Console.WriteLine(faktoriyel);

            // CEVAP1: WHILE

            Console.Write("Sayı Giriniz: ");
            int sayi = Convert.ToInt32(Console.ReadLine());
            int faktoriyel = 1;

            while (sayi > 0)
            {
                faktoriyel *= sayi;
                sayi--;
            }
            Console.WriteLine(faktoriyel);


            // SORU2: Klavyeden 0 girene kadar girilen sayıları toplayan program: 0 girilince çıksın.

            int sayi, toplam = 0;
            do
            {
                Console.Write("Bir sayı girin: ");
                sayi = Convert.ToInt32(Console.ReadLine());
                toplam += sayi;
            } while (sayi != 0);

            Console.WriteLine("Girdiğin sayıların toplamı:{0}", toplam);

            //SORU3: Kullanıcının gireceği 5 adet sayıdan kaç tanesinin 10 ile 20 arasında olduğunu sayan örnek.

            int sayac = 0;
            for (int i = 1; i <= 5; i++)
            {
                Console.Write("Sayı: ");
                int sayi = Convert.ToInt32(Console.ReadLine());
                if (sayi >= 10 && sayi <= 20)
                {
                    sayac++;
                }
            }
            string kelime;
            if (sayac > 0)
            {
                kelime = sayac.ToString();
            }
            else
            {
                kelime = "hiçbir";
            }
            Console.WriteLine($"Girdiğiniz 5 sayıdan {kelime} tanesi 10 ile 20 arasındadır.");

            //Genişliği ve yüksekliği kullanıcı tarafından verilen dikdörtgen oluşturma örneğini yazın

            Console.Write("Yüksekliği Girin : ");
            int yukseklik = Convert.ToInt32(Console.ReadLine());
            Console.Write("Genişliği Girin : ");
            int genislik = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= yukseklik; i++)
            {
                for (int j = 1; j <= genislik; j++)
                {
                    if (i == 1 || i == yukseklik)
                        Console.Write("*");
                    else
                        if (j == 1 || j == genislik)
                        Console.Write("*");
                    else
                        Console.Write(" ");
                }
                Console.WriteLine();
            }



            Console.Read();

        }
    }
}