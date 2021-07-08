using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalFantasy.Core.Entities
{
    public enum CategoriaEroe
    {
        Soldier,
        Wizard
    }


    public class Eroe : Personaggio
    {
        public CategoriaEroe CategoriaEroe { get; set; }

        public string GiocatoreNickname { get; set; }
        public Giocatore Giocatore { get; set; }

        public int PuntiEsperienza { get; set; } //= PuntiExpIniziali();

       
        //evidentemente non si fa in questo modo
        //private static int PuntiExpIniziali()
        //{
            
        //    switch (Livello)
        //    {
        //        case 1:
        //            return 0;
        //        case 2:
        //            return 30;
        //        case 3:
        //            return 60;
        //        case 4:
        //            return 90;
        //        case 5:
        //            return 120;
        //        default:
        //            return 0;
        //    }
        //}

        

        public override string ToString()
        {
            return $"{Nome} - Liv: {Livello} - PV: {PuntiVita} - Arma: {ArmaNome}\n";
        }




    }
}
