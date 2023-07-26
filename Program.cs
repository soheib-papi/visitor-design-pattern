
using visitor_design_pattern.visitor;

var document = new HtmlDocument();
document.Add(new HeadingNode());
document.Add(new AnchorNode());
document.Highlight();

Console.ReadLine();