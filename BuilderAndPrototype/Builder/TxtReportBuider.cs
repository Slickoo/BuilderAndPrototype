namespace BuilderAndPrototype.Builder
{
    public class TxtReportBuider : IReportBuilder
    {
        private Report _report;

        public TxtReportBuider()
        {
            _report = new Report();
            _report.Name = "TxtReport";
        }

        public IReportBuilder WithHeader(string header)
        {
            _report.Header = header;
            return this;
        }

        public IReportBuilder WithBody(string body)
        {
            _report.Body = body;
            return this;
        }

        public IReportBuilder WithFooter(string footer)
        {
            _report.Footer = footer;
            return this;
        }

        public void Reset()
        {
            _report = new Report();
            _report.Name = "TxtReport";
        }

        public Report GetReport()
        {
            return _report;
        }
    }
}
