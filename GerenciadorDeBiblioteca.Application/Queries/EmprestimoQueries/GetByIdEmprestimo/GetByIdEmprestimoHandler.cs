using GerenciadorDeBiblioteca.API.Models;
using GerenciadorDeBiblioteca.API.Persistence;
using GerenciadorDeBiblioteca.Application.Models;
using GerenciadorDeBiblioteca.Core.Repositories;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace GerenciadorDeBiblioteca.Application.Queries.EmprestimoQueries.GetByIdEmprestimo
{
    public class GetByIdEmprestimoHandler : IRequestHandler<GetByIdEmprestimoQuery, ResultViewModel<EmprestimoViewModel>>
    {

        private readonly GerenciadorDeBibliotecaDbContext _context;
        public GetByIdEmprestimoHandler(GerenciadorDeBibliotecaDbContext context)
        {
            _context = context;
        }

        public async Task<ResultViewModel<EmprestimoViewModel>> Handle(GetByIdEmprestimoQuery request, CancellationToken cancellationToken)
        {
            var emprestimo = await _context.Emprestimos.SingleOrDefaultAsync(e =>e.Id == request.Id);

            var model = EmprestimoViewModel.FromEntity(emprestimo);

            return ResultViewModel<EmprestimoViewModel>.Success(model);
        }
    }
    
}
