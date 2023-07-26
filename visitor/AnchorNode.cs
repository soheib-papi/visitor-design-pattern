
namespace visitor_design_pattern.visitor;
public class AnchorNode : IHtmlNode
{
    public void Highlight()
    {
        Console.WriteLine("Highlight-Anchor");
    }
}
