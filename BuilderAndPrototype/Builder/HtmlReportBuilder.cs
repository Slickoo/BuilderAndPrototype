namespace BuilderAndPrototype.Builder
{
    class HtmlReportBuilder : IReportBuilder
    {
        private Report _report;

        public HtmlReportBuilder()
        {
            _report = new Report();
            _report.Name = "HtmlReport";
        }

        public IReportBuilder WithHeader(string header)
        {
            _report.Header = $"<body><h1>{header}</h1>";
            return this;
        }

        public IReportBuilder WithBody(string body)
        {
            _report.Body = $"<p>{body}</p>";
            return this;
        }

        public IReportBuilder WithFooter(string footer)
        {
            _report.Footer = $"<footer>{footer}</footer></body>";
            return this;
        }

        public Report GetReport()
        {
            return _report;         
        }

        public void Reset()
        {
            _report = new Report();
            _report.Name = "HtmlReport";
        }
    }
}
