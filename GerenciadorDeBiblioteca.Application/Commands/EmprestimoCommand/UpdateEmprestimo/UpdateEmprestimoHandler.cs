using GerenciadorDeBiblioteca.API.Persistence;
using GerenciadorDeBiblioteca.Application.Models;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciadorDeBiblioteca.Application.Commands.EmprestimoCommand.UpdateEmprestimo
{
    public class UpdateEmprestimoHandler : IRequestHandler<UpdateEmprestimoCommand, ResultViewModel>
    {
        private readonly GerenciadorDeBibliotecaDbContext _context;
        public UpdateEmprestimoHandler(GerenciadorDeBibliotecaDbContext context)
        {
            _context = context;
        }
        public async Task<ResultViewModel> Handle(UpdateEmprestimoCommand request, CancellationToken cancellationToken)
        {
            var emprestimo = await _context.Emprestimos.SingleOrDefaultAsync(emp => emp.Id == request.IdEmprestimo);

            return ResultViewModel.Success();
        }
    }
}
