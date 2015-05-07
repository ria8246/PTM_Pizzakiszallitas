using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PTM_Pizzakiszallitas
{
    public class Pizza
    {
        private string feltet;
        private int atmero;


        public Pizza(string feltet, int atmero) {
            this.feltet = feltet;
            this.atmero = atmero;
        
        }

        public Pizza() { //?
            feltet = "";
            atmero = 0;
        }

        public string getFeltet() {
            return feltet;
        }
        public int getAtmero() {
            return atmero;
        }


        public void setFeltet(string feltet)
        {
             this.feltet = feltet;
        }
        public void setAtmero(int atmero )
        {
            this.atmero=atmero;
        }

    }
}
