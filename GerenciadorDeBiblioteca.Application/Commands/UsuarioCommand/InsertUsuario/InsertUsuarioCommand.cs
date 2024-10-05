using GerenciadorDeBiblioteca.Application.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciadorDeBiblioteca.Application.Commands.UsuarioCommand.InsertUsuario
{
    public class InsertUsuarioCommand:IRequest<ResultViewModel>
    {
        public string Nome { get; set; }

        public string Email { get; set; }
    }
}
