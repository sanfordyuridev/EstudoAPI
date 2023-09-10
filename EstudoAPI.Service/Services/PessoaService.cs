using AutoMapper;
using AutoMapper.QueryableExtensions;
using EstudoAPI.Domain.Dto;
using EstudoAPI.Domain.Entities;
using EstudoAPI.Domain.Interfaces.Data;
using EstudoAPI.Domain.Interfaces.Services;

namespace EstudoAPI.Service.Services
{
    public class PessoaService : IPessoaService
    {
        private readonly IMapper _mapper;
        private readonly IPessoaRepository _pessoaRepository;


        public PessoaService(IMapper mapper, IPessoaRepository pessoaRepository)
        {
            _mapper = mapper;
            _pessoaRepository = pessoaRepository;
        }

        public void Create(PessoaDto model)
            => _pessoaRepository.Create(_mapper.Map<Pessoa>(model));

        public void Update(PessoaDto model)
            => _pessoaRepository.Update(_mapper.Map<Pessoa>(model));
        

        public void Delete(PessoaDto model)
            => _pessoaRepository.Delete(_mapper.Map<Pessoa>(model));

        public PessoaDto Get(Guid id)
            => _mapper.Map<PessoaDto>(_pessoaRepository.Get(id));

        public IQueryable<PessoaDto> GetAll()
            => _pessoaRepository.GetAll().ProjectTo<PessoaDto>(_mapper.ConfigurationProvider);

        public PessoaDto GetByCpf(string cpf)
            => _mapper.Map<PessoaDto>(_pessoaRepository.GetBy(p => p.CPF.Equals(cpf)));
    }
}
