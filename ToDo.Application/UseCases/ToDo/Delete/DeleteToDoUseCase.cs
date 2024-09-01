using ToDo.Communication.Entities;
using ToDo.Communication.Enums;

namespace ToDo.Application.UseCases.ToDo.Delete;

public class DeleteToDoUseCase
{
    public void Execute(string id)
    {
        var toDoList = new List<ToDoEntity>{
            new ()
            {
                Id = "1",
                Name = "Create database",
                Priority = PriorityType.Medium,
                Status = StatusType.Waiting
            },
            new()
            {
                Id = "2",
                Name = "Create frontend",
                Priority = PriorityType.Low,
                Status = StatusType.Done
            },
            new()
            {
                Id = "3",
                Name = "Create backend",
                Priority = PriorityType.High,
                Status = StatusType.Doing
            }
        };
        Console.WriteLine(toDoList);

        var toDo = toDoList.FirstOrDefault(x => x.Id == id);
        if (toDo is not null)
        {
            toDoList.Remove(toDo);
            Console.WriteLine(toDoList);
        }
        else
        {
            throw new Exception("ToDo not found");
        }
    }
}
