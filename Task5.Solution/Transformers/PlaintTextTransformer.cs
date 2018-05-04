namespace Task5.Solution.Transformers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class PlaintTextTransformer : ITransform
    {
        public string Transform(BoldText part)
        {
            if (part == null)
            {
                throw new ArgumentNullException(nameof(part));
            }

            return "**" + part.Text + "**";
        }

        public string Transform(HyperLink part)
        {
            if (part == null)
            {
                throw new ArgumentNullException(nameof(part));
            }

            return part.Text + " [" + part.Url + "]"; ;
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
