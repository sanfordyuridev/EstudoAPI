using EstudoAPI.Domain.Entities;
using EstudoAPI.Domain.Interfaces.Data;
using EstudoAPI.Infra.Context;
using EstudoAPI.Repositories.Commun;

namespace EstudoAPI.Infra.Data
{
    public class PessoaRepository : Repository<Pessoa>, IPessoaRepository
    {
        public PessoaRepository(EstudoContext context) : base(context)
        {
        }
    }
}
