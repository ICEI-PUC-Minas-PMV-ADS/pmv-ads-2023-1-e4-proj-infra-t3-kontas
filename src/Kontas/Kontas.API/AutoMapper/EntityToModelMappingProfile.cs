using AutoMapper;
using Kontas.API.Entities;
using Kontas.API.Models;

namespace Kontas.API.AutoMapper
{
    public class EntityToModelMappingProfile : Profile
    {
        public EntityToModelMappingProfile()
        {
            CreateMap<Conta, ContaGetResponse>();
            CreateMap<ContaPagamento, ContaPagamentoGetResponse>();
        }
    }
}
