namespace ToDoApp.Models;

public class Todolitem
{
    public int Id { get; set; }
    public string Name { get; set; }
    public bool IsCompleted { get; set; }
    public DateTime DateCompleted { get; set; }
}
