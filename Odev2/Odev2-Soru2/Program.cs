namespace Odev2_Soru2
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi = 0;
            int[] sayilar = new int[20];
            int[] en_kucuk_uc = new int[3], en_buyuk_uc = new int[3];
            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine((i + 1) + ".Sayiyi girin: ");
                bool tur_kontrol = int.TryParse(Console.ReadLine(), out sayi);
                if (!tur_kontrol)
                {
                    Console.WriteLine("Lutfen bir SAYI girin!");
                    i--;
                    continue;
                }
                sayilar[i] = sayi;
            }
            Array.Sort(sayilar);
            for (int i = 0, j = 19; i < 20; i++, j--)
            {
                if (i < 3)
                    en_kucuk_uc[i] = sayilar[i];
                if (i > 16)
                    en_buyuk_uc[j] = sayilar[i];
            }
            Console.WriteLine("En kucuk 3 sayinin ortalamasi: " + en_kucuk_uc.ortalama());
            Console.WriteLine("En buyuk 3 sayinin ortalamasi: " + en_buyuk_uc.ortalama());
            Console.WriteLine("En buyuk 3 ve en kucuk 3 sayinin ortalamalarinin toplami: " + (en_kucuk_uc.ortalama() + en_buyuk_uc.ortalama()));
        }
    }

    public static class MyExtensions
    {

        public static double ortalama(this int[] dizi)
        {
            double sum = 0;
            foreach (int sayi in dizi)
            {
                sum += sayi;
            }
            return sum / (double)dizi.Length;
        }
    }
}