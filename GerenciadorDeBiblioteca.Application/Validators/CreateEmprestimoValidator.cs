using FluentValidation;
using GerenciadorDeBiblioteca.Application.Commands.EmprestimoCommand.InsertEmprestimo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciadorDeBiblioteca.Application.Validators
{
    public class CreateEmprestimoValidator:AbstractValidator<InsertEmprestimoCommand>
    {
        public CreateEmprestimoValidator()
        {
            RuleFor(e => e.IdCliente)
                .NotEmpty()
                .WithMessage("Obrigatório informar o Id do Cliente.");

            RuleFor(e => e.IdLivro)
                .NotEmpty()
                .WithMessage("Obrigatório informar o Id do Livro.");

            RuleFor(e => e.DataEmprestimo)
                .NotEmpty();
        }
    }
}
