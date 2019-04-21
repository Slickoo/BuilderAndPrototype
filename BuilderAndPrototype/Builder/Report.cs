namespace BuilderAndPrototype.Builder
{
    public class Report
    {
        public string Name { get; set; }
        public string Header { get; set; }
        public string Body { get; set; }
        public string Footer { get; set; }

        public override string ToString()
        {
            return $"Name:{Name}\nHead:{Header}\nBody:{Body}\nFooter:{Footer}\n";
        }
    }
}
    