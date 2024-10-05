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
    public class UsuarioRepository : IUsuarioRepository
    {

        private readonly GerenciadorDeBibliotecaDbContext _context;
        public UsuarioRepository(GerenciadorDeBibliotecaDbContext context)
        {
            _context = context;
        }
        public async Task<int> Add(Usuario usuario)
        {
            await _context.Usuarios.AddAsync(usuario);
            _context.SaveChanges();

            return usuario.Id;
        }

        public async Task<List<Usuario>> GetAll()
        {
            var usuarios = await _context.Usuarios.ToListAsync();

            return usuarios;
        }

        public async Task<Usuario> GetById(int id)
        {
            var usuario = await _context.Usuarios.SingleOrDefaultAsync(u => u.Id == id);

            return usuario;
        }

        public async Task<int> Update(Usuario usuario)
        {
            _context.Usuarios.Update(usuario);
            await _context.SaveChangesAsync();

            return usuario.Id;
        }
    }
}
