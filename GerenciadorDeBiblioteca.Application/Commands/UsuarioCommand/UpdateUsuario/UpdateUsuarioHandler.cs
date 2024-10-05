using GerenciadorDeBiblioteca.API.Persistence;
using GerenciadorDeBiblioteca.Application.Models;
using MediatR;
using Microsoft.EntityFrameworkCore;


namespace GerenciadorDeBiblioteca.Application.Commands.UsuarioCommand.UpdateUsuario
{
    public class UpdateUsuarioHandler : IRequestHandler<UpdateUsuarioCommand, ResultViewModel>
    {
        private readonly GerenciadorDeBibliotecaDbContext _context;
        public UpdateUsuarioHandler(GerenciadorDeBibliotecaDbContext context)
        {
            _context = context;
        }
        public async Task<ResultViewModel> Handle(UpdateUsuarioCommand request, CancellationToken cancellationToken)
        {

            var usuario = await _context.Usuarios.SingleOrDefaultAsync();

          

            usuario.Update(request.Nome, request.Email);

            _context.Usuarios.Update(usuario);
           await _context.SaveChangesAsync();


            return ResultViewModel.Success();
        }
    }
}
