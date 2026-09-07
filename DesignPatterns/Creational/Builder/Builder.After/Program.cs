/*
    StringBuilder is 1 of the example of Builder pattern
*/

using System.Text;

using Builder.After.HtmlElements;
using Builder.After.Reports;

var reportHTML = new StringBuilder();
reportHTML.Append("<html>");
reportHTML.Append("<head>");
reportHTML.Append("<title>Monthly Report</title>");
reportHTML.Append("</head>");
reportHTML.Append("</html>");
Console.WriteLine(reportHTML.ToString());

/*
    Create the HtmlBuilder pattern to build the HTML string in a more readable way
*/

var htmlBuilder = new FluentHtmlElementBuilder("ul");
var htmlTree = htmlBuilder
    .AddChild("ol", ol => ol
        .AddChild("li", "Item 1").Build())
    .AddChild("ol", ol => ol
        .AddChild("li", "Item 2").Build())
    .AddChild("li", "Item 3")
    .AddChild("li", "")
    .AddChild("span", "Nested item")
    .Build();

Console.WriteLine(htmlTree);

/*
    We can solve the problem of having too many parameters in the constructor by using the Builder pattern. The Builder pattern allows us to create complex objects step by step, providing a clear and fluent interface for constructing the object. This way, we can set only the properties we want without having to provide default values for all other parameters.
*/

// Fluent Report Builder
// - fluent: chaining method call on the same instance
var report = new FluentReportBuilder()
    .SetTitle("Monthly Report")
    .SetContent("This is the content of the monthly report.")
    .SetFooter("Custom Footer")
    .SetIncludeCharts(true)
    .SetIncludeSummary(false)
    .Build();

Console.WriteLine(report.ToString());