using AutoMapper;
using Kontas.API.Entities;
using Kontas.API.Models;
using Kontas.API.Repositories.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

namespace Kontas.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StatusContaController : ControllerBase
    {
        private readonly IStatusContaRepository repository;

        public StatusContaController(IStatusContaRepository repository)
        {
            this.repository = repository;
        }
        [HttpGet]
        public ActionResult GetAll()
        {
            var lista = repository.Get();
            var listaResponse = new List<StatusContaGetResponse>();
            foreach (var item in lista)
            {
                listaResponse.Add(new StatusContaGetResponse()
                {
                    Id = item.Id,
                    Nome = item.Nome,
                });
            }
            return Ok(listaResponse);
        }
        [HttpPost]
        public ActionResult Add(StatusContaAddRequest request)
        {
            if (ModelState.IsValid)
            {
                var entity = new StatusConta
                {
                    Nome = request.Nome
                };
                try
                {
                    repository.Add(entity);
                    return Ok();
                }
                catch (DbUpdateException)
                {
                    return BadRequest("Erro ao tentar adicionar no banco de dados, verifique se já existe StatusConta com esse nome");
                }
                catch (Exception)
                {
                    return StatusCode(500);
                }
            }
            else { return BadRequest(ModelState); }
        }
        [HttpPut]
        public ActionResult Update(StatusContaUpdateRequest request)
        {
            if (ModelState.IsValid)
            {
                var entity = new StatusConta
                {
                    Id = request.Id,
                    Nome = request.Nome
                };
                try
                {
                    repository.Update(entity);
                    return Ok();
                }
                catch (Exception ex)
                {
                    return BadRequest(ex.Message);
                }
            }
            else { return BadRequest(ModelState); }
        }
        [HttpDelete]
        public ActionResult Delete(int id)
        {
            return Ok();
        }
    }
}
