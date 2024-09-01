using System;

namespace ToDo.Communication.Responses;

public class ResponseAllToDoJson
{
    public List<ResponseShortToDoJson> ToDo { get; set; } = [];
}
