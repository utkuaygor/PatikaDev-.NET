using Proje_1.Data;

namespace Proje_1.Controller
{
    static class Islemler
    {
        public static void telefon_kaydet()
        {
            Console.WriteLine("Lütfen isim giriniz".PadRight(35) + ":");
            string isim = Console.ReadLine().ToString();
            Console.WriteLine("Lütfen soyisim giriniz".PadRight(35) + ":");
            string soyisim = Console.ReadLine().ToString();
            Console.WriteLine("Lütfen telefon numarası giriniz".PadRight(35) + ":");
            string telefon = Console.ReadLine().ToString();

            Kisi kayit = new Kisi(isim, soyisim, telefon);


            /* ilk bulunan değeri silmemek için isim ve soyisim unique olarak alınmak isterse bu blok yorumdan çıkartılmalı

            if (Rehber.Rehber_listesi.Any(p => p.Isim == kayit.Isim) && Rehber.Rehber_listesi.Any(p => p.Soyisim == kayit.Soyisim))
            {
                Console.WriteLine($"{isim + " " + soyisim} zaten kayitli!");
                return;
            }

            */

            if (Rehber.Rehber_listesi.Any(p => p.Telefon == kayit.Telefon))
            {
                Console.WriteLine("Bu numara zaten kayitli!");
                Console.WriteLine("****************************************");
                return;
            }

            Rehber.Rehber_listesi.Add(kayit);
            Console.WriteLine($"{isim + " " + soyisim} adlı kisi {telefon} numarası ile eklendi.");
            Console.WriteLine("****************************************");
        }

        public static void telefon_sil()
        {
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("Lütfen numarasını silmek istediğiniz kişinin adını ya da soyadını giriniz:");
                string aranacakDeger = Console.ReadLine().ToString();
                if (Rehber.Rehber_listesi.Any(p => p.Isim.ToLower() == aranacakDeger.ToLower() || p.Soyisim.ToLower() == aranacakDeger.ToLower()))
                {
                    Console.WriteLine($"{aranacakDeger} isimli/soyisimli kişi rehberden silinmek üzere, onaylıyor musunuz? (Y/N)");
                    string secim = Console.ReadLine().ToLower();
                    if (secim == "y")
                    {
                        Rehber.Rehber_listesi.Remove(Rehber.Rehber_listesi.Find(p => p.Isim.ToLower() == aranacakDeger.ToLower() || p.Soyisim.ToLower() == aranacakDeger.ToLower()));
                        Console.WriteLine($"{aranacakDeger} isim/soyisimli kayıt başarıyla silindi!");
                        Console.WriteLine("****************************************");
                        flag = false;
                    }
                    else
                    {
                        Console.WriteLine("Silme işlemi sonlandırıldı.");
                        Console.WriteLine("****************************************");
                        flag = false;
                    }
                }
                else
                {
                    Console.WriteLine("Aradığınız krtiterlere uygun veri rehberde bulunamadı. Lütfen bir seçim yapınız.");
                    Console.WriteLine("* Silmeyi sonlandırmak için: (1)");
                    Console.WriteLine("* Yeniden denemek için: (2)");
                    int secim = Convert.ToInt32(Console.ReadLine());
                    switch (secim)
                    {
                        case 1:
                            Console.WriteLine("Silme işlemi sonlandırıldı.");
                            Console.WriteLine("****************************************");
                            flag = false;
                            break;
                        case 2:
                            Console.WriteLine("****************************************");
                            break;

                    };
                }
            }
        }

        public static void telefon_guncelle()
        {
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("Lütfen numarasını güncellemek istediğiniz kişinin adını ya da soyadını giriniz:");
                string aranacakDeger = Console.ReadLine().ToString();
                if (Rehber.Rehber_listesi.Exists(p => p.Isim.ToLower() == aranacakDeger.ToLower() || p.Soyisim.ToLower() == aranacakDeger.ToLower()))
                {
                    Console.WriteLine("Lütfen yeni numarayı giriniz: ");
                    string numara = Console.ReadLine().ToString();
                    Rehber.Rehber_listesi.Find(p => p.Isim == aranacakDeger || p.Soyisim == aranacakDeger).Telefon = numara;
                    Console.WriteLine($"{aranacakDeger} isimli/soyisimli kullanıcının başarıyla güncellendi.");
                    Console.WriteLine("****************************************");
                    flag = false;
                }
                else
                {
                    Console.WriteLine("Aradığınız krtiterlere uygun veri rehberde bulunamadı. Lütfen bir seçim yapınız.");
                    Console.WriteLine("* Güncellemeyi sonlandırmak için: (1)");
                    Console.WriteLine("* Yeniden denemek için: (2)");
                    int secim = Convert.ToInt32(Console.ReadLine());
                    switch (secim)
                    {
                        case 1:
                            Console.WriteLine("Güncelleme işlemi sonlandırıldı.");
                            Console.WriteLine("****************************************");
                            flag = false;
                            break;
                        case 2:
                            Console.WriteLine("****************************************");
                            break;
                    };
                }
            }
        }

        public static void rehberi_listele()
        {
            Console.WriteLine("Telefon Rehberi");
            Console.WriteLine("****************************************");
            foreach (Kisi kayit in Rehber.Rehber_listesi)
            {
                Console.WriteLine($"İsim: {kayit.Isim}");
                Console.WriteLine($"Soyisim: {kayit.Soyisim}");
                Console.WriteLine($"Telefon Numarası: {kayit.Telefon}");
                Console.WriteLine("-");
            }
            Console.WriteLine("****************************************");
        }

        public static void rehberde_ara()
        {
            Console.WriteLine("Arama yapmak istediğiniz tipi seçiniz.");
            Console.WriteLine("****************************************");
            Console.WriteLine("İsim veya soyisime göre arama yapmak için: (1)");
            Console.WriteLine("Telefon numarasina göre arama yapmak için: (2)");
            int secim = Convert.ToInt32(Console.ReadLine());
            switch (secim)
            {
                case 1:
                    Console.WriteLine("Lütfen aramak istediğiniz kişinin adını ya da soyadını giriniz:");
                    string aranacakDeger = Console.ReadLine().ToString();
                    if (Rehber.Rehber_listesi.Exists(p => p.Isim.ToLower() == aranacakDeger.ToLower() || p.Soyisim.ToLower() == aranacakDeger.ToLower()))
                    {
                        foreach (Kisi kayit in Rehber.Rehber_listesi.FindAll(p => p.Isim == aranacakDeger || p.Soyisim == aranacakDeger))
                        {
                            Console.WriteLine($"İsim: {kayit.Isim}");
                            Console.WriteLine($"Soyisim: {kayit.Soyisim}");
                            Console.WriteLine($"Telefon Numarası: {kayit.Telefon}");
                            Console.WriteLine("-");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Aradığınız krtiterlere uygun veri rehberde bulunamadı.");
                        Console.WriteLine("****************************************");
                    }
                    break;
                case 2:
                    Console.WriteLine("Lütfen aramak istediğiniz telefon numarasını giriniz:");
                    aranacakDeger = Console.ReadLine().ToString();
                    if (Rehber.Rehber_listesi.Exists(p => p.Telefon == aranacakDeger))
                    {
                        foreach (Kisi kayit in Rehber.Rehber_listesi.FindAll(p => p.Telefon == aranacakDeger))
                        {
                            Console.WriteLine($"İsim: {kayit.Isim}");
                            Console.WriteLine($"Soyisim: {kayit.Soyisim}");
                            Console.WriteLine($"Telefon Numarası: {kayit.Telefon}");
                            Console.WriteLine("-");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Aradığınız krtiterlere uygun veri rehberde bulunamadı.");
                        Console.WriteLine("****************************************");
                    }
                    break;
                default:
                    break;
            }
        }
    }
}
