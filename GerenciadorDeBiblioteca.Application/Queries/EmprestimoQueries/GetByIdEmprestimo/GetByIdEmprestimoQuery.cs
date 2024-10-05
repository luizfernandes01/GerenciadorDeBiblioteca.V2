using GerenciadorDeBiblioteca.API.Models;
using GerenciadorDeBiblioteca.Application.Models;
using MediatR;


namespace GerenciadorDeBiblioteca.Application.Queries.EmprestimoQueries.GetByIdEmprestimo
{
    public class GetByIdEmprestimoQuery:IRequest<ResultViewModel<EmprestimoViewModel>>
    {
        public GetByIdEmprestimoQuery(int id)
        {
            Id = id;
        }

        public int Id { get; set; }
    }
}
