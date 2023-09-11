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
        public IActionResult PorId(Guid id)
        {
            PessoaDto pessoa = _pessoasService.Get(id);
            if (pessoa == null)
            {
                return NotFound();
            }
            return Ok(pessoa);
        }

        [HttpGet("cpf/{cpf}")]
        public IActionResult PorCpf(string cpf)
        {
            PessoaDto pessoa = _pessoasService.GetByCpf(cpf);
            if (pessoa == null)
            {
                return NotFound();
            }
            return Ok(pessoa);
        }

        [HttpPost]
        public IActionResult Post(PessoaDto pessoa)
        {
            _pessoasService.Create(pessoa);
            return Ok();
        }

        [HttpPut]
        public IActionResult Put(PessoaDto pessoa)
        {
            if (_pessoasService.Get(pessoa.Id) == null)
            {
                return NotFound();
            }

            _pessoasService.Update(pessoa);
            return Ok();
        }

        [HttpDelete]
        public IActionResult Delete(Guid id)
        {
            PessoaDto pessoa = _pessoasService.Get(id);
            if(pessoa == null)
            {
                return NotFound();
            }

            _pessoasService.Delete(pessoa);
            return Ok();
        }
    }
}
