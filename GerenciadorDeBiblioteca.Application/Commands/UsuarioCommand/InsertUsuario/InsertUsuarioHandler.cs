using GerenciadorDeBiblioteca.API.Persistence;
using GerenciadorDeBiblioteca.Application.Models;
using GerenciadorDeBiblioteca.Core.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciadorDeBiblioteca.Application.Commands.UsuarioCommand.InsertUsuario
{
    public class InsertUsuarioHandler : IRequestHandler<InsertUsuarioCommand, ResultViewModel>
    {

        private readonly GerenciadorDeBibliotecaDbContext _context;
        public InsertUsuarioHandler(GerenciadorDeBibliotecaDbContext context)
        {
            _context = context;
        }
        public async Task<ResultViewModel> Handle(InsertUsuarioCommand request, CancellationToken cancellationToken)
        {
        var usuario = new Usuario(request.Nome, request.Email);

            await _context.Usuarios.AddAsync(usuario);
            _context.SaveChanges();

            return ResultViewModel<int>.Success(usuario.Id);
        }
    }
}
