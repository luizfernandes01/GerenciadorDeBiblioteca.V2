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
    public class LivroRepository : ILivroRepository
    {

        private readonly GerenciadorDeBibliotecaDbContext _context;
        public LivroRepository(GerenciadorDeBibliotecaDbContext context)
        {
            _context = context;
        }
        public async Task<int> Add(Livro livro)
        {
           await _context.Livros.AddAsync(livro);
            _context.SaveChanges();

            return livro.Id;
        }

        public async Task<List<Livro>> GetAll()
        {
            var livros = await _context.Livros.Where(l => !l.IsDeleted).ToListAsync();

           return livros;

          
        }

        public async Task<Livro> GetById(int id)
        {
             return await _context.Livros.SingleOrDefaultAsync(l => l.Id == id);
        }

        public async Task<int> Update(Livro livro)
        {
            _context.Livros.Update(livro);
            await _context.SaveChangesAsync();

            return livro.Id;
        }
    }
}
