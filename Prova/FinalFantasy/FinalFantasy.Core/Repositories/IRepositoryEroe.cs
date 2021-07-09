using FinalFantasy.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalFantasy.Core.Repositories
{
    public interface IRepositoryEroe : IRepositoryPersonaggio
    {
        public Eroe Create();
        public bool AddToGiocatore(Eroe newEroe, Giocatore giocatore);
        public bool Delete(Giocatore giocatore);
    }
}
