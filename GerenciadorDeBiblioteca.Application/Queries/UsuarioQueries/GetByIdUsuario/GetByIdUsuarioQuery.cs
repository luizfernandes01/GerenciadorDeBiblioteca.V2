using GerenciadorDeBiblioteca.API.Models;
using GerenciadorDeBiblioteca.Application.Models;
using MediatR;


namespace GerenciadorDeBiblioteca.Application.Queries.UsuarioQueries.GetByIdUsuario
{
    public class GetByIdUsuarioQuery:IRequest<ResultViewModel<UsuarioViewModel>>
    {
        public GetByIdUsuarioQuery(int id)
        {
            Id = id;
        }

        public int Id { get; set; }
    }
}
