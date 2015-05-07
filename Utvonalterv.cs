using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PTM_Pizzakiszallitas
{
   public class Utvonalterv
    {
        private List<Rendeles> kiszallitando;

        public Utvonalterv() {
            kiszallitando = new List<Rendeles>();
        }

        public void RendelesHozzaadas(Rendeles hozzaadando) {
            kiszallitando.Add(hozzaadando);
        }

    }
}
