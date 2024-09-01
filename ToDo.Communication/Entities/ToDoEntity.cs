using System;
using ToDo.Communication.Enums;

namespace ToDo.Communication.Entities;

public class ToDoEntity
{
    public string Id { get; set; } = string.Empty;
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public DateTime Deadline { get; set; }
    public PriorityType Priority { get; set; }
    public StatusType Status { get; set; }
}
