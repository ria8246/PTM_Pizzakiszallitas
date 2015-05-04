using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PTM_Pizzakiszallitas
{
    class Varos
    {
        private string varosNev;
        private int iranyitoSzam;
        private Utcak utcak;

        public Varos() {
            varosNev = "";
            iranyitoSzam = 0;
            utcak = new Utcak();
        }

        public Varos(string varosNev,        int iranyitoSzam,        Utcak utcak) {
            this.varosNev = varosNev;
            this.iranyitoSzam = iranyitoSzam;
            this.utcak = utcak; //?
        }
    }
}
