using Task13._1Tasker;

List<TodoItem> todoList = new List<TodoItem>();
bool exit = false;

while (!exit)
{
    Console.WriteLine("\nTask List: ");
    Console.WriteLine("1. Add Task");
    Console.WriteLine("2. SHow all tasks");
    Console.WriteLine("3. Mark the task as completed");
    Console.WriteLine("4. Delete Task");
    Console.WriteLine("5. Exit");
    Console.Write("Select an option: ");

    string? choice = Console.ReadLine();

    switch (choice)
    {
        case "1":
            AddToDoItem(todoList);
            break;
        case "2":
            DisplayTodoItems(todoList);
            break;
        case "3":
            MarkTaskAsDone(todoList);
            break;
        case "4":
            RemoveTodoItem(todoList);
            break;
        case "5":
            exit = true;
            break;
        default:
            Console.WriteLine("\nInvalid input. Please try again.");
            break;
    }
}

static void AddToDoItem(List<TodoItem> todoList)
{
    Console.Write("Enter the name of the task: ");
    string? title = Console.ReadLine();
    todoList.Add(new TodoItem(title));
    Console.WriteLine("Task added!");
}

static void DisplayTodoItems(List<TodoItem> todoList)
{
    if (todoList.Count == 0)
    {
        Console.Write("List is empty!");
        return;
    }

    Console.WriteLine("\nTasks:");
    for (int i = 0; i < todoList.Count; i++)
    {
        Console.WriteLine($"{i + 1}. {todoList[i].Title} - {(todoList[i].IsDone ? "Done" : "Don't done")}");
    }
}

static void MarkTaskAsDone(List<TodoItem> todoList)
{
    DisplayTodoItems(todoList);
    Console.WriteLine("Write a number of task, which you want to mark task as done.");

    if (int.TryParse(Console.ReadLine(), out int index) && index > 0 && index <= todoList.Count)
    {
        todoList[index - 1].IsDone = true;
        Console.WriteLine("Task finished!");
    }
    else
    {
        Console.WriteLine("Invalid input.");
    }
}

static void RemoveTodoItem(List<TodoItem> todoList)
{
    DisplayTodoItems(todoList);
    Console.Write("Write a number of task which you want to remove: ");

    if (int.TryParse(Console.ReadLine(), out int index) && index > 0 && index <= todoList.Count)
    {
        todoList.RemoveAt(index - 1);
        Console.WriteLine("Task deleted!");
    }
    else
    {
        Console.WriteLine("Invalid input.");
    }
}