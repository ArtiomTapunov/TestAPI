using System.Linq;
using AutoMapper;
using TestAPI.Contracts.V1.Responses;
using TestAPI.Domain;

namespace TestAPI.MappingProfiles
{
    public class DomainToResponseProfile : Profile
    {
        public DomainToResponseProfile()
        {
            CreateMap<Post, PostResponse>();
        }
    }
}