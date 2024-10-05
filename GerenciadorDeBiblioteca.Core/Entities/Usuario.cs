namespace GerenciadorDeBiblioteca.Core.Entities
{
    public class Usuario: BaseEntity
    {
        public Usuario(string nome, string email)
            :base()
        {
            Nome = nome;
            Email = email;
           Ativo = true;
        }

        public int Id { get;private set; }

        public string Nome { get;private set; }

        public string Email { get;private set; }

        public bool Ativo { get; private set; }

        public void Update(string nome,string email)
        {
            Nome = nome;
            Email = email;

        }
    }
}
