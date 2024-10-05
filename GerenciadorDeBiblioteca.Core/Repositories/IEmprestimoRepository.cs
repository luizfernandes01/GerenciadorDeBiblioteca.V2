using GerenciadorDeBiblioteca.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciadorDeBiblioteca.Core.Repositories
{
    public interface IEmprestimoRepository
    {
        Task<List<Emprestimo>> GetAll();

        Task<Emprestimo> GetById(int id);

        Task<int> Add(Emprestimo emprestimo);

        Task<int> Update(Emprestimo emprestimo);
    }
}
