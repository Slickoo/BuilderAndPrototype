namespace BuilderAndPrototype.Builder
{
    public class ReportDirector
    {
        private IReportBuilder _builder;

        public ReportDirector(IReportBuilder builder)
        {
            _builder = builder;
        }

        public void ChangeBuilder(IReportBuilder builder)
        {
            _builder = builder;
        }

        public Report GetEmptyReport()
        {
            return _builder.WithHeader("Empty").WithBody("Empty").GetReport();
        }

        public Report GetReport(string header,string body, string footer)
        {
            return _builder.WithHeader(header).WithBody(body).WithFooter(footer).GetReport();
        }
    }
}
