using to_do.Model;

namespace to_do.CommandsAndInterface;

internal class DeleteTodoItemCommand : ICommand
{
    private readonly TodoList _todoList;
    public string No { get; } = "2";
    public string Description => $"{No} - slett";
    public DeleteTodoItemCommand(TodoList todoList)
    {
        _todoList = todoList;
    }

    public void Run()
    {
        Console.Write("Hvilket nr vil du slette? ");
        var noStr = Console.ReadLine();
        var no = Convert.ToInt32(noStr);
        var index = no - 1;
        _todoList.Delete(index);
    }
}