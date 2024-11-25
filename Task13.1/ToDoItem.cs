namespace Task13._1Tasker;

internal class TodoItem
{
    public string Title { get; set; }
    public bool IsDone { get; set; }

    public TodoItem(string title)
    {
        Title = title;
        IsDone = false;
    }
}