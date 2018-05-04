namespace Task5.Solution
{
    public interface ITransform
    {
        string Transform(BoldText part);

        string Transform(HyperLink part);

        string Transform(PlainText part);
    }
}
