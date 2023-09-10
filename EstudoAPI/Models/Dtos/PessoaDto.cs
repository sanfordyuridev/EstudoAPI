namespace EstudoAPI.Models.Dtos
{
    public class PessoaDto
    {

        public PessoaDto() {
            this.Id = new Guid();
        }  

        public Guid Id { get; set; }
        public string CPF { get; set; }
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }

    }
}
