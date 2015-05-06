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
			if ( egyik.varosNev.CompareTo (masik.varosNev) <  0) {
				return true;
			} else if ( egyik.varosNev == masik.varosNev ) {
		
				if ( egyik.utcaNev.CompareTo (masik.utcaNev) < 0 ) {
					return true;
				} else if ( egyik.utcaNev == masik.utcaNev ) {
			
					if ( egyik.hazSzam < masik.hazSzam ) {
						return true;
					} else {
						return false;
					}
			
				} else {
					return false;
				}
		
			} else {
				return false;
			}
			
		}

		// Szükséges implementálni.
		static public bool operator > (Cim egyik, Cim masik)
		{
			if (egyik.varosNev.CompareTo (masik.varosNev) > 0)
			{
				return true;
			}
			else if (egyik.varosNev == masik.varosNev)
			{

				if (egyik.utcaNev.CompareTo (masik.utcaNev) > 0)
				{
					return true;
				}
				else if (egyik.utcaNev == masik.utcaNev)
				{

					if (egyik.hazSzam > masik.hazSzam)
					{
						return true;
					}
					else
					{
						return false;
					}

				}
				else
				{
					return false;
				}

			}
			else
			{
				return false;
			}

		}
    }
}
