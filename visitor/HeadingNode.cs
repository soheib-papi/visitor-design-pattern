
namespace visitor_design_pattern.visitor;
public class HeadingNode : IHtmlNode
{
    public void Execute(IOperation operation)
    {
        operation.Apply(this);
    }
}
