namespace WebApplication11.Models
{
    public partial class Pessoa
    {
        public int Id { get; set; }
        public string Nome { get; set; } = null!;
        public string Endereco { get; set; } = null!;
        public string Cidade { get; set; } = null!;
        public string? Estado { get; set; }
        public string EstadoCivil { get; set; } = null!;
    }
}
