using System;

namespace sınav
{
    class Program
    {
        static void Main(string[] args)
        {
            int toplam;
            int sayi;
            int islem;
            for (sayi = 1; sayi < 10000; sayi++)
            {
                toplam = 0;
                for (islem = 1; islem < sayi; islem++)
                {
                    if (sayi % islem == 0)
                    {
                        toplam = toplam + islem;
                    }
                }
                if (sayi == toplam)
                {
                    Console.WriteLine(sayi + ": Mükemmel Sayıdır.");
                }

            }
            Console.ReadKey();
        }
    }
    }
}
