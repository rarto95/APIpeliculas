namespace APIpeliculas.Models
{
    public class Movie
    {
        public int Id { get; set; }

        public string Titulo { get; set; }

        public string Description { get; set; }
        public int Duracion { get; set; }

        public double Rating { get; set; }

        public string Director { get; set; }

        public int Estreno { get; set; }

        public int GeneroId { get; set; }

        public Genero Genero { get; set; }
    }
}
