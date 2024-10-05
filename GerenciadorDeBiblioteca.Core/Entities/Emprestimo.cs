using System.Net.Sockets;
using System.Text.Json.Serialization;

namespace GerenciadorDeBiblioteca.Core.Entities
{
    public class Emprestimo
    {
        public Emprestimo(int idCliente,int idLivro)
            :base()
        {
            IdCliente = idCliente;
            IdLivro = idLivro;
        }

        public int Id { get; private set; }
        public int IdCliente { get; private set; }
      
        public Usuario? Cliente { get; private set; }
        public int IdLivro { get; private set; }
       
        public Livro? Livro { get; private set; }

        public DateTime DataEmprestimo { get; private set; } 

        public DateTime Devolucao { get; private set; } 

        public void UpdateLoan(int idCliente, int idLivro)
        {
            IdCliente = idCliente;
            IdLivro = idLivro;
        }
        public void renovacao(DateTime date)
        {
            Devolucao = date;
        }
            
            
        
    }
}
