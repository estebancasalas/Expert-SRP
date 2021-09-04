using System;

namespace SRP
{
    public class Libro
    {

        public string Titulo { get ; } // Faltan metodos set privados
        public string Autor { get ; } // Faltan metodos set privados
        public string Codigo { get ;  } // Faltan metodos set privados
        public string SectorBiblioteca { get ; set; } 
        public string EstanteBiblioteca { get ; set; }

        public Libro(String titulo, String autor, String codigo)
        {
            this.Titulo = titulo;
            this.Autor = autor;
            this.Codigo = codigo;
        }

        public void AlmacenarLibro(String sector, String estante)
        {
            this.SectorBiblioteca = sector;
            this.EstanteBiblioteca = estante;
        }

    }
}
