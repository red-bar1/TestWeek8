using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalFantasy.Core.Entities
{
    public enum CategoriaMostro
    {
        Ghost,
        Lucifer
    }

    public class Mostro : Personaggio
    {
        public CategoriaMostro CategoriaMostro { get; set; }

        public override string ToString()
        {
            return $"{Nome} - Liv: {Livello} - PV: {PuntiVita} - {CategoriaMostro} - Arma: {ArmaNome}";
        }

    }

    
}
