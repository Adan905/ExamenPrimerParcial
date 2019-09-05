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
        public decimal Rating_de_IMDB { get; set; }
        public string Sinopsis { get; set; }
        public List<Peliculas> Pelicula { get; set; }

        public int Año
        {
            get
            {
                return Año;
            }
            set
            {
                if (value >=1800)
                {
                    if (value < 2019)
                    {
                        Año = value;
                    }
                    else if (value > 2019)
                    {
                        throw new Exception("La película no se pudo haber estrenado después del 2019");
                    }      
                }
                else
                {
                    throw new Exception("La pelicula no pudo haberse estrenado antes del año 1800");
                }
            }
        }
        public int Duracion
        {
            get
            {
                return Duracion
            }
            set
            {
                if (value > 0 )
                {
                  
                    throw new Exception("La película no puede durar 0 minutos");
                }
            }
        }

        public decimal Rating_de_IMDB
        {
            get
            {
                return Rating_de_IMDB
            }
            set
            {
                if (value >= 0)
                {
                    throw new Exception("El rating debe de estar entre 0 y 10");
                }
                else
                {
                    throw new Exception("El rating debe de ser un número entre 0 y 10");
                }
            }
        }

        public Peliculas()
        {
            Titulo = "No información";
            Año = "0";
            Director = "No información";
            Genero = "No información";
            Pais = "No información";
            Duracion = "0";
            Rating_de_IMDB = "0";
            Sinposis = "No información";
        }

        public Peliculas(string titulo, int año, string director, string genero, string pais, int duracion, decimal rating_de_imdb, string sinopsis)
        {
            Titulo = titulo;
            Año = año;
            Director = director;
            Genero = genero;
            Pais = pais;
            Duracion = duracion;
            Rating_de_IMDB = rating_de_imdb;
            Sinopsis = sinopsis;
        }
    }
}
