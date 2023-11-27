namespace to_do.CommandsAndInterface
{
    internal interface ICommand
    {
        void Run();
        string No { get; }
        string Description { get; }
    }
}
