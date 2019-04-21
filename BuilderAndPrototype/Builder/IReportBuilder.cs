

namespace BuilderAndPrototype.Builder
{
    public interface IReportBuilder
    {
        IReportBuilder WithHeader(string header);
        IReportBuilder WithBody(string body);
        IReportBuilder WithFooter(string footer);
        Report GetReport();
        void Reset();
    }
}

