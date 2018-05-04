namespace Task5.Solution
{
    public class PlainText : DocumentPart
    {
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
