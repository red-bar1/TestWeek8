using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalFantasy.Core.Entities
{
        public class Arma
    {
        public string Nome { get; set; }
        public int Danno { get; set; }

        public ICollection<Personaggio> Personaggi { get; set; } = new List<Personaggio>();
    }
}
