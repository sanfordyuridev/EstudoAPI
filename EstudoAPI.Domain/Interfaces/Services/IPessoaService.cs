using EstudoAPI.Domain.Dto;
using EstudoAPI.Domain.Interfaces.Commun;

namespace EstudoAPI.Domain.Interfaces.Services
{
    public interface IPessoaService : IService<PessoaDto>
    {
        Task<PessoaDto> GetByCpf(string cpfName);
    }
}
