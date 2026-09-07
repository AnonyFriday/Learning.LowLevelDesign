namespace Builder.After.Reports;

public class Report
{
    public string Title { get; set; } = string.Empty;
    public string Content { get; set; } = string.Empty;
    public string Footer { get; set; } = string.Empty;
    public bool IncludeCharts { get; set; } = false;
    public bool IncludeSummary { get; set; } = false;

    public Report() { }

    public override string ToString()
    {
        return $"Title: {Title}\nContent: {Content}\nFooter: {Footer}\nIncludeCharts: {IncludeCharts}\nIncludeSummary: {IncludeSummary}";
    }
}

