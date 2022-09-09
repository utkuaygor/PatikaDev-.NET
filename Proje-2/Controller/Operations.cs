using Proje_2.Data;

namespace Proje_2.Controller
{
    class Operations
    {
        public static void list_board()
        {
            Console.WriteLine("TO DO Line");
            Console.WriteLine("****************************************");
            if (Board.ToDo.Count > 0)
            {
                foreach (var card in Board.ToDo)
                {
                    Console.WriteLine($"Başlık: {card.Title}");
                    Console.WriteLine($"İçerik: {card.Content}");
                    Console.WriteLine($"Atanan Kişi: {card.Member.Name + " " + card.Member.Surname}");
                    Console.WriteLine($"Büyüklük: {card.Size}");
                    Console.WriteLine("-\n");
                }
            }
            else
            {
                Console.WriteLine("~ BOŞ ~\n");
            }
            Console.WriteLine("IN PROGRESS Line");
            Console.WriteLine("****************************************");
            if (Board.InProgress.Count > 0)
            {
                foreach (var card in Board.InProgress)
                {
                    Console.WriteLine($"Başlık: {card.Title}");
                    Console.WriteLine($"İçerik: {card.Content}");
                    Console.WriteLine($"Atanan Kişi: {card.Member.Name + " " + card.Member.Surname}");
                    Console.WriteLine($"Büyüklük: {card.Size}");
                    Console.WriteLine("-\n");
                }
            }
            else
            {
                Console.WriteLine("~ BOŞ ~\n");
            }
            Console.WriteLine("DONE Line");
            Console.WriteLine("****************************************");
            if (Board.Done.Count > 0)
            {
                foreach (var card in Board.Done)
                {
                    Console.WriteLine($"Başlık: {card.Title}");
                    Console.WriteLine($"İçerik: {card.Content}");
                    Console.WriteLine($"Atanan Kişi: {card.Member.Name + " " + card.Member.Surname}");
                    Console.WriteLine($"Büyüklük: {card.Size}");
                    Console.WriteLine("-\n");
                }
            }
            else
            {
                Console.WriteLine("~ BOŞ ~\n");
            }
        }

        public static void add_card()
        {
            Console.Write("Başlık giriniz".PadRight(50) + ":");
            string baslik = Console.ReadLine().ToString();
            Console.Write("İçerik giriniz".PadRight(50) + ":");
            string icerik = Console.ReadLine().ToString();
            Console.Write("Büyüklük seçiniz -> XS(1),S(2),M(3),L(4),XL(5)".PadRight(50) + ":");
            int buyukluk = Convert.ToInt32(Console.ReadLine());
            if (buyukluk < 1 || buyukluk > 5)
            {
                Console.WriteLine("Hatalı Giriş Yaptınız!");
                Console.WriteLine("****************************************");
                return;
            }
            Console.Write("Kişi giriniz(ID)".PadRight(50) + ":");
            int id = Convert.ToInt32(Console.ReadLine());
            if (!Team.TeamList.Exists(p => p.Id == id))
            {
                Console.WriteLine("Hatalı giriş yaptınız! Bu ID'ye sahip bir kullanıcı mevcut değil!");
                Console.WriteLine("****************************************");
                return;

            }
            bool temp = Enum.TryParse(Enum.GetName(typeof(Size), buyukluk), out Size newSize);
            Board.ToDo.Add(new Card(baslik, icerik, Team.TeamList.Find(p => p.Id == id), newSize, CardType.TODO));
            Console.WriteLine("Kart başarı ile eklendi!");
            Console.WriteLine("****************************************");

        }

        public static void delete_card()
        {
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("Öncelikle silmek istediğiniz kartı seçmeniz gerekiyor.");
                Console.Write("Lütfen kart başlığını yazınız:  ");
                string baslik = Console.ReadLine().ToString();
                if (Board.ToDo.Exists(p => p.Title == baslik) ||
                    Board.InProgress.Exists(p => p.Title == baslik) ||
                    Board.Done.Exists(p => p.Title == baslik))
                {
                    Board.ToDo.RemoveAll(p => p.Title == baslik);
                    Board.InProgress.RemoveAll(p => p.Title == baslik);
                    Board.Done.RemoveAll(p => p.Title == baslik);
                    Console.WriteLine("{0} başlıklı kartlar başarıyla kaldırıldı!\n", baslik);
                    flag = false;
                }
                else
                {
                    Console.WriteLine("Aradığınız krtiterlere uygun kart board'da bulunamadı. Lütfen bir seçim yapınız.");
                    Console.WriteLine("* Silmeyi sonlandırmak için : (1)");
                    Console.WriteLine("* Yeniden denemek için : (2)");
                    int secim = Convert.ToInt32(Console.ReadLine());
                    switch (secim)
                    {
                        case 1:
                            Console.WriteLine();
                            flag = false;
                            break;
                        case 2:
                            Console.WriteLine();
                            break;
                    }
                }
            }
        }

        public static void move_card()
        {
            bool flag = true;
            bool find_flag = false;
            Card card = null;
            while (flag)
            {
                Console.WriteLine("Öncelikle taşımak istediğiniz kartı seçmeniz gerekiyor.");
                Console.Write("Lütfen kart başlığını yazınız:  ");
                string baslik = Console.ReadLine().ToString();
                if (Board.ToDo.Exists(p => p.Title == baslik))
                {
                    find_flag = true;
                    card = Board.ToDo.Find(p => p.Title == baslik);
                }
                else if (Board.InProgress.Exists(p => p.Title == baslik))
                {
                    find_flag = true;
                    card = Board.InProgress.Find(p => p.Title == baslik);
                }
                else if (Board.Done.Exists(p => p.Title == baslik))
                {
                    find_flag = true;
                    card = Board.Done.Find(p => p.Title == baslik);

                }
                if (find_flag)
                {
                    Console.WriteLine("Bulunan Kart Bilgileri: ");
                    Console.WriteLine("****************************************");
                    Console.WriteLine("Başlık".PadRight(20) + ": {0}", card.Title);
                    Console.WriteLine("İçerik".PadRight(20) + ": {0}", card.Content);
                    Console.WriteLine("Atanan Kişi".PadRight(20) + ": {0}", card.Member.Name + " " + card.Member.Surname);
                    Console.WriteLine("Büyüklük".PadRight(20) + ": {0}", card.Size);
                    Console.WriteLine("Line".PadRight(20) + ": {0}", card.Type);
                    Console.WriteLine("Lütfen taşımak istediğiniz Line'ı seçiniz: ");
                    Console.WriteLine("(1) TODO");
                    Console.WriteLine("(2) IN PROGRESS");
                    Console.WriteLine("(3) DONE");
                    int secim = Convert.ToInt32(Console.ReadLine());
                    if (secim == (int)card.Type)
                    {
                        Console.WriteLine("Kartı aynı Line'a taşıyamazsınız!");
                        return;
                    }
                    switch ((int)card.Type)
                    {
                        case 1:
                            Board.ToDo.Remove(card);
                            break;
                        case 2:
                            Board.InProgress.Remove(card);
                            break;
                        case 3:
                            Board.Done.Remove(card);
                            break;

                    }
                    switch (secim)
                    {
                        case 1:
                            Board.ToDo.Add(card);
                            flag = false;
                            break;
                        case 2:
                            Board.InProgress.Add(card);
                            flag = false;
                            break;
                        case 3:
                            Board.Done.Add(card);
                            flag = false;
                            break;
                    }

                }
                else
                {
                    Console.WriteLine("Aradığınız krtiterlere uygun kart board'da bulunamadı. Lütfen bir seçim yapınız.");
                    Console.WriteLine("* Taşımayı sonlandırmak için : (1)");
                    Console.WriteLine("* Yeniden denemek için : (2)");
                    int secim = Convert.ToInt32(Console.ReadLine());
                    switch (secim)
                    {
                        case 1:
                            Console.WriteLine();
                            flag = false;
                            return;
                        case 2:
                            Console.WriteLine();
                            break;
                    }
                }
            }
        }
    }
}