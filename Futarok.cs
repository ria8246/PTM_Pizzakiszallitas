using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PTM_Pizzakiszallitas
{
    class Futarok
    {
        private List<Futar> futarok;

        public Futarok() {
            futarok = new List<Futar>();
            for (int i = 0; i < 4; i++)
            {
                //futarok.Push(new Futar());
                futarok.Add(new Futar());
            }
        }

        public Futar KovetkezoFutar(int index)
        {
            //return stack.Pop();

            return futarok.ElementAt(index);
        }

        

        

    }
}
