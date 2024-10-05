

using GerenciadorDeBiblioteca.API.Persistence;
using GerenciadorDeBiblioteca.Application.Commands.UsuarioCommand.DeleteUsuario;
using GerenciadorDeBiblioteca.Application.Commands.UsuarioCommand.InsertUsuario;
using GerenciadorDeBiblioteca.Application.Commands.UsuarioCommand.UpdateUsuario;
using GerenciadorDeBiblioteca.Application.Queries.UsuarioQueries.GetAllUsuario;
using GerenciadorDeBiblioteca.Application.Queries.UsuarioQueries.GetByIdUsuario;
using GerenciadorDeBiblioteca.Core.Entities;
using MediatR;

using Microsoft.AspNetCore.Mvc;

namespace GerenciadorDeBiblioteca.API.Controllers
{
    [Route("api/usuarios")]
    [ApiController]
    public class UsuariosController : ControllerBase
    {
        private readonly IMediator _mediator;
      
        public UsuariosController(IMediator mediator)
        {
            _mediator = mediator;
           
        }

        [HttpGet]

        public async Task< IActionResult> GetAll()
        {
          

            var result = await _mediator.Send(new GetAllUsuarioQuery());


            return Ok(result);
        }

        [HttpGet("{id}")]

        public async Task< IActionResult> GetById(int id)
        {
            var result = _mediator.Send(new GetByIdUsuarioQuery(id));
          

            return Ok(result);
        }

        [HttpPost]

        public async Task< IActionResult> Post(InsertUsuarioCommand command)
        {
            var result = _mediator.Send(command);

          

            return Ok(command);

        }

        [HttpPut("{id}")]

        public async Task< IActionResult> Put(int id, UpdateUsuarioCommand command)
        {

            var result = _mediator.Send(command);

                       
            return Ok();
        }

        [HttpDelete("{id}")]

        public async Task< IActionResult> Delete(int id)
        {
            var result = _mediator.Send(new DeleteUsuarioCommand(id));

            
            return NoContent();
        }
    }
}
