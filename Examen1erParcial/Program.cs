using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen1erParcial
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Playlist> playlists = new List<Playlist>();

            //Playlists
            Playlist pl1 = new Playlist("Terror", "Una playlists de peliculas de terror");
            Playlist pl2 = new Playlist("Animadas", "Una playlists de peliculas de animadas");

            playlists.Add(pl1);
            playlists.Add(pl2);

            //Peliculas terror
            Pelicula p1 = new Pelicula("El Baile de Milo", 2019, "Elberg Alarga", "Terror", "Mexico", 140, 5, "Huye o sera tu perdicion");
            Pelicula p2 = new Pelicula("Feminazi", 2010, "Cristofer", "Terror", "España", 80, 1, "El fin del patriarcado");
            Pelicula p3 = new Pelicula("666", 2000, "Phil Blackburn", "Terror", "USA", 90, 4, "El diablo y su numero");
            Pelicula p4 = new Pelicula("El ataque de los Furros", 2019, "Fausto Cota", "Terror", "Mexico", 70, 1, "Todo es paranormal");
            Pelicula p5 = new Pelicula("El espiritu de la niña", 1999, "Bill Marston", "Terror", "USA", 50, 4, "Espiritu poseidor");
            Pelicula p6 = new Pelicula("El Area 51", 2019, "Will Smith", "Terror", "USA", 140, 5, "100% reales no feik");
            Pelicula p7 = new Pelicula("El agujero negro", 2003, "Timmy Black", "Terror", "USA", 110, 2, "todo se abduce");

            //Peliculas animadas
            Pelicula p8 = new Pelicula("Planeta del Tesoro", 2005, "Kyle Sulton", "Animacion", "USA", 220, 4, "La busqueda en las estrellas");
            Pelicula p9 = new Pelicula("Toy Pedo", 2002, "Alberto Valenzuela", "Animacion", "Mexico", 50, 5, "Jugetes bien pedos");
            Pelicula p10 = new Pelicula("Calliou", 2007, "Memo", "Infantil", "USA", 90, 4, "El pequeño Memo");
            Pelicula p11 = new Pelicula("El Asentamiento", 2005, "Preston Garvey", "Animacion", "USA", 70, 2, "Otro asentamiento necesita nuestra ayuda");
            Pelicula p12 = new Pelicula("Los Padrinos Magicos", 2004, "Tim Polland", "Animacion", "USA", 100, 4, "Pide un deseo");
            Pelicula p13 = new Pelicula("Coco", 2018, "Damian Burboa", "Animacion", "Mexico", 110, 4, "Niño con guitarra");
            Pelicula p14 = new Pelicula("El dinero crece en los arboles", 2019, "AMLO", "Animacion", "Mexico", 140, 5, "Mexico mas seguro");

            //Constructor vacio
            Pelicula pelicula1 = new Pelicula();

            pl1.peliculas.Add(p1);
            pl1.peliculas.Add(p2);
            pl1.peliculas.Add(p3);
            pl1.peliculas.Add(p4);
            pl1.peliculas.Add(p5);
            pl1.peliculas.Add(p6);
            pl1.peliculas.Add(p7);

            pl2.peliculas.Add(p8);
            pl2.peliculas.Add(p9);
            pl2.peliculas.Add(p10);
            pl2.peliculas.Add(p11);
            pl2.peliculas.Add(p12);
            pl2.peliculas.Add(p13);
            pl2.peliculas.Add(p14);

            foreach (Playlist playlist in playlists)
            {
                Console.WriteLine("Playlist: " + playlist.TituloP);
                Console.WriteLine("Descripcion: " + playlist.Descripcion);
                Console.WriteLine("Lista de peliculas: ");
                foreach (Pelicula pelicula in playlist.peliculas)
                {
                    Console.WriteLine("Titulo: " + pelicula.Titulo);
                    Console.WriteLine("Año: " + pelicula.Estreno);
                    Console.WriteLine("Director: " + pelicula.Director);
                    Console.WriteLine("Genero: " + pelicula.Genero);
                    Console.WriteLine("Origen: " + pelicula.Origen);
                    Console.WriteLine("Duracion: " + pelicula.Duracion + " Minutos");
                    Console.WriteLine("Rating: " + pelicula.Rate + " Estrellas");
                    Console.WriteLine("Sipnosis: " + pelicula.Sipnosis);
                }
            }

            try
            {
                pelicula1.Estreno = 2020;
                Console.WriteLine("Año: " + pelicula1.Estreno);
            }
            catch (Exception e)
            {
                Console.WriteLine("Año fuera de rango");
            }

            try
            {
                pelicula1.Duracion = -1;
                Console.WriteLine("Duracion " + pelicula1.Duracion);
            }
            catch (Exception e)
            {
                Console.WriteLine("Duracion Invalida");
            }

            try
            {
                pelicula1.Rate = 6;
                Console.WriteLine("Rating " + pelicula1.Rate);
            }
            catch (Exception e)
            {
                Console.WriteLine("Rating no valido");
            }

            Console.ReadLine();
        }
    }
}
