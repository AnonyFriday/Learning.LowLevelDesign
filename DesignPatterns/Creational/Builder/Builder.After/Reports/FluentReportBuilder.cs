namespace Builder.After.Reports;

/*
    Don't use static 
    - each builder create a new instance, not a shared instance
*/
public sealed class FluentReportBuilder
{
    // 1. Create a private instance 
    private readonly Report _report = new();

    // 2. For each property, create a method to set it and return the builder instance for method chaining
    public FluentReportBuilder() { }

    public FluentReportBuilder SetTitle(string title)
    {
        _report.Title = title;
        return this;
    }

    public FluentReportBuilder SetContent(string content)
    {
        _report.Content = content;
        return this;
    }

    public FluentReportBuilder SetFooter(string footer)
    {
        _report.Footer = footer;
        return this;
    }

    public FluentReportBuilder SetIncludeCharts(bool includeCharts)
    {
        _report.IncludeCharts = includeCharts;
        return this;
    }

    public FluentReportBuilder SetIncludeSummary(bool includeSummary)
    {
        _report.IncludeSummary = includeSummary;
        return this;
    }

    public Report Build()
    {
        return _report;
    }
}