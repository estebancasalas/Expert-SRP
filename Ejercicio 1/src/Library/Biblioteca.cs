using System;
using Libro;
using UbicacionLibro;

namespace SRP
{
    public class Biblioteca
    {
        public Libro Libro {get; private set;}
        public UbicacionLibro Ubicacion {get; private set;}

        public void AlmacenarLibro(String libro, String ubicacion)  
        {
            this.Libro = libro;
            this.Ubicacion = ubicacion;
        } 
    }
}