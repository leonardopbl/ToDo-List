using System;
using ToDo.Communication.Enums;

namespace ToDo.Communication.Responses;

public class ResponseShortToDoJson
{
    public string Id { get; set; } = string.Empty;
    public string Name { get; set; } = string.Empty;
    public PriorityType Priority { get; set; }
    public StatusType Status { get; set; }
}
