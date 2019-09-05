using System;
using System.Collections.Generic;
using System.Text;

namespace ExamenPrimerParcial
{
    class Playlist
    {
        public string Titulo { get; set; }
        public string Descripcion { get; set; }
        public List<Playlist> Lista { get; set; }

        public Playlist()
        {
            Titulo = "Playlist Nueva";
            Descripcion = "No description";
            Lista = new List<Pelicula>();
        }

        public Playlist(string titulo, string descripcion)
        {
            Titulo = titulo;
            Descripcion = descripcion;
            Lista = new List<Peliculas>();
        }
    }

}
