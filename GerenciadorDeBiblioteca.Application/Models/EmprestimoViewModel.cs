

using GerenciadorDeBiblioteca.Core.Entities;

namespace GerenciadorDeBiblioteca.API.Models
{
    public class EmprestimoViewModel
    {
        public EmprestimoViewModel(int id, int idCliente, int idLivro, DateTime dataEmprestimo)
        {
            Id = id;
            IdCliente = idCliente;
            IdLivro = idLivro;
            DataEmprestimo = dataEmprestimo;
        }

        public int Id { get;  set; }
        public int IdCliente { get;  set; }
                
        public int IdLivro { get;  set; }
              
        public DateTime DataEmprestimo { get;  set; }
               
                public static EmprestimoViewModel FromEntity (Emprestimo entity)
            => new(entity.Id,entity.IdCliente,entity.IdLivro,entity.DataEmprestimo);
           

    }
} 

