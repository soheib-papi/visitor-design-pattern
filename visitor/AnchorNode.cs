
namespace visitor_design_pattern.visitor;
public class AnchorNode : IHtmlNode
{
    public void Execute(IOperation operation)
    {
        operation.Apply(this);
    }
}
