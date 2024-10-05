using GerenciadorDeBiblioteca.API.Models;
using GerenciadorDeBiblioteca.API.Persistence;
using GerenciadorDeBiblioteca.Application.Models;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace GerenciadorDeBiblioteca.Application.Queries.UsuarioQueries.GetAllUsuario
{
    public class GetAllUsuarioHandler : IRequestHandler<GetAllUsuarioQuery, ResultViewModel<List<UsuarioViewModel>>>
    {
        private readonly GerenciadorDeBibliotecaDbContext _context;
        public GetAllUsuarioHandler(GerenciadorDeBibliotecaDbContext context)
        {
            _context = context;
        }
        public async Task<ResultViewModel<List<UsuarioViewModel>>> Handle(GetAllUsuarioQuery request, CancellationToken cancellationToken)
        {
            var usuarios = await _context.Usuarios.ToListAsync();

            var model = usuarios.Select(UsuarioViewModel.FromEntity).ToList();

            return ResultViewModel<List<UsuarioViewModel>>.Success(model);
        }
    }
}
       
        
    


