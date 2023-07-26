
namespace visitor_design_pattern.visitor;
public class HtmlDocument
{
    private List<IHtmlNode> nodes = new();

    public void Add(IHtmlNode node)
    {
        nodes.Add(node);
    }

    public void Highlight()
    {
        foreach(var node in nodes)
            node.Highlight();
    }
}
