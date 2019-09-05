using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen1erParcial
{
    class Playlist
    {
        public string TituloP { get; set; }
        public string Descripcion { get; set; }
        public List<Pelicula> peliculas;

        public Playlist()
        {
            TituloP = "Desconocido";
            Descripcion = "Desconocido";
            peliculas = new List<Pelicula>();
        }

        public Playlist(string tituloP, string descripcion)
        {
            TituloP = tituloP;
            Descripcion = descripcion;
            peliculas = new List<Pelicula>();
        }
    }
}
