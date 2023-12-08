namespace KlikkerSpill;

public class ClickCommand : ICommand
{
    private ClickerGame _game;
    public char Character { get; } = ' ';

    public ClickCommand(ClickerGame game)
    {
        _game = game;
    }

    public void Run()
    {
        _game.Click();
    }
}