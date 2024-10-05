using GerenciadorDeBiblioteca.API.Models;
using GerenciadorDeBiblioteca.Application.Models;
using MediatR;


namespace GerenciadorDeBiblioteca.Application.Queries.LivroQueries.GetByIdLivros
{
    public class GetByIdLivroQuery:IRequest<ResultViewModel<LivroViewModel>>
    {
        public GetByIdLivroQuery(int id)
        {
            Id = id;
        }

        public int Id { get; set; }
    }
}
