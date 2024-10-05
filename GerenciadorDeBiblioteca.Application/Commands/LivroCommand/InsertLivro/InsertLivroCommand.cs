using GerenciadorDeBiblioteca.Application.Models;
using GerenciadorDeBiblioteca.Core.Entities;
using MediatR;

namespace GerenciadorDeBiblioteca.Application.Commands.LivroCommand.InsertLivro
{
    public class InsertLivroCommand:IRequest<ResultViewModel<int>>
    {
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public string ISBN { get; set; }
        public int AnoDePublicacao { get; set; }

        public Livro ToEntity()
            => new(Titulo, Autor, ISBN, AnoDePublicacao);
    }
}
