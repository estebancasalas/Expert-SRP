using System;

namespace SRP
{
    public class Libro
    {

        public string Titulo { get ; private set; } // Faltan metodos set privados
        public string Autor { get ; private set; } // Faltan metodos set privados
        public string Codigo { get ; private set; } // Faltan metodos set privados
        /*
        public string SectorBiblioteca { get ; set; }  // Atributos que le deberían corresponder a otra clase
        public string EstanteBiblioteca { get ; set; } // Atributos que le deberían corresponder a otra clase
        */

        public Libro(String titulo, String autor, String codigo)
        {
            this.Titulo = titulo;
            this.Autor = autor;
            this.Codigo = codigo;
        }

        /* 
        El metodo no corresponde con la clase libro
        
        public void AlmacenarLibro(String sector, String estante)  
        {
            this.SectorBiblioteca = sector;
            this.EstanteBiblioteca = estante;
        } 
        */

    }
}
 /* Segun el principio SRP(Single Responsibility Principle) cada objeto debe tener una unica responsabilidad. En este
 caso, podemos asignarle a la clase libro la responsabilidad de conocer los datos del libro, crear otra clase que se
 encargue de conocer la ubicación, y otra que se encargue de almacenarlo. */