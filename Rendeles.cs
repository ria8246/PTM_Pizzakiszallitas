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



	//Rendeles osztályba
	static public bool operator < (Rendeles egyik, Rendeles masik ) {
	if (/* egyik.Cim < masik.Cim */ true) { /* Cannot access Rendeles.Cim */
		return true;
	} else {
		return false;
	}
	}
	// Szükséges implementálni.
	static public bool operator > (Rendeles egyik, Rendeles masik)
	{
		if (/* egyik.Cim > masik.Cim */ true)
		{ /* Cannot access Rendeles.Cim */
			return true;
		}
		else
		{
			return false;
		}
	}
}
}
