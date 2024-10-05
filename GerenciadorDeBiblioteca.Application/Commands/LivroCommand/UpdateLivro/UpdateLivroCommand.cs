using GerenciadorDeBiblioteca.Application.Models;
using MediatR;


namespace GerenciadorDeBiblioteca.Application.Commands.LivroCommand.UpdateLivro
{
    public class UpdateLivroCommand:IRequest<ResultViewModel>
    {
        public int IdLivro { get; set; }
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public string ISBN { get; set; }
        public int AnoDePublicacao { get; set; }
    }
}
