using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTM_Pizzakiszallitas
{
    class Rendelesek
    {
        private Stack<Rendeles> rendelesek;

        public Rendelesek() {
            rendelesek = new Stack<Rendeles>();
        }


        public void RendelestHozzaad(Rendeles ujRendeles) 
        {
            rendelesek.Push(ujRendeles);
        }

        public Rendeles RendelestKivesz() {
            return rendelesek.Pop();        
        }
    }
}
