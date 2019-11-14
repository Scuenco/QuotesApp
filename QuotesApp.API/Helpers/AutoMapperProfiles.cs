using AutoMapper;
using QuotesApp.API.Dtos;
using QuotesApp.API.Models;

namespace QuotesApp.API.Helpers
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        { 
            //Create our map, specifying the source, destination
            CreateMap<User, UserForListDto>();
            CreateMap<User, UserForDetailsDto>();
            CreateMap<Quote, QuotesForDetailsDto>()
                // For QuotesForDetailsDto.Customer, we will map from Quote.Customer.Name
                .ForMember(dest => dest.Customer, 
                            opt => opt.MapFrom(src => src.Customer.Name));
            CreateMap<Material, MaterialForQuotesForDetailsDto>();
            CreateMap<UserForRegisterDto, User>();
        }
    }
}