using to_do.Model;


namespace to_do.CommandsAndInterface;

internal class MarkAsDoneCommand : ICommand
{
    private readonly TodoList _todoList;
    public string No { get; } = "3";
    public string Description => $"{No} - marker som gjort";

    public MarkAsDoneCommand(TodoList todoList)
    {
        _todoList = todoList;
    }

    public void Run()
    {
        Console.Write("Hvilket nr vil du sette som utført? ");
        var noStr = Console.ReadLine();
        var no = Convert.ToInt32(noStr);
        var index = no - 1;
        _todoList.MarkAsDone(index);
    }

}