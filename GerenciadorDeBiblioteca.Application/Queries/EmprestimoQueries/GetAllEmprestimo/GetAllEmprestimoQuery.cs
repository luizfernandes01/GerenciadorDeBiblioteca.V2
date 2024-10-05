using GerenciadorDeBiblioteca.API.Models;
using GerenciadorDeBiblioteca.Application.Models;
using MediatR;


namespace GerenciadorDeBiblioteca.Application.Queries.EmprestimoQueries.GetAllEmprestimos
{
    public class GetAllEmprestimoQuery:IRequest<ResultViewModel<List<EmprestimoViewModel>>>
    {

    }
}
