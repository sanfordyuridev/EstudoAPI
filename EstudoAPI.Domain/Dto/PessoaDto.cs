using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace EstudoAPI.Domain.Dto
{
    [DisplayName("Pessoa")]
    public class PessoaDto
    {
        public PessoaDto() =>
            Id = Guid.NewGuid();

        public PessoaDto(string nome, string cpf, DateTime nascimento) {
            Id = Guid.NewGuid();
            Nome = nome;
            CPF = cpf;
            Nascimento = nascimento;
        }

        public Guid Id { get; set; }

        [Required(ErrorMessage = "Campo 'Nome' obrigatório.")]
        public string Nome { get; private set; }

        [Required(ErrorMessage = "Campo 'CPF' obrigatório.")]
        public string CPF { get; private set; }

        [Required(ErrorMessage = "Campo 'Nascimento' obrigatório.")]
        public DateTime Nascimento { get; private set; }
    }

}
