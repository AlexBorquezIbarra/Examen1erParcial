using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen1erParcial
{
    class Playlist
    {
        public string Titulo;
        public string Descripcion;
        public List<Pelicula> Peliculas;

        public Playlist ()
        {
            Titulo = "Desconcido";
            Descripcion = "Desconocido";
            Peliculas = new List<Pelicula>();
        }

        public Playlist(string titulo)
        {
            Titulo = titulo;
            Descripcion = "Desconocido";
            Peliculas = new List<Pelicula>();
        }
    }
}
