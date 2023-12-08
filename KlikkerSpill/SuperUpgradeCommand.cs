namespace KlikkerSpill;

public class SuperUpgradeCommand : ICommand
{
    private ClickerGame _game;

    public SuperUpgradeCommand(ClickerGame game)
    {
        _game = game;

    }

    public char Character { get; } = 'S';
    public void Run()
    {
        _game.SuperUpgrade();
    }
}