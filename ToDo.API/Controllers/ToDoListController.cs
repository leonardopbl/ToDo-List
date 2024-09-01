using Microsoft.AspNetCore.Mvc;
using ToDo.Application.UseCases.ToDo.Delete;
using ToDo.Application.UseCases.ToDo.GetAll;
using ToDo.Application.UseCases.ToDo.GetById;
using ToDo.Application.UseCases.ToDo.Register;
using ToDo.Application.UseCases.ToDo.Update;
using ToDo.Communication.Requests;
using ToDo.Communication.Responses;

namespace ToDo.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ToDoList : ControllerBase
    {
        [HttpPost]
        [ProducesResponseType(typeof(ResponseCreatedToDoJson), StatusCodes.Status201Created)]
        [ProducesResponseType(typeof(ResponseErrorsJson), StatusCodes.Status400BadRequest)]
        public IActionResult Create([FromBody] RequestToDoJson request)
        {
            var response = new RegisterToDoUseCase().Execute(request);
            return Created(string.Empty, response);
        }

        [HttpGet]
        [ProducesResponseType(typeof(ResponseAllToDoJson), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        public IActionResult GetAll()
        {
            var response = new GetAllToDoUseCase().Execute();
            if (response.ToDo.Count == 0)
            {
                return NoContent();
            }
            return Ok(response);
        }

        [HttpGet]
        [Route("{id}")]
        [ProducesResponseType(typeof(ResponseToDoJson), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ResponseErrorsJson), StatusCodes.Status404NotFound)]
        public IActionResult Get(string id)
        {
            var response = new GetToDoByIdUseCase().Execute(id);
            if (response == null)
            {
                return NotFound();
            }
            return Ok(response);
        }

        [HttpPut]
        [Route("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(typeof(ResponseErrorsJson), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(ResponseErrorsJson), StatusCodes.Status404NotFound)]
        public IActionResult Update(string id, [FromBody] RequestToDoJson request)
        {
            var useCase = new UpdateToDoUseCase();
            useCase.Execute(id, request);

            return NoContent();
        }

        [HttpDelete]
        [Route("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(typeof(ResponseErrorsJson), StatusCodes.Status404NotFound)]
        public IActionResult Delete(string id)
        {
            var useCase = new DeleteToDoUseCase();
            useCase.Execute(id);
            return NoContent();
        }
    }
}
