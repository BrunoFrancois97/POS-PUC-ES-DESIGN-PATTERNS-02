namespace DesignPatterns.Aula02
{
    public interface IHtmlElement
    {
        IHtmlElement AddElement(IHtmlElement htmlElement);
        string ToHtml();
    }
}
