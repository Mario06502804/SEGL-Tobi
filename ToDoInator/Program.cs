
Console.WriteLine("Willkommen bei ToDoInator");
var ToDoList = new List<ToDoItem>();
while (true)
{
    foreach (var Item in ToDoList)
    {
        Console.WriteLine(Item);
    }
    Console.WriteLine(value: """
        1. Neues ToDo
        2. ToDo abhaken
        """);
    var userMenuChoice = Console.ReadLine();
    switch (userMenuChoice)
    {
        case "1":
            Console.WriteLine("Was ist das ToDo?");
            var toDoDescription = Console.ReadLine();
            Console.WriteLine("""
                Wie wichtig? 
                1 => Hohe Prio
                2 => Normal Prio
                3 => Niedrige prio
                """);
            var toDoPio = Console.ReadLine();
            var newTodo = new ToDoItem();
            newTodo.Description = toDoDescription;
            newTodo.Prio = Convert.ToInt32(toDoPio);
            ToDoList.Add(newTodo);
            break;
        case "2":
            // todo abhaken
            Console.WriteLine("Welches ToDo möchtest du Löschen?");
            var indexToDelet = Convert.ToInt32(Console.ReadLine());
            ToDoList.RemoveAt(indexToDelet);
            break;
        default:
            // nicht definireter Input eg."hamster"

            break;
    }
    Console.Clear();
}