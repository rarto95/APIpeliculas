using APIpeliculas.DataAccess;
using APIpeliculas.Models;
using Microsoft.AspNetCore.Mvc;

namespace APIpeliculas.Controllers
{
    [ApiController]
    [Route("/api/[controller]")]
    public class GeneroController:ControllerBase
    {
        private readonly AppDBContext _appDBContext; //guion bajo para readonly

        public GeneroController(AppDBContext appDBContext)
        {
            _appDBContext = appDBContext;
        }

        [HttpGet] //atributo
        public IActionResult GetAll() {
            var generos = _appDBContext.Generos.ToList();
            if(generos == null) return NotFound();
            return Ok(generos);
        }
        [HttpPost]
        public IActionResult Post(GeneroInput model) {
            var genero = new Genero();
            genero.Nombre = model.Nombre;
            _appDBContext.Generos.Add(genero);
            if(_appDBContext.SaveChanges() >0) return Ok(genero);
            return BadRequest();

        }
        [HttpPut]
        public IActionResult Put(GeneroInput model, int id) {
            var genero = _appDBContext.Generos.FirstOrDefault(g => g.Id == id);
            if(genero == null) return NotFound();
            genero.Nombre = model.Nombre;
            if (_appDBContext.SaveChanges() > 0) return Ok(genero);
            return BadRequest();
        }
        [HttpDelete]
        public IActionResult Delete(int id) {
            var genero = _appDBContext.Generos.FirstOrDefault(g => g.Id == id);
            if (genero == null) return NotFound();
            _appDBContext.Generos.Remove(genero);
            if (_appDBContext.SaveChanges() > 0) return NoContent(); //se recomienda NoContent para el delete
            return BadRequest();
        }
    }
}

/*status code
 o
200(200 a 299) son OK del controllerbase, son buenos - Ok,
,
400(400 a 499) que algo se pidio de mala manera - Bad Request,
,
500(500 a 599) algo jodio la api o el codigo - Internal Server Error,
,
,
*/
