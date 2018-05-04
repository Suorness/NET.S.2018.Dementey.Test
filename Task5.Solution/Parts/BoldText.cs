namespace Task5.Solution
{
    public class BoldText : DocumentPart
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
