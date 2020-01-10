using AutoMapper;
using G1_ee_groep1_palamedes.SH_MVL.API.Models;
using G1_ee_groep1_palamedes.SH_MVL.API.DTO;

namespace G1_ee_groep1_palamedes.SH_MVL.API.Services
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
