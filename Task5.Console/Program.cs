namespace Task5.Console
{
    using System.Collections.Generic;
    using System;
    using Task5.Solution;
    using Task5.Solution.Transformers;

    class Program
    {
        static void Main(string[] args)
        {
            List<DocumentPart> parts = new List<DocumentPart>
                {
                    new PlainText {Text = "Some plain text"},
                    new HyperLink {Text = "google.com", Url = "https://www.google.by/"},
                    new BoldText {Text = "Some bold text"}
                };

            Document document = new Document(parts);

            ITransform html = new HtmlTransformer();
            ITransform latex = new LatexTransformer();
            ITransform plainText = new PlaintTextTransformer();

            Console.WriteLine(document.TransformParts(html));            

            Console.WriteLine(document.TransformParts(latex));

            Console.WriteLine(document.TransformParts(plainText));

            Console.ReadLine();
        }
    }
}
