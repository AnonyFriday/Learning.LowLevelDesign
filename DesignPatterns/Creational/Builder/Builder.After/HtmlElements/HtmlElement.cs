using System.Text;

namespace Builder.After.HtmlElements;

/*
    string html = "<ul>\n" +
    "  <li>Item 1</li>\n" +
    "  <li>Item 2</li>\n" +
    "  <li>\n" +
    "    <span>Nested item</span>\n" +
    "  </li>\n" +
    "</ul>";
*/
public class HtmlElement
{
    public string Tag { get; set; }
    public string Text { get; set; }
    public List<HtmlElement> InnerElements { get; set; } = new List<HtmlElement>();
    private const int indentSize = 2;

    public HtmlElement()
    {
    }

    public HtmlElement(string tag)
    {
        Tag = tag;
    }

    public HtmlElement(string tag, string text)
    {
        Tag = tag;
        Text = text;
    }

    public string ToStringImpl(int indentLevel)
    {
        var sb = new StringBuilder();
        var i = new string(' ', indentSize * indentLevel);

        sb.Append($"{i}<{Tag}>\n");
        if (!string.IsNullOrWhiteSpace(Text))
        {
            sb.Append($"{i}{new string(' ', indentSize)}{Text}\n");
        }

        // increase 1 level for each element
        foreach (var element in InnerElements)
        {
            sb.Append(element.ToStringImpl(indentLevel + 1));
        }

        sb.Append($"{i}</{Tag}>\n");

        return sb.ToString();
    }

    public override string ToString()
    {
        return ToStringImpl(0);
    }
}