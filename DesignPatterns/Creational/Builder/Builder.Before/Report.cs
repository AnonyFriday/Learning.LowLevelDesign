namespace Builder.Before;

public class Report
{
    public string Title { get; set; }
    public string Content { get; set; }
    public string Footer { get; set; }
    public bool IncludeCharts { get; set; }
    public bool IncludeSummary { get; set; }

    /*
        Create too many constructors to handle different combination of the default
    */
    public Report(string title, string content)
    {
        Title = title;
        Content = content;
        Footer = "Default Footer";
        IncludeCharts = false;
        IncludeCharts = false;
    }

    public Report(string title, string content, string footer)
    {
        Title = title;
        Content = content;
        Footer = footer;
    }

    public Report(string title, string content, bool includeCharts, bool includeSummary)
    {
        Title = title;
        Content = content;
        Footer = "Default Footer";
        IncludeCharts = includeCharts;
        IncludeSummary = includeSummary;
    }

    public void GenerateReport()
    {
        Console.WriteLine("Generating Report...");
        Console.WriteLine($"Title: {Title}");
        Console.WriteLine($"Content: {Content}");
        Console.WriteLine($"Footer: {Footer}");
    }
}