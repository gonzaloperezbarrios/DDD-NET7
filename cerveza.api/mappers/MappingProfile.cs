namespace cerveza.api.mappers;
using AutoMapper;
using cerveza.api.Requests;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<CerbezaFilterRequest, CerbezaFilterDTO>();
    }
}
