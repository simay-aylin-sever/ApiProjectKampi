using ApiProjeKampi.WebApi.Dtos.FeatureDtos;
using ApiProjeKampi.WebApi.Dtos.MessageDtos;
using ApiProjeKampi.WebApi.Entities;
using AutoMapper;

namespace ApiProjeKampi.WebApi.Mapping
{
    public class GeneralMapping :Profile
    {
        public GeneralMapping()
        {
            CreateMap<Feature, ResultFeatureDto>().ReverseMap();
            CreateMap<Feature, CreateFeatureDto>().ReverseMap();
            CreateMap<Feature, UpdateFeatureDto>().ReverseMap();
            CreateMap<Feature, GetByIdFeatureDto>().ReverseMap();

            CreateMap<Message, ResultMessageDtos>().ReverseMap();
            CreateMap<Message, CreateMessageDtos>().ReverseMap();
            CreateMap<Message, UpdateMessageDto>().ReverseMap();
            CreateMap<Message, GetByIdMessageDtos>().ReverseMap();
            
        }
    }
}
