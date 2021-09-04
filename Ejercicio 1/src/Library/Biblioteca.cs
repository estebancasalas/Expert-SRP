using System;

namespace SRP
{
    public class Biblioteca
    {
        public Libro Libro {get; set;}
        public UbicacionLibro Ubicacion {get; set;}

        public Biblioteca(Libro libro, UbicacionLibro ubicacion)  
        {
            this.Libro = libro;
            this.Ubicacion = ubicacion;
        } 
    }
}