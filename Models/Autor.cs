namespace WebApplication11.Models
{
    public partial class Autor
    {
        public Autor()
        {
            LivroAutors = new HashSet<LivroAutor>();
        }

        public int Id { get; set; }
        public string Nome { get; set; } = null!;
        public DateTime? DataNascimento { get; set; }
        public bool? Ativo { get; set; }

        public virtual ICollection<LivroAutor> LivroAutors { get; set; }
    }
}
