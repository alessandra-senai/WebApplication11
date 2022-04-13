namespace WebApplication11.Models
{
    public partial class LivroAutor
    {
        public int Id { get; set; }
        public int IdLivro { get; set; }
        public int IdAutor { get; set; }

        public virtual Autor IdAutorNavigation { get; set; } = null!;
        public virtual Livro IdLivroNavigation { get; set; } = null!;
    }
}
