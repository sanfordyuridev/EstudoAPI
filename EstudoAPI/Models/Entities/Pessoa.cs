namespace EstudoAPI.Models.Entities
{
    public class Pessoa
    {

        public Guid Id { get; set; }
        public string CPF { get; set; }
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }

    }
}
