using GerenciadorDeBiblioteca.API.Models;
using GerenciadorDeBiblioteca.Application.Models;
using GerenciadorDeBiblioteca.Core.Repositories;
using MediatR;

namespace GerenciadorDeBiblioteca.Application.Queries.LivroQueries.GetAllLivros
{
    public class GetAllLivroHandler : IRequestHandler<GetAllLivroQuery, ResultViewModel<List<LivroItemViewModel>>>
    {
        private readonly ILivroRepository _repository;
        
        public GetAllLivroHandler(ILivroRepository repository)
        {
            _repository = repository;
           
        }

        public async Task<ResultViewModel<List<LivroItemViewModel>>> Handle(GetAllLivroQuery request, CancellationToken cancellationToken)
        {
            var livros = await _repository.GetAll(); 

            var model = livros.Select(LivroItemViewModel.FromEntity).ToList();

            return ResultViewModel<List<LivroItemViewModel>>.Success(model);
        }
    }
}

