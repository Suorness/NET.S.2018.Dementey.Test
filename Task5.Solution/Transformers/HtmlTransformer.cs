namespace Task5.Solution.Transformers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class HtmlTransformer : ITransform
    {
        public string Transform(BoldText part)
        {
            if (part == null)
            {
                throw new ArgumentNullException(nameof(part));
            }

            return "<b>" + part.Text + "</b>"; ;
        }

        public string Transform(HyperLink part)
        {
            if (part == null)
            {
                throw new ArgumentNullException(nameof(part));
            }

            return "<a href=\"" + part.Url + "\">" + part.Text + "</a>"; ;
        }

        public string Transform(PlainText part)
        {
            if (part == null)
            {
                throw new ArgumentNullException(nameof(part));
            }

            return part.Text;
        }
    }
}
