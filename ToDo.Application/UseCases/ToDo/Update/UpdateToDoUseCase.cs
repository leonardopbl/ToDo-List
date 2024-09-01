using ToDo.Communication.Entities;
using ToDo.Communication.Enums;
using ToDo.Communication.Requests;

namespace ToDo.Application.UseCases.ToDo.Update;

public class UpdateToDoUseCase
{
    public void Execute(string id, RequestToDoJson request)
    {
        var newToDo = new ToDoEntity
        {
            Id = "1",
            Name = "Create database",
            Description = "desenvolver o banco de dados",
            Deadline = DateTime.Now,
            Priority = PriorityType.Low,
            Status = StatusType.Waiting
        };

        Console.WriteLine($"INITIAL todo looks like {newToDo}");

        newToDo.Name = request.Name;
        newToDo.Description = request.Description;
        newToDo.Deadline = request.Deadline;
        newToDo.Priority = request.Priority;
        newToDo.Status = request.Status;

        Console.WriteLine($"FINAL todo looks like {newToDo}");

    }
}
