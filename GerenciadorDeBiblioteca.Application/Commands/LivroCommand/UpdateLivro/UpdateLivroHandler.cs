using GerenciadorDeBiblioteca.API.Persistence;
using GerenciadorDeBiblioteca.Application.Models;
using GerenciadorDeBiblioteca.Core.Repositories;
using MediatR;


namespace GerenciadorDeBiblioteca.Application.Commands.LivroCommand.UpdateLivro
{
    public class UpdateLivroHandler : IRequestHandler<UpdateLivroCommand, ResultViewModel>
    {
        private readonly ILivroRepository _repository;
       
        public UpdateLivroHandler(ILivroRepository repository)
        {
            
            _repository = repository;
        }
        public async Task<ResultViewModel> Handle(UpdateLivroCommand request, CancellationToken cancellationToken)
        {
            var livro = await _repository.GetById( request.IdLivro);

            if (livro == null)
            {
                return ResultViewModel.Error("Livro não existe.");
            }

            livro.Update(request.Titulo, request.Autor, request.ISBN, request.AnoDePublicacao);

            await _repository.Update(livro);

            return ResultViewModel.Success();
        }
    }
    
}
