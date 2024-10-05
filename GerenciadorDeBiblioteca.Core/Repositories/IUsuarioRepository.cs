using GerenciadorDeBiblioteca.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciadorDeBiblioteca.Core.Repositories
{
    public interface IUsuarioRepository
    {
        Task<List<Usuario>>GetAll();

        Task<Usuario> GetById(int id);

        Task<int> Add(Usuario usuario);

        Task<int> Update(Usuario usuario);
    }
}
