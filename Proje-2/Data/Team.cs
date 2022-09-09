namespace Proje_2.Data
{
    class Team
    {

        //Predefined olan bir takım kullanacağım için değişkenler şimdilik statik
        private static List<Member> teamList;

        public static List<Member> TeamList { get; set; }

        static Team()
        {
            TeamList = new List<Member>(){
                new Member("Utku","Akman",1),
                new Member("Doğuş","Karaaslan",2),
                new Member("Lokman","Demir",3),
                new Member("Handan","Gül",4)
            };
        }
    }
}