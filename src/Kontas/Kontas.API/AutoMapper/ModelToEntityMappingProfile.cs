using AutoMapper;
using Kontas.API.Entities;
using Kontas.API.Models;

namespace Kontas.API.AutoMapper
{
    public class ModelToEntityMappingProfile : Profile
    {
        public ModelToEntityMappingProfile()
        {
            CreateMap<ContaAddRequest, Conta>();
            CreateMap<ContaUpdateRequest, Conta>();
            CreateMap<ContaPagamentoAddRequest, ContaPagamento>();
            CreateMap<ContaPagamentoUpdateRequest, ContaPagamento>();
        }
    }
}
