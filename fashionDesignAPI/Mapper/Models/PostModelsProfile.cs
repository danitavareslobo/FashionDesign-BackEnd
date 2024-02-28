using AutoMapper;
using fashionDesignAPI.Dto.Models.Request;
using fashionDesignAPI.Extensions;
using fashionDesignAPI.Models;

namespace fashionDesignAPI.Mapper.Models
{
    public class PostModelsProfile : Profile
    {
        public PostModelsProfile()
        {
            CreateMap<Model, PostModels>()
                .ForMember(dest => dest.Name, src => src.MapFrom(s => s.Name))
                .ForMember(dest => dest.ResponsibleId, src => src.MapFrom(s => s.ResponsibleId))
                .ForMember(dest => dest.CollectionId, src => src.MapFrom(s => s.CollectionId))
                .ForMember(dest => dest.RealCost, src => src.MapFrom(s => s.RealCost))
                .ForMember(dest => dest.Type, src => src.MapFrom(s => s.Type.GetEnumDescription()))
                .ForMember(dest => dest.Embroidery, src => src.MapFrom(s => s.Embroidery))
                .ForMember(dest => dest.Print, src => src.MapFrom(s => s.Print))
                .ReverseMap();
        }
    }
}
