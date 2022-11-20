using AutoMapper;
using IntegraBrasilApi.Dtos;
using IntegraBrasilApi.Model;

namespace ApiDotNet.Mapping
{
    public class BancoMapping : Profile
    {
        public BancoMapping()
        {
            CreateMap(typeof(ResponseGenerico<>), typeof(ResponseGenerico<>));
            CreateMap<BancoResponse, BancoModel>();
            CreateMap<BancoModel, BancoResponse>();
        }
    }
}