using APIpeliculas.DataAccess;
using APIpeliculas.Models;
using APIpeliculas.ViewModels;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace APIpeliculas.Controllers
{
    [ApiController]
    [Route("/api/[Controller]")]
    public class MovieController : ControllerBase
    {
        private readonly AppDBContext _AppDBContext;
        private readonly IMapper _mapper;

        public MovieController(AppDBContext AppBdContext, IMapper mapper) 
        { 
            _AppDBContext = AppBdContext;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var movies = _AppDBContext.Movies.Include(m => m.Genero).ToList(); //include agrega tabla
            if (movies == null) return NotFound();
            return Ok(_mapper.Map<IEnumerable<MovieViewModel>>(movies)); //list o collection para cuando se vaya a utilizar, IEnumerable solo para ver
        }

        [HttpPost]
        public IActionResult Post(MovieInput model)
        {
            //var movie = new Movie();
            //movie.Titulo = model.Titulo;
            //movie.Description = model.Description;
            //movie.Duracion = model.Duracion;
            //movie.Director = model.Director;
            //movie.Estreno = model.Estreno;
            //movie.GeneroId = model.GeneroId;
            //var genero = _AppDBContext.Generos.FirstOrDefault(g => g.Id == movie.GeneroId);
            //if (genero == null) return NotFound();
            var movie = _mapper.Map<Movie>(model);
            _AppDBContext.Movies.Add(movie);
            if (_AppDBContext.SaveChanges() >0) return Ok(movie);
            return BadRequest(model);
        }
        [HttpPut]
        public IActionResult Put(MovieInput model,int id)
        {
            var movie = _AppDBContext.Movies.FirstOrDefault(m => m.Id == id);
            if (movie == null) return NotFound();
            //movie.Titulo = model.Titulo;
            //movie.Description = model.Description;
            //movie.Duracion = model.Duracion;
            //movie.Director = model.Director;
            //movie.Estreno = model.Estreno;
            //movie.GeneroId = model.GeneroId;
            //var genero = _AppDBContext.Generos.FirstOrDefault(g => g.Id == movie.GeneroId);
            //if (genero == null) return NotFound();
            _mapper.Map(model, movie);
            if (_AppDBContext.SaveChanges() >0) return Ok(movie);
            return BadRequest();
        }
        [HttpDelete]
        public IActionResult Delete(int id) 
        {
            var movie = _AppDBContext.Movies.FirstOrDefault(m => m.Id == id);
            if (movie == null) return NotFound();
            _AppDBContext.Movies.Remove(movie);
            if (_AppDBContext.SaveChanges() > 0) return NoContent();
            return BadRequest();
        }
    }
}
