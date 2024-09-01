using ToDo.Communication.Enums;

namespace ToDo.Communication.Requests;

public class RequestToDoJson
{
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public PriorityType Priority { get; set; }
    public DateTime Deadline { get; set; }
    public StatusType Status { get; set; }
}
