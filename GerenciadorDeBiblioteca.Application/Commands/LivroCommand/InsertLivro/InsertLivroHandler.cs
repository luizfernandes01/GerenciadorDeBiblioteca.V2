using GerenciadorDeBiblioteca.API.Persistence;
using GerenciadorDeBiblioteca.Application.Models;
using GerenciadorDeBiblioteca.Core.Repositories;
using MediatR;


namespace GerenciadorDeBiblioteca.Application.Commands.LivroCommand.InsertLivro
{
          
    public class InsertLivroHandler : IRequestHandler<InsertLivroCommand, ResultViewModel<int>>
    {
        private readonly ILivroRepository _repository;
      
        public InsertLivroHandler(ILivroRepository repository)
        {
         
            _repository = repository;
        }
        public async Task<ResultViewModel<int>> Handle(InsertLivroCommand request, CancellationToken cancellationToken)
        {
            var livro = request.ToEntity();

            await _repository.Add(livro);

            return ResultViewModel<int>.Success(livro.Id);
        }
    }
}
