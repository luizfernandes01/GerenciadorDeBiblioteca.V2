using FluentValidation;
using GerenciadorDeBiblioteca.Application.Commands.LivroCommand.InsertLivro;


namespace GerenciadorDeBiblioteca.Application.Validators
{
    public class InsertLivroValidator : AbstractValidator<InsertLivroCommand>
    {
        public InsertLivroValidator()
        {
            RuleFor(l => l.Titulo)
                .NotEmpty()
                .WithMessage("Não pode ser vazio.")
                .MaximumLength(50)
                .WithMessage("Tamanho máximo é 50 caracteres.");
        }
    }
}
