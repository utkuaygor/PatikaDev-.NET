namespace Odev2_Soru3
{
    class Program
    {
        static void Main()
        {

            char[] sesli = { 'a', 'i', 'o', 'u', 'e' }; //ingilizce alfabeye göre
            List<char> cumledeki_sesliler = new List<char>();
            Console.WriteLine("Bir cumle girin: ");
            string cumle = Console.ReadLine().Trim();
            if (string.IsNullOrWhiteSpace(cumle))
            {
                Console.WriteLine("Lutfen ici dolu bir cumle girin!");
                Main();
            }
            foreach (char harf in cumle)
            {
                if (sesli.Contains(harf))
                    cumledeki_sesliler.Add(harf);
            }
            cumledeki_sesliler.Sort();
            cumledeki_sesliler.ForEach(harf => Console.Write(harf + " "));
        }
    }
}