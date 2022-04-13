namespace WebApplication11.Models
{
    public partial class Editora
    {
        public Editora()
        {
            Livros = new HashSet<Livro>();
        }

        public int Id { get; set; }
        public string Nome { get; set; } = null!;
        public bool? Ativo { get; set; }

        public virtual ICollection<Livro> Livros { get; set; }
    }
}
