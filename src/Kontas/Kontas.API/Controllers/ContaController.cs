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
    public class ContaController : ControllerBase
    {
        private readonly IContaRepository repository;
        private readonly IMapper mapper;

        public ContaController(IContaRepository repository, IMapper mapper)
        {
            this.repository = repository;
            this.mapper = mapper;
        }

        [HttpGet]
        public ActionResult GetAll()
        {
            var lista = mapper.Map<IEnumerable<ContaGetResponse>>(repository.Get().ToList());
            return Ok(lista);
            /*
            var lista = repository.Get();
            var listaResponse = new List<ContaGetResponse>();
            foreach (var item in lista)
            {
               /* 
               listaResponse.Add(new ContaGetResponse()
                {
                    Id = item.Id,
                    Descricao = item.Descricao,
                    Vencimento = item.Vencimento.Date,
                    Valor = item.Valor,
                    Apagar = item.Apagar
                });
               
        }
            return Ok(listaResponse);*/
        }
        [HttpPost]
        public ActionResult Add(ContaAddRequest conta)
        {
            if (ModelState.IsValid)
            {
                var entity = mapper.Map<Conta>(conta);
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
        public ActionResult Update(ContaUpdateRequest conta)
        {
            if (ModelState.IsValid)
            {
                var entity = mapper.Map<Conta>(conta);
                try
                {
                    repository.Update(entity);
                    return Ok();
                }
                catch (DbUpdateException)
                {
                    return BadRequest("Erro ao tentar atualizar no banco de dados, verifique se os valores dos campos são válidos");
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
