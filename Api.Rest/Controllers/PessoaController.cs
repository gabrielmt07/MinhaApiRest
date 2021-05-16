using Api.Data.Interfaces;
using Api.Domain;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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

        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
