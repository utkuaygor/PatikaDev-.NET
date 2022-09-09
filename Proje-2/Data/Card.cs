namespace Proje_2.Data
{
    class Card
    {
        private string title;
        private string content;
        private Member member;
        private Size size;
        private CardType type;

        public Card(string _title, string _content, Member _member, Size _size, CardType _type)
        {
            Title = _title;
            Content = _content;
            Member = _member;
            Size = _size;
            Type = _type;
        }

        public string Title { get; set; }
        public string Content { get; set; }
        public Member Member { get; set; }
        public Size Size { get; set; }
        public CardType Type { get; set; }
    }
}