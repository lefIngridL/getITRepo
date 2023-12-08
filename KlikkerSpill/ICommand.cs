namespace KlikkerSpill;

public interface ICommand
{
    void Run();
    char Character { get; }
}