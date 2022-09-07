namespace Proje_1.Data
{
    class Kisi
    {
        private string isim;
        private string soyisim;

        private string telefon;

        public Kisi(string _isim, string _soyisim, string _telefon)
        {
            this.Isim = _isim;
            this.Soyisim = _soyisim;
            this.Telefon = _telefon;
        }

        public string Isim { get => isim; set => isim = value; }
        public string Soyisim { get => soyisim; set => soyisim = value; }

        public string Telefon { get => telefon; set => telefon = value; }

    }
}