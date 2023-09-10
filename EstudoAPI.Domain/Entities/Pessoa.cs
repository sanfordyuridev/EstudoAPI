using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudoAPI.Domain.Entities
{
    public class Pessoa : Entity {

        public Pessoa()
        {

        }

        public Pessoa(string nome, string cpf, DateTime nascimento) {
            Id = Guid.NewGuid();
            Nome = nome;
            CPF = cpf;
            Nascimento = nascimento;
        }

        public string Nome { get; set; }
        public string CPF { get; set; }
        public DateTime Nascimento { get; set; }


    }
}
