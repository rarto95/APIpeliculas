using APIpeliculas.Models;
using APIpeliculas.ViewModels;
using AutoMapper;

namespace APIpeliculas.Profiles
{
    public class MainProfile:Profile
    {
        public MainProfile()
        {
            CreateMap<GeneroInput, Genero>();

            CreateMap<MovieInput, Movie>();
            CreateMap<Movie, MovieViewModel>()
                .ForMember(src => src.Genero, opt => opt.MapFrom(m => m.Genero.Nombre));
        }
    }
}
