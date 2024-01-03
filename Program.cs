using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcBasamaklıOrnek214
{
    internal class Program
    {
        static void Main(string[] args)
        {

            
            string s = " ";
            string[] Birler = { "Bir", "İki", "Üç", "Dört", "Beş", "Altı", "Yedi", "Sekiz", "Dokuz" };
            string[] Onlar = { "On", "Yirmi", "Otuz", "Kırk", "Elli", "Altmış", "Yetmiş", "Seksen", "Doksan" };
            string[] Yuzler = { "Yüz", "İkiYüz", "ÜçYüz", "DörtYüz", "BeşYüz", "AltıYüz", "YediYüz", "SekizYüz", "DokuzYüz" };

            Console.Write("Bir Sayı Giriniz (1-999 arasında): ");
            int a = Convert.ToInt32(Console.ReadLine());

            if (a >= 1 && a <= 999)
            {
                if (a >= 100)
                {
                   s = Yuzler[(a / 100) - 1];
                   a = a % 100;
                    
                }

                if (a / 10 >= 1)
                {
                    s = s + Onlar[(a / 10) - 1];
                }

                if (a % 10 != 0)
                {
                    s = s + Birler[(a % 10) - 1];
                }

                Console.WriteLine(s);
            }
            else
            {
                Console.WriteLine("Uygun değer girmediniz.");
            }

            Console.Write("Press any key to continue . . . ");
            Console.ReadKey(true);
        }
    }
}
