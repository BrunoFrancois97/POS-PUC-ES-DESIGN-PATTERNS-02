namespace DesignPatterns.Aula02.HtmlTags
{
    public class BoldTag : HtmlElement
    {
        public BoldTag(string aruments) : base(BuildTag("b", aruments), "b") { }
    }
}
