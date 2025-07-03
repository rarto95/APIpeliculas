using APIpeliculas.Models;

namespace APIpeliculas.Seeder
{
    public static class Seeder
    {
        public static List<Genero> Genero = new List<Genero>()
   {
       new() {Id =10,Nombre="Accion"},
       new() {Id =20,Nombre="Aventura"},
       new() {Id =30,Nombre="Comedia"},
       new() {Id =40,Nombre="Drama"},
       new() {Id =50,Nombre="Fantasia"},
       new() {Id =60,Nombre="Ciencia Ficcion"},
       new() {Id =70,Nombre="Terror"},
       new() {Id =80,Nombre="Romance"}

   };

        public static List<Movie> Movie = new List<Movie>()
   {
       new Movie
       {
           Id = 1,
           Titulo = "Mad Max: Fury Road",
           Estreno = 2015,
           Director = "George Miller",
           Description = "En un futuro postapocalíptico, Max se une a una misteriosa mujer para huir de un tirano.",
           Duracion = 120,
           GeneroId = 10,

       },
   new Movie
   {
       Id = 2,
       Titulo = "Indiana Jones y los cazadores del arca perdida",
       Estreno = 1981,
       Director = "Steven Spielberg",
       Description = "El arqueólogo Indiana Jones busca el Arca de la Alianza antes que los nazis.",
       Rating = 8.4,
       Duracion = 130,
       GeneroId = 20,

   },
   new Movie
   {
       Id = 3,
       Titulo = "Superbad",
       Estreno = 2007,
       Director = "Greg Mottola",
       Description = "Dos amigos intentan disfrutar su última fiesta antes de graduarse.",
       Rating = 7.6,
       Duracion = 100,
       GeneroId = 30,

   },
   new Movie
   {
       Id = 4,
       Titulo = "El Padrino",
       Estreno = 1972,
       Director = "Francis Ford Coppola",
       Description = "La historia de la familia mafiosa Corleone.",
       Rating = 9.2,
       Duracion = 180,
       GeneroId = 40,

   },
   new Movie
   {
       Id = 5,
       Titulo = "El Señor de los Anillos: La Comunidad del Anillo",
       Estreno = 2001,
       Director = "Peter Jackson",
       Description = "Un hobbit debe destruir un anillo para salvar la Tierra Media.",
       Rating = 8.8,
       Duracion = 187,
       GeneroId = 50,

   },
   new Movie
   {
       Id = 6,
       Titulo = "Interestelar",
       Estreno = 2014,
       Director = "Christopher Nolan",
       Description = "Un grupo de astronautas viaja a través de un agujero de gusano en busca de un nuevo hogar para la humanidad.",
       Rating = 8.6,
       Duracion = 180,
       GeneroId = 60,

   },
   new Movie
   {
       Id = 7,
       Titulo = "El Conjuro",
       Estreno = 2013,
       Director = "James Wan",
       Description = "Investigadores paranormales ayudan a una familia aterrorizada por una presencia oscura.",
       Rating = 7.5,
       Duracion = 120,
       GeneroId = 70,

   },
   new Movie
   {
       Id = 8,
       Titulo = "Titanic",
       Estreno = 1997,
       Director = "James Cameron",
       Description = "Una historia de amor a bordo del trágico Titanic.",
       Rating = 7.8,
       Duracion = 160,
       GeneroId = 80,

   },
   new Movie
   {
       Id = 9,
       Titulo = "Guardianes de la Galaxia",
       Estreno = 2014,
       Director = "James Gunn",
       Description = "Un grupo de inadaptados se une para salvar la galaxia.",
       Rating = 8.0,
       Duracion = 140,
       GeneroId = 10,

   },
   new Movie
   {
       Id = 10,
       Titulo = "La La Land",
       Estreno = 2016,
       Director = "Damien Chazelle",
       Description = "Un pianista y una actriz persiguen sus sueños en Los Ángeles.",
       Rating = 8.0,
       Duracion = 120,
       GeneroId = 40,

   }
};
    }
}