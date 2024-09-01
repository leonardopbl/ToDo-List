using System;
using ToDo.Communication.Responses;
using ToDo.Communication.Enums;

namespace ToDo.Application.UseCases.ToDo.GetAll;

public class GetAllToDoUseCase
{
    public ResponseAllToDoJson Execute()
    {
        return new ResponseAllToDoJson()
        {
            ToDo = [
                new ResponseShortToDoJson
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
            ]
        };
    }
}
