using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PTM_Pizzakiszallitas
{
    class Futarok
    {
        private Stack<Futar> stack;

        public Futarok() {
            stack = new Stack<Futar>();
            for (int i = 0; i < 4; i++)
            {
                stack.Push(new Futar());
            }
        }

        public Futar KovetkezoFutar()
        {
            return stack.Pop();
        }
    }
}
