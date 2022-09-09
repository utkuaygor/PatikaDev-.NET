namespace Proje_2.Data
{
    class Board
    {

        //Predefined olan bir board kullanacağım için değişkenler şimdilik statik
        private static List<Card> toDo;
        private static List<Card> inProgress;
        private static List<Card> done;

        static Board()
        {
            ToDo = new List<Card>() { new Card("To Do List Item", "This card created for To Do list.", Team.TeamList[0], Size.M, CardType.TODO) };
            InProgress = new List<Card>() { new Card("In Progress List Item", "This card created for In Progress list.", Team.TeamList[2], Size.XL, CardType.IN_PROGRESS) };
            Done = new List<Card>() { new Card("Done List Item", "This card created for Done list.", Team.TeamList[3], Size.XS, CardType.DONE) };

        }

        public static List<Card> ToDo { get => toDo; set => toDo = value; }
        public static List<Card> InProgress { get => inProgress; set => inProgress = value; }
        public static List<Card> Done { get => done; set => done = value; }


    }
}