using FinalFantasy.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalFantasy.RepositoryMock
{
    //in realta questa repo non serve
    class RepositoryArmiMock
    {
        private ICollection<Arma> Armi = new List<Arma>()
        {
            new Arma {Nome = "Ascia", Danno = 8},
            new Arma {Nome = "Mazza", Danno= 5},
            new Arma {Nome = "Spada", Danno= 10},
            new Arma {Nome = "Bastone Magico", Danno=10},
            new Arma {Nome= "Bacchetta", Danno=5},
            new Arma {Nome="Arco e Frecce", Danno=8},
            new Arma {Nome="Arco", Danno=7 }
        };
    }
}
