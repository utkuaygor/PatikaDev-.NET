using System.Collections;
using System.Linq;


namespace Odev2_Soru1
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi = 0;
            ArrayList asalOlmayan = new ArrayList();
            ArrayList asallar = new ArrayList();
            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine((i + 1) + ".Sayiyi girin: ");
                bool tur_kontrol = int.TryParse(Console.ReadLine(), out sayi);
                bool negatif_kontrol = sayi <= 0;
                if (!tur_kontrol || negatif_kontrol)
                {
                    Console.WriteLine("Lutfen POZITIF bir SAYI girin!");
                    i--;
                    continue;
                }
                else
                {
                    if (sayi.asalMi())
                        asallar.Add(sayi);
                    else
                        asalOlmayan.Add(sayi);
                }
            }
            Console.Write("Asal olmayan sayilar: ");
            asalOlmayan.listYazdir();
            Console.WriteLine("Asal olmayan sayilar icin dizi boyutu: " + asalOlmayan.Count);
            Console.WriteLine("Asal olmayan sayilar icin dizi ortalamasi: " + (double)asalOlmayan.listToplam() / (double)asalOlmayan.Count);
            Console.WriteLine("====================");
            Console.Write("Asal olan sayilar: ");
            asallar.listYazdir();
            Console.WriteLine("Asal sayilar icin dizi boyutu: " + asallar.Count);
            Console.WriteLine("Asal sayilar icin dizi ortalamasi: " + (double)asallar.listToplam() / (double)asallar.Count);
        }
    }

    public static class MyExtensions
    {

        public static bool asalMi(this int sayi) //Asal Kontrolü
        {
            if (sayi <= 1) return false;
            if (sayi == 2) return true;
            if (sayi % 2 == 0) return false;

            var sinir = (int)Math.Floor(Math.Sqrt(sayi));

            for (int i = 3; i <= sinir; i += 2)
                if (sayi % i == 0)
                    return false;

            return true;
        }

        public static int listToplam(this ArrayList sayilar) //Kodu temizlemek icin ayri olarak bir toplam fonksiyonu yazdim
        {
            int sum = 0;
            foreach (int sayi in sayilar)
            {
                sum += sayi;
            }
            return sum;
        }

        public static void listYazdir(this ArrayList sayilar)
        {
            sayilar.Sort();
            sayilar.Reverse();
            foreach (int sayi in sayilar)
            {
                Console.Write(sayi + " ");
            }
            Console.WriteLine();
        }

    }
}