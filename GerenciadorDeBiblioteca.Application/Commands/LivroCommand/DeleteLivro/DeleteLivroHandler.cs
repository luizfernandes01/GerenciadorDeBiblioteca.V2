using GerenciadorDeBiblioteca.API.Persistence;
using GerenciadorDeBiblioteca.Application.Models;
using GerenciadorDeBiblioteca.Core.Repositories;
using MediatR;

namespace GerenciadorDeBiblioteca.Application.Commands.LivroCommand.DeleteLivro
{
    public class DeleteLivroHandler : IRequestHandler<DeleteLivroCommand, ResultViewModel>
    {
        private readonly ILivroRepository _repository;
        
        public DeleteLivroHandler(ILivroRepository repository)
        {
            
            _repository = repository;
        }
        public async Task<ResultViewModel> Handle(DeleteLivroCommand request, CancellationToken cancellationToken)
        {
            var livro = await _repository.GetById(request.Id);

            if (livro == null)
            {
                return ResultViewModel.Error("Livro não existe.");
            }
            livro.SetAsDeleted();
            await _repository.Update(livro);
          

            return ResultViewModel.Success();
        }
    }
}
