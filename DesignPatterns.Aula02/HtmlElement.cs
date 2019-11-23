using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Aula02
{
    public abstract class HtmlElement : IHtmlElement
    {
        private IList<IHtmlElement> htmlElements;
        private readonly string initialTag;
        private readonly string endTag;
        private readonly string content = "";

        public HtmlElement(string initialTag, string endTag)
        {
            htmlElements = new List<IHtmlElement>();
            this.initialTag = initialTag;
            this.endTag = endTag;
        }

        public HtmlElement(string initialTag, string content, string endTag)
        {
            htmlElements = new List<IHtmlElement>();
            this.initialTag = initialTag;
            this.content = content;
            this.endTag = endTag;
        }

        public IHtmlElement AddElement(IHtmlElement htmlElement)
        {
            htmlElements.Add(htmlElement);

            return this;
        }

        public static string BuildTag(string tag, string aruments)
        {
            var stringBuilder = new StringBuilder();
            stringBuilder.Append($"<{tag} {aruments}>");
            return stringBuilder.ToString();
        }

        public string ToHtml()
        {
            var stringBuilder = new StringBuilder();
            stringBuilder.Append($"{initialTag}");
            foreach (var htmlElement in htmlElements)
            {
                stringBuilder.Append(htmlElement.ToHtml());
            }
            stringBuilder.Append(content);
            stringBuilder.Append($"</{endTag}>");
            return stringBuilder.ToString();
        }
    }
}
