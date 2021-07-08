using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalFantasy.Core.Entities
{
    public class Giocatore
    {
        public string Nickname { get; set; }
        public ICollection<Eroe> Eroi { get; set; } = new List<Eroe>();

        public override string ToString()
        {
            return $"Nickname: {Nickname}";// - Lista eroi: {Eroi}";
        }
    }
}
