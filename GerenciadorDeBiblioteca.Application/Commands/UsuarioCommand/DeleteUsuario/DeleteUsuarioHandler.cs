using GerenciadorDeBiblioteca.API.Persistence;
using GerenciadorDeBiblioteca.Application.Models;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace GerenciadorDeBiblioteca.Application.Commands.UsuarioCommand.DeleteUsuario
{
    public class DeleteUsuarioHandler : IRequestHandler<DeleteUsuarioCommand, ResultViewModel>
    {

        private readonly GerenciadorDeBibliotecaDbContext _context;
        public DeleteUsuarioHandler(GerenciadorDeBibliotecaDbContext context)
        {
            _context = context;
        }
        public async Task<ResultViewModel> Handle(DeleteUsuarioCommand request, CancellationToken cancellationToken)
        {
            var usuario = await _context.Usuarios.SingleOrDefaultAsync(u => u.Id == request.Id);


            return ResultViewModel.Success();
        }
    }
}
