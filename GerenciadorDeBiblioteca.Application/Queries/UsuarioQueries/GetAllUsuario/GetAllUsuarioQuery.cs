using GerenciadorDeBiblioteca.API.Models;
using GerenciadorDeBiblioteca.Application.Models;
using MediatR;


namespace GerenciadorDeBiblioteca.Application.Queries.UsuarioQueries.GetAllUsuario
{
    public class GetAllUsuarioQuery:IRequest<ResultViewModel<List<UsuarioViewModel>>>
    {
       
    }
}
