using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PTM_Pizzakiszallitas
{
    class Cim
    {
        private int iranyitoSzam; 
        private string varosNev;
        private string utcaNev;
        private int hazSzam;


       public Cim(int iranyitoSzam, string varosNev, string utcaNev,  int hazSzam) {
                this.iranyitoSzam = iranyitoSzam;
                this.varosNev = varosNev;
                this.utcaNev = utcaNev;
                this.hazSzam = hazSzam;
        
        }

        public Cim() {
            iranyitoSzam = 0;
            varosNev = "";
            utcaNev = "";
            hazSzam = 0;
        
        }

		//Cim osztályba
static public bool operator < (Cim egyik, Cim masik ) {
	/*
	if ( varosNev < masik.varosNev ) {
		return this;
	} else if ( varosNev == varosNev ) {
		
		if ( utcaNev < masik.utcaNev ) {
			return this;
		} else if ( utcaNev == masik.utcaNev ) {
			
			if ( hazSzam < masik.hazSzam ) {
				return this;
			} else {
				return masik;
			}
			
		} else {
			return masik;
		}
		
	} else {
		return masik;
	}*/
	// Cannot access fields of Cim
	return true;
}
	
    }
}
