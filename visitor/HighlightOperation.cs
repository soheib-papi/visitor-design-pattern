
namespace visitor_design_pattern.visitor;
public class HighlightOperation : IOperation
{
    public void Apply(HeadingNode heading)
    {
        Console.WriteLine("Highlight-Heading");
    }

    public void Apply(AnchorNode anchor)
    {
        Console.WriteLine("Highlight-Anchor");
    }
}
