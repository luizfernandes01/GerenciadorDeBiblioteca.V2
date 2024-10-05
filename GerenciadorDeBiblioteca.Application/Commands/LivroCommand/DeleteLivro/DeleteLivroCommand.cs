using GerenciadorDeBiblioteca.Application.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciadorDeBiblioteca.Application.Commands.LivroCommand.DeleteLivro
{
      
        public class DeleteLivroCommand : IRequest<ResultViewModel>
        {
            public DeleteLivroCommand(int id)
            {
                Id = id;
            }
            public int Id { get; set; }
        }
    
}
