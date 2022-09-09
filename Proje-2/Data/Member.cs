namespace Proje_2.Data
{
    class Member
    {
        private string name;

        private string surname;

        private int id;

        public int Id { get; set; }

        public string Name { get; set; }

        public string Surname { get; set; }

        public Member(string _name, string _surname, int _id)
        {
            this.Id = _id;
            this.Name = _name;
            this.Surname = _surname;
        }
    }
}