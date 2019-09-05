using System;
using System.Collections.Generic;
using System.Text;

namespace ExamenPrimerParcial
{
    class Peliculas
    {
        public string Titulo { get; set; }
        public int Año { get; set; }
        public string Director { get; set; }
        public string Genero { get; set; }
        public string Pais { get; set; }
        public int Duracion { get; set; }
        public int Rating_de_IMDB { get; set; }
        public string Sinopsis { get; set; }
        public List<Peliculas> Pelicula { get; set; }

        public Peliculas()
        {
            Titulo = "El Dorado";
            Año = "2002";
            Director = "Guillermo del Toro";
            Genero = "Aventura";
            Pais = "USA";
            Duracion = "93";
            Rating_de_IMDB = "7.8";
            Sinopsis = "Durante el virreinato en Nueva España, dos criollos intentan encontrar un lugar mágico dónde todo está hecho de oro.";
            P

        }
    }
}
