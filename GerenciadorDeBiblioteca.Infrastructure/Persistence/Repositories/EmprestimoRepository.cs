using Azure.Core;
using GerenciadorDeBiblioteca.API.Persistence;
using GerenciadorDeBiblioteca.Core.Entities;
using GerenciadorDeBiblioteca.Core.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciadorDeBiblioteca.Infrastructure.Persistence.Repositories
{
    public class EmprestimoRepository : IEmprestimoRepository
    {
        private readonly GerenciadorDeBibliotecaDbContext _context;
        public EmprestimoRepository(GerenciadorDeBibliotecaDbContext context)
        {
            _context = context;
        }
        public async Task<int> Add(Emprestimo emprestimo)
        {
            await _context.Emprestimos.AddAsync(emprestimo);
            _context.SaveChanges();

            return emprestimo.Id;
        }

        public async Task<List<Emprestimo>> GetAll()
        {
            var emprestimos = await _context.Emprestimos.ToListAsync();

            return emprestimos;
        }

        public async Task<Emprestimo> GetById(int id)
        {
            var emprestimo = await _context.Emprestimos.SingleOrDefaultAsync(e => e.Id == id);

            return emprestimo;
        }

        public async Task<int> Update(Emprestimo emprestimo)
        {

            var emprestimos = await _context.Emprestimos.SingleOrDefaultAsync();

            return emprestimo.Id;


        }
    }
}
