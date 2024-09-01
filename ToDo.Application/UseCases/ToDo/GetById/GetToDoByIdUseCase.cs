using ToDo.Communication.Responses;
using ToDo.Communication.Enums;
namespace ToDo.Application.UseCases.ToDo.GetById;

public class GetToDoByIdUseCase
{
    public ResponseToDoJson Execute(string id)
    {
        return new ResponseToDoJson()
        {
            Id = id,
            Name = "Create database",
            Description = "Create the database for the project",
            Priority = PriorityType.High,
            Deadline = DateTime.Now,
            Status = StatusType.Doing,

        };
    }
}
