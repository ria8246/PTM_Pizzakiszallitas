﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PTM_Pizzakiszallitas
{
    class Konyha
    {
        public Konyha() {
        }

        //Létrehoz egy uj pizzat, majd visszaadja.
        public Pizza PizzatSut ( PizzaInfo pizzaInfo ) {

            Pizza pizza = new Pizza( pizzaInfo.GetAtmero(), pizzaInfo.GetFeltet() );
            return pizza;

        }

        
        //public void PizzatAtad ( Pizza pizza, Futar futar ) {
        //    TODO
        //}
        
    }
}
