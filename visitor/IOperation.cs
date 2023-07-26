
namespace visitor_design_pattern.visitor;
public interface IOperation
{
    void Apply(HeadingNode heading);
    void Apply(AnchorNode anchor);
}
