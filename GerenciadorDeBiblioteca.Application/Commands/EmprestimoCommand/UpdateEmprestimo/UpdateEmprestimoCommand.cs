using GerenciadorDeBiblioteca.Application.Models;
using MediatR;


namespace GerenciadorDeBiblioteca.Application.Commands.EmprestimoCommand.UpdateEmprestimo
{
    public class UpdateEmprestimoCommand:IRequest<ResultViewModel>
    {
        public string DataEmprestimo { get; set; }

        public int IdEmprestimo { get; set; }
    }
}
