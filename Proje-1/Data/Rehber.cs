namespace Proje_1.Data
{

    class Rehber
    {
        private static List<Kisi> rehber_listesi;

        public static List<Kisi> Rehber_listesi { get => rehber_listesi; set => rehber_listesi = value; }
        static Rehber()
        {
            rehber_listesi = new List<Kisi>(){
                new Kisi("Dogus","Karaaslan","(531) 392 92 92"),
                new Kisi("Bahar","Yilmaz","(538) 295 13 13"),
                new Kisi("Hakan","Durmuş","(517) 044 58 39"),
                new Kisi("Zeynep","Atasoy","(501) 998 36 47"),
                new Kisi("Sergün","Sever","(577) 632 78 03")
            };
        }
    }
}