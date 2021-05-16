using Api.Data.Interfaces;
using Api.Domain;
using Microsoft.AspNetCore.Mvc;
using Api.Data.Imp;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Api.Rest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PessoaController : ControllerBase
    {
        private readonly IPessoaRepository _repository;

        public PessoaController(IPessoaRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public ActionResult Get()
        {
            var pessoas = _repository.Get();
            return Ok(pessoas);
        }

        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            var pessoa = _repository.GetById(id);
            return Ok(pessoa);
        }

        [HttpPost]
        public ActionResult Post(Pessoa pessoa)
        {
            _repository.Add(pessoa);
            return StatusCode(201);
        }

        [HttpPut("{id:int}")]
        public ActionResult Put(int id, Pessoa pessoa)
        {
            pessoa.Id = id;
            _repository.Atualizar(pessoa);
            return StatusCode(200);

        }

        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            _repository.Delete(id);
            return StatusCode(200);
        }
    }
}
