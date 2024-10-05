using GerenciadorDeBiblioteca.API.Models;
using GerenciadorDeBiblioteca.Application.Models;
using MediatR;


namespace GerenciadorDeBiblioteca.Application.Queries.LivroQueries.GetAllLivros
{
    public class GetAllLivroQuery : IRequest<ResultViewModel<List<LivroItemViewModel>>>
    {

    }
}
