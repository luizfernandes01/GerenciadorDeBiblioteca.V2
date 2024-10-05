using GerenciadorDeBiblioteca.API.Models;
using GerenciadorDeBiblioteca.API.Persistence;
using GerenciadorDeBiblioteca.Application.Models;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciadorDeBiblioteca.Application.Queries.UsuarioQueries.GetByIdUsuario
{
    public class GetByIdUsuarioHandler : IRequestHandler<GetByIdUsuarioQuery, ResultViewModel<UsuarioViewModel>>
    {

        private readonly GerenciadorDeBibliotecaDbContext _context;
        public GetByIdUsuarioHandler(GerenciadorDeBibliotecaDbContext context)
        {
            _context = context;
        }
        public async Task<ResultViewModel<UsuarioViewModel>> Handle(GetByIdUsuarioQuery request, CancellationToken cancellationToken)
        {
            var usuario = await _context.Usuarios.SingleOrDefaultAsync(u => u.Id == request.Id);

            if (usuario == null)
            {
                return ResultViewModel<UsuarioViewModel>.Error("Usuario não existe.");
            }
            var model = UsuarioViewModel.FromEntity(usuario);

            return ResultViewModel<UsuarioViewModel>.Success(model);

        }
    }
}