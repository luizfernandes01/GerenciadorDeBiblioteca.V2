using GerenciadorDeBiblioteca.API.Models;
using GerenciadorDeBiblioteca.API.Persistence;
using GerenciadorDeBiblioteca.Application.Models;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace GerenciadorDeBiblioteca.Application.Queries.EmprestimoQueries.GetAllEmprestimos
{
    public class GetAllEmprestimoHandler : IRequestHandler<GetAllEmprestimoQuery, ResultViewModel<List<EmprestimoViewModel>>>
    {
        private readonly GerenciadorDeBibliotecaDbContext _context;
        public GetAllEmprestimoHandler(GerenciadorDeBibliotecaDbContext context)
        {
            _context = context;
        }
        public async Task<ResultViewModel<List<EmprestimoViewModel>>> Handle(GetAllEmprestimoQuery request, CancellationToken cancellationToken)
        {
            var emprestimos = await _context.Emprestimos.ToListAsync();

            var model = emprestimos.Select(EmprestimoViewModel.FromEntity).ToList();

            return ResultViewModel<List<EmprestimoViewModel>>.Success(model);
        }
    }
}
