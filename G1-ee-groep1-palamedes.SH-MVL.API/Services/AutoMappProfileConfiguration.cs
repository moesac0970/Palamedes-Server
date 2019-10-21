using AutoMapper;
using G1_ee_groep1_palamedes.SH_MVL.Lib.DTO;
using G1_ee_groep1_palamedes.SH_MVL.Lib.Models;

namespace G1_ee_groep1_palamedes.SH_MVL.API.Services
{
    public class AutoMapperProfileConfiguration : Profile
    {
        public AutoMapperProfileConfiguration() : this("MyProfile")
        {

        }

        public AutoMapperProfileConfiguration(string profileName) : base(profileName)
        {
            // ref : create map if necessary 
            ////////////////////////////////
            ///
            //CreateMap<BookBasic, Book>().ReverseMap();
            //CreateMap<Book, BookDetail>()
            //    .ForMember(
            //        dest => dest.AuthorName,
            //        opts => opts.MapFrom(
            //            src => $"{src.Author.LastName} {src.Author.FirstName}"))
            //    .ReverseMap();
            //CreateMap<Book, BookStatistic>()
            //    .ForMember(
            //        dest => dest.ScoreAverage,
            //        opts => opts.MapFrom(src => src.Ratings.Average(r => r.Score))
            //        )
            //    .ReverseMap();
            CreateMap<ArtBasic, Art>().ReverseMap();
            
        }


    }
}
