namespace DesignPatterns.Aula02.HtmlTags
{
    public class SpanTag : HtmlElement
    {
        public SpanTag(string arguments, string content) : base(BuildTag("span", arguments), content, "span")
        {
        }
    }
}
