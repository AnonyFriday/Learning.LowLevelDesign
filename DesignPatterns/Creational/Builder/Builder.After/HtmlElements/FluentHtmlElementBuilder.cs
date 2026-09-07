namespace Builder.After.HtmlElements;

public class FluentHtmlElementBuilder
{
    private HtmlElement _root;

    public FluentHtmlElementBuilder(string rootTag)
    {
        _root = new HtmlElement { Tag = rootTag };
    }

    public HtmlElement Build()
    {
        return _root;
    }

    public FluentHtmlElementBuilder AddChild(string childTag, string childText)
    {
        var childElement = new HtmlElement(childTag, childText);
        _root.InnerElements.Add(childElement);
        return this;
    }

    public FluentHtmlElementBuilder AddChild(string childTag, Action<FluentHtmlElementBuilder> childBuilderAction)
    {
        var childBuilder = new FluentHtmlElementBuilder(childTag);

        childBuilderAction(childBuilder);

        _root.InnerElements.Add(childBuilder.Build());

        return this;
    }

    public void Clear()
    {
        _root = new HtmlElement { Tag = _root.Tag };
    }
}