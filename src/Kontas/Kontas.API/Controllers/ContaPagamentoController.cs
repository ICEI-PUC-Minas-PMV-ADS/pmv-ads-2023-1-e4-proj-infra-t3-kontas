using AutoMapper;
using Kontas.API.Entities;
using Kontas.API.Models;
using Kontas.API.Repositories.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Kontas.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContaPagamentoController : ControllerBase
    {
        private readonly IContaPagamentoRepository repository;
        private readonly IMapper mapper;

        public ContaPagamentoController(IContaPagamentoRepository repository, IMapper mapper)
        {
            this.repository = repository;
            this.mapper = mapper;
        }
        [HttpGet]
        public ActionResult GetAll()
        {
            var lista = mapper.Map<IEnumerable<ContaPagamentoGetResponse>>(repository.Get().ToList());
            return Ok(lista);
        }
        [HttpPost]
        public ActionResult Add(ContaPagamentoAddRequest contaPagamento)
        {
            if (ModelState.IsValid)
            {
                var entity = mapper.Map<ContaPagamento>(contaPagamento);
                try
                {
                    repository.Add(entity);
                    return Ok();
                }
                catch (DbUpdateException)
                {
                    return BadRequest("Erro ao tentar adicionar no banco de dados, verifique se os valores dos campos são válidos");
                }
                catch (Exception)
                {
                    return StatusCode(500);
                }
            }
            else { return BadRequest(ModelState); }
        }
        [HttpPut]
        public ActionResult Update(ContaPagamentoUpdateRequest contaPagamento)
        {
            if (ModelState.IsValid)
            {
                var entity = mapper.Map<ContaPagamento>(contaPagamento);
                try
                {
                    repository.Update(entity);
                    return Ok();
                }
                catch (DbUpdateException)
                {
                    return BadRequest("Erro ao tentar adicionar no banco de dados, verifique se os valores dos campos são válidos");
                }
                catch (Exception)
                {
                    return StatusCode(500);
                }
            }
            else { return BadRequest(ModelState); }
        }
        [HttpDelete]
        public ActionResult Delete(int id)
        {
            if (id == 0) { return BadRequest();}
            try
            {
                repository.Delete(id);
                return Ok();
            }
            catch (Exception)
            {
                return StatusCode(500);
            }
        }
    }
}
