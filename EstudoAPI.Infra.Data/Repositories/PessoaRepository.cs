using EstudoAPI.Domain.Entities;
using EstudoAPI.Domain.Interfaces.Data;
using EstudoAPI.Domain.Repositories;
using EstudoAPI.Infra.Context;
using EstudoAPI.Repositories.Commun;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudoAPI.Infra.Data
{
    public class PessoaRepository : Repository<Pessoa>, IPessoaRepository
    {
        public PessoaRepository(EstudoContext context) : base(context)
        {
        }
    }
}
