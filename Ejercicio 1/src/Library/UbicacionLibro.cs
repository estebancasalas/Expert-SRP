using System;

namespace SRP
{
    public class UbicacionLibro
    {
        public string SectorBiblioteca {get; set;}
        public string EstanteBiblioteca {get; set;}

        public UbicacionLibro(String sectorBiblioteca, String estanteBiblioteca)
        {
            this.SectorBiblioteca = sectorBiblioteca;
            this.EstanteBiblioteca = estanteBiblioteca;
        }
    }
}