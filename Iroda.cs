using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PTM_Pizzakiszallitas
{

    //A cimek és a megsütött pizzak összerendelésére
    public struct PizzakEsCimek
    {
        public Pizza pizza;
        public Cim cim;
    }
    

    class Iroda
    {
        //Azokat a cim-pizza párokat tároljuk amelyeket beleveszunk az utvonaltervbe.
        List<PizzakEsCimek> FeldolgozasAlattiRendelesek;

        public Iroda()
        {
            FeldolgozasAlattiRendelesek = new List<PizzakEsCimek>();
        }

        //A Rendelesek közül kiszed egyet, a cimet eltárolja, a pizza_info allapjan
        //pedig utasitja a konyhat a pizza elkészitésére, majd a pizzat is eltarolja
        public void PizzatKeszittet( Rendelesek rendelesek, Konyha konyha ) 
        {
            PizzakEsCimek pec = new PizzakEsCimek();
            
            Rendeles rendeles = rendelesek.GetRendeles();
            pec.cim = rendeles.GetCim();

            PizzaInfo pizzaInfo = rendeles.GetRendeltPizza();
            pec.pizza = konyha.PizzatSut( pizzaInfo );

            FeldolgozasAlattiRendelesek.Add( pec );
        }

        //A tárolt cimeket sorbarendezi, majd végig megy rajta egy ciklussal és
        //átpakolja az Utvonaltervbe, a már rendezett sorrendben
        public Utvonalterv UtvonalTervezes( Rendelesek rendelesek )
        {
            FeldolgozasAlattiRendelesek.Sort();

            Utvonalterv utvonalterv = new Utvonalterv();

            foreach (PizzakEsCimek pec in FeldolgozasAlattiRendelesek)
            {
                //TODO
                //utvonalterv.AddCim(pec.cim);
            }

            FeldolgozasAlattiRendelesek.Clear();

            return utvonalterv;

        }

        //public void UtvonaltervAtadasa(Utvonalterv utvonalterv, Futar futar) { 
        //    TODO
        //}


        //A futar indit az mit is kell hogy csinaljon ???

        //public FutarAllapot FutartIndit(Futar futar)
        //{
        //    //TODO
        //    futar.Kiszallitas(); 
        //}

    }
}
