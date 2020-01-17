using AutoMapper;
using Palamedes.API.DTO;
using Palamedes.API.Models;

namespace Palamedes.API.Services
{
    public class AutoMapperProfileConfiguration : Profile
    {
        public AutoMapperProfileConfiguration() : this("MyProfile")
        {

        }

        public AutoMapperProfileConfiguration(string profileName) : base(profileName)
        {
            CreateMap<Art, ArtBasic>()
                .ForMember(
                dest => dest.ArtistName,
                opts => opts.MapFrom(
                    src => $"{src.Artist.ArtistName}"))
                .ForMember(
                dest => dest.Category,
                opts => opts.MapFrom(
                    src => src.Category.Name.ToLower()
                    ))
                .ReverseMap();

            CreateMap<Art, Art>()
                .ForMember(dest => dest.ArtistId, opts => opts.MapFrom(src => $"{src.Artist.Id}"))
                .ForMember(dest => dest.CategoryId, opts => opts.MapFrom(src => $"{src.Category.Id}"))
                .ReverseMap();

            CreateMap<Artist, Artist>()
                .ForMember(dest => dest.UserId, opts => opts.MapFrom(src => $"{src.User.Id}"))
                .ReverseMap();

        }


    }
}
