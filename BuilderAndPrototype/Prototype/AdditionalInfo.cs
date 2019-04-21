namespace BuilderAndPrototype.Prototype
{
    public class AdditionalInfo
    {
        public int PageNum { get; set; }
        public string Author { get; set; }

        public AdditionalInfo(int pageNum, string author)
        {
            PageNum = pageNum;
            Author = author;
        }

        public AdditionalInfo(AdditionalInfo info)
        {
            PageNum = info.PageNum;
            Author = info.Author;
        }
    }
}
