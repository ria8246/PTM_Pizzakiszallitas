using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace PTM_Pizzakiszallitas
{
   public class Rendeles : Tuple<Cim, Pizza> // 1 cim - 1 pizza
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
	if (egyik.RendelesiCim () < masik.RendelesiCim () ) {
		return true;
	} else {
		return false;
	}
	}

	// Szükséges implementálni.
	static public bool operator > (Rendeles egyik, Rendeles masik)
	{
		if (egyik.RendelesiCim () > masik.RendelesiCim ())
		{
			return true;
		}
		else
		{
			return false;
		}
	}
	// KRiSTóF által
	 public Rendeles (Cim cim, Pizza pizza) : base (cim, pizza)
	 {
	 }

	 public Pizza RendeltPizza ()
	 {
		 Pizza rendeltPizza = base.Item2;

		 return rendeltPizza;
	 }

	 public Cim RendelesiCim ()
	 {
		 Cim rendelesiCim = base.Item1;

		 return rendelesiCim;
	 }
}
}
