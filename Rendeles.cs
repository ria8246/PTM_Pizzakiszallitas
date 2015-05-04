using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace PTM_Pizzakiszallitas
{
    class Rendeles : Tuple<Cim, Pizza> // 1 cim - 1 pizza
    {
        
        //public Tuple<Cim, Pizza> rendeles;   

       /* public Rendeles() {
            rendeles = new Tuple<Cim, Pizza>(Cim c, Pizza p);
        }
        */

     public Rendeles() : base(new Cim(), new Pizza())
    {
    }



    }
}
