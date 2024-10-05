using GerenciadorDeBiblioteca.Application.Models;
using MediatR;


namespace GerenciadorDeBiblioteca.Application.Commands.UsuarioCommand.UpdateUsuario
{
    public class UpdateUsuarioCommand:IRequest<ResultViewModel>
    {
        public string Nome { get; set; }

        public string Email { get; set; }
    }
}
