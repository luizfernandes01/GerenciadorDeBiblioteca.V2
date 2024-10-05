using GerenciadorDeBiblioteca.API.Models;
using GerenciadorDeBiblioteca.API.Persistence;
using GerenciadorDeBiblioteca.Application.Commands.LivroCommand.DeleteLivro;
using GerenciadorDeBiblioteca.Application.Commands.LivroCommand.InsertLivro;
using GerenciadorDeBiblioteca.Application.Commands.LivroCommand.UpdateLivro;
using GerenciadorDeBiblioteca.Application.Queries.LivroQueries.GetAllLivros;
using GerenciadorDeBiblioteca.Application.Queries.LivroQueries.GetByIdLivros;

using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GerenciadorDeBiblioteca.API.Controllers
{
    [Route("api/livros")]
    [ApiController]
    public class LivrosController : ControllerBase
    {
        private readonly IMediator _mediator;
     
        public LivrosController(IMediator mediator)
        {
            _mediator = mediator;
        
        }

        [HttpGet]

        public async Task< IActionResult> GetAll()
        {
           // var result = _service.GetAll();

            var query = new GetAllLivroQuery();

            var result = await _mediator.Send(query);

            return Ok(result);

        }        

        [HttpGet("{id}")]

        public async Task< IActionResult> GetById(int id)
        {
          var result = await _mediator.Send(new GetByIdLivroQuery(id));

            if(!result.IsSuccess)
            {
                return BadRequest(result.Message);
            }

            return Ok(result);
                           
        }

        [HttpPost]

        public async Task< IActionResult> Post(InsertLivroCommand command)
        {
            var result = await _mediator.Send(command);

            
            return CreatedAtAction(nameof(GetById),new { id = result.Data }, command);
        }

        [HttpPut("{id}")]

        public async Task< IActionResult> Put(int id,UpdateLivroCommand command)
        {
            var result = await _mediator.Send(command);

            if (!result.IsSuccess)
            {
                return BadRequest(result.Message);
            }
                                            


            return NoContent();
        }

        [HttpDelete("{id}")]

        public async Task<IActionResult> Delete(int id)
        {
            var result = await _mediator.Send(new DeleteLivroCommand(id));

            if (!result.IsSuccess)
            {
                return BadRequest(result.Message);
            }


            return NoContent();
        }
    }
}
