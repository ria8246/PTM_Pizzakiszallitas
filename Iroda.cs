using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PTM_Pizzakiszallitas
{
    class Iroda
    {
        //Azokat a cimeket tároljuk amelyekből lesz az utvonalterv
        ArrayList UtvonaltervCimek;

        public Iroda()
        {
            UtvonaltervCimek = new ArrayList();
        }

        //A Rendelesek közül kiszed egyet, a cimet eltárolja, a pizza_info allapjan
        //pedig utasitja a konyhat a pizza elkészitésére
        public void PizzatKeszittet( Rendelesek rendelesek, Konyha konyha ) 
        {
            //TODO kereses ???
            rendelesek rendeles = rendelesek.GetRendeles();
            UtvonaltervCimek.Add( rendeles.GetCim() );

            PizzaInfo pizzaInfo = rendeles.GetRendeltPizza();
            konyha.PizzatSut( pizzaInfo );
            
        }

        //A tárolt cimeket sorbarendezi, majd végig megy rajta egy ciklussal és
        //átpakolja az Utvonaltervbe, a már rendezett sorrendben
        public Utvonalterv UtvonalTervezes( Rendelesek rendelesek )
        {
            UtvonaltervCimek.Sort();

            Utvonalterv utvonalterv = new Utvonalterv();

            foreach (Object obj in UtvonaltervCimek)
            {
                utvonalterv.AddCim(obj);
            }

            UtvonaltervCimek.Clear();

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
