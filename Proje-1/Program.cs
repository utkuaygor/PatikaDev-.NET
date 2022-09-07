using Proje_1.Controller;
using Proje_1.Data;

namespace Proje_1
{
    class Program
    {
        static void Main()
        {
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("Islemler");
                Console.WriteLine("****************************************");
                Console.WriteLine("(1) Yeni Numara Kaydetmek");
                Console.WriteLine("(2) Var Olan Numarayi Silmek");
                Console.WriteLine("(3) Varolan Numarayı Güncellemek");
                Console.WriteLine("(4) Rehberi Listelemek");
                Console.WriteLine("(5) Rehberde Arama Yapmak\n");
                Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçiniz: ");
                int secim = Convert.ToInt32(Console.ReadLine());


                switch (secim)
                {
                    case 1:
                        Islemler.telefon_kaydet();
                        break;
                    case 2:
                        Islemler.telefon_sil();
                        break;
                    case 3:
                        Islemler.telefon_guncelle();
                        break;
                    case 4:
                        Islemler.rehberi_listele();
                        break;
                    case 5:
                        Islemler.rehberde_ara();
                        break;
                    default:
                        Console.WriteLine("Çıkış Yapılıyor........");
                        flag = false;
                        break;
                }
            }

        }
    }
}