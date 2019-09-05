using System;

namespace ExamenPrimerParcial
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Playlist> peliculas1 = new List<Playlist>();

            Playlist Tarantino = new Playlist("Samuel L. Jackson", "racism");
            Tarantino.Titulo = "Racist man shoots black dude";
            Tarantino.Descripcion = "bruh";
            Playlist.Add(Tarantino);

            Playlist HarryPotter = new Playlist("Harry hechizos", "Ron hechizos");
            HarryPotter.Titulo = "Whack magic";
            HarryPotter.Descripcion = "Magic reeee";
            Playlist.Add(HarryPotter);

            Peliculas eskerir = new Pelicula("Eskerir", 1989, "Quentin Tarantino", "Drama", "USA", 93, 7.6, "Está padre vean la película paro");
            Peliculas esclavo = new Pelicula("Esclavo", 1977, "Quentin Tarantino", "Tristeza", "Sudán", 123, 8.2, "Un exclavo está siendo esclavizado");
            Peliculas Matar = new Pelicula("Matar", 2005, "Terry Crews", "Guerra", "USA", 120, 6.3, "Hay una guerra y la gente muere");
            Peliculas Felino = new Pelicula("Felino", 1912, "Primo de Tarantino", "Tragicomedia", "EUA", 85, 8.8, "Un gato vive su vida");
            Peliculas Falino = new Pelicula("Falino", 1963, "Mamá Tarantino", "Comedia", "EUA", 90, 8.5, "El primo del gato vive su vida");
            Peliculas Fulio = new Pelicula("Fulio", 1994, "Quentin Tarantino", "Drama", "EUA", 115, 8.9, "El hijo del gato busca vengar a su madre");
            Peliculas FILI = new Pelicula("Fili", 2003, "Quentin Tarantino", "Comedia", "EUA", 140, 9.9, "La madre del gato se va de vacaciones");

            Peliculas HP1 = new Pelicula("HP1", 1999, "Rowling", "Infantil", "USA", 83, 8.6, "Harry escapa del mal");
            Peliculas HP2 = new Pelicula("HP2", 2001, "Rowling", "Infantil", "USA", 85, 8.2, "Harry escapa del mal con amigos");
            Peliculas HP3 = new Pelicula("HP3", 2002, "Rowling", "Infantil", "USA", 90, 9.0, "Harry escapa del mal con más amigos");
            Peliculas HP4 = new Pelicula("HP4", 2005, "Rowling", "Infantil", "USA", 86, 8.3, "Harry escapa del mal sin amigos");
            Peliculas HP5 = new Pelicula("HP5", 2006, "Rowling", "Infantil", "USA", 101, 8.0, "Harry escapa del matrimonio");
            Peliculas HP6 = new Pelicula("HP6", 2008, "Rowling", "Infantil", "USA", 120, 8.2, "Harry escapa del divorcio");
            Peliculas HP7 = new Pelicula("HP7", 2010, "Rowling", "Infantil", "USA", 130, 8.6, "Harry se vuelve el mal");

            Tarantino.Lista.add(eskerir);
            Tarantino.Lista.add(esclavo);
            Tarantino.Lista.add(Matar);
            Tarantino.Lista.add(Felino);
            Tarantino.Lista.add(Falino);
            Tarantino.Lista.add(Fulio);
            Tarantino.Lista.add(FILI);

            HarryPotter.Lista.add(HP1);
            HarryPotter.Lista.add(HP2);
            HarryPotter.Lista.add(HP3);
            HarryPotter.Lista.add(HP4);
            HarryPotter.Lista.add(HP5);
            HarryPotter.Lista.add(HP6);
            HarryPotter.Lista.add(HP7);

               foreach(Playlist playlist in playlists)
            {
                Console.WriteLine("Titulo: " + playlist.Titulo);
                Console.WriteLine("Descripción: " + playlist.Descripcion);
                Console.WriteLine(" ");
                Console.WriteLine(" Peliculas dentro de la lista: ");
                foreach(Peliculas pelicula in playlist.Lista)
                {
                    Console.WriteLine("   Nombre de la Película: " + pelicula.Titulo);
                    Console.WriteLine("   Director: " + pelicula.Director);
                    Console.WriteLine("   Genero: " + pelicula.Genero);
                    Console.WriteLine("   Pais: " + pelicula.Pais);
                    Console.WriteLine("   Sinopsis: " + pelicula.Sinopsis);
                   try { pelicula.Año = pelicula.Año; Console.WriteLine("   Fecha: " + pelicula.Año); } catch(Exception se) { Console.WriteLine("Año incorrecto"); }
                    try { pelicula.Duracion = pelicula.Duracion; Console.WriteLine("   Duracion: " + pelicula.Duracion); } catch (Exception se) { Console.WriteLine("Duración incorrecta"); }
                    try { pelicula.Imdb = pelicula.Rating_de_IMDB; Console.WriteLine("   Rating de IMDB: " + pelicula.Rating_de_IMDB); } catch (Exception se) { Console.WriteLine("Rating incorrecto"); }
                    Console.WriteLine(" ");




                }
                Console.WriteLine(" ");
                Console.WriteLine(" ");
            }

               
               Console.Read();
        }


    }
}
