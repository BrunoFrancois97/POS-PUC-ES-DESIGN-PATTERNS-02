using DesignPatterns.Aula02.HtmlTags;

namespace DesignPatterns.Aula02
{
    public class Program
    {
        static void Main(string[] args)
        {
            var html = new BoldTag("").AddElement(new ItalicTag("class= 'testItalic'").AddElement(new SpanTag("class= 'testSpan'", "This is a test!"))).ToHtml();
        }
    }
}
