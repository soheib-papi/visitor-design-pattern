
namespace visitor_design_pattern.visitor;
public class HeadingNode : IHtmlNode
{
    public void Highlight()
    {
        Console.WriteLine("Highlight-Heading");
    }
}
