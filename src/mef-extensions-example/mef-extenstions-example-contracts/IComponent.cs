namespace mef_extenstions_example_contracts
{
    public interface IComponent
    {
        string Description { get; }

        string ManipulateOperation(params double[] args);
    }
}