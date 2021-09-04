using System;

namespace SRP
{
    
    class Program
    {
        static void Main(string[] args)
        {
            Libro libro1 = new Libro("Design Patterns","Erich Gamma & Others","001-034");
            Libro libro2 = new Libro("Pro C#","Troelsen","001-035");
            UbicacionLibro ubicacion1 = new UbicacionLibro("A","7");
            UbicacionLibro ubicacion2 = new UbicacionLibro("B","3");
            Biblioteca Libroguardado = new Biblioteca(libro1, ubicacion1);
            Biblioteca Libroguardado2 = new Biblioteca(libro2, ubicacion2);
        }
    }
}
