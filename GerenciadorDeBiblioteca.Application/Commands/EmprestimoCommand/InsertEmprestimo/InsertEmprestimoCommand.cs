using GerenciadorDeBiblioteca.Application.Models;
using MediatR;


namespace GerenciadorDeBiblioteca.Application.Commands.EmprestimoCommand.InsertEmprestimo
{
    public class InsertEmprestimoCommand:IRequest<ResultViewModel<int>>
    {
        public int IdCliente { get; set; }
        public int IdLivro { get; set; }
        public string DataEmprestimo { get; set; }
    }
}
