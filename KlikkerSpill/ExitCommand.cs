namespace KlikkerSpill;

public class ExitCommand : ICommand
{
    public char Character { get; } = 'X';
    public void Run()
    {
        Environment.Exit(0);
    }
}