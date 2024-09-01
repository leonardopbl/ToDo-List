using System.Text.Json;
using ToDo.Communication.Entities;
using ToDo.Communication.Requests;
using ToDo.Communication.Responses;

namespace ToDo.Application.UseCases.ToDo.Register;

public class RegisterToDoUseCase
{
    public ResponseCreatedToDoJson Execute(RequestToDoJson request)
    {
        var newToDo = new ToDoEntity
        {
            Id = "1",
            Name = request.Name,
            Description = request.Description,
            Deadline = request.Deadline,
            Priority = request.Priority,
            Status = request.Status
        };

        Console.WriteLine(newToDo);
        return new ResponseCreatedToDoJson
        {
            Id = newToDo.Id,
            Name = newToDo.Name,
        };
    }
}
