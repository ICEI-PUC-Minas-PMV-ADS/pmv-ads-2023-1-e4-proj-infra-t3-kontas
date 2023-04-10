using AutoMapper;
using Kontas.API.Models;
using Kontas.API.Repositories.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Kontas.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContasController : ControllerBase
    {
        private readonly IContaRepository repository;
        private readonly IMapper mapper;

        public ContasController(IContaRepository repository, IMapper mapper)
        {
            this.repository = repository;
            this.mapper = mapper;
        }

        [HttpGet]
        public ActionResult GetAll()
        {
            var lista = repository.Get();
            return Ok(lista);
        }
        [HttpPost]
        public ActionResult Add(ContaRequest conta)
        {
            return Ok();
        }
        [HttpPut]
        public ActionResult Update(ContaRequest conta)
        {
            return Ok();
        }
        [HttpDelete]
        public ActionResult Delete(int id)
        {
            return Ok();
        }
    }
}
