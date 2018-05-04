namespace Task5.Solution
{
    public class HyperLink : DocumentPart
    {
        public string Url { get; set; }

        public override string Format(ITransform transform)
        {
            if (transform == null)
            {
                throw new System.ArgumentNullException(nameof(transform));
            }

            return transform.Transform(this);
        }
    }
}
