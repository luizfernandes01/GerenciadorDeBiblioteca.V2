

using GerenciadorDeBiblioteca.Core.Entities;

namespace GerenciadorDeBiblioteca.API.Models
{
    public class UsuarioViewModel
    {
        public UsuarioViewModel(string nome, string email)
        {
            Nome = nome;
            Email = email;
        }

        public int Id { get; set; }
        public string Nome { get; set; }

        public string Email { get; set; }


           public static UsuarioViewModel FromEntity(Usuario entity)
            =>new (entity.Nome, entity.Email);
                  
                
       
    }
}
