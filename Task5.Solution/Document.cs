using System;
using System.Collections.Generic;
using System.Text;

namespace Task5.Solution
{
    public class Document
    {
        private List<DocumentPart> parts;

        public Document(IEnumerable<DocumentPart> parts)
        {
            if (parts == null)
            {
                throw new ArgumentNullException(nameof(parts));
            }
            this.parts = new List<DocumentPart>(parts);
        }

        public string TransformParts(ITransform transform)
        {
            StringBuilder result = new StringBuilder();
            foreach (var part in parts)
            {
                result.Append(part.Format(transform));
            }

            return result.ToString();
        }
    }
}
