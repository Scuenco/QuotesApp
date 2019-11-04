using AutoMapper;
using QuotesApp.API.Dtos;
using QuotesApp.API.Models;

namespace QuotesApp.API.Helpers
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        { 
            //Create our map, specifying the source and destination
            CreateMap<User, UserForListDto>();
            CreateMap<User, UserForDetailsDto>();
            CreateMap<Quote, QuotesForDetailsDto>();
            CreateMap<Material, MaterialForQuotesForDetailsDto>();
        }
    }
}