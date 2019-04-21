namespace BuilderAndPrototype.Prototype
{
    class Book : IPrototype
    {
        public string Title { get; set; }
        public int Price { get; set; }
        public AdditionalInfo Info { get; set; }

        public Book(string title, int price, AdditionalInfo info)
        {
            Title = title;
            Price = price;
            Info = info;
        }
        public IPrototype ShallowClone()
        {
            return (Book)MemberwiseClone();
        }

        public IPrototype DeepClone()
        {
            var book = (Book)MemberwiseClone();
            book.Info = new AdditionalInfo(Info);
            return book;
        }


        public override string ToString()
        {
            return $"Title:{Title} Price:{Price} Pages:{Info.PageNum} Author:{Info.Author}\n";
        }
    }
}
