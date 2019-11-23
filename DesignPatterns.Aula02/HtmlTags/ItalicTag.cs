using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Aula02.HtmlTags
{
    public class ItalicTag : HtmlElement
    {
        public ItalicTag(string aruments) : base(BuildTag("i", aruments), "i") { }

    }
}
