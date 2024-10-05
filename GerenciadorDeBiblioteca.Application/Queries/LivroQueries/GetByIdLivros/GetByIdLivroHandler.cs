using GerenciadorDeBiblioteca.API.Models;
using GerenciadorDeBiblioteca.API.Persistence;
using GerenciadorDeBiblioteca.Application.Models;
using GerenciadorDeBiblioteca.Core.Repositories;
using MediatR;
using Microsoft.EntityFrameworkCore;


namespace GerenciadorDeBiblioteca.Application.Queries.LivroQueries.GetByIdLivros
{
    public class GetByIdLivroHandler : IRequestHandler<GetByIdLivroQuery, ResultViewModel<LivroViewModel>>
    {
        private readonly ILivroRepository _repository;
        
        public GetByIdLivroHandler(ILivroRepository repository)
        {
           
            _repository = repository;
        }
        public async Task<ResultViewModel<LivroViewModel>> Handle(GetByIdLivroQuery request, CancellationToken cancellationToken)
        {
            var livro = await _repository.GetById(request.Id);

            var model = LivroViewModel.FromEntity(livro);

            if (livro == null)
            {
                return ResultViewModel<LivroViewModel>.Error("Livro não existe.");
            }

            return ResultViewModel<LivroViewModel>.Success(model);

        }
    }
}
