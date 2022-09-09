using Proje_2.Controller;

namespace Proje_2
{
    class Program
    {
        static void Main()
        {
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçiniz :) ");
                Console.WriteLine("****************************************");
                Console.WriteLine("(1) Board Listelemek");
                Console.WriteLine("(2) Board'a Kart Eklemek");
                Console.WriteLine("(3) Board'dan Kart Silmek");
                Console.WriteLine("(4) Kart Taşımak");
                int choose = Convert.ToInt32(Console.ReadLine());
                switch (choose)
                {
                    case 1:
                        Operations.list_board();
                        break;
                    case 2:
                        Operations.add_card();
                        break;
                    case 3:
                        Operations.delete_card();
                        break;
                    case 4:
                        Operations.move_card();
                        break;
                    default:
                        Console.WriteLine("Programdan çıkış yapılıyor....");
                        flag = false;
                        break;

                }
            }
        }
    }
}