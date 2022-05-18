using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPG3.Entidades
{
    public class Peliculas
    {
        private int codPelicula;
        private string titulo;
        private string leyenda;
        private string duracion;
        private string sinopsis;
        private DateTime añoEstreno;
        private int origen;
        private string descriOrigen;
        private int calificacion;
        private string descriCalificacion;
        private int formato;
        private string descriFormato;
        private int genero;
        private string descriGenero;
        private int distribuidora;
        private string descriDistribuidora;
        private int idioma;
        private string descriIdioma;

        public int CodPelicula { get => codPelicula; set => codPelicula = value; }
        public string Titulo { get => titulo; set => titulo = value; }
        public string Leyenda { get => leyenda; set => leyenda = value; }
        public string Duracion { get => duracion; set => duracion = value; }
        public string Sinopsis { get => sinopsis; set => sinopsis = value; }
        public DateTime AñoEstreno { get => añoEstreno; set => añoEstreno = value; }
        public int Origen { get => origen; set => origen = value; }
        public string DescriOrigen { get => descriOrigen; set => titulo = descriOrigen; }
        public int Calificacion { get => calificacion; set => calificacion = value; }
        public string DescriCalificacion { get => descriCalificacion; set => titulo = descriCalificacion; }
        public int Formato { get => formato; set => formato = value; }
        public string DescriFormato { get => descriFormato; set => titulo = descriFormato; }
        public int Genero { get => genero; set => genero = value; }
        public string DescriGenero { get => descriGenero; set => titulo = descriGenero; }
        public int Distribuidora { get => distribuidora; set => distribuidora = value; }
        public string DescriDistribuidora { get => descriDistribuidora; set => titulo = descriDistribuidora; }
        public int Idioma { get => idioma; set => idioma = value; }
        public string DescriIdioma { get => descriIdioma; set => titulo = descriIdioma; }

        public Peliculas(int codPelicula, string titulo, string leyenda, string duracion, 
            string sinopsis, DateTime añoEstreno, int origen, string descriOrigen,
            int calificacion,string descriCalificacion, int formato, string descriFormato, 
            int genero,string descriGenero,int distribuidora,string descriDistribuidora, 
            int idioma, string descriIdioma)
        {
            this.codPelicula = codPelicula;
            this.titulo = titulo;
            this.leyenda = leyenda;
            this.duracion = duracion;
            this.sinopsis = sinopsis;
            this.añoEstreno = añoEstreno;
            this.origen = origen;
            this.descriOrigen = descriOrigen;
            this.calificacion = calificacion;
            this.descriCalificacion = descriCalificacion;
            this.formato = formato;
            this.descriFormato = descriFormato;
            this.genero = genero;
            this.descriGenero = descriGenero;
            this.distribuidora = distribuidora;
            this.descriDistribuidora = descriDistribuidora;
            this.idioma = idioma;
            this.descriIdioma = descriIdioma;
        }

        public Peliculas()
        {

        }
    }
}
