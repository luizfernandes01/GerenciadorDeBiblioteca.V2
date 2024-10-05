using FluentValidation;
using GerenciadorDeBiblioteca.API.Models;
using System.Net.Mail;

namespace GerenciadorDeBiblioteca.Application.Validators
{
    public class CreateUsuarioValidator:AbstractValidator<CreateUsuarioInputModel>
    {
        public CreateUsuarioValidator()
        {
            RuleFor(u => u.Email)
                .EmailAddress()
                .WithMessage("E-mail inválido.");
        }
    }
}
