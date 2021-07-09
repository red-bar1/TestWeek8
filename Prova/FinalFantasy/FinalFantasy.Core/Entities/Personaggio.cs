using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalFantasy.Core.Entities
{
    public abstract class Personaggio
    {
        public string Nome { get; set; }
        public int Livello { get; set; } = 1;
        public int PuntiVita
        { 
            get
            {
                switch (Livello)
                {
                    case 1:
                        return 20;
                    case 2:
                        return 40;
                    case 3:
                        return 60;
                    case 4:
                        return 80;
                    case 5:
                        return 100;
                }
                return 0;
            }
        }

        public string ArmaNome { get; set; }
        public Arma Arma { get; set; }
    }
}
