using GerenciadorDeBiblioteca.Application.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciadorDeBiblioteca.Application.Commands.UsuarioCommand.DeleteUsuario
{
    public class DeleteUsuarioCommand:IRequest<ResultViewModel>
    {
        public DeleteUsuarioCommand(int id)
        {
            Id = id;
        }

        public int Id { get; set; }
    }
}
