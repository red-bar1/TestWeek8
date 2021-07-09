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

        public int PuntiEsperienza { get; set; } 

        public override string ToString()
        {
            return $"{Nome} - Liv: {Livello} - PV: {PuntiVita} - Arma: {ArmaNome}\n";
        }




    }
}
