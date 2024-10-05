using GerenciadorDeBiblioteca.API.Persistence;
using GerenciadorDeBiblioteca.Application.Models;
using GerenciadorDeBiblioteca.Core.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciadorDeBiblioteca.Application.Commands.EmprestimoCommand.InsertEmprestimo
{
    public class InsertEmprestimoHandler : IRequestHandler<InsertEmprestimoCommand, ResultViewModel<int>>
    {
        private readonly GerenciadorDeBibliotecaDbContext _context;
        public InsertEmprestimoHandler(GerenciadorDeBibliotecaDbContext context)
        {
            _context = context;
        }
        public async Task<ResultViewModel<int>> Handle(InsertEmprestimoCommand request, CancellationToken cancellationToken)
        {
            var emprestimo = new Emprestimo(request.IdCliente, request.IdLivro);

           await _context.Emprestimos.AddAsync(emprestimo);
            _context.SaveChanges();

            return ResultViewModel<int>.Success(emprestimo.Id);
        }
    }
}
