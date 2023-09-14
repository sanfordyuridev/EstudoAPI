using EstudoAPI.Domain.Dto;
using EstudoAPI.Domain.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;

namespace EstudoAPI.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PessoaController : Controller
    {
        private readonly IPessoaService _pessoasService;

        public PessoaController(IPessoaService pessoasService)
        {
            _pessoasService = pessoasService;
        }

        [HttpGet]
        public IActionResult Get()
            => Ok(_pessoasService.GetAll());

        [HttpGet("{id}")]
        public async Task<IActionResult> PorId(Guid id)
        {
            PessoaDto pessoa = await _pessoasService.Get(id);
            if (pessoa == null)
            {
                return NotFound();
            }
            return Ok(pessoa);
        }

        [HttpGet("cpf/{cpf}")]
        public async Task<IActionResult> PorCpf(string cpf)
        {
            PessoaDto pessoa = await _pessoasService.GetByCpf(cpf);
            if (pessoa == null)
            {
                return NotFound();
            }
            return Ok(pessoa);
        }

        [HttpPost]
        public async Task<IActionResult> Post(PessoaDto pessoa)
        {
            await _pessoasService.Create(pessoa);
            return Ok();
        }

        [HttpPut]
        public async Task<IActionResult> Put(PessoaDto pessoa)
        {
            if (_pessoasService.Get(pessoa.Id) == null)
            {
                return NotFound();
            }

            await _pessoasService.Update(pessoa);
            return Ok();
        }

        [HttpDelete]
        public async Task<IActionResult> Delete(Guid id)
        {
            PessoaDto pessoa = await _pessoasService.Get(id);
            if(pessoa == null)
            {
                return NotFound();
            }

            await _pessoasService.Delete(pessoa);
            return Ok();
        }
    }
}
