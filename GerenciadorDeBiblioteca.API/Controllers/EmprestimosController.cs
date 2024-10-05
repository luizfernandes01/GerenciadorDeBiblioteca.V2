using GerenciadorDeBiblioteca.Application.Commands.EmprestimoCommand.InsertEmprestimo;
using GerenciadorDeBiblioteca.Application.Commands.EmprestimoCommand.UpdateEmprestimo;
using GerenciadorDeBiblioteca.Application.Queries.EmprestimoQueries.GetAllEmprestimos;
using GerenciadorDeBiblioteca.Application.Queries.EmprestimoQueries.GetByIdEmprestimo;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace GerenciadorDeBiblioteca.API.Controllers
{
    [Route("api/emprestimos")]
    [ApiController]
    public class EmprestimosController : ControllerBase
    {
        private readonly IMediator _mediator;
     
        public EmprestimosController(IMediator mediator)
        {
          
            _mediator = mediator;
        }

        [HttpGet]

        public async Task< IActionResult> GetAll()
        {
            var result = _mediator.Send(new GetAllEmprestimoQuery());

            return Ok(result);
        }

        [HttpGet("{id}")]

        public async Task< IActionResult> GetById(int id)
        {
            var result = _mediator.Send(new GetByIdEmprestimoQuery(id));

            return Ok(result);
        }
        [HttpPost]

        public async Task< IActionResult> Post(InsertEmprestimoCommand command)
        {
            var result = _mediator.Send(command);

            
            return Ok(result); 
        }

       

        [HttpPut("{id}")]

        public async Task< IActionResult> Put(int id,UpdateEmprestimoCommand command)
        {
            var result = await _mediator.Send(command);

          
           

            return BadRequest(result);
        }

     

      
       
    }
}
