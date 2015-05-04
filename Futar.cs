using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PTM_Pizzakiszallitas
{
    class Futar
    {

        private Utvonalterv szallitasiSorrend;
        
        public enum FutarAllapot
        {
            pizzat_szallit,
            varakozik,
            visszafele_megy
        };

         private FutarAllapot aktualisAllapot;

        //

         public Futar()
         {
             aktualisAllapot = FutarAllapot.varakozik;
             szallitasiSorrend = new Utvonalterv();
         }

        
        public FutarAllapot getFutarAllapot(){
            return aktualisAllapot;
        }

        public Utvonalterv getSzallitasiSorrend() {
            return szallitasiSorrend;
        }

        public FutarAllapot Kiszallitas() {
            aktualisAllapot = FutarAllapot.pizzat_szallit;
            return aktualisAllapot;
        }

        public FutarAllapot VisszafeleMegy()
        {
            aktualisAllapot = FutarAllapot.visszafele_megy;
            return aktualisAllapot;
        }

        
    }
}
