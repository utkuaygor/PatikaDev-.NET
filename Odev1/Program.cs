namespace Odev1
{
    class Program
    {
        static void Main()
        {
            int secim = 0;
            try
            {
                do
                {
                    Console.WriteLine("Calistirilacak Maddeyi Secin[1 - 2 - 3 - 4 ]\n(Cikis Yapmak Icin -1): ");
                    secim = Int32.Parse(Console.ReadLine());
                    switch (secim)
                    {
                        case 1:
                            madde1();
                            break;
                        case 2:
                            madde2();
                            break;
                        case 3:
                            madde3();
                            break;
                        case 4:
                            madde4();
                            break;
                        case -1:
                            Console.WriteLine("Cikis yapiliyor...");
                            return;
                        default:
                            Console.WriteLine("Hatali giris yaptiniz!");
                            break;
                    }

                } while (secim != -1);
            }
            catch (FormatException e)
            {
                Console.WriteLine("Deger bos girilemez! Madde yeniden calistiriliyor...");
                Main();
            }
        }

        static void madde1()
        {
            try
            {
                Console.WriteLine("Pozitif bir sayı girin: ");
                int n = Int32.Parse(Console.ReadLine());
                if (n <= 0)
                    throw new ArgumentException("Lutfen pozitif bir sayi girin! Madde yeniden calistiriliyor...");
                int[] sayilar = new int[n];
                for (int i = 0; i < n; i++)
                {
                    Console.WriteLine((i + 1) + ". Pozitif Sayıyı Girin: ");
                    sayilar[i] = Int32.Parse(Console.ReadLine());
                    if (sayilar[i] <= 0)
                        throw new ArgumentException("Lutfen pozitif bir sayi girin! Madde yeniden calistiriliyor...");
                }
                Console.Write("Cift olan sayilar: ");
                foreach (int sayi in sayilar)
                {
                    if (sayi % 2 == 0)
                        Console.Write(sayi + " ");
                }
                Console.WriteLine();
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message.ToString());
                madde1();
            }
            catch (FormatException e)
            {
                Console.WriteLine("Deger bos girilemez! Madde yeniden calistiriliyor...");
                madde1();
            }
        }

        static void madde2()
        {
            try
            {
                Console.WriteLine("Pozitif bir sayı(n) girin: ");
                int n = Int32.Parse(Console.ReadLine());
                if (n <= 0)
                    throw new ArgumentException("Lutfen pozitif bir sayi girin! Madde yeniden calistiriliyor...");
                Console.WriteLine("Pozitif bir sayı(m) girin: ");
                int m = Int32.Parse(Console.ReadLine());
                if (m <= 0)
                    throw new ArgumentException("Lutfen pozitif bir sayi girin! Madde yeniden calistiriliyor...");
                int[] sayilar = new int[n];
                for (int i = 0; i < n; i++)
                {
                    Console.WriteLine((i + 1) + ". Pozitif Sayıyı Girin: ");
                    sayilar[i] = Int32.Parse(Console.ReadLine());
                    if (sayilar[i] <= 0)
                        throw new ArgumentException("Lutfen pozitif bir sayi girin! Madde yeniden calistiriliyor...");
                }
                Console.Write(m + "'e esit ya da tam bolunen sayilar: ");
                foreach (int sayi in sayilar)
                {
                    if (sayi == m || sayi % m == 0)
                        Console.Write(sayi + " ");
                }
                Console.WriteLine();
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message.ToString());
                madde2();
            }
            catch (FormatException e)
            {
                Console.WriteLine("Deger bos veya kelime olarak girilemez! Madde yeniden calistiriliyor...");
                madde2();
            }
        }

        static void madde3()
        {
            try
            {
                Console.WriteLine("Pozitif bir sayı(n) girin: ");
                int n = Int32.Parse(Console.ReadLine());
                if (n <= 0)
                    throw new ArgumentException("Lutfen pozitif bir sayi girin! Madde yeniden calistiriliyor...");
                string[] kelimeler = new string[n];
                for (int i = 0; i < n; i++)
                {
                    Console.WriteLine((i + 1) + ". Kelimeyi girin: ");
                    kelimeler[i] = Console.ReadLine().ToString();
                    if (string.IsNullOrWhiteSpace(kelimeler[i]))
                        throw new ArgumentException("Lutfen bir kelime girin! Madde yeniden calistiriliyor...");
                }
                Array.Reverse(kelimeler);
                Console.Write("Kelimelerin tersten siralanmis hali: ");
                foreach (string kelime in kelimeler)
                {
                    Console.Write(kelime + " ");
                }
                Console.WriteLine();
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message.ToString());
                madde3();
            }
            catch (FormatException e)
            {
                Console.WriteLine("Deger bos veya kelime olarak girilemez! Madde yeniden calistiriliyor...");
                madde3();
            }
        }

        static void madde4()
        {
            try
            {
                Console.WriteLine("Bir cumle yazin: ");
                string cumle = Console.ReadLine().Trim().ToString();
                if (string.IsNullOrWhiteSpace(cumle))
                    throw new ArgumentException("Lutfen bir cumle girin! Madde yeniden calistiriliyor...");
                int kelimeler = (cumle.Split(" ")).Length;
                int harfler = (string.Join("", cumle.Split(" ")).Length);
                Console.WriteLine("Cumledeki Kelimelerin Sayisi: " + kelimeler);
                Console.WriteLine("Cumledeki Harflerin Sayisi: " + harfler);
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message.ToString());
            }
        }
    }
}